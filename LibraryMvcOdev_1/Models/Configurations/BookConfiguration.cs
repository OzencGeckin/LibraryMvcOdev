using LibraryMvcOdev_1.Models.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryMvcOdev_1.Models.Configurations
{
    public class BookConfiguration : BaseConfiguration<Book>
    {
        public override void Configure(EntityTypeBuilder<Book> builder)
        {
            base.Configure(builder);
            builder.ToTable("Kitaplar");
            
        }
    }
}
