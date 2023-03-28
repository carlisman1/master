using Microsoft.EntityFrameworkCore;
using PracticaMvcCore2Iniciales.Data;
using PracticaMvcCore2Iniciales.Helpers;
using PracticaMvcCore2Iniciales.Models;

namespace PracticaMvcCore2Iniciales.Repositories
{
    public class RepositoryLibros
    {
        private HelperPathProvider helper;
        private PracticaDBContext context;

        public RepositoryLibros(HelperPathProvider helper, PracticaDBContext context)
        {
            this.helper = helper;
            this.context = context;
        }

        public async Task<List<Libros>> PaginacionLibros(int posicion)
        {
            List<Libros> librosa = await
                this.context.Libros.ToListAsync();
            return librosa.Skip(posicion).Take(6).ToList();
        }

        public Task<int> LibrosCount()
        {
            return this.context.Libros.CountAsync();
        }

        public async Task<List<Libros>> FindLibroGenero(int idgenero)
        {
            List<Libros> librosa = await
                this.context.Libros.Where(x => x.IdGenero == idgenero).ToListAsync();
            return librosa;
        }

        public async Task<List<Libros>> GetLibrosAsync()
        {
            return await this.context.Libros.ToListAsync();
        }

        public async Task<Libros> DetallesLibro(int idlibro)
        {
            Libros libro =
                await this.context.Libros.FirstOrDefaultAsync
                (x => x.IdLibro == idlibro);
            return libro;
        }
    }
}
