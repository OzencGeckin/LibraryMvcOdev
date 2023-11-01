using LibraryMvcOdev_1.Models.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryMvcOdev_1.Models.Configurations
{
    public class RoomConfiguration : BaseConfiguration<Room>
    {
        public override void Configure(EntityTypeBuilder<Room> builder)
        {
            base.Configure(builder);
            builder.ToTable("Odalar");
        }
    }
}
