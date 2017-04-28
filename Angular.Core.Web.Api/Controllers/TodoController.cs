using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Angular.Core.Web.Api.Repository;
using Angular.Core.Web.Api.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Angular.Core.Web.Api.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        private ITodoRespository _repository;

        public TodoController(ITodoRespository repository)
        {
            _repository = repository;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Todo> Get()
        {
            return _repository.GetTodos();
        }
        // POST api/values
        [HttpPost]
        public void Post([FromBody]Todo todo)
        {
            _repository.AddTodo(todo);
        }
    }
}
