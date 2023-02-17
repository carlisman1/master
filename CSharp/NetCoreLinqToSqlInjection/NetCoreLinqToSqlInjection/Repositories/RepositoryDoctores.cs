using NetCoreLinqToSqlInjection.Models;
using System.Data;
using System.Data.SqlClient;

#region PROCEDURE DELETE
//CREATE OR REPLACE PROCEDURE SP_DELETE_EMPLEADO
//(P_IDDOCTOR DOCTOR.DOCTOR_NO%TYPE)
//AS
//BEGIN
//  DELETE FROM DOCTOR WHERE DOCTOR_NO=P_IDDOCTOR;
//END;
#endregion


namespace NetCoreLinqToSqlInjection.Repositories
{
    public class RepositoryDoctores : IRepository
    {
        public DataTable tablaDoctores;

        private SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataReader? reader;

        public RepositoryDoctores()
        {
            string connectionString = "Data Source=LOCALHOST\\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Password=MCSD2023";
            string sql = "SELECT * FROM DOCTOR";
            SqlDataAdapter adpter = new SqlDataAdapter(sql, connectionString);

            // Ado
            this.cn = new(connectionString);
            this.cmd = this.cn.CreateCommand();

            this.tablaDoctores = new DataTable();
            adpter.Fill(this.tablaDoctores);
        }

        public List<Doctor> GetDoctor()
        {
            var consulta = from datos in this.tablaDoctores.AsEnumerable()
                           select datos;
            List<Doctor> doctores = new List<Doctor>();
            foreach (var row in consulta)
            {
                doctores.Add(new Doctor()
                {
                    HospitalCod = row.Field<string>("HOSPITAL_COD"),
                    DoctorCod = row.Field<string>("DOCTOR_NO"),
                    Apellido = row.Field<string>("APELLIDO"),
                    Especialidad = row.Field<string>("ESPECIALIDAD"),
                    Salario = row.Field<int>("SALARIO")
                });
            }
            return doctores;
        }

        public int GetMaximoDoctor()
        {
            var maximo = (from datos in this.tablaDoctores.AsEnumerable() select datos).Max(x => x.Field<int>("DOCTOR_NO")) + 1;
            return maximo;
        }

        public void InsertDoctor(string hospitalCod, string doctorCod, string apellido, string especialidad, int salario)
        {
            string sql = "INSERT INTO DOCTOR VALUES(@HOSPITALCOD, @DOCTORCOD, @APELLIDO, @ESPECIALIDAD, @SALARIO)"; this.cmd.CommandType = CommandType.Text; this.cmd.CommandText = sql;

            SqlParameter paramHospCod = new("@HOSPITALCOD", hospitalCod);
            SqlParameter paramDoctorCod = new("@DOCTORCOD", doctorCod);
            SqlParameter paramApellido = new("@APELLIDO", apellido);
            SqlParameter paramEspecialidad = new("@ESPECIALIDAD", especialidad);
            SqlParameter paramSalario = new("@SALARIO", salario);
            this.cmd.Parameters.Add(paramSalario); 
            this.cmd.Parameters.Add(paramApellido); 
            this.cmd.Parameters.Add(paramEspecialidad); 
            this.cmd.Parameters.Add(paramDoctorCod); 
            this.cmd.Parameters.Add(paramHospCod);
            this.cn.Open(); 
            this.cmd.ExecuteNonQuery(); 
            this.cmd.Parameters.Clear(); 
            this.cn.Close();
        }

        public void DeleteDoctor(int iddoctor)
        {
            SqlParameter pamid = new SqlParameter("@iddoctor", iddoctor);
            this.cmd.Parameters.Add(pamid);
            this.cmd.CommandType = CommandType.StoredProcedure;
            this.cmd.CommandText = "SP_DELETEDOCTOR";
            this.cn.Open();
            this.cmd.ExecuteNonQuery();
            this.cn.Close();
            this.cmd.Parameters.Clear();
        }

    }
}
