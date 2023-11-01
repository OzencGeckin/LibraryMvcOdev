using LibraryMvcOdev_1.Models.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryMvcOdev_1.Models.Configurations
{
    public class TagConfiguration : BaseConfiguration<Tag>
    {
        public override void Configure(EntityTypeBuilder<Tag> builder)
        {
            base.Configure(builder);
            builder.ToTable("Etiketler");
        }
    }
}
