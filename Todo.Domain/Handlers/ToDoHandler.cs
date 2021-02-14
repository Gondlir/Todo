using Flunt.Notifications;
using Todo.Domain.Commands;
using Todo.Domain.Commands.Contracts;
using Todo.Domain.Entities;
using Todo.Domain.Handlers.Contracts;
using Todo.Domain.Repositories;

namespace Todo.Domain.Handlers
{
    public class ToDoHandler : Notifiable,
    IHandler<CreateToDoCommands>,
    IHandler<UpdateCommand>,
    IHandler<MarkAsDoneCommand>,
    IHandler<MarkAsUndoneCommand>
    {
        private readonly IRepository _repository;

        public ToDoHandler(IRepository repository)
        {
            _repository = repository;
        }
        public ICommandResult Handle(CreateToDoCommands command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Erro, tarefa errada !", command.Notifications);

            var todoapp = new ToDoEntity(command.Title, command.User, command.Date);
            _repository.Create(todoapp);
            return new GenericCommandResult(true, "Tarefa Salva !", todoapp);
        }

        public ICommandResult Handle(UpdateCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Tarefa errada !", command.Notifications);

            var todo = _repository.GetById(command.Id, command.User);

            todo.UpdateTitle(command.Title);

            _repository.Update(todo);

            return new GenericCommandResult(true, "Tarefa salva", command.Notifications);
        }

        public ICommandResult Handle(MarkAsDoneCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Tarefa errada !", command.Notifications);

            var todo = _repository.GetById(command.Id, command.User);

            todo.MarkAsDone();

            _repository.Update(todo);

            return new GenericCommandResult(true, "Tarefa salva", command.Notifications);
        }

        public ICommandResult Handle(MarkAsUndoneCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Tarefa errada !", command.Notifications);

            var todo = _repository.GetById(command.Id, command.User);

            todo.MarkAsUnDone();

            _repository.Update(todo);

            return new GenericCommandResult(true, "Tarefa salva", command.Notifications);
        }
    }
}