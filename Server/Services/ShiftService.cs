using System.Collections.Generic;
using System.Data;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using vagtplanen.Shared.Models;

namespace vagtplanen.Server.Services
{
    public class ShiftService
    {
        private readonly string _connectionString;
        public ShiftService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("postgres");
        }

        public static IDbConnection OpenConnection(string connStr)
        {
            var conn = new NpgsqlConnection(connStr);
            conn.Open();
            return conn;
        }

        public IEnumerable<Shift> Get()
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = @"SELECT * FROM all_shifts";

                var result = conn.QueryAsync<Shift, Volunteer, TaskClass, Shift>(query, (s, v, t) =>
                {
                    if (v == null) { v = new(); };
                    s.volunteer = v;

                    if (t == null) { t = new(); };
                    s.task = t;
                    return s;
                }, splitOn: "shift_id, volunteer_id, task_id");
                return result.Result;
            }
        }

        public Shift Get(int id)
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = @"SELECT * FROM shift WHERE shift_id = @_id";
                var value = new { _id = id };
                var result = conn.QueryFirstOrDefault<Shift>(query, value);
                return result;
            }
        }
    }
}
