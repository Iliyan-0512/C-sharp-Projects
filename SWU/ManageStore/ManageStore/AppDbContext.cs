using Microsoft.EntityFrameworkCore;

namespace ManageStore
{
    public class AppDbContext : DbContext
    {
       public DbSet<Product> Products {  get; set; }

        public DbSet<Mesuare> Mesuares { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite(@"Data Source=Test.db");
        }
    }
}
