using LibraryMvcOdev_1.Models.Configurations;
using LibraryMvcOdev_1.Models.Entites;
using Microsoft.EntityFrameworkCore;

namespace LibraryMvcOdev_1.Models.ContextClasses
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> opt):base(opt)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
        }
    }
}
