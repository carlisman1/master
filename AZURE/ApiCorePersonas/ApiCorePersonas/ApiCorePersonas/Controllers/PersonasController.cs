using ApiCorePersonas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCorePersonas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        List<Persona> personas;

        public PersonasController(List<Persona> personas)
        {
            this.personas = new List<Persona>
            {
                new Persona {IdPersona = 1, Nombre = "Seryi",
                Email="protinder@gmail.com", Edad=23},
                new Persona {IdPersona = 2, Nombre = "Guti",
                Email="follaculosgordos@gmail.com", Edad=22},
                new Persona {IdPersona = 3, Nombre = "Yeizy",
                Email="chantichapiador@gmail.com", Edad=22},
                new Persona {IdPersona = 4, Nombre = "Felix",
                Email="borrachoalvolante@gmail.com", Edad=23}
            };

        }

        [HttpGet]
        public ActionResult<List<Persona>> Get()
        {
            return this.personas;
        }

        //PARA PODER UTILIZAR EL METODO GET(ID)
        //DEBEMOS DECORAR CON EL SIGUIENTE ATRIBUTO
        // [HttpGet("{id}")]
        [HttpGet("{id}")]
        public ActionResult<Persona> FindPersona(int id)
        {
            return this.personas.FirstOrDefault(x => x.IdPersona == id);
        }

    }
}
