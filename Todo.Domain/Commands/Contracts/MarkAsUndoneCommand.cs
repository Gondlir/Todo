using System;
using Flunt.Validations;
using Flunt.Notifications;
using Todo.Domain.Commands.Contracts;
namespace Todo.Domain.Commands
{
    public class MarkAsUndoneCommand : Notifiable, ICommand
    {
        public MarkAsUndoneCommand() { }
        public MarkAsUndoneCommand(Guid id, string user)
        {
            Id = id;
            User = user;
        }

        public Guid Id { get; set; }
        public string User { get; set; }
        public void Validate()
        {
            AddNotifications(new Contract().Requires()
            .HasMinLen(User, 3, "User", "Usuário inválido !"));
        }
    }
}