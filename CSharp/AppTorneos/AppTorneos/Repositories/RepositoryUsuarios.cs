﻿using AppTorneos.Data;
using AppTorneos.Models;
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

        public void InsertarUsuario(string usuariotag, string nombre, string email, string contrasenia)
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
            this.context.Database.ExecuteSqlRaw(sql, paminombre, pamemail, pamusuariotag, pamicontrasenia);
        }

        public User LoginUsuarios(string email, string contrasenia)
        {
            string sql = "LOGIN_SP @Email, @Contrasenia";
            SqlParameter pamemail =
                new SqlParameter("@Email", email);
            SqlParameter pamicontrasenia =
                new SqlParameter("@Contrasenia", contrasenia);
            var consulta = this.context.Usuarios.FromSqlRaw(sql, pamemail, pamicontrasenia);
            User usuario = consulta.AsEnumerable().FirstOrDefault();
            return usuario;
        }
    }
}
