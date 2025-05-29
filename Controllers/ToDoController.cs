using Microsoft.AspNetCore.Mvc;
using JobarCharityInitProject.Infrastructure.Integrations.Data.Models;
using JobarCharityInitProject.Services.ToDoService;

namespace JobarCharityInitProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoController : ControllerBase
    {
        private readonly ILogger<ToDoController> _logger;
        private readonly IToDoService _toDoService;

        public ToDoController(ILogger<ToDoController> logger, IToDoService toDoService)
        {
            _logger = logger;
            _toDoService = toDoService;
        }

        [HttpGet("{id}")]
        public async Task<ToDo> GetToDo(int id)
        {
            return await _toDoService.GetToDoByIdAsync(id);
        }
        [HttpGet("GetAll")]
        public async Task<IEnumerable<ToDo>> GetToDos()
        {
            return await _toDoService.GetAllToDosAsync();
        }
    }
}
