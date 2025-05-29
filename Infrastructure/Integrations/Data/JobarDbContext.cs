using Microsoft.EntityFrameworkCore;

namespace JobarCharityInitProject.Infrastructure.Integrations.Data
{
    public class JobarDbContext : DbContext
    {
        public JobarDbContext(DbContextOptions<JobarDbContext> options) : base(options)
        {
        }
        public DbSet<Models.ToDo> ToDos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.ApplyConfigurationsFromAssembly
                (typeof(JobarDbContext).Assembly);
        }

    }
}
