using System;
using Microsoft.AspNetCore.Mvc;
using vagtplanen.Server.Services;
using vagtplanen.Shared.Models;

namespace vagtplanen.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private TeamService _service;
        public TeamController(TeamService service)
        {
            _service = service;
        }


        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var list = _service.Get();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        [HttpGet("{em}", Name = "TeamByEmail")]
        public IActionResult Get(string em)
        {
            try
            {
                var team = _service.Get(em);

                if (team == null)
                    return NotFound();
                return Ok(team);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Create(Team team)
        {
            try
            {
                var teamCreated = _service.Create(team);
                return CreatedAtRoute("TeamById", teamCreated);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        [HttpPut]
        public IActionResult Update(Team team)
        {
            try
            {
                var teamUpdated = _service.Update(team);
                return Ok(teamUpdated);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _service.Delete(id);
                return NoContent();
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
