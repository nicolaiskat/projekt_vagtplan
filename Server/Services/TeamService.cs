using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using vagtplanen.Shared.Models;

namespace vagtplanen.Server.Services
{
    public class TeamService
    {
        private readonly string _connectionString;
        public TeamService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("postgres");
        }

        public static IDbConnection OpenConnection(string connStr)
        {
            var conn = new NpgsqlConnection(connStr);
            conn.Open();
            return conn;
        }
        public IEnumerable<Team> Get()
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = @"select *, skillname as name from all_teams";

                var list = conn.Query<Team, TeamTask, Skill, Team>(
                    query,
                    (t, tt, s) =>
                    {
                        t.teamtasks = new(); t.skills = new();
                        t.teamtasks.Add(tt);
                        t.skills.Add(s);

                        return t;
                    },

                    splitOn: "team_id, teamtask_id, skill_id");

                var result = list.GroupBy(t => t.team_id).Select(g =>
                {
                    var groupedList = g.First();

                    groupedList.teamtasks = g.Select(t => t.teamtasks.Single()).ToList();
                    groupedList.skills = g.Select(t => t.skills.Single()).ToList();

                    groupedList.teamtasks.RemoveAll(x => x == null);
                    groupedList.skills.RemoveAll(x => x == null);

                    return groupedList;
                });
                return result;
            }
        }


        public Team Get(string em)
        {
            var t = Get().First(x => x.email == em);
            return t;
        }


        public Team Create(Team obj)
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = @"CALL add_team(@name, @contact_name, @mobile, @email, @password)";

                var values = new
                {
                    name = obj.name,
                    contact_name = obj.contact_name,
                    mobile = obj.mobile,
                    email = obj.email,
                    password = obj.password
                };

                conn.Execute(query, values);

                return obj;
            }
        }

        public Team Update(Team obj)
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = @"CALL edit_team(@id, @name, @contact_name, @mobile, @email)";

                var values = new
                {
                    id = obj.team_id,
                    name = obj.name,
                    contact_name = obj.contact_name,
                    mobile = obj.mobile,
                    email = obj.email
                };

                conn.Execute(query, values);

                return obj;
            }
        }

        public int Delete(int id)
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = @"CALL delete_team(@_id)";

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
