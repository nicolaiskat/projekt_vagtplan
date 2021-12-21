using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using vagtplanen.Shared.Models;

namespace vagtplanen.Server.Services
{
    //SkillService indeholder alt forretningslogikken for hvordan data hentes og lægges til en volunteer
    //Dette betyder at du her kan finde kode CRUD på en/flere volunteer(s)
    public class SkillService
    {
        //Initialiserer string til connection-uri
        private readonly string _connectionString;
        public SkillService(IConfiguration configuration)
        {
            //Henter connection-uri til _connectionString
            _connectionString = configuration.GetConnectionString("postgres");
        }

        //Method til at forbinde fra connectionstreng til faktiske connection
        public static IDbConnection OpenConnection(string connStr)
        {
            var conn = new NpgsqlConnection(connStr);
            conn.Open();
            return conn;
        }

        public IEnumerable<Skill> Get()
        {
            using (var conn = OpenConnection(_connectionString))
            {
                //Query gemmes som string
                var query = @"select * from skill";

                //Kører en query 
                var list = conn.Query<Skill>(query);
                return list;
            }
        }

        // Method til at hente enkelt volunteer
        //Hvis Get() indeholder kun én parameter, som string, så køres denne Get()
        public Skill Get(int id)
        {
            //Henter data på alle volunteers fra ovennstående/tidligere Get()
            //Anvender LINQ for at finde unik volunteer på email (email parameter fås fra controller)
            var listen = Get().First(x => x.skill_id == id);
            return listen;
        }
    }
}
