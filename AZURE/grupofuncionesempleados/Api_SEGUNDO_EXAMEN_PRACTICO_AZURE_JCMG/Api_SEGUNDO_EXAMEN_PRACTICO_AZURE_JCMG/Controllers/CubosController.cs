using Api_SEGUNDO_EXAMEN_PRACTICO_AZURE_JCMG.Models;
using Api_SEGUNDO_EXAMEN_PRACTICO_AZURE_JCMG.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api_SEGUNDO_EXAMEN_PRACTICO_AZURE_JCMG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CubosController : Controller
    {
        private RepositoryCubos repo;

        public CubosController(RepositoryCubos repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Cubos>>> GetCubos()
        {
            return await this.repo.GetCubosAsync();
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<CompraCubos>>> GetCCubos()
        {
            return await this.repo.GetCCubosAsync();
        }

        [HttpGet("{marca}")]
        public async Task<ActionResult<List<Cubos>>> FindCubo(string marca)
        {
            return await this.repo.FindCuboAsync(marca);
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult> InsertCubo(Cubos cub)
        {
            await this.repo.InsertarCuboAsync
                (cub.IdCubo, cub.Nombre, cub.Marca, cub.Imagen, cub.Precio);
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> InsertUsuario(UsuarioCubos usu)
        {
            await this.repo.InsertarUsuarioAsync
                (usu.IdUsuario, usu.Nombre, usu.Email, usu.Pass, usu.Imagen);
            return Ok();
        }

        [HttpPost("[action]")]
        public async Task<ActionResult> InsertCompraCubo(CompraCubos ccub)
        {
            await this.repo.InsertarCCuboAsync
                (ccub.IdPedido, ccub.IdCubo, ccub.IdUsuario, ccub.FechaPedido);
            return Ok();
        }

        [HttpGet]
        [Route("[action]")]
        [Authorize]
        public async Task<ActionResult<UsuarioCubos>> GetUsuario(int idusuario)
        {
            return await this.repo.GetUsuarioIdAsync(idusuario);
        }
    }
}
