using AppTorneos.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AppTorneos.Repositories
{
    public class RepositoryUsuarios
    {
        private BWTOURNAMENTContext context;

        public RepositoryUsuarios(BWTOURNAMENTContext context)
        {
            this.context = context;
        }

        public void InsertarUsuario(string nombre, string email, string usuariotag, string contrasenia)
        {
            string sql = "INSERTARUSUARIO_SP @Nombre, @Email, @UsuarioTag, @Contrasenia";
            SqlParameter paminombre =
                new SqlParameter("@Nombre", nombre);
            SqlParameter pamemail =
                new SqlParameter("@Email", email);
            SqlParameter pamusuariotag =
                new SqlParameter("@UsuarioTag", usuariotag);
            SqlParameter pamicontrasenia =
                new SqlParameter("@Contrasenia", contrasenia);
            //PARA EJECUTAR CONSULTAS DE ACCION EN UN PROCEDURE
            //SE UTILIZA EL METODO ExecuteSqlRaw() Y VIENE DESDE
            // Database
            this.context.Database.ExecuteSqlRaw(sql, nombre, email, usuariotag, contrasenia);
        }

    }
}
