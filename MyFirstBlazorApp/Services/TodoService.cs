﻿using MyFirstBlazorApp.Models;

namespace MyFirstBlazorApp.Services
{
    public class TodoService : ITodoService
    {
        private readonly IList<TodoItem> _todoItems;

        public TodoService()
        {
            _todoItems = new List<TodoItem>
            {
                new TodoItem("Todo item 1"),
                new TodoItem("Todo item 2")
            };
        }

        public void Add(TodoItem item)
        {
            _todoItems.Add(item);
        }

        public IEnumerable<TodoItem> GetAll()
        {
            return _todoItems.ToList();
        }

        public void Delete(TodoItem item)
        {
            _todoItems.Remove(item);
        }

        public void Complete(TodoItem item)
        {
            item.Completed = true;
        }

        public void Uncomplete(TodoItem item)
        {
            item.Completed = false;
        }
    }
}
