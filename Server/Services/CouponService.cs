using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace vagtplanen.Server.Services
{
    public class CouponService
    {
        private readonly string _connectionString;
        public CouponService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("postgres");
        }

        public static IDbConnection OpenConnection(string connStr)
        {
            var conn = new NpgsqlConnection(connStr);
            conn.Open();
            return conn;
        }

        public IEnumerable<Coupon> Get()
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = "SELECT * FROM all_coupons;";
                var result = conn.Query<Coupon>(query);
                return result;
            }
        }

        public Coupon Get(int id)
        {
            using (var conn = OpenConnection(_connectionString))
            {
                //fiks param
                var query = @"SELECT * FROM coupon WHERE coupon_id = @_id";

                var value = new { _id = id };
                var result = conn.QueryFirstOrDefault<Coupon>(query, value);
                return result;
            }
        }

        public Coupon CreateCoupon(Coupon obj)
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = @"CALL add_coupon(@description, @price)";
                var values = new
                {
                    description = obj.description,
                    price = obj.price
                };

                conn.ExecuteAsync(query, values);
                return obj;
            }
        }
    }
}