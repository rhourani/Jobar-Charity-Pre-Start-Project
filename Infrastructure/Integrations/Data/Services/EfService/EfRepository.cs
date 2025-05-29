using JobarCharityInitProject.Infrastructure.Integrations.Data;
using JobarCharityInitProject.Infrastructure.Integrations.Data.Services.EfService;
using Microsoft.EntityFrameworkCore;

namespace Repository_pattern_API.Infrastructure.Integrations.Data.Services.EfService;

public class EfRepository<T> : IRepository<T> where T : class
{
    protected readonly JobarDbContext _dbContext;
    private DbSet<T> _entities;

    public EfRepository(JobarDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public virtual async Task<T> GetByIdAsync(int id)
    {
        return await Entities.FindAsync(id);
    }

    public async Task<IEnumerable<T>> ListAllAsync()
    {
        return await Entities.ToListAsync();
    }
    public async Task<T> AddAsync(T entity)
    {
        await Entities.AddAsync(entity);
        await _dbContext.SaveChangesAsync();
        return entity;
    }

    public async Task UpdateAsync(T entity)
    {
        _dbContext.Entry(entity).State = EntityState.Modified;
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(T entity)
    {
        Entities.Remove(entity);
        await _dbContext.SaveChangesAsync();
    }
    public async Task DeleteAsync(IList<T> entity)
    {
        Entities.RemoveRange(entity);
    }

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await _dbContext.SaveChangesAsync(cancellationToken);
    }

    protected virtual DbSet<T> Entities
    {
        get
        {
            if (_entities == null)
                _entities = _dbContext.Set<T>();

            return _entities;
        }
    }

    public IQueryable<T> Table => Entities;
}
