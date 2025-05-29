
using JobarCharityInitProject.Infrastructure.Integrations.Data.Models;
using JobarCharityInitProject.Infrastructure.Integrations.Data.Services.EfService;

namespace JobarCharityInitProject.Services.ToDoService;

public class ToDoService : IToDoService
{
    private readonly IRepository<ToDo> _todoRepository;

    public ToDoService(IRepository<ToDo> todoRepository)
    {
        _todoRepository = todoRepository;
    }

    public async Task<IEnumerable<ToDo>> GetAllToDosAsync()
    {
        return await _todoRepository.ListAllAsync();
    }
    public async Task<ToDo> GetToDoByIdAsync(int id)
    {
        return await _todoRepository.GetByIdAsync(id);
    }

    // Business logic methods that utilize the repository
    // ...
}