using Todo.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Todo.Domain.Repositories
{
    public interface IRepository
    {
        void Create(ToDoEntity todo);
        void Update(ToDoEntity todo);
        ToDoEntity GetById(Guid id, string user);
        IEnumerable<ToDoEntity> GetAll(string email);
        IEnumerable<ToDoEntity> GetAllDone(string email);
        IEnumerable<ToDoEntity> GetAllUndone(string email);
        IEnumerable<ToDoEntity> GetByPeriod(string email, DateTime date, bool done);
    }
}