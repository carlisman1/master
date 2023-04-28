using ApiSeriesExamenJCMG.Data;
using ApiSeriesExamenJCMG.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiSeriesExamenJCMG.Repositories
{
    public class RepositoryPersonajes
    {
        private SeriesContext context;

        public RepositoryPersonajes(SeriesContext context)
        {
            this.context = context;
        }

        public async Task<List<Personaje>> GetPersonajeAsync()
        {
            return await this.context.Personaje.ToListAsync();
        }

        public async Task<Personaje> FindPersonajeAsync(int idpersonaje)
        {
            return await
                this.context.Personaje.FirstOrDefaultAsync
                (x => x.IdPersonaje == idpersonaje);
        }

        public async Task InsertarPersonajeAsync(int idpersonaje, string npersonaje
            , string imagen, int idserie)
        {
            Personaje per = new Personaje();
            per.IdPersonaje = idpersonaje;
            per.NPersonaje = npersonaje;
            per.Imagen = imagen;
            per.IdSerie = idserie;
            this.context.Personaje.Add(per);
            await this.context.SaveChangesAsync();
        }

        public async Task UpdatePersonajeAsync(int idpersonaje, string npersonaje
            , string imagen, int idserie)
        {
            Personaje per = await this.FindPersonajeAsync(idpersonaje);
            per.NPersonaje = npersonaje;
            per.Imagen = imagen;
            per.IdSerie = idserie;
            await this.context.SaveChangesAsync();
        }

        public async Task DeletePersonajeAsync(int idpersonaje)
        {
            Personaje per = await this.FindPersonajeAsync(idpersonaje);
            this.context.Personaje.Remove(per);
            await this.context.SaveChangesAsync();
        }
    }
}
