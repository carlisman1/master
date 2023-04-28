using ServiceWCFLogicaCoches.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ServiceWCFLogicaCoches.Repositories
{
    public class RepositoryCoches
    {
        private XDocument document;

        public RepositoryCoches() 
        { 
            string resourceName = "ServiceWCFLogicaCoches.coches.xml"; 
            Stream stream = this.GetType().Assembly.GetManifestResourceStream(resourceName); 
            this.document = XDocument.Load(stream); 
        }

        public List<Coche> GetCoches() 
        { 
            var consulta = from datos in this.document.Descendants("coche") 
                           select new Coche() 
                           {    IdCoche = int.Parse(datos.Element("idcoche").ToString()), 
                                Imagen = datos.Element("imagen").ToString(), 
                                Marca = datos.Element("marca").ToString(), 
                                Modelo = datos.Element("modelo").ToString() }; 
            return consulta.ToList(); 
        }

        public Coche FindCoche(int idCoche) 
        { 
            return this.GetCoches().FirstOrDefault(x => x.IdCoche == idCoche); 
        }
    }
}
