using Oracle.ManagedDataAccess;
using SegundaPracticaJaunCarlosMarañon.Models;
using System.Data.OracleClient;
using SegundaPracticaJaunCarlosMarañon.Repositories;
using System.Data;
using Oracle.ManagedDataAccess.Client;


#region PROCEDURES
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
                    idcomic = row.Field<int>("IDCOMIC"),
                    nombre = row.Field<string>("NOMBRE"),
                    imagen = row.Field<string>("IMAGEN"),
                    descripcion = row.Field<string>("DESCRIPCION")
                });
            }
            return com;
        }

        public void InsertarComic(int idcomic, string nombre, string imagen, string descripcion)
        {
            OracleParameter pamid = new OracleParameter(":P_idcomic", idcomic);
            this.cmd.Parameters.Add(pamid);
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
