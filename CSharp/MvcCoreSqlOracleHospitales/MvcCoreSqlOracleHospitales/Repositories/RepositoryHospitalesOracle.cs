using Oracle.ManagedDataAccess;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using MvcCoreSqlOracleHospitales.Models;
using MvcCoreSqlOracleHospitales.Repositories;

#region PROCEDURES
//CREATE OR REPLACE PROCEDURE SP_INSERTAR_HOSP
//(P_HOSPITAL_COD HOSPITAL.HOSPITAL_COD%TYPE, P_NOMBRE HOSPITAL.NOMBRE%TYPE, P_DIRECCION HOSPITAL.DIRECCION%TYPE, P_TELEFONO HOSPITAL.TELEFONO%TYPE, P_NUM_CAMA HOSPITAL.NUM_CAMA%TYPE)
//AS
//BEGIN
// INSERT INTO HOSPITAL VALUES(P_HOSPITAL_COD, P_NOMBRE, P_DIRECCION, P_TELEFONO, P_NUM_CAMA);
//COMMIT;
//END;

//CREATE OR REPLACE PROCEDURE SP_MODIFICAR_HOSP
//(P_HOSPITAL_COD HOSPITAL.HOSPITAL_COD%TYPE, P_NOMBRE HOSPITAL.NOMBRE%TYPE, P_DIRECCION HOSPITAL.DIRECCION%TYPE, P_TELEFONO HOSPITAL.TELEFONO%TYPE, P_NUM_CAMA HOSPITAL.NUM_CAMA%TYPE)
//AS
//BEGIN
//  UPDATE HOSPITAL SET NOMBRE = P_NOMBRE, DIRECCION = P_DIRECCION, TELEFONO = P_TELEFONO, NUM_CAMA = P_NUM_CAMA WHERE HOSPITAL_COD = P_HOSPITAL_COD;
//COMMIT;
//END

//CREATE OR REPLACE PROCEDURE SP_ELIMINAR_HOSP
//(P_HOSPITAL_COD HOSPITAL.HOSPITAL_COD%TYPE)
//AS
//BEGIN
//  DELETE FROM HOSPITAL WHERE HOSPITAL_COD = P_HOSPITAL_COD;
//COMMIT;
//END;

#endregion

namespace MvcCoreSqlOracleHospitales.Repositories
{
    public class RepositoryHospitalesOracle : IRepositoryHospital
    {
        private OracleConnection cn;
        private OracleCommand cmd;
        private OracleDataAdapter adapter;
        private DataTable tablaHospitales;

        public RepositoryHospitalesOracle()
        {
            string connectionString =
                @"Data Source=LOCALHOST:1521/XE; Persist Security Info=True;User Id=SYSTEM;Password=oracle";
            this.cn = new OracleConnection(connectionString);
            this.cmd = new OracleCommand();
            this.cmd.Connection = this.cn;
            string sql = "select * from hospital";
            this.adapter = new OracleDataAdapter(sql, connectionString);
            this.tablaHospitales = new DataTable();
            this.adapter.Fill(this.tablaHospitales);
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
            OracleParameter pamid = new OracleParameter(":P_HOSPITAL_COD", idhospital);
            this.cmd.Parameters.Add(pamid);
            OracleParameter pamnombre = new OracleParameter(":P_NOMBRE", nombre);
            this.cmd.Parameters.Add(pamnombre);
            OracleParameter pamdireccion = new OracleParameter(":P_DIRECCION", direccion);
            this.cmd.Parameters.Add(pamdireccion);
            OracleParameter pamtelefono = new OracleParameter(":P_TELEFONO", telefono);
            this.cmd.Parameters.Add(pamtelefono);
            OracleParameter pamcama = new OracleParameter(":P_NUM_CAMA", numCama);
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
            OracleParameter pamid = new OracleParameter(":P_HOSPITAL_COD", idhospital);
            this.cmd.Parameters.Add(pamid);
            OracleParameter pamnombre = new OracleParameter(":P_NOMBRE", nombre);
            this.cmd.Parameters.Add(pamnombre);
            OracleParameter pamdireccion = new OracleParameter(":P_DIRECCION", direccion);
            this.cmd.Parameters.Add(pamdireccion);
            OracleParameter pamtelefono = new OracleParameter(":P_TELEFONO", telefono);
            this.cmd.Parameters.Add(pamtelefono);
            OracleParameter pamcama = new OracleParameter(":P_NUM_CAMA", numCama);
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
            OracleParameter pamid = new OracleParameter(":P_HOSPITAL_COD", idhospital);
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
