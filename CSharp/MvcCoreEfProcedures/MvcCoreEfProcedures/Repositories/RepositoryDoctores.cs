#region PROCEDURES
//CREATE PROCEDURE SP_TODOS_DOCTORES
//AS 
//	SELECT * FROM DOCTOR
//GO
//CREATE PROCEDURE SP_ESPECIALIDAD_DOCTORES
//AS
//	SELECT DISTINCT ESPECIALIDAD FROM DOCTOR
//GO
#endregion

using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MvcCoreEfProcedures.Data;
using MvcCoreEfProcedures.Models;
using System.Data;
using System.Data.Common;

namespace MvcCoreEfProcedures.Repositories
{
    public class RepositoryDoctores
    {

        private HospitalContext context;

        public RepositoryDoctores (HospitalContext context)
        {
            this.context = context;
        }

        public List<Doctor> GetDoctores()
        {
            using (DbCommand cmd =
                this.context.Database.GetDbConnection().CreateCommand())
            {
                string sql = "SP_TODOS_DOCTORES";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sql;
                cmd.Connection.Open();
                DbDataReader reader = cmd.ExecuteReader();
                List<Doctor> doctores = new List<Doctor>();
                while (reader.Read())
                {
                    Doctor doctor = new Doctor
                    {
                        HospitalCod = reader["HOSPITAL_COD"].ToString(),
                        DoctorNo = reader["DOCTOR_NO"].ToString(),
                        Apellido = reader["APELLIDO"].ToString(),
                        Especialidad = reader["ESPECIALIDAD"].ToString(),
                        Salario = int.Parse(reader["SALARIO"].ToString())   
                    };
                    doctores.Add(doctor);
                }
                reader.Close();
                cmd.Connection.Close();
                return doctores;
            }
        }

        public List<string> GetEspecialidad()
        {
            using(DbCommand cmd =
                this.context.Database.GetDbConnection().CreateCommand())
            {
                string sql = "SP_ESPECIALIDAD_DOCTORES";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sql;
                cmd.Connection.Open();
                DbDataReader reader = cmd.ExecuteReader();
                List<string> especialidades = new List<string>();
                while (reader.Read())
                {
                    string espe = reader["ESPECIALIDAD"].ToString();
                    especialidades.Add(espe);
                }
                reader.Close();
                cmd.Connection.Close();
                return especialidades;
            }
        }
         public List<Doctor> GetDoctoresEspecialidades(string especialidad)
        {
            using(DbCommand cmd =
                this.context.Database.GetDbConnection().CreateCommand())
            {
                string sql = "SP_DOCTORES_ESPECIALIDAD";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sql;
                cmd.Connection.Open();
                DbDataReader reader = cmd.ExecuteReader();
                List<Doctor> doctores = new List<Doctor>();
                while (reader.Read())
                {
                    Doctor doc = new Doctor
                    {
                        HospitalCod = reader["HOSPITAL_COD"].ToString(),
                        DoctorNo = reader["DOCTOR_NO"].ToString(),
                        Apellido = reader["APELLIDO"].ToString(),
                        Especialidad = reader["ESPECIALIDAD"].ToString(),
                        Salario = int.Parse(reader["SALARIO"].ToString())
                    };
                    doctores.Add(doc);
                }
                reader.Close();
                cmd.Connection.Close();
                return doctores;
            }
        }

        public async Task IncrementarSalarioAsync(string especialidad, int incremento)
        {
            string sql = "SP_INCREMENTAR_DOCTORES @ESPECIALIDAD, @INCREMENTO";
            SqlParameter pamespe = new SqlParameter("@ESPECIALIDAD", especialidad);
            SqlParameter pamincremento = new SqlParameter("@INCREMENTO", incremento);
            await this.context.Database.ExecuteSqlRawAsync(sql, pamespe, pamincremento);

        }
    }
}
