using ApiSeriesExamenJCMG.Models;
using ApiSeriesExamenJCMG.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiSeriesExamenJCMG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonajesController : ControllerBase
    {
        private RepositoryPersonajes repo;

        public PersonajesController(RepositoryPersonajes repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Personaje>>> GetPersonaje()
        {
            return await this.repo.GetPersonajeAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Personaje>> FindPersonaje(int id)
        {
            return await this.repo.FindPersonajeAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult> InsertPersonaje(Personaje per)
        {
            await this.repo.InsertarPersonajeAsync
                (per.IdPersonaje, per.NPersonaje, per.Imagen, per.IdSerie);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdatePersonaje(Personaje per)
        {
            await this.repo.UpdatePersonajeAsync(per.IdPersonaje, per.NPersonaje, per.Imagen, per.IdSerie);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePersonaje(int id)
        {
            await this.repo.DeletePersonajeAsync(id);
            return Ok();
        }
    }
}
