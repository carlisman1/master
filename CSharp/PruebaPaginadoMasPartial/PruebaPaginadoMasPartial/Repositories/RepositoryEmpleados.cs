using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PruebaPaginadoMasPartial.Data;
using PruebaPaginadoMasPartial.Models;

#region PROCEDURES
//CREATE OR ALTER PROCEDURE SP_LOGINEMP (@APELLIDO NVARCHAR(50), @OFICIO NVARCHAR(50))
//AS
//	SELECT * FROM EMP WHERE APELLIDO = @APELLIDO AND OFICIO = @OFICIO
//GO
#endregion

namespace PruebaPaginadoMasPartial.Repositories
{
    public class RepositoryEmpleados
    {
        private EmpleadosContext context;

        public RepositoryEmpleados(EmpleadosContext context) 
        { 
            this.context = context; 
        }

        public Empleado HacerLogin(string apellido, string oficio)
        {
            string sql = "SP_LOGINEMP @APELLIDO, @OFICIO";

            SqlParameter pamape = new SqlParameter("@APELLIDO", apellido);
            SqlParameter pamofi = new SqlParameter("@OFICIO", oficio);

            var consulta = this.context.Empleados.FromSqlRaw(sql, pamape, pamofi);

            Empleado emp = consulta.AsEnumerable().FirstOrDefault();

            return emp;
        }

        public int TotalEmpleado()
        {
            return this.context.Empleados.Count();
        }

        public List<Empleado> GetEmpleados(int posicion, int paginado, string oficio)
        {
            string sql = "SP_PAGINACIONEMP @POSICION, @PAGINADO, @OFICIO";

            SqlParameter pampos = new SqlParameter("@POSICION", posicion);
            SqlParameter pampag = new SqlParameter("@PAGINADO", paginado);
            SqlParameter pamofi = new SqlParameter("@OFICIO", oficio);

            var consulta = this.context.Empleados.FromSqlRaw(sql, pampos, pampag, pamofi);

            return consulta.AsEnumerable().ToList();

        }

        public int GetEmpleadosOficio(string oficio)
        {
            var consulta = this.context.Empleados.Where(x => x.Oficio == oficio).ToList();

            return consulta.Count();
        }
    }
}
