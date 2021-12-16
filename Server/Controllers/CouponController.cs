using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vagtplanen.Server.Services;

namespace vagtplanen.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponController : ControllerBase
    {
        private CouponService _service;
        public CouponController(CouponService service)
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

        [HttpGet("{id}", Name = "CouponById")]
        public IActionResult Get(int id)
        {
            try
            {
                var coupon = _service.Get(id);
                if (coupon == null)
                    return NotFound();
                return Ok(coupon);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Create(Coupon coupon)
        {
            try
            {
                var couponCreated = _service.CreateCoupon(coupon);
                return CreatedAtRoute("CouponById", couponCreated);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Update(Coupon coupon)
        {
        
            try
            {
             
                var couponUpdated = _service.Update(coupon);
                return Ok(couponUpdated);
            }
            //Hvis fejl
            catch (Exception ex)
            {
                //Returnerer Status 500 for fejl og skriver meddelelsen for fejlen
                return StatusCode(500, ex.Message);
            }
        }
        //Method til at hente delete volunteer i databasse gennnemm .../api/volunteer/@id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
         
            try
            {
                _service.Delete(id);
                return NoContent();
            }
            //Hvis fejl
            catch (Exception ex)
            {
                //Returnerer Status 500 for fejl og skriver meddelelsen for fejlen
                return StatusCode(500, ex.Message);
            }
        }
    }
}
