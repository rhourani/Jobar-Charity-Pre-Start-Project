using Microsoft.EntityFrameworkCore;
using Repository_pattern_API.Infrastructure.Integrations.Data.Models;

namespace JobarCharityInitProject.Infrastructure.Integrations.Data
{
    public class JobarDbContext : DbContext
    {
        public JobarDbContext(DbContextOptions<JobarDbContext> options) : base(options)
        {
        }
        public DbSet<Models.ToDo> ToDos { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.ApplyConfigurationsFromAssembly
                (typeof(JobarDbContext).Assembly);
        }

    }
}
