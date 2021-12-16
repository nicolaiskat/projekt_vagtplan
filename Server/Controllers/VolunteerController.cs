using System;
using Microsoft.AspNetCore.Mvc;
using vagtplanen.Server.Services;

namespace vagtplanen.Server.Controllers
{
    //Data i dennne controller routes til "....../api/volunteer"
    [Route("api/[controller]")]
    [ApiController]

    //Nedarver fra ControllerBase
    //Standard Klasse for at lave controllers
    public class VolunteerController : ControllerBase
    {
        //Genererer tom VolunteerService
        private VolunteerService _service;
        public VolunteerController(VolunteerService service)
        {
            //Gemmer service til tidligere tomme public VolunteerService
            //Herinde ligger forretningslogik og connection til database
            _service = service;
        }


        //Method til at hente alle volunteers til .../api/volunteer
        [HttpGet]
        public ActionResult Get()
        {
            //Forsøger
            try
            {
                //Kører 'Get()' metoden fra Service-laget
                //Gemmer alle volunteers som IEnumerable<Volunteer> i 'list'
                //Returnerer listen af alle volunteres med et Status 200 OK reponse
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

        //Method til at hente alle volunteer til og fra .../api/volunteer/@email
        [HttpGet("{em}", Name = "VolunteerByEmail")]
        public IActionResult Get(string em)
        {
            //Forsøger
            try
            {
                //Kører 'Get(string un)' metoden fra Service - laget
                //Gemmer den volunteer som har email magen til em fra input i 'coor'
                //Returnerer listen af alle volunteres med et Status 200 OK reponse
                var volunteer = _service.Get(em);

                //Hvis 'coor' ikke kan findes i metoden returneres Status 404
                if (volunteer == null)
                    return NotFound();
                return Ok(volunteer);
            }
            //Hvis fejl
            catch (Exception ex)
            {
                //Returnerer Status 500 for fejl og skriver meddelelsen for fejlen
                return StatusCode(500, ex.Message);
            }
        }

        //Method til at hente post volunteer til databasse gennnemm .../api/volunteer
        [HttpPost]
        public IActionResult Create(Volunteer volunteer)
        {
            //Forsøger
            try
            {
                //Kører 'Create()' metoden fra Service - laget
                //Gemmer samme objekt som fra input i 'coor'
                //Returnerer objektet et Status 201 Created response
                var volunteerCreated = _service.Create(volunteer);
                return CreatedAtRoute("VolunteerById", volunteerCreated);
            }
            //Hvis fejl
            catch (Exception ex)
            {
                //Returnerer Status 500 for fejl og skriver meddelelsen for fejlen
                return StatusCode(500, ex.Message);
            }
        }

        //Method til at hente put volunteer i databasse gennnemm .../api/volunteer
        [HttpPut]
        public IActionResult Update(Volunteer volunteer)
        {
            //Forsøger
            try
            {
                // Kører 'Update()' metoden fra Service - laget
                //Gemmer samme objekt som fra input i 'coor'
                //Returnerer objektet et Status 200 OK reponse
                var volunteerUpdated = _service.Update(volunteer);
                return Ok(volunteerUpdated);
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
            //Forsøger
            try
            {
                //Kører Delete method fra Service-laget og bruger 'id' som parameter
                //Når kørt, returneres en "NoContentResult" fra ControllerBase klassen
                //Melder: 204 No Content
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
