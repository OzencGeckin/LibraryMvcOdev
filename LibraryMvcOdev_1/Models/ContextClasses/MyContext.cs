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
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new BookTagConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new TagConfiguration());
            modelBuilder.ApplyConfiguration(new ShelfConfiguration());
            modelBuilder.ApplyConfiguration(new RoomConfiguration());
            
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Shelf> Shelves { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<BookTag> BookTags { get; set; }

    }
}
