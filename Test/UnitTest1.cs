using JobarCharityInitProject.Infrastructure.Integrations.Data.Models;
using JobarCharityInitProject.Infrastructure.Integrations.Data.Services.EfService;
using JobarCharityInitProject.Services.ToDoService;
using Moq;
using NUnit.Framework;

namespace Repository_pattern_API.Test;

[TestFixture]
public class ToDoServiceTests
{
    private Mock<IRepository<ToDo>> _mockRepo;
    private ToDoService _service;

    [SetUp]
    public void Setup()
    {
        _mockRepo = new Mock<IRepository<ToDo>>();
        _service = new ToDoService(_mockRepo.Object);
    }

    [Test]
    public async Task GetAllToDosAsync_ReturnsAllToDos()
    {
        // Arrange
        var todos = new List<ToDo>
        {
            new() { Id = 1, Title = "Test1", Description = "Desc1", IsCompleted = false },
            new() { Id = 2, Title = "Test2", Description = "Desc2", IsCompleted = true }
        };
        _mockRepo.Setup(r => r.ListAllAsync()).ReturnsAsync(todos);

        // Act
        var result = await _service.GetAllToDosAsync();

        // Assert
        Assert.That(result, Is.EquivalentTo(todos));
    }

    [Test]
    public async Task GetToDoByIdAsync_ReturnsCorrectToDo()
    {
        // Arrange
        var todo = new ToDo { Id = 1, Title = "Test1", Description = "Desc1", IsCompleted = false };
        _mockRepo.Setup(r => r.GetByIdAsync(1)).ReturnsAsync(todo);

        // Act
        var result = await _service.GetToDoByIdAsync(1);

        // Assert
        Assert.That(result, Is.EqualTo(todo));
    }
}
