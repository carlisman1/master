using ApiCoreCrudDoctores.Models;
using ApiCoreCrudDoctores.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiCoreCrudDoctores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctoresController : ControllerBase
    {
        private RepositoryHospital repo;

        public DoctoresController(RepositoryHospital repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Doctor>>> GetDoctores()
        {
            return await this.repo.GetDoctoresAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Doctor>> FindEmpleado(string iddoctor)
        {
            return await this.repo.FindDoctorAsync(iddoctor);
        }

        [HttpPost]
        public async Task<ActionResult>InsertDoctor(Doctor doc)
        {
            await this.repo.InsertarDoctorAsync
                (doc.IdHospital, doc.IdDoctor, doc.Apellido
                , doc.Especialidad, doc.Salario);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateDoctor(Doctor doc)
        {
            await this.repo.UpdateDoctorAsync(doc.IdHospital
                ,doc.IdDoctor , doc.Apellido, doc.Especialidad, doc.Salario);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteDoctor(string iddoctor)
        {
            await this.repo.DeleteDoctorAsync(iddoctor);
            return Ok();
        }
    }
}
