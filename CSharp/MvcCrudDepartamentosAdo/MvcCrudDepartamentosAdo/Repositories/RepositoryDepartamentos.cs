using System.Data;
using System.Data.SqlClient;
using MvcCrudDepartamentosAdo.Models;

namespace MvcCrudDepartamentosAdo.Repositories
{
    public class RepositoryDepartamentos
    {
        private SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataReader reader;

        public RepositoryDepartamentos()
        {
            string connectionString =
                @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.cmd = new SqlCommand();
            this.cmd.Connection = this.cn;
        }

        public List<Departamento> GetDepartamentos()
        {
            string sql = "select * from dept";
            this.cmd.CommandType = CommandType.Text;
            this.cmd.CommandText = sql;
            this.cn.Open();
            this.reader = this.cmd.ExecuteReader();
            List<Departamento> departamentos = new List<Departamento>();
            while (this.reader.Read())
            {
                Departamento dept = new Departamento();
                dept.IdDepartamento = int.Parse(this.reader["DEPT_NO"].ToString());
                dept.Nombre = this.reader["DNOMBRE"].ToString();
                dept.Localidad = this.reader["LOC"].ToString();
                departamentos.Add(dept);
            }
            this.reader.Close();
            this.cn.Close();
            return departamentos;
        }

        public Departamento FindDepartamento(int id)
        {
            string sql = "select * from dept where dept_no=@iddepartamento";
            SqlParameter pamid = new SqlParameter("@iddepartamento", id);
            this.cmd.Parameters.Add(pamid);
            this.cmd.CommandType= CommandType.Text;
            this.cmd.CommandText = sql;
            this.cn.Open();
            this.reader = this.cmd.ExecuteReader();
            this.reader.Read();
            Departamento departamento = new Departamento();
            departamento.IdDepartamento = int.Parse(this.reader["DEPT_NO"].ToString());
            departamento.Nombre = this.reader["DNOMBRE"].ToString();
            departamento.Localidad = this.reader["LOC"].ToString();
            this.reader.Close();
            this.cn.Close();
            return departamento;
        }

        public void CreateDepartamento(int iddepartamento, string nombre, string localidad)
        {
            string sql = "INSERT INTO DEPT VALUES(@ID, @NOMBRE, @LOCALIDAD)";
            SqlParameter pamid = new SqlParameter("@ID", iddepartamento);
            SqlParameter pamnombre = new SqlParameter("@NOMBRE", nombre);
            SqlParameter pamlocalidad = new SqlParameter("@LOCALIDAD", localidad);
            this.cmd.Parameters.Add(pamid);
            this.cmd.Parameters.Add(pamnombre);
            this.cmd.Parameters.Add(pamlocalidad);
            this.cmd.CommandType = CommandType.Text;
            this.cmd.CommandText = sql;
            this.cn.Open();
            this.cmd.ExecuteNonQuery();
            this.cn.Close();
            this.cmd.Parameters.Clear();

        }

        public void UpdateDepartamento(int id, string nombre, string localidad)
        {
            string sql = "update dept set dnombre=@NOMBRE, loc=@LOC where dept_no=@ID";
            SqlParameter pamid = new SqlParameter("@ID", id);
            SqlParameter pamnombre = new SqlParameter("@NOMBRE", nombre);
            SqlParameter pamlocalidad = new SqlParameter("@LOC", localidad);
            this.cmd.Parameters.Add(pamid);
            this.cmd.Parameters.Add(pamnombre);
            this.cmd.Parameters.Add(pamlocalidad);
            this.cmd.CommandType = CommandType.Text;
            this.cmd.CommandText = sql;
            this.cn.Open();
            this.cmd.ExecuteNonQuery();
            this.cn.Close();
            this.cmd.Parameters.Clear();
        }

        public void DeleteDepartamento(int iddepartamento)
        {
            string sql = "delete from dept where dept_no=@ID";
            SqlParameter pamid = new SqlParameter("@ID", iddepartamento);
            this.cmd.Parameters.Add(pamid);
            this.cmd.CommandType = CommandType.Text;
            this.cmd.CommandText= sql;
            this.cn.Open();
            this.cmd.ExecuteNonQuery();
            this.cn.Close();
            this.cmd.Parameters.Clear();
        }
    }
}
