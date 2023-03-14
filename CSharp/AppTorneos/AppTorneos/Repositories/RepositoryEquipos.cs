using AppTorneos.Data;
using Microsoft.Data.SqlClient;

namespace AppTorneos.Repositories
{
    public class RepositoryEquipos
    {
        private BSTournamentContext context;

        public RepositoryEquipos(BSTournamentContext context)
        {
            this.context = context;
        }

        public void InsertarEquipo(string nombre, string jugador1, string jugador2, string jugador3)
        {
            string sql = "INSERTAREQUIPO_SP @Nombre, @Jugador1, @Jugador2, @Jugador3";
            SqlParameter paminombre =
                new SqlParameter("@Nombre", nombre);
        }
    }
}
