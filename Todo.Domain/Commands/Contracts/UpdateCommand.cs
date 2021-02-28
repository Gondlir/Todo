using System;
using Flunt.Validations;
using Flunt.Notifications;
using Todo.Domain.Commands.Contracts;
namespace Todo.Domain.Commands
{
    public class UpdateCommand : Notifiable, ICommand
    {
        public UpdateCommand() { }
        public UpdateCommand(Guid id, string title, string user)
        {
            Id = id;
            Title = title;
            User = user;
        }

        public Guid Id { get; set; }

        public string Title { get; set; }

        public string User { get; set; }

        public void Validate()
        {
            AddNotifications(
                            new Contract()
                            .Requires()
                            .HasMinLen(Title, 3, "Title", "Tarefa com pouca informação !")
                            .HasMinLen(User, 3, "User", "Usuário inválido")
                            );
        }
    }
}