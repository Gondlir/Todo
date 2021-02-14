using Todo.Domain.Entities;
using System;
namespace Todo.Domain.Repositories
{
    public interface IRepository
    {
        void Create(ToDoEntity todo);
        void Update(ToDoEntity todo);
        ToDoEntity GetById(Guid id, string user);
    }
}