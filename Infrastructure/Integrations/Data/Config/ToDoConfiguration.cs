using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using JobarCharityInitProject.Infrastructure.Integrations.Data.Models;

namespace JobarCharityInitProject.Infrastructure.Integrations.Data.Config
{
    public class ToDoConfiguration : IEntityTypeConfiguration<ToDo>
    {
        public void Configure(EntityTypeBuilder<ToDo> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Title).HasMaxLength(50);
            builder.Property(e => e.Description).HasMaxLength(50);
        }
    }
}
