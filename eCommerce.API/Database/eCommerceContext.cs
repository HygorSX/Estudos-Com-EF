using Microsoft.EntityFrameworkCore;

namespace eCommerce.API.Database
{
    public class eCommerceContext : DbContext
    {
        public eCommerceContext(DbContextOptions<eCommerceContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<EnderecoEntrega> EnderecoEntregas { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        #region Conexao sem distinção de ambientes de execução
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-73M6QT8\\MSSQLSERVER01;Database=eCommerce;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
        }
        #endregion
    }
}
