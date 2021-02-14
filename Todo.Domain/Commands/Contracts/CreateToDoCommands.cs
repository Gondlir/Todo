using System;
using Flunt.Validations;
using Todo.Domain.Commands.Contracts;
using Flunt.Notifications;

namespace Todo.Domain.Commands
{
    public class CreateToDoCommands : Notifiable, ICommand
    {
        public CreateToDoCommands() { }
        public CreateToDoCommands(string title, string user, DateTime date)
        {
            Title = title;
            User = user;
            Date = date;
        }

        public string Title { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                .Requires()
                .HasMinLen(Title, 3, "Title", "Tarefa com pouca informação !")
                .HasMinLen(User, 6, "User", "Usuário inválido")
                );
        }
    }
}