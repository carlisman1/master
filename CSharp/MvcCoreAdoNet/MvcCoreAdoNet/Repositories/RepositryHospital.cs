using System.Data;
using System.Data.SqlClient;
using MvcCoreAdoNet.Models;

namespace MvcCoreAdoNet.Repositories
{
    public class RepositryHospital
    {
        private SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataReader reader;
        
        public RepositryHospital()
        {
            string connectionString =
                @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.cmd = new SqlCommand();
            this.cmd.Connection = this.cn;
        }

        public List<Hospital> GetHospitales()
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
                hospital.Direccion = this.reader["DIRECCION"].ToString();
                hospital.Telefono = this.reader["TELEFONO"].ToString();
                hospital.Camas = int.Parse(this.reader["NUM_CAMA"].ToString());
                hospitales.Add(hospital);
            }
            this.reader.Close();
            this.cn.Close();
            return hospitales;
        }

        public Hospital FindHospital(int idhospital)
        {
            string sql = "SELECT * FROM HOSPITAL WHERE HOSPITAL_COD=@HOSPITAL";
            SqlParameter pamid = new SqlParameter("@IDHOSPITAL", idhospital);
            this.cmd.Parameters.Add(pamid);
            this.cmd.CommandType = CommandType.Text;
            this.cmd.CommandText = sql;
            this.cn.Open();
            this.reader = this.cmd.ExecuteReader();
            Hospital hospital = new Hospital();
            this.reader.Read();
            hospital.IdHospital = int.Parse(this.reader["HOSPITAL_COD"].ToString());
            hospital.Nombre = this.reader["NOMBRE"].ToString();
            hospital.Direccion = this.reader["DIRECCION"].ToString();
            hospital.Telefono = this.reader["TELEFONO"].ToString();
            hospital.Camas = int.Parse(this.reader["NUM_CAMA"].ToString());
            this.reader.Close();
            this.cn.Close();
            this.cmd.Parameters.Clear();
            return hospital;
        }
    }
}
