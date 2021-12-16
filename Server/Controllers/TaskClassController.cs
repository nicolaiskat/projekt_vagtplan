using System;
using Microsoft.AspNetCore.Mvc;
using vagtplanen.Server.Services;
using vagtplanen.Shared.Models;

namespace vagtplanen.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TaskClassController : ControllerBase
    {
        private TaskClassService _service;
        public TaskClassController(TaskClassService service)
        {
            _service = service;
        }


        [HttpGet]
        public ActionResult Get()
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

        [HttpGet("{id}", Name = "TaskClassById")]
        public IActionResult Get(int id)
        {
            try
            {
                var task = _service.Get(id);

                if (task == null)
                    return NotFound();
                return Ok(task);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Create(TaskClass task)
        {
            try
            {
                var taskCreated = _service.Create(task);
                return CreatedAtRoute("TaskClassById", taskCreated);
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
