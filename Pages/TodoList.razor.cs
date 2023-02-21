using BlazorApp1.Data;
using Microsoft.AspNetCore.Components;

namespace MyBlazorServerApp.Pages
{
    public class TodoListBase : ComponentBase
    {
        protected List<TodoItem> todos = new();
        protected string? newTodo;

        protected void AddTodo()
        {
            // Add the todo
            if (!string.IsNullOrWhiteSpace(newTodo))
            {
                todos.Add(new TodoItem { Title = newTodo });
                newTodo = string.Empty;
            }
        }
    }
}
