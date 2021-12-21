using System.Data;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using vagtplanen.Shared.Models;

namespace vagtplanen.Server.Services
{
    public class MethodService
    {
        private readonly string _connectionString;
        public MethodService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("postgres");
        }

        public static IDbConnection OpenConnection(string connStr)
        {
            var conn = new NpgsqlConnection(connStr);
            conn.Open();
            return conn;
        }

        public async Task<int> CheckLogin(string un, string pw)
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = @"SELECT check_login(@username, @password)";
                var values = new { username = un, password = pw };
                var result = await conn.QueryFirstOrDefaultAsync<int>(query, values);
                return result;
            }
        }

        public async Task UseCoupon(int vol, Coupon c)
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = @"CALL use_coupon(@volunteer, @coupon)";
                var values = new { volunteer = vol, coupon = c.coupon_id};
                await conn.ExecuteAsync(query, values);
            }
        }

        public async Task BuyCoupon(int vol, Coupon c)
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = @"CALL buy_coupon(@volunteer, @coupon)";
                var values = new { volunteer = vol, coupon = c.coupon_id };
                await conn.ExecuteAsync(query, values);
            }
        }

        public async Task DeassignShift(Shift s)
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = @"CALL deassign_shift(@volunteer, @shift)";
                var values = new
                {
                    volunteer = s.volunteer.volunteer_id,
                    shift = s.shift_id
                }; await conn.ExecuteAsync(query, values);
            }
        }

        public async Task AssignShift(Shift s)
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = @"CALL assign_shift(@volunteer, @shift)";
                var values = new
                {
                    volunteer = s.volunteer.volunteer_id,
                    shift = s.shift_id
                };
                await conn.ExecuteAsync(query, values);
            }
        }

        public async Task LockShift(Shift s)
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = "";
                if (s.locked == false)
                    query = @"CALL lock_shift(@s_id)";
                else
                    query = @"CALL unlock_shift(@s_id)";

                var values = new { s_id = s.shift_id };
                await conn.ExecuteAsync(query, values);
            }
        }

        public async Task AssignTeamtask(TeamTask tt)
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = @"CALL assign_teamtask(@team, @teamtask)";
                var values = new
                {
                    team = tt.team.team_id,
                    teamtask = tt.teamtask_id
                };
                await conn.ExecuteAsync(query, values);
            }
        }

        public async Task DeassignTeamtask(TeamTask tt)
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = @"CALL deassign_teamtask(@team, @teamtask)";
                var values = new
                {
                    team = tt.team.team_id,
                    teamtask = tt.teamtask_id
                };
                await conn.ExecuteAsync(query, values);
            }
        }

        public async Task LockTask(TaskClass t)
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = "";
                if (t.locked == false)
                    query = @"CALL lock_task(@task_id)";
                else
                    query = @"CALL unlock_task(@task_id)";
                var values = new { task_id = t.task_id };
                await conn.ExecuteAsync(query, values);
            }
        }

        public async Task LockTeamtask(TeamTask tt)
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = "";
                if (tt.locked == false)
                    query = @"CALL lock_teamtask(@teamtask)";
                else
                    query = @"CALL unlock_teamtask(@teamtask)";
                var values = new { teamtask = tt.teamtask_id };
                await conn.ExecuteAsync(query, values);
            }
        }

        public async Task AssignSkill(int volunteer_id, Skill s)
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = @"CALL assign_skill(@vol, @skill, 'volunteer')";
                var values = new { vol = volunteer_id, skill = s.skill_id};
                await conn.ExecuteAsync(query, values);
            }
        }

        public async Task DeAssignSkill(int volunteer_id, Skill s)
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = @"CALL deassign_skill(@vol, @skill)";
                var values = new { vol = volunteer_id, skill = s.skill_id};
                await conn.ExecuteAsync(query, values);
            }
        }
    }
}
