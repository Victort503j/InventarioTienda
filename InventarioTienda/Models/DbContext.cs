using Microsoft.EntityFrameworkCore;

namespace InventarioTienda.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Rol> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Box> Boxes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<SalesDetails> SalesDetails { get; set; }
        public DbSet<Sale> Sales { get; set; }
    }
}
