using System.Data;
using System.Data.SqlClient;
using MvcCoreAdoNet.Models;

namespace MvcCoreAdoNet.Repositories
{
    public class RepositoryDoctor
    {
        private SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataReader reader;

        public RepositoryDoctor()
        {
            string connectionString =
                @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.cmd = new SqlCommand();
            this.cmd.Connection = this.cn;
        }

        public List<Doctor> GetDoctores()
        {
            string sql = "SELECT * FROM DOCTOR";
            this.cmd.CommandType = CommandType.Text;
            this.cmd.CommandText = sql;
            this.cn.Open();
            this.reader = this.cmd.ExecuteReader();
            List<Doctor> doctores = new List<Doctor>();
            while (this.reader.Read())
            {
                Doctor doctor = new Doctor();
                doctor.IdHospital= int.Parse(this.reader["HOSPITAL_COD"].ToString());
                doctor.IdDoctor = int.Parse(this.reader["DOCTOR_NO"].ToString());
                doctor.Apellido = this.reader["APELLIDO"].ToString();
                doctor.Especialidad = this.reader["ESPECIALIDAD"].ToString();
                doctor.Salario = int.Parse(this.reader["SALARIO"].ToString());
                doctores.Add(doctor);
            }
            this.reader.Close();
            this.cn.Close();
            return doctores;
        }

        public List<Doctor> FindDoctor(string especialidad)
        {
            string sql = "SELECT * FROM DOCTOR WHERE ESPECIALIDAD = @ESPECIALIDAD";
            this.cmd.Parameters.AddWithValue("@ESPECIALIDAD", especialidad);
            this.cmd.CommandType = CommandType.Text;
            this.cmd.CommandText = sql;
            this.cn.Open();
            this.reader = this.cmd.ExecuteReader();
            List<Doctor> doctores = new List<Doctor>();
            while (this.reader.Read())
            {
                Doctor doctor = new Doctor();
                doctor.IdHospital = int.Parse(this.reader["HOSPITAL_COD"].ToString());
                doctor.IdDoctor = int.Parse(this.reader["DOCTOR_NO"].ToString());
                doctor.Apellido = this.reader["APELLIDO"].ToString();
                doctor.Especialidad = this.reader["ESPECIALIDAD"].ToString();
                doctor.Salario = int.Parse(this.reader["SALARIO"].ToString());
                doctores.Add(doctor);
            }
            this.reader.Close();
            this.cn.Close();
            this.cmd.Parameters.Clear();
            return doctores;
        }

        public List<string> GetEspecialidades()
        {
            string sql = "SELECT DISTINCT ESPECIALIDAD FROM DOCTOR";
            this.cmd.CommandType = CommandType.Text;
            this.cmd.CommandText = sql;
            this.cn.Open();
            this.reader = this.cmd.ExecuteReader();
            List<string> especialidades = new List<string>();
            while (this.reader.Read())
            {
                string especialidad = this.reader["ESPECIALIDAD"].ToString();
                especialidades.Add(especialidad);
            }
            this.reader.Close();
            this.cn.Close();
            return especialidades;
        }

        public List<Hospital> GetHospitalesSelect()
        {
            string sql = "SELECT * FROM HOSPITAL";
            this.cmd.CommandType = CommandType.Text;
            this.cmd.CommandText = sql;
            this.cn.Open();
            this.reader = this.cmd.ExecuteReader();
            List<Hospital> hospitales = new List<Hospital>();
            while (this.reader.Read())
            {
                Hospital hospital = new Hospital();
                hospital.IdHospital = int.Parse(this.reader["HOSPITAL_COD"].ToString());
                hospital.Nombre = this.reader["NOMBRE"].ToString();
                hospitales.Add(hospital);
            }
            this.cn.Close();
            this.reader.Close();
            return hospitales;
        }

        public List<Doctor> GetDoctoresHospital(int idhospital)
        {
            string sql = "SELECT APELLIDOS FROM DOCTORES WHERE HOSPITAL_COD = @IDHOSPITAL";
            this.cmd.Parameters.AddWithValue("@ID", idhospital);
            this.cmd.CommandType = CommandType.Text;
            this.cmd.CommandText = sql;
            this.cn.Open();
            this.reader = this.cmd.ExecuteReader();
            List<Doctor> doctores = new List<Doctor>();
            while (this.reader.Read())
            {
                Doctor doctor = new Doctor();
                doctor.IdDoctor = int.Parse(this.reader["DOCTOR_NO"].ToString());
                doctor.Apellido = this.reader["APELLIDO"].ToString();
                doctor.Especialidad = this.reader["ESPECIALIDAD"].ToString();
                doctor.Salario = int.Parse(this.reader["SALARIO"].ToString());
                doctores.Add(doctor);
            }
            this.cmd.Parameters.Clear();
            this.cn.Close();
            this.reader.Close();
            return doctores;
        }

    }
}
