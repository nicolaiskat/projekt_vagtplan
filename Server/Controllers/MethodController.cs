using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vagtplanen.Server.Services;
using vagtplanen.Shared.Models;

namespace vagtplanen.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MethodController : ControllerBase
    {
        private MethodService _service;
        public MethodController(MethodService service)
        {
            _service = service;
        }

        [HttpGet("login/{un}/{pw}")]
        public async Task<IActionResult> CheckLogin(string un, string pw)
        {
            try
            {
                var access_niveau = await _service.CheckLogin(un, pw);
                return Ok(access_niveau);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost("usecoupon/{volunteer_id}")]
        public async Task UseCoupon(int volunteer_id, Coupon coupon)
        {
            try
            {
                await _service.UseCoupon(volunteer_id, coupon);
            }
            catch (Exception ex)
            {
                //log error
                StatusCode(500, ex.Message);
            }
        }

        [HttpPost("buycoupon/{volunteer_id}")]
        public async Task BuyCoupon(int volunteer_id, Coupon coupon)
        {
            try
            {
                await _service.BuyCoupon(volunteer_id, coupon);
            }
            catch (Exception ex)
            {
                //log error
                StatusCode(500, ex.Message);
            }
        }

        [HttpPost("assignshift")]
        public async Task AssignShift(Shift shift)
        {
            try
            {
                await _service.AssignShift(shift);
            }
            catch (Exception ex)
            {
                //log error
                StatusCode(500, ex.Message);
            }
        }

        [HttpPost("deassignshift")]
        public async Task DeAssignShift(Shift shift)
        {
            try
            {
                await _service.DeassignShift(shift);
            }
            catch (Exception ex)
            {
                //log error
                StatusCode(500, ex.Message);
            }
        }

        [HttpPost("assignteamtask")]
        public async Task AssignTeamTask(TeamTask teamtask)
        {
            try
            {
                await _service.AssignTeamtask(teamtask);
            }
            catch (Exception ex)
            {
                //log error
                StatusCode(500, ex.Message);
            }
        }
        [HttpPost("deassignteamtask")]
        public async Task DeAssignTeamTask(TeamTask teamtask)
        {
            try
            {
                await _service.DeassignTeamtask(teamtask);
            }
            catch (Exception ex)
            {
                //log error
                StatusCode(500, ex.Message);
            }
        }
        [HttpPost("lockshift")]
        public async Task LockShift(Shift shift)
        {
            try
            {
                await _service.LockShift(shift);
            }
            catch (Exception ex)
            {
                //log error
                StatusCode(500, ex.Message);
            }
        }
        [HttpPost("locktask")]
        public async Task LockTask (TaskClass task)
        {
            try
            {
                await _service.LockTask(task);
            }
            catch (Exception ex)
            {
                //log error
                StatusCode(500, ex.Message);
            }
        }
        [HttpPost("lockteamtask")]
        public async Task LockTask(TeamTask teamtask)
        {
            try
            {
                await _service.LockTeamtask(teamtask);
            }
            catch (Exception ex)
            {
                //log error
                StatusCode(500, ex.Message);
            }
        }

        [HttpPost("assignskill/{volunteer_id}")]
        public async Task AssignSkill(int volunteer_id, Skill skill)
        {
            try
            {
                await _service.AssignSkill(volunteer_id, skill);
            }
            catch (Exception ex)
            {
                //log error
                StatusCode(500, ex.Message);
            }
        }

        [HttpPost("deassignskill/{volunteer_id}")]
        public async Task DeAssignSkill(int volunteer_id, Skill skill)
        {
            try
            {
                await _service.DeAssignSkill(volunteer_id, skill);
            }
            catch (Exception ex)
            {
                //log error
                StatusCode(500, ex.Message);
            }
        }
    }
}
