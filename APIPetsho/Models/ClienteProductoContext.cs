using Microsoft.EntityFrameworkCore;

namespace APIPetshop.Models
{
    public class ClienteProductoContext :DbContext
    {
        public ClienteProductoContext(DbContextOptions<ClienteProductoContext> options) : base(options)
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set;}
    }
}
