using AppTorneos.Models;
using Microsoft.EntityFrameworkCore;

namespace AppTorneos.Data
{
    public class BWTOURNAMENTContext: DbContext
    {
        public BWTOURNAMENTContext(DbContextOptions<BWTOURNAMENTContext> options) 
        : base(options){ }

        public DbSet<User> Usuarios { get; set; }
    }
}
