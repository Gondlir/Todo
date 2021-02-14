using Flunt.Notifications;
using Todo.Domain.Commands;
using Todo.Domain.Commands.Contracts;
using Todo.Domain.Entities;
using Todo.Domain.Handlers.Contracts;
using Todo.Domain.Repositories;

namespace Todo.Domain.Handlers
{
    public class ToDoHandler : Notifiable, IHandler<CreateToDoCommands>, IHandler<UpdateCommand>
    {
        private readonly IRepository _repository;

        public ToDoHandler(IRepository repository)
        {
            _repository = repository;
        }
        public ICommandResult Handle(CreateToDoCommands command)
        {
            throw new System.NotImplementedException();
        }

        public ICommandResult Handle(UpdateCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}