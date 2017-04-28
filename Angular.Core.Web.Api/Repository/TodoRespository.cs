using Angular.Core.Web.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular.Core.Web.Api.Repository
{
    public class TodoRespository:ITodoRespository
    {
        public static List<Todo> Todos = new List<Todo>();

        public IEnumerable<Todo> GetTodos()
        {
            return Todos;
        }

        public void AddTodo(Todo todo)
        {
            Todos.Add(todo);
        }
    }
}
