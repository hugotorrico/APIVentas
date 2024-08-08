using APIVentas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIVentas.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Persona> Get()
        {
            List<Persona> personas = new List<Persona>();
            for (int i = 0; i < 20; i++)
            {
                personas.Add(new Persona { Apellidos = "Apellidos", Nombres = "Nombres" });
            }
            return personas;
        }
        [HttpGet]
        public IEnumerable<Persona> GetDemo()
        {
            List<Persona> personas = new List<Persona>();
            for (int i = 0; i < 20; i++)
            {
                personas.Add(new Persona { Apellidos = "Apellidos", Nombres = "Nombres" });
            }
            return personas;
        }

        [HttpGet]
        public IEnumerable<Persona> GetPrueba()
        {
            List<Persona> personas = new List<Persona>();
            for (int i = 0; i < 20; i++)
            {
                personas.Add(new Persona { Apellidos = "Apellidos", Nombres = "Nombres" });
            }
            return personas;
        }
    }
}
