using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vagtplanen.Server.Services;

namespace vagtplanen.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShiftController : ControllerBase
    {
        private ShiftService _service;
        public ShiftController(ShiftService service)
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
                //log error
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id}", Name = "ShiftById")]
        public IActionResult Get(int id)
        {
            try
            {
                var shift = _service.Get(id);
                if (shift == null)
                    return NotFound();
                return Ok(shift);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }

        //[HttpPost]
        //public IActionResult Create(Shift shift)
        //{
        //    try
        //    {
        //        var shiftCreated = _service.Create(shift);
        //        return CreatedAtRoute("ShiftById", shiftCreated);
        //    }
        //    catch (Exception ex)
        //    {
        //        //log error
        //        return StatusCode(500, ex.Message);
        //    }
        //}


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
                //log error
                return StatusCode(500, ex.Message);
            }
        }
    }
}
