using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiPrimerWebApiM3.Entities;

namespace MiPrimerWebApiM3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {

        [HttpPost]
        public ActionResult<Personas> Post([FromBody] Personas personas)
        {

            return Ok();
        }


        [HttpPost("/api/humanos")]
        public ActionResult<Personas> PostHumanos([FromBody] Humanos personas)
        {

            return Ok();
        }


    }
}
