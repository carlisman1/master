using MvcCoreEnfermosEF.Data;
using MvcCoreEnfermosEF.Models;

namespace MvcCoreEnfermosEF.Repositories
{
    public class RepositoryEnfermo
    {
        private EnfermosContext context;

        public RepositoryEnfermo(EnfermosContext context)
        {
            this.context = context;
        }

        public List<Enfermo> GetEnfermos()
        {
            var consulta = from datos in this.context.Enfermos.AsEnumerable()
                           select datos;
            return consulta.ToList();
        }

        public Enfermo Detalles(string inscripcion)
        {
            var consulta = from datos in this.context.Enfermos.AsEnumerable()
                           where datos.Inscripcion == inscripcion
                           select datos;
            return consulta.FirstOrDefault();
        }
    }
}
