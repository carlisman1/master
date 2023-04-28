using Microsoft.EntityFrameworkCore;
using ApiCoreCrudDoctores.Models;

namespace ApiCoreCrudDoctores.Data
{
    public class HospitalContext:DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options)
                : base(options) { }
        public DbSet<Doctor> Doctor { get; set; }
    }
}
