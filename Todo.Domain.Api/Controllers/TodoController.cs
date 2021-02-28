using Microsoft.AspNetCore.Mvc;
using Todo.Domain.Commands;
using Todo.Domain.Handlers;

namespace Todo.Api.Controllers
{
    [ApiController]
    [Route("v1/todos")]
    public class TodoController : ControllerBase
    {
        [Route("")]
        [HttpPost]
        public GenericCommandResult Create([FromBody] CreateToDoCommands command,
        [FromServices] ToDoHandler handler)
        {
            command.User = "kaoef";
            return (GenericCommandResult)handler.Handle(command);
        }
    }
}