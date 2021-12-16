using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using vagtplanen.Shared.Models;

namespace vagtplanen.Server.Services
{
    public class TeamTaskService
    {
        private readonly string _connectionString;
        public TeamTaskService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("postgres");
        }

        public static IDbConnection OpenConnection(string connStr)
        {
            var conn = new NpgsqlConnection(connStr);
            conn.Open();
            return conn;
        }

        public IEnumerable<TeamTask> Get()
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = @"select * from all_teamtasks";

                var list = conn.Query<TeamTask, Team, TeamTask>(
                query,
                (tt, t) =>
                {
                    if (t == null) { t = new(); };
                    tt.team = t;

                    return tt;
                },
                splitOn: "teamtask_id, team_id");


                return list;
            }

        }

        public TeamTask Get(int em)
        {
            var listen = Get().First(x => x.teamtask_id == em);
            return listen;
        }

        public TeamTask Create(TeamTask obj)
        {
            using (var conn = OpenConnection(_connectionString))
            {
                
                var query = @"CALL add_teamtask(@description, @people_needed, @start_t, @end_t)";

                var values = new
                {
                    description = obj.description,
                    people_needed = obj.people_needed,
                    start_t = obj.start_time,
                    end_t = obj.end_time
                };

                conn.Execute(query, values);

                return obj;
            }
        }

        public int Delete(int id)
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = @"CALL delete_teamtask(@_id)";
                var value = new
                {
                    _id = id
                };
                conn.ExecuteAsync(query, value);

                return id;
            }
        }
    }
}
