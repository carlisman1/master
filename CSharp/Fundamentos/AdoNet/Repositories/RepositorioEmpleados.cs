using AdoNet.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoNet.Models;
using System.Data;

namespace AdoNet.Repositories
{
    public class RepositorioEmpleados
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader reader;

        public RepositorioEmpleados()
        {
            string connectionString = HelperConfiguration.GetConnectionString();
            this.cn = new SqlConnection(connectionString);
            this.cmd = new SqlCommand();
            this.cmd.Connection = this.cn;
        }
        //RECOGEMOS LOS OFICIOS
        public List<string> GetOficios()
        {
            this.cmd.CommandType = CommandType.StoredProcedure;
            this.cmd.CommandText = "SP_OFICIO";
            List<string> oficios = new List<string>();
            this.cn.Open();
            this.reader = this.cmd.ExecuteReader();
            while (this.reader.Read())
            {
                string oficio = this.reader["OFICIO"].ToString();
                oficios.Add(oficio);
            }
            this.reader.Close();
            this.cn.Close();
            return oficios;
        }

        public DatosOficio GetDatosOficio(string oficio)
        {
            SqlParameter pamoficio = new SqlParameter("@NOMBRE", oficio);
            this.cmd.Parameters.Add(pamoficio);
            var DatosOficio = new DatosOficio() { Nombre = oficio , Empleados = new()};
            this.cmd.CommandType = CommandType.StoredProcedure;
            this.cmd.CommandText = "SP_EMPLEADOS";
            this.cn.Open();
            this.reader = this.cmd.ExecuteReader();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string nombreOficio = this.reader["OFICIO"].ToString();
                int salario = int.Parse(this.reader["SALARIO"].ToString());
                DatosOficio.Empleados.Add(new Empleado() { Apellido = apellido, Oficio = oficio, Salario = salario });
            }
            this.cmd.Parameters.Clear();
            this.reader.Close();
            this.cn.Close();
            return DatosOficio;
        }

        public int DeleteEmpleado(int id)
        {
            SqlParameter pamid = new SqlParameter("@IDEMPLEADO",id);
            this.cmd.Parameters.Add(pamid);
            this.cmd.CommandType = CommandType.StoredProcedure;
            this.cmd.CommandText = "SP_ELIMINAR_EMPLEADO";
            this.cn.Open();
            int eliminados = this.cmd.ExecuteNonQuery();
            this.cn.Close();
            this.cmd.Parameters.Clear();
            return eliminados;
        }
    }
}
