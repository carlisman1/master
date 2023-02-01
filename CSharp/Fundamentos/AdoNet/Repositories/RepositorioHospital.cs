using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoNet.Models;
using Microsoft.Extensions.Configuration;
using AdoNet.Helpers;

namespace AdoNet.Repositories
{
    public class RepositorioHospital
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader reader;
        public RepositorioHospital()
        {
            string connectionString = HelperConfiguration.GetConnectionString();
            this.cn = new SqlConnection(connectionString);
            this.cmd = new SqlCommand();
            this.cmd.Connection =   this.cn;
        }
        //NECESITAMOS UN METODO PARA DEVOLVER TODOS LOS HOSPITALES
        public List<string> GetHospitales()
        {
            this.cmd.CommandType = CommandType.StoredProcedure;
            this.cmd.CommandText = "SP_HOSPITALES";
            List<string> hospitales = new List<string>();
            this.cn.Open();
            this.reader = this.cmd.ExecuteReader();
            while (this.reader.Read())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                hospitales.Add(nombre);
            }
            this.reader.Close();
            this.cn.Close();
            return hospitales;
        }
        public DatosHospital GetDatosHospital(string nombre)
        {
            SqlParameter pamnombre = new SqlParameter("@NOMBRE", nombre);
            this.cmd.Parameters.Add(pamnombre);

            SqlParameter pamsuma = new SqlParameter("@SUMA", 0);
            pamsuma.Direction = ParameterDirection.Output;
            this.cmd.Parameters.Add(pamsuma);

            SqlParameter pammedia = new SqlParameter("@MEDIA", 0);
            pammedia.Direction = ParameterDirection.Output;
            this.cmd.Parameters.Add(pammedia);

            SqlParameter pampersona = new SqlParameter("@PERSONAS", 0);
            pampersona.Direction = ParameterDirection.Output;
            this.cmd.Parameters.Add(pampersona);

            this.cmd.CommandType = CommandType.StoredProcedure;
            this.cmd.CommandText = "SP_EMPLEADOS_HOSPITAL_CLASE";
            this.cn.Open();
            this.reader = this.cmd.ExecuteReader();
            List<EmpleadoHospital> empleados = new List<EmpleadoHospital>();
            while (this.reader.Read())
            {
                int idempleado = int.Parse(this.reader["IDEMPLEADO"].ToString());
                string apellido = this.reader["APELLIDO"].ToString();
                int salario = int.Parse(this.reader["SALARIO"].ToString());
                EmpleadoHospital empleado = new EmpleadoHospital();
                empleado.IdEmpleado = idempleado;
                empleado.Apellido = apellido;
                empleado.Salario = salario;
                empleados.Add(empleado);
            }
            this.reader.Close();
            DatosHospital datos = new DatosHospital();
            datos.Empleados = empleados;
            datos.SumaSalarial = int.Parse(pamsuma.Value.ToString());
            datos.MediaSalarial = int.Parse(pammedia.Value.ToString());
            datos.Personas = int.Parse(pampersona.Value.ToString());
            this.cn.Close();
            this.cmd.Parameters.Clear();
            return datos;
        }
    }
    
}
