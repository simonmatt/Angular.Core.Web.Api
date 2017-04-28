using Angular.Core.Web.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular.Core.Web.Api.Repository
{
    public interface ITodoRespository
    {
        IEnumerable<Todo> GetTodos();
        void AddTodo(Todo todo);
    }
}
