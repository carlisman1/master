using System.Data;
using System.Data.SqlClient;
using MvcCoreSqlOracleHospitales.Repositories;
using MvcCoreSqlOracleHospitales.Models;

#region PROCEDURES
//CREATE PROCEDURE SP_INSERTAR_HOSP(@HOSPITAL_COD int, @NOMBRE nvarchar(50), @DIRECCION nvarchar(50), @TELEFONO nvarchar(50), @NUM_CAMA int)
//AS
//    INSERT INTO HOSPITAL VALUES( @HOSPITAL_COD , @NOMBRE, @DIRECCION, @TELEFONO, @NUM_CAMA)
//GO

//CREATE PROCEDURE SP_MODIFICAR_HOSP(@HOSPITAL_COD INT, @NOMBRE nvarchar(50), @DIRECCION nvarchar(50), @TELEFONO nvarchar(50), @NUM_CAMA int)
//AS
//    UPDATE HOSPITAL SET HOSPITAL_COD = @HOSPITAL_COD , NOMBRE = @NOMBRE, DIRECCION = @DIRECCION, TELEFONO = @TELEFONO, NUM_CAMA = @NUM_CAMA
//	WHERE @HOSPITAL_COD = HOSPITAL_COD
//GO

//CREATE PROCEDURE SP_ELIMINAR_HOSP(@HOSPITAL_COD int)
//AS
//    DELETE FROM HOSPITAL WHERE HOSPITAL_COD = @HOSPITAL_COD 
//GO
#endregion

namespace MvcCoreSqlOracleHospitales.Repositories
{
    public class RepositoryHospitalesSQL : IRepositoryHospital
    {
        public DataTable tablaHospitales;

        private SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataReader? reader;

        public RepositoryHospitalesSQL()
        {
            string connectionString = "Data Source=LOCALHOST\\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Password=MCSD2023";
            string sql = "SELECT * FROM HOSPITAL";

            SqlDataAdapter adapter = new SqlDataAdapter(sql, connectionString);

            // Ado
            this.cn = new(connectionString);
            this.cmd = this.cn.CreateCommand();

            this.tablaHospitales = new DataTable();
            adapter.Fill(this.tablaHospitales);
        }

        public List<Hospital> GetHospitales()
        {
            var consulta = from datos in this.tablaHospitales.AsEnumerable()
                           select datos;
            List<Hospital> hospitales = new List<Hospital>();
            foreach (var row in consulta)
            {
                hospitales.Add(new Hospital()
                {
                    IdHospital = row.Field<int>("HOSPITAL_COD"),
                    Nombre = row.Field<string>("NOMBRE"),
                    Direccion = row.Field<string>("DIRECCION"),
                    Telefono = row.Field<string>("TELEFONO"),
                    NumCama = row.Field<int>("NUM_CAMA")
                });
            }
            return hospitales;
        }

        public Hospital Detalles(int idhospital)
        {
            var consulta = from datos in this.tablaHospitales.AsEnumerable()
                           where datos.Field<int>("HOSPITAL_COD") == idhospital
                           select datos;

            var row = consulta.First();

            Hospital hosp = new()
            {
                IdHospital = row.Field<int>("HOSPITAL_COD"),
                Nombre = row.Field<string>("NOMBRE"),
                Direccion = row.Field<string>("DIRECCION"),
                Telefono = row.Field<string>("TELEFONO"),
                NumCama = row.Field<int>("NUM_CAMA")
            };

            return hosp;
        }

        public void InsertarHospital(int idhospital, string nombre, string direccion, string telefono, int numCama)
        {
            SqlParameter pamid = new SqlParameter("@HOSPITAL_COD", idhospital);
            this.cmd.Parameters.Add(pamid);
            SqlParameter pamnombre = new SqlParameter("@NOMBRE", nombre);
            this.cmd.Parameters.Add(pamnombre);
            SqlParameter pamdireccion = new SqlParameter("@DIRECCION", direccion);
            this.cmd.Parameters.Add(pamdireccion);
            SqlParameter pamtelefono = new SqlParameter("@TELEFONO", telefono);
            this.cmd.Parameters.Add(pamtelefono);
            SqlParameter pamcama = new SqlParameter("@NUM_CAMA", numCama);
            this.cmd.Parameters.Add(pamcama);

            this.cmd.CommandType = CommandType.StoredProcedure;
            this.cmd.CommandText = "SP_INSERTAR_HOSP";
            this.cn.Open();
            this.cmd.ExecuteNonQuery();
            this.cn.Close();
            this.cmd.Parameters.Clear();
        }

        public void ModificarHospital(int idhospital, string nombre, string direccion, string telefono, int numCama)
        {
            SqlParameter pamid = new SqlParameter("@HOSPITAL_COD", idhospital);
            this.cmd.Parameters.Add(pamid);
            SqlParameter pamnombre = new SqlParameter("@NOMBRE", nombre);
            this.cmd.Parameters.Add(pamnombre);
            SqlParameter pamdireccion = new SqlParameter("@DIRECCION", direccion);
            this.cmd.Parameters.Add(pamdireccion);
            SqlParameter pamtelefono = new SqlParameter("@TELEFONO", telefono);
            this.cmd.Parameters.Add(pamtelefono);
            SqlParameter pamcama = new SqlParameter("@NUM_CAMA", numCama);
            this.cmd.Parameters.Add(pamcama);

            this.cmd.CommandType = CommandType.StoredProcedure;
            this.cmd.CommandText = "SP_MODIFICAR_HOSP";
            this.cn.Open();
            this.cmd.ExecuteNonQuery();
            this.cn.Close();
            this.cmd.Parameters.Clear();
        }

        public void EliminarHospital(int idhospital)
        {
            SqlParameter pamid = new SqlParameter("@HOSPITAL_COD", idhospital);
            this.cmd.Parameters.Add(pamid);
            this.cmd.CommandType = CommandType.StoredProcedure;
            this.cmd.CommandText = "SP_ELIMINAR_HOSP";
            this.cn.Open();
            this.cmd.ExecuteNonQuery();
            this.cn.Close();
            this.cmd.Parameters.Clear();
        }
    }
}
