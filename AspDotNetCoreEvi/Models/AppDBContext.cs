using Microsoft.EntityFrameworkCore;

namespace AspDotNetCoreEvi.Models
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext>options):base(options) 
        {} 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(p => p.ProductId);
            modelBuilder.Entity<Category>().HasKey(p => p.CategoryId);
            modelBuilder.Entity<Product>().HasOne(s=>s.Category).WithMany(s=>s.Products).HasForeignKey(s=>s.CategoryId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Seed();
        }
        public DbSet<Product> Products { get; set;}
        public DbSet<Category> Categories { get; set;}
       
    }
}
