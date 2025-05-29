namespace JobarCharityInitProject.Infrastructure.Integrations.Data.Services.EfService;

public interface IRepository<T>
{
    Task<T> GetByIdAsync(int id);
    Task<IEnumerable<T>> ListAllAsync();
    Task<T> AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    Task DeleteAsync(IList<T> entity);
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
