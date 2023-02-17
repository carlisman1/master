using Oracle.ManagedDataAccess;
using System.Data;
using NetCoreLinqToSqlInjection.Repositories;
using NetCoreLinqToSqlInjection.Models;
using Oracle.ManagedDataAccess.Client;

namespace NetCoreLinqToSqlInjection.Repositories
{
    public class RepositoryDoctoresOracle : IRepository
    {
        private OracleConnection cn;
        private OracleCommand cmd;
        private OracleDataAdapter adapter;
        private DataTable tablaDoctores;

        public RepositoryDoctoresOracle()
        {
            string connectionString =
                @"Data Source=LOCALHOST:1521/XE; Persist Security Info=True;User Id=SYSTEM;Password=oracle";
            this.cn = new OracleConnection(connectionString);
            this.cmd = new OracleCommand();
            this.cmd.Connection = this.cn;
            string sql = "select * from doctor";
            this.adapter = new OracleDataAdapter(sql, connectionString);
            this.tablaDoctores = new DataTable();
            this.adapter.Fill(this.tablaDoctores);
        }

        public List<Doctor> GetDoctor()
        {
            var consulta = from datos in this.tablaDoctores.AsEnumerable()
                           select new Doctor
                           {
                               DoctorCod = datos.Field<int>("DOCTOR_NO").ToString(),
                               HospitalCod = datos.Field<int>("HOSPITAL_COD").ToString(),
                               Apellido = datos.Field<string>("APELLIDO"),
                               Especialidad = datos.Field<string>("ESPECIALIDAD"),
                               Salario = datos.Field<int>("SALARIO")
                           };
            return consulta.ToList();
        }

        public int GetMaxDoctor()
        {
            var maximo =
                (from datos in this.tablaDoctores.AsEnumerable()
                 select datos).Max(x => x.Field<int>("DOCTOR_NO")) + 1;
            return maximo;
        }

        public void InsertDoctor(string hospitalCod, string doctorCod, string apellido, string especialidad, int salario)
        {
            string sql = "insert into doctor values(:idhospital, :iddoctor, " +
                ":apellido, :especialidad, :salario)";
            int maximo = this.GetMaxDoctor();
            OracleParameter pamhosp = new OracleParameter(":idhospital", hospitalCod);
            this.cmd.Parameters.Add(pamhosp);
            OracleParameter pamid = new OracleParameter(":iddoctor", maximo);
            this.cmd.Parameters.Add(pamid);
            OracleParameter pamape = new OracleParameter(":apellido", apellido);
            this.cmd.Parameters.Add(pamape);
            OracleParameter pamespe = new OracleParameter(":especialidad", especialidad);
            this.cmd.Parameters.Add(pamespe);
            OracleParameter pamsalario = new OracleParameter(":salario", salario);
            this.cmd.Parameters.Add(pamsalario);
            this.cmd.CommandType = CommandType.Text;
            this.cmd.CommandText = sql;
            this.cn.Open();
            this.cmd.ExecuteNonQuery();
            this.cn.Close();
            this.cmd.Parameters.Clear();
        }

        public void DeleteDoctor(int iddoctor)
        {
            OracleParameter pamid = new OracleParameter(":p_iddoctor", iddoctor);
            this.cmd.Parameters.Add(pamid);
            this.cmd.CommandType = CommandType.StoredProcedure;
            this.cmd.CommandText = "SP_DELETE_EMPLEADO";
            this.cn.Open();
            this.cmd.ExecuteNonQuery();
            this.cn.Close();
            this.cmd.Parameters.Clear();
        }
    }

    
}
