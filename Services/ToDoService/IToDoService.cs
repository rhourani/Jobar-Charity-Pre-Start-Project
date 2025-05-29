using JobarCharityInitProject.Infrastructure.Integrations.Data.Models;

namespace JobarCharityInitProject.Services.ToDoService;

public interface IToDoService
{
    Task<ToDo> GetToDoByIdAsync(int id);
    Task<IEnumerable<ToDo>> GetAllToDosAsync();
}
