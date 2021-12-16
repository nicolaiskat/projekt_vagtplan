using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace vagtplanen.Server.Services
{
    public class CoordinatorService
    {
        private readonly string _connectionString;
        public CoordinatorService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("postgres");
        }

        //LINK HERTIL
        public static IDbConnection OpenConnection(string connStr)
        {
            var conn = new NpgsqlConnection(connStr);
            conn.Open();
            return conn;
        }

        public IEnumerable<Coordinator> Get()
        {
            using (var conn = OpenConnection(_connectionString))
            {
                //Brug view hertil
                var query = "SELECT * FROM all_coordinators;";
                var result = conn.Query<Coordinator>(query);
                return result;
            }
        }

        public Coordinator Get(string e)
        {
            var result = Get().First(x => x.email == e);
            return result;
        }

        public Coordinator Update(Coordinator obj)
        {
            //Alt kode i denne 'using' kan forbbindes med databasen
            using (var conn = OpenConnection(_connectionString))
            {
                //Query gemmes som string
                //Alle '@' inde i strengen er parametre i stored procedure som ændres afhængigt at inndhold fra Volunteer-objektet
                var query = @"CALL edit_coordinator(@id, @first_name, @last_name, @mobile, @email, @address, @cpr, @gender)";

                //Definerer alle værdierne fra Coordinator-objektet til query-parametrenes værdier
                var values = new
                {
                    //f.eks er @id det samme som
                    //obj.coordinator_id når kode køres:

                    id = obj.coordinator_id,
                    first_name = obj.first_name,
                    last_name = obj.last_name,
                    mobile = obj.mobile,
                    email = obj.email,
                    address = obj.address,
                    cpr = obj.cpr,
                    gender = obj.gender
                };

                //Eksekverer 'query' med 'values' som parametre
                conn.Execute(query, values);

                //Returnerer samme obj tilbage som modtaget i parameteren
                return obj;
            }
        }

        //public Coordinator CreateCoordinator(Coordinator obj)
        //{
        //    using (var conn = OpenConnection(_connectionString))
        //    {
        //        var query = @"CALL add_coordinator(@first_name, @last_name, @mobile, @email, @address, @gender, @cpr @password)";
        //        var values = new
        //        {
        //            first_name = obj.first_name,
        //            last_name = obj.last_name,
        //            mobil = obj.mobile,
        //            email = obj.email,
        //            address = obj.address,
        //            gender = obj.gender,
        //            cpr = obj.cpr,
        //            password = obj.password
        //        };

        //        conn.ExecuteAsync(query, values);
        //        return obj;
        //    }
        //}
    }
}
