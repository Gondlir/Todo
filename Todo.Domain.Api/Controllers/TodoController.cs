using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Todo.Domain.Commands;
using Todo.Domain.Entities;
using Todo.Domain.Handlers;
using Todo.Domain.Repositories;

namespace Todo.Api.Controllers
{
    [ApiController]
    [Route("v1/todos")]
    public class TodoController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public IEnumerable<ToDoEntity> GetAll([FromServices] IRepository repo)
        {
            return repo.GetAll("kaoef");
        }
        [Route("done")]
        [HttpGet]
        public IEnumerable<ToDoEntity> GetAllDone([FromServices] IRepository repo)
        {
            return repo.GetAllDone("kaoef");
        }
        [Route("undone")]
        [HttpGet]
        public IEnumerable<ToDoEntity> GetAllUndone([FromServices] IRepository repo)
        {
            return repo.GetAllUndone("kaoef");
        }
        [Route("done/today")]
        [HttpGet]
        public IEnumerable<ToDoEntity> GetDoneForToday([FromServices] IRepository repo)
        {
            return repo.GetByPeriod("kaoef", DateTime.Now.Date, true);
        }
        [Route("undone/today")]
        [HttpGet]
        public IEnumerable<ToDoEntity> GetUndoneForToday([FromServices] IRepository repo)
        {
            return repo.GetByPeriod("kaoef", DateTime.Now.Date, false);
        }
        [Route("done/tomorrow")]
        [HttpGet]
        public IEnumerable<ToDoEntity> GetDoneForTomorrow([FromServices] IRepository repo)
        {
            return repo.GetByPeriod("kaoef", DateTime.Now.Date.AddDays(1), true);
        }
        [Route("undone/tomorrow")]
        [HttpGet]
        public IEnumerable<ToDoEntity> GetUndoneForTomorrow([FromServices] IRepository repo)
        {
            return repo.GetByPeriod("kaoef", DateTime.Now.Date.AddDays(1), false);
        }

        [Route("")]
        [HttpPost]
        public GenericCommandResult Create([FromBody] CreateToDoCommands command,
                [FromServices] ToDoHandler handler)
        {
            command.User = "kaoef";
            return (GenericCommandResult)handler.Handle(command);
        }

        [Route("")]
        [HttpPut]
        public GenericCommandResult Update([FromBody] UpdateCommand command,
                [FromServices] ToDoHandler handler)
        {
            command.User = "kaoef";
            return (GenericCommandResult)handler.Handle(command);
        }
        [Route("mark-as-done")]
        [HttpPut]
        public GenericCommandResult MarkAsDone([FromBody] MarkAsDoneCommand command,
                [FromServices] ToDoHandler handler)
        {
            command.User = "kaoef";
            return (GenericCommandResult)handler.Handle(command);
        }
        [Route("mark-as-undone")]
        [HttpPut]
        public GenericCommandResult MarkAsUndone([FromBody] MarkAsUndoneCommand command,
                [FromServices] ToDoHandler handler)
        {
            command.User = "kaoef";
            return (GenericCommandResult)handler.Handle(command);
        }
    }
}