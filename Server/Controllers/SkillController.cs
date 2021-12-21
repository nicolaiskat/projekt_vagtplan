using System;
using Microsoft.AspNetCore.Mvc;
using vagtplanen.Server.Services;
using vagtplanen.Shared.Models;

namespace vagtplanen.Server.Controllers
{
    //Data i dennne controller routes til "....../api/skill"
    [Route("api/[controller]")]
    [ApiController]

    //Nedarver fra ControllerBase
    //Standard Klasse for at lave controllers
    public class SkillController : ControllerBase
    {
        //Genererer tom SkillService
        private SkillService _service;
        public SkillController(SkillService service)
        {
            //Gemmer service til tidligere tomme public SkillService
            //Herinde ligger forretningslogik og connection til database
            _service = service;
        }


        //Method til at hente alle skills til .../api/skill
        [HttpGet]
        public IActionResult Get()
        {
            //Forsøger
            try
            {
                //Kører 'Get()' metoden fra Service-laget
                //Gemmer alle volunteers som IEnumerable<Skill> i 'list'
                //Returnerer listen af alle skills med et Status 200 OK reponse
                var list = _service.Get();
                return Ok(list);
            }
            //Hvis fejl
            catch (Exception ex)
            {
                //Returnerer Status 500 for fejl og skriver meddelelsen for fejlen
                return StatusCode(500, ex.Message);
            }
        }

        //Method til at hente alle skill til og fra .../api/skill/@id
        [HttpGet("{id}", Name = "SkillById")]
        public IActionResult Get(int id)
        {
            //Forsøger
            try
            {
                //Kører 'Get(string un)' metoden fra Service - laget
                //Gemmer den skill som har id magen til em fra input i 'ski'
                //Returnerer listen af alle skills med et Status 200 OK reponse
                var skill = _service.Get(id);

                //Hvis 'ski' ikke kan findes i metoden returneres Status 404
                if (skill == null)
                    return NotFound();
                return Ok(skill);
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
