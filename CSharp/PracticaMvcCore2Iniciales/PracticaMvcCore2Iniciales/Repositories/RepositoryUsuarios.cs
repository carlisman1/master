using Microsoft.EntityFrameworkCore;
using PracticaMvcCore2Iniciales.Data;
using PracticaMvcCore2Iniciales.Models;

namespace PracticaMvcCore2Iniciales.Repositories
{
    public class RepositoryUsuarios
    {
        private PracticaDBContext context;

        public RepositoryUsuarios(PracticaDBContext context)
        {
            this.context = context;
        }

        public Usuarios GetUserByEmailPass(string email, string pass)
        {
            return this.context.Usuarios
                .Where(x => x.Email == email && x.Pass == pass)
                .AsEnumerable().FirstOrDefault();
        }

        public async Task<Usuarios> FindUsuarioAsync(int idusuario)
        {
            Usuarios usu =
                await this.context.Usuarios.FirstOrDefaultAsync
                (x => x.IdUsuario == idusuario);
            return usu;
        }
    }
}
