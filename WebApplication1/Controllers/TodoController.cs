using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private List<Todo> _todos;

        public TodoController(List<Todo> todos)
        {
            _todos = todos;
        }

        [HttpGet]
        public IEnumerable<Todo> GetTodos()
        {
            return _todos;
        }

        [HttpPost]
        public void AddNewTodo(Todo todo)
        {
            _todos.Add(todo);
        }
    }
}
