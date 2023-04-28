using ApiCoreCrudDoctores.Data;
using ApiCoreCrudDoctores.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCoreCrudDoctores.Repositories
{
    public class RepositoryHospital
    {
        private HospitalContext context;

        public RepositoryHospital(HospitalContext context)
        {
            this.context = context;
        }

        public async Task<List<Doctor>> GetDoctoresAsync()
        {
            return await this.context.Doctor.ToListAsync();
        }

        public async Task<Doctor> FindDoctorAsync(string iddoctor)
        {
            return await
                this.context.Doctor.FirstOrDefaultAsync
                (x => x.IdDoctor == iddoctor);
        }

        public async Task InsertarDoctorAsync(string idhospital
        , string iddoctor, string apellido, string especialidad, int salario)
        {
            Doctor doc = new Doctor();
            doc.IdHospital = idhospital;
            doc.IdDoctor = iddoctor;
            doc.Apellido = apellido;
            doc.Especialidad = especialidad;
            doc.Salario = salario;
            this.context.Doctor.Add(doc);
            await this.context.SaveChangesAsync();
        }

        public async Task UpdateDoctorAsync(string idhospital, string iddoctor, string apellido
        , string especialidad, int salario)
        {
            Doctor doc = await this.FindDoctorAsync(iddoctor);
            doc.IdHospital = idhospital;
            doc.Apellido = apellido;
            doc.Especialidad = especialidad;
            doc.Salario = salario;
            await this.context.SaveChangesAsync();
        }

        public async Task DeleteDoctorAsync(string iddoctor)
        {
            Doctor doc = await this.FindDoctorAsync(iddoctor);
            this.context.Doctor.Remove(doc);
            await this.context.SaveChangesAsync();
        }
    }
}
