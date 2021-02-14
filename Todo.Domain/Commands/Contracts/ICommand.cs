using System;
namespace Todo.Domain.Commands.Contracts
{
    public interface ICommand
    {
        bool Validade();
    }
}