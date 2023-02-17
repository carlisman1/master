using Oracle.ManagedDataAccess;
using SegundaPracticaJaunCarlosMarañon.Models;
using System.Data.OracleClient;
using SegundaPracticaJaunCarlosMarañon.Repositories;
using System.Data;
using Oracle.ManagedDataAccess.Client;


#region PROCEDURES
//CREATE OR REPLACE PROCEDURE SP_INSERTAR_COMIC
//(P_nombre COMICS.NOMBRE%TYPE,
//P_imagen COMICS.IMAGEN%TYPE,
//P_descripcion COMICS.DESCRIPCION%TYPE)
//AS
//BEGIN
//  INSERT INTO COMICS VALUES((select max(IDCOMIC) +1 FROM COMICS), P_nombre, P_imagen, P_descripcion);
//COMMIT;
//END;
#endregion


namespace SegundaPracticaJaunCarlosMarañon.Repositories
{
    public class RepositoryComicOracle : IRepositoryComic
    {
        private OracleConnection cn;
        private OracleCommand cmd;
        private OracleDataAdapter adapter;
        private DataTable tablaComics;

        public RepositoryComicOracle()
        {
            string connectionString =
                @"Data Source=LOCALHOST:1521/XE; Persist Security Info=True;User Id=SYSTEM;Password=oracle";
            this.cn = new OracleConnection(connectionString);
            this.cmd = new OracleCommand();
            this.cmd.Connection = this.cn;
            string sql = "select * from COMICS";
            this.adapter = new OracleDataAdapter(sql, connectionString);
            this.tablaComics = new DataTable();
            this.adapter.Fill(this.tablaComics);
        }

        public List<Comic> GetComics()
        {
            var consulta = from datos in this.tablaComics.AsEnumerable()
                           select datos;
            List<Comic> com = new List<Comic>();
            foreach (var row in consulta)
            {
                com.Add(new Comic()
                {
                    Idcomic = row.Field<int>("IDCOMIC"),
                    Nombre = row.Field<string>("NOMBRE"),
                    Imagen = row.Field<string>("IMAGEN"),
                    Descripcion = row.Field<string>("DESCRIPCION")
                });
            }
            return com;
        }

        public void InsertarComic(string nombre, string imagen, string descripcion)
        {
            OracleParameter pamnombre = new OracleParameter(":P_nombre", nombre);
            this.cmd.Parameters.Add(pamnombre);
            OracleParameter pamimagen = new OracleParameter(":P_imagen", imagen);
            this.cmd.Parameters.Add(pamimagen);
            OracleParameter pamdesc = new OracleParameter(":P_descripcion", descripcion);
            this.cmd.Parameters.Add(pamdesc);

            this.cmd.CommandType = CommandType.StoredProcedure;
            this.cmd.CommandText = "SP_INSERTAR_COMIC";
            this.cn.Open();
            this.cmd.ExecuteNonQuery();
            this.cn.Close();
            this.cmd.Parameters.Clear();
        }
    }
}
