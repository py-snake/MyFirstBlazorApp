using MyFirstBlazorApp.Models;

namespace MyFirstBlazorApp.Services
{
    public interface ITodoService
    {
        public void Add(TodoItem item);
        public IEnumerable<TodoItem> GetAll();
    }
}
