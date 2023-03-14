using MvcCoreUtilidades.Models;

namespace MvcCoreUtilidades.Repositories
{
    public class RepositoryCoches
    {
        private List<Coche> Cars;

        public RepositoryCoches(){
            this.Cars = new List<Coche>
            {
                new Coche {IdCoche = 1, Marca = "Pontiac"
                , Modelo = "Firebird", Imagen = ""},
                new Coche {IdCoche = 2, Marca = "VW"
                , Modelo = "Escarabajo", Imagen = ""},
                new Coche {IdCoche = 3,Marca = "Ferrari"
                ,Modelo = "Testarrosa", Imagen = ""},
                new Coche {IdCoche = 4,Marca = "Ford",
                    Modelo = "Mustang GT",Imagen = "" },
            };
        }

       public List<Coche> GetCoches()
        {
            return this.Cars;
        }

       public Coche FindCoche(int id)
       {
           return this.Cars.FirstOrDefault(x => x.IdCoche == id);
        }
    }
}
