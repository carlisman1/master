using Microsoft.EntityFrameworkCore;
using PracticaMvcCore2Iniciales.Data;
using PracticaMvcCore2Iniciales.Helpers;
using PracticaMvcCore2Iniciales.Models;

namespace PracticaMvcCore2Iniciales.Repositories
{
    public class RepositoryGeneros
    {
        private HelperPathProvider helper;
        private PracticaDBContext context;

        public RepositoryGeneros(HelperPathProvider helper, PracticaDBContext context)
        {
            this.helper = helper;
            this.context = context;
        }

        public async Task<List<Generos>> GetGenerosAsync()
        {
            return await this.context.Generos.ToListAsync();
        }
    }
}
