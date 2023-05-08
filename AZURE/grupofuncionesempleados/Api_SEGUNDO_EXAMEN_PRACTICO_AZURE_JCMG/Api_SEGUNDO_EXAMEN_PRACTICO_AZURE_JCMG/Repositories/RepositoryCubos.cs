using Api_SEGUNDO_EXAMEN_PRACTICO_AZURE_JCMG.Data;
using Api_SEGUNDO_EXAMEN_PRACTICO_AZURE_JCMG.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_SEGUNDO_EXAMEN_PRACTICO_AZURE_JCMG.Repositories
{
    public class RepositoryCubos
    {
        private CubosContext context;

        public RepositoryCubos(CubosContext context)
        {
            this.context = context;
        }

        public async Task<List<Cubos>> GetCubosAsync()
        {
            return await this.context.NCubos.ToListAsync();
        }

        public async Task<Cubos> FindCuboAsync(string marca)
        {
            return await
                this.context.NCubos.FirstOrDefaultAsync
                (x => x.Marca == marca);
        }

        public async Task InsertarCuboAsync(int idcubo, string nombre
            , string marca, string imagen, int precio)
        {
            Cubos cub = new Cubos();
            cub.IdCubo = idcubo;
            cub.Nombre = nombre;
            cub.Marca = marca;
            cub.Imagen = imagen;
            cub.Precio = precio;
            this.context.NCubos.Add(cub);
            await this.context.SaveChangesAsync();
        }

        public async Task<UsuarioCubos> GetUsuarioAsync(string email, string pass)
        {
            return await
                this.context.UCubos.FirstOrDefaultAsync
                (x => x.Email == email && x.Pass == pass);
        }

        public async Task<UsuarioCubos> GetUsuarioIdAsync(int idusuario)
        {
            return await
                this.context.UCubos.FirstOrDefaultAsync
                (x => x.IdUsuario == idusuario);
        }

        public async Task InsertarUsuarioAsync(int idusuario, string nombre
            , string email, string pass, string imagen)
        {
            UsuarioCubos usu = new UsuarioCubos();
            usu.IdUsuario = idusuario;
            usu.Nombre = nombre;
            usu.Email = email;
            usu.Pass = pass;
            usu.Imagen = imagen;
            this.context.UCubos.Add(usu);
            await this.context.SaveChangesAsync();
        }

        public async Task InsertarCCuboAsync(int idpedido, int idcubo
            , int idusuario, DateTime fechaPedido)
        {
            CompraCubos ccub = new CompraCubos();
            ccub.IdPedido = idpedido;
            ccub.IdCubo = idcubo;
            ccub.IdUsuario = idusuario;
            ccub.FechaPedido = fechaPedido;
            this.context.CCubos.Add(ccub);
            await this.context.SaveChangesAsync();
        }



        public async Task<List<CompraCubos>> GetCCubosAsync()
        {
            return await this.context.CCubos.ToListAsync();
        }
    }
}