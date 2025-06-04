using JobarCharityInitProject.Infrastructure.Integrations.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repository_pattern_API.Infrastructure.Integrations.Data.Models;

namespace Repository_pattern_API.Infrastructure.Integrations.Data.Config
{
    public class AddressConfig : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Country).HasMaxLength(56);
            builder.Property(e => e.City).HasMaxLength(85);
            builder.Property(e => e.StreetName).HasMaxLength(100);
            builder.Property(e => e.HomeNum).IsRequired(false).HasMaxLength(15);
            builder.Property(e => e.FullAddress).HasMaxLength(300);
        }
    }
}
