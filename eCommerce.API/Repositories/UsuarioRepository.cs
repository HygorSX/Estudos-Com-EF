using eCommerce.Models;

namespace eCommerce.API.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public static List<Usuario> _db = new List<Usuario>();
        public List<Usuario> Get()
        {
            return _db;
        }

        public Usuario Get(int id)
        {
            return _db.Find(x => x.Id == id);
        }

        public void Add(Usuario user)
        {
            _db.Add(user);
        }

        public void Update(Usuario user)
        {
            _db.Remove(Get(user.Id));
            _db.Add(user);
        }

        public void Delete(int id)
        {
            _db.Remove(Get(id));
        }
    }
}
