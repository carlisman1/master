using MvcCrudDoctoresAdo.Models;
using System.Data;
using System.Data.SqlClient;

namespace MvcCrudDoctoresAdo.Repositories
{
    public class RepositoryDoctores 
    {
        private SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataReader reader;

        public RepositoryDoctores()
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
                Doctor doct = new Doctor();
                doct.IdHospital = int.Parse(this.reader["HOSPITAL_COD"].ToString());
                doct.IdDoctor = int.Parse(this.reader["DOCTOR_NO"].ToString());
                doct.Apellido = this.reader["APELLIDO"].ToString();
                doct.Especialidad = this.reader["ESPECIALIDAD"].ToString();
                doct.Salario = int.Parse(this.reader["SALARIO"].ToString());
                doctores.Add(doct);
            }
            this.reader.Close();
            this.cn.Close();
            return doctores;
        } 

        public void Create(int idhospital, int iddoctor
            , string apellido, string especialidad, int salario)
        {
            string sql = "INSERT INTO DOCTOR VALUES(@IDHOSPITAL, @IDDOCTOR" +
                ", @APELLIDO, @ESPECIALIDAD, @SALARIO)";
            SqlParameter pamidhosp = new SqlParameter("@IDHOSPITAL", idhospital);
            SqlParameter pamiddoc = new SqlParameter("@IDDOCTOR", iddoctor);
            SqlParameter pamape = new SqlParameter("@APELLIDO", apellido);
            SqlParameter pamespe = new SqlParameter("@ESPECIALIDAD", especialidad);
            SqlParameter pamsalario = new SqlParameter("@SALARIO", salario);
            this.cmd.Parameters.Add(pamidhosp);
            this.cmd.Parameters.Add(pamiddoc);
            this.cmd.Parameters.Add(pamape);
            this.cmd.Parameters.Add(pamespe);
            this.cmd.Parameters.Add(pamsalario);
            this.cmd.CommandType = CommandType.Text;
            this.cmd.CommandText = sql;
            this.cn.Open();
            this.cmd.ExecuteNonQuery();
            this.cn.Close();
            this.cmd.Parameters.Clear();
        }

        public Doctor Detalles(int iddoctor)
        {
            string sql = "SELECT * FROM DOCTOR WHERE @IDDOCTOR = DOCTOR_NO";
            SqlParameter pamiddoc = new SqlParameter("@IDDOCTOR", iddoctor);
            this.cmd.Parameters.Add(pamiddoc);
            this.cmd.CommandType = CommandType.Text;
            this.cmd.CommandText = sql;
            this.cn.Open();
            this.reader = this.cmd.ExecuteReader();
            this.reader.Read();
            Doctor doc = new Doctor();
            doc.IdHospital = int.Parse(this.reader["HOSPITAL_COD"].ToString());
            doc.IdDoctor = int.Parse(this.reader["DOCTOR_NO"].ToString());
            doc.Apellido = this.reader["APELLIDO"].ToString();
            doc.Especialidad = this.reader["ESPECIALIDAD"].ToString();
            doc.Salario = int.Parse(this.reader["SALARIO"].ToString());
            this.cmd.Parameters.Clear();
            this.reader.Close();
            this.cn.Close();
            return doc;
        }

        public void Modificar(int idhospital, int iddoctor, string apellido, string especialidad, int salario)
        {
            string sql = "UPDATE DOCTOR SET HOSPITAL_COD=@idhospital, APELLIDO=@apellido" +
                ", ESPECIALIDAD=@especialidad, SALARIO=@salario WHERE DOCTOR_NO=@iddoctor";
            SqlParameter pamidhosp = new SqlParameter("@IDHOSPITAL", idhospital);
            SqlParameter pamiddoc = new SqlParameter("@IDDOCTOR", iddoctor);
            SqlParameter pamape = new SqlParameter("@APELLIDO", apellido);
            SqlParameter pamespe = new SqlParameter("@ESPECIALIDAD", especialidad);
            SqlParameter pamsalario = new SqlParameter("@SALARIO", salario);
            this.cmd.Parameters.Add(pamidhosp);
            this.cmd.Parameters.Add(pamiddoc);
            this.cmd.Parameters.Add(pamape);
            this.cmd.Parameters.Add(pamespe);
            this.cmd.Parameters.Add(pamsalario);
            this.cmd.CommandType = CommandType.Text;
            this.cmd.CommandText = sql;
            this.cn.Open();
            this.cmd.ExecuteNonQuery();
            this.cn.Close();
            this.cmd.Parameters.Clear();
        }

        public void Eliminar(int iddoctor)
        {
            string sql = "DELETE DOCTOR WHERE DOCTOR_NO=@iddoctor";
            SqlParameter pamiddoc = new SqlParameter("@iddoctor", iddoctor);
            this.cmd.Parameters.Add(pamiddoc);
            this.cmd.CommandType = CommandType.Text;
            this.cmd.CommandText = sql;
            this.cn.Open();
            this.cmd.ExecuteNonQuery();
            this.cn.Close();
            this.cmd.Parameters.Clear();
        }

        public List<Hospital> GetHospitales()
        {
            string sql = "SELECT NOMBRE, HOSPITAL_COD FROM HOSPITAL";
            this.cmd.CommandType = CommandType.Text;
            this.cmd.CommandText = sql;
            this.cn.Open();
            this.reader = this.cmd.ExecuteReader();
            List<Hospital> hospitales = new List<Hospital>();
            while (this.reader.Read())
            {
                Hospital hospital = new Hospital();
                hospital.IdHospital = this.reader["HOSPITAL_COD"].ToString();
                hospital.Nombre = this.reader["NOMBRE"].ToString();
                hospitales.Add(hospital);
            }
            this.reader.Close();
            this.cn.Close();
            return hospitales;
        }
    }
}
