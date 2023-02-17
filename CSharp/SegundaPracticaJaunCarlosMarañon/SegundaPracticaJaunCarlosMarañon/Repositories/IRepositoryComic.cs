using SegundaPracticaJaunCarlosMarañon.Models;

namespace SegundaPracticaJaunCarlosMarañon.Repositories
{
    public interface IRepositoryComic
    {
        List<Comic> GetComics();
        void InsertarComic(string nombre, string imagen, string descripcion);
    }
}
