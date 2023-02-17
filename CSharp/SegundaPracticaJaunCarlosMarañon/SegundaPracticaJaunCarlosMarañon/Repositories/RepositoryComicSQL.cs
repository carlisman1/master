using System.Data;
using System.Data.SqlClient;
using SegundaPracticaJaunCarlosMarañon.Models;


#region PROCEDURES
//CREATE PROCEDURE SP_INSERTAR_COMIC(@idcomic int, @nombre nvarchar(50), @imagen nvarchar(50), @descripcion nvarchar(50)) 
//as
//    insert into COMICS values(@idcomic, @nombre, @imagen, @descripcion)
//go
#endregion

namespace SegundaPracticaJaunCarlosMarañon.Repositories
{
    public class RepositoryComicSQL : IRepositoryComic
    {
        public DataTable tablaComics;

        private SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataReader? reader;

        public RepositoryComicSQL()
        {
            string connectionString = "Data Source=LOCALHOST\\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Password=MCSD2023";
            string sql = "SELECT * FROM COMICS";

            SqlDataAdapter adapter = new SqlDataAdapter(sql, connectionString);

            // Ado
            this.cn = new(connectionString);
            this.cmd = this.cn.CreateCommand();

            this.tablaComics = new DataTable();
            adapter.Fill(this.tablaComics);
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

        public int GetMaximo()
        {
            var maximo = (from datos in this.GetComics() select datos).Max(x => x.idcomic);
            return maximo + 1;
        }

        public void InsertarComic(int idcomic, string nombre, string imagen, string descripcion)
        {
            
            SqlParameter pamid = new SqlParameter("@idcomic", GetMaximo());
            this.cmd.Parameters.Add(pamid);
            SqlParameter pamnombre = new SqlParameter("@nombre", nombre);
            this.cmd.Parameters.Add(pamnombre);
            SqlParameter pamimagen = new SqlParameter("@imagen", imagen);
            this.cmd.Parameters.Add(pamimagen);
            SqlParameter pamdesc = new SqlParameter("@descripcion", descripcion);
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
