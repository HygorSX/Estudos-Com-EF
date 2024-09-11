using eCommerce.Models;

namespace eCommerce.API.Repositories
{
    public interface IUsuarioRepository
    {
        List<Usuario> Get();
        Usuario Get(int id);
        void Add(Usuario user);
        void Update(Usuario user);
        void Delete(int id);

    }
}
