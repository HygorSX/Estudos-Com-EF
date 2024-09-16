using eCommerce.API.Database;
using eCommerce.Models;

namespace eCommerce.API.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly eCommerceContext _db;

        public UsuarioRepository(eCommerceContext db)
        {
            _db = db;
        }

        public List<Usuario> Get()
        {
            return _db.Usuarios.OrderBy(a => a.Id).ToList();
        }

        public Usuario Get(int id)
        {
            return _db.Usuarios.Find(id);
        }

        public void Add(Usuario user)
        {
            _db.Usuarios.Add(user);
            _db.SaveChanges();
        }

        public void Update(Usuario user)
        {
            _db.Usuarios.Update(user);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            _db.Usuarios.Remove(Get(id));
            _db.SaveChanges();
        }
    }
}
