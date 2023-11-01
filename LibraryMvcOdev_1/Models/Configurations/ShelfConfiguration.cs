using LibraryMvcOdev_1.Models.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryMvcOdev_1.Models.Configurations
{
    public class ShelfConfiguration : BaseConfiguration<Shelf>
    {
        public override void Configure(EntityTypeBuilder<Shelf> builder)
        {
            base.Configure(builder);
            builder.ToTable("Raflar");
        }
    }
}
