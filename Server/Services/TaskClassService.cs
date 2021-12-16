using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using vagtplanen.Shared.Models;

namespace vagtplanen.Server.Services
{
    public class TaskClassService
    {
        private readonly string _connectionString;
        public TaskClassService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("postgres");
        }

        public static IDbConnection OpenConnection(string connStr)
        {
            var conn = new NpgsqlConnection(connStr);
            conn.Open();
            return conn;
        }

        public IEnumerable<TaskClass> Get()
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = @"select * from all_tasks";

                var list = conn.Query<TaskClass, Shift, TaskClass>(
                query,
                (t, s) =>
                {
                    t.shifts = new();
                    t.shifts.Add(s);

                    return t;
                },
                splitOn: "task_id, shift_id");

                var result = list.GroupBy(t => t.task_id).Select(g =>
                {
                    //Starter ved "first" i gruppen
                    var groupedList = g.First();
                    groupedList.shifts = g.Select(t => t.shifts.Single()).ToList();
                    groupedList.shifts.RemoveAll(s => s == null);

                    //Returnerer grupperet liste
                    return groupedList;
                });


                return result;
            }

        }

        public TaskClass Get(int id)
        {
            var listen = Get().First(x => x.task_id == id);
            return listen;
        }

        public TaskClass Create(TaskClass task)
        {
            using (var conn = OpenConnection(_connectionString))
            {

                var query = @"CALL add_task(@start_t, @end_t, @description, @number_of_shifts)";

                var values = new
                {
                    start_t = task.shifts.First().start_time,
                    end_t = task.shifts.First().end_time,
                    description = task.description,
                    number_of_shifts = task.number_of_shifts
                };

                conn.Execute(query, values);

                return task;
            }
        }

        public int Delete(int id)
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = @"CALL delete_task(@_id)";
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
