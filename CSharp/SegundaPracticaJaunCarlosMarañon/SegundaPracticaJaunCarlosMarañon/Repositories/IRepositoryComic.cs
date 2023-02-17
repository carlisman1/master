using SegundaPracticaJaunCarlosMarañon.Models;

namespace SegundaPracticaJaunCarlosMarañon.Repositories
{
    public interface IRepositoryComic
    {
        List<Comic> GetComics();
        void InsertarComic(int idcomic, string nombre, string imagen, string descripcion);
    }
}
