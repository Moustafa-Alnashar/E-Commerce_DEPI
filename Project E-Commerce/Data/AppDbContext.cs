using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project_E_Commerce.Models;


namespace Project_E_Commerce.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        internal object Cart_Item;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product_variation> Product_Variations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 


            modelBuilder.Entity<Product>()
    .Property(p => p.Price)
    .HasColumnType("decimal(18,2)");


            base.OnModelCreating(modelBuilder);


            foreach (var foreignKey in modelBuilder.Model
                     .GetEntityTypes()
                     .SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
        //public DbSet<Project_E_Commerce.Models.Category> Category { get; set; } = default!;


    }
}
