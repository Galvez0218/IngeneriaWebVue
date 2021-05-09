using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        [HttpGet]
        public Persona Get()
        {
            Persona oPersona = new Persona()
            {
                Nombre = "Alvina"
            };
            return oPersona;
        }
    }

    public class Persona
    {
        public string Nombre { get; set; }
    }
}
