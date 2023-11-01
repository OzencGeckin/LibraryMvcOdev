using LibraryMvcOdev_1.Models.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryMvcOdev_1.Models.Configurations
{
    public class BookTagConfiguration : BaseConfiguration<BookTag>
    {
        public override void Configure(EntityTypeBuilder<BookTag> builder)
        {
            base.Configure(builder);
            builder.ToTable("Kitap Etiketleri");
            builder.Ignore(x => x.ID);
            builder.HasKey(x => new
            {
                x.BookID,
                x.TagID
            });
        }
    }
}
