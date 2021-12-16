using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vagtplanen.Server.Services;
using vagtplanen.Shared.Models;

namespace vagtplanen.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TeamTaskController : ControllerBase
    {
        private TeamTaskService _service;
        public TeamTaskController(TeamTaskService service)
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

        [HttpGet("{id}", Name = "TeamTaskById")]
        public IActionResult Get(int id)
        {
            try
            {
                var teamTask = _service.Get(id);

                if (teamTask == null)
                    return NotFound();
                return Ok(teamTask);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Create(TeamTask teamTask)
        {
            try
            {
                var teamTaskUpdated = _service.Create(teamTask);
                return CreatedAtRoute("TeamTaskById", teamTaskUpdated);
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
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
