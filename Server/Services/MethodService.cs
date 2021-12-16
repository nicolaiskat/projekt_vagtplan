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
                var query = @"CALL assign_skill(@vol, @skill, @name)";
                var values = new { vol = volunteer_id, skill = s.skill_id, name = s.name };
                await conn.ExecuteAsync(query, values);
            }
        }

        public async Task DeAssignSkill(int volunteer_id, Skill s)
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = @"CALL deassign_skill(@vol, @skill, @name)";
                var values = new { vol = volunteer_id, skill = s.skill_id, name = s.name };
                await conn.ExecuteAsync(query, values);
            }
        }

        //Lines kode nedenfor
        //public async Task DeleteTeamtask(int teamtask_id)
        //{
        //    using (var conn = OpenConnection(_connectionString))
        //    {
        //        var query = @"CALL delete_teamtask(@tt_id)";
        //        var values = new { tt_id = teamtask_id };
        //        await conn.ExecuteAsync(query, values);
        //    }
        //}

        //public async Task DeleteTask(int task_id)
        //{
        //    using (var conn = OpenConnection(_connectionString))
        //    {
        //        var query = @"CALL delete_task(@t_id)";
        //        var values = new { t_id = task_id };
        //        await conn.ExecuteAsync(query, values);
        //    }
        //}

        //public async Task DeleteShift(int shift_id)
        //{
        //    using (var conn = OpenConnection(_connectionString))
        //    {
        //        var query = @"CALL delete_shift(@s_id)";
        //        var values = new { s_id = shift_id };
        //        await conn.ExecuteAsync(query, values);
        //    }
        //}

        //public async Task DeleteVolunteer(int volunteer_id)
        //{
        //    using (var conn = OpenConnection(_connectionString))
        //    {
        //        var query = @"CALL delete_volunteer(@vol_id)";
        //        var values = new { vol_id = volunteer_id };
        //        await conn.ExecuteAsync(query, values);
        //    }
        //}

        //public async Task EditCoupon(int coupon_id, string description, int price)
        //{
        //    using (var conn = OpenConnection(_connectionString))
        //    {
        //        var query = @"CALL edit_coupon(@cou_id, @_description, @_price)";
        //        var values = new { cou_id = coupon_id, _description = description, _price = price };
        //        await conn.ExecuteAsync(query, values);
        //    }
        //}

        //public async Task EditTeam(int team_id, string name, string contact_name, string mobile, string email)
        //{
        //    using (var conn = OpenConnection(_connectionString))
        //    {
        //        var query = @"CALL edit_team(@t_id, @_name, @c_name, @_mobile, @_email)";
        //        var values = new { t_id = team_id, _name = name, c_name = contact_name, _mobile = mobile, _email = email };
        //        await conn.ExecuteAsync(query, values);
        //    }
        //}

        //public async Task EditVolunteer(int volunteer_id, string first_name, string last_name, string mobile, string email, string address, string cpr, string gender)
        //{
        //    using (var conn = OpenConnection(_connectionString))
        //    {
        //        var query = @"CALL edit_volunteer(@vol_id, @firstname, @lastname, @_mobile, @_email, @_address, @_cpr, @_gender)";
        //        var values = new { vol_id = volunteer_id, firstname = first_name, lastname = last_name, _mobile = mobile, _email = email, _address = address, _cpr = cpr, _gender = gender };
        //        await conn.ExecuteAsync(query, values);
        //    }
        //}

        //public async Task AddCoordinator(string first_name, string last_name, string mobile, string email, string address, string gender, string cpr, string password)
        //{
        //    using (var conn = OpenConnection(_connectionString))
        //    {
        //        var query = @"CALL add_coordinator(@firstname, @lastname, @_mobile, @_email, @_address, @_gender, @_cpr, @pw)";
        //        var values = new { firstname = first_name, lastname = last_name, _mobile = mobile, _email = email, _address = address, _gender = gender, _cpr = cpr, pw = password };
        //        await conn.ExecuteAsync(query, values);
        //    }
        //}

        //public async Task AddCoupon(string description, string price)
        //{
        //    using (var conn = OpenConnection(_connectionString))
        //    {
        //        var query = @"CALL add_coupon(@_description, @_price)";
        //        var values = new { _descriotion = description, _price = price };
        //        await conn.ExecuteAsync(query, values);
        //    }
        //}

        //public async Task AddShift(DateTime start_time, DateTime end_time, int task_id)
        //{
        //    using (var conn = OpenConnection(_connectionString))
        //    {
        //        var query = @"CALL add_shift(@starttime, @endtime, t_id)";
        //        var values = new { starttime = start_time, endtime = end_time, t_id = task_id };
        //        await conn.ExecuteAsync(query, values);
        //    }
        //}

        //public async Task AddTask(string description)
        //{
        //    using (var conn = OpenConnection(_connectionString))
        //    {
        //        var query = @"CALL add_task(@_description)";
        //        var values = new { _descriotion = description };
        //        await conn.ExecuteAsync(query, values);
        //    }
        //}

        //public async Task AddTeam(string name, string contact_name, string mobile, string email, string password)
        //{
        //    using (var conn = OpenConnection(_connectionString))
        //    {
        //        var query = @"CALL add_team(@_name, @contactname, @_mobile, @_email, @pw)";
        //        var values = new { _name = name, contatcname = contact_name, _mobile = mobile, _email = email, pw = password };
        //        await conn.ExecuteAsync(query, values);
        //    }
        //}

        //public async Task AddVolunteer(string first_name, string last_name, string mobile, string email, string address, string gender, string cpr, string password)
        //{
        //    using (var conn = OpenConnection(_connectionString))
        //    {
        //        var query = @"CALL add_volunteer(@firstname, @lastname, @_mobile, @_email, @_address, @_gender, @_cpr, @pw)";
        //        var values = new { firstname = first_name, lastname = last_name, _mobile = mobile, _email = email, _address = address, _gender = gender, _cpr = cpr, pw = password };
        //        await conn.ExecuteAsync(query, values);
        //    }
        //}

        //public async Task AddTeamtask(string description, int people_needed, DateTime start_time, DateTime end_time)
        //{
        //    using (var conn = OpenConnection(_connectionString))
        //    {
        //        var query = @"CALL add_teamtask(@_description, @peopleneeded, @start, @end)";
        //        var values = new { _description = description, peopleneeded = people_needed, start = start_time, _end = end_time };
        //        await conn.ExecuteAsync(query, values);
        //    }
        //}

        //public async Task AddSkill(string skill_name)
        //{
        //    using (var conn = OpenConnection(_connectionString))
        //    {
        //        var query = @"CALL add_skill(@s_name)";
        //        var values = new { s_name = skill_name };
        //        await conn.ExecuteAsync(query, values);
        //    }
        //}

    }
}
