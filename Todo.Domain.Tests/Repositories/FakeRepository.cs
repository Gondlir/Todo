using System;
using System.Collections.Generic;
using Todo.Domain.Entities;
using Todo.Domain.Repositories;

namespace Todo.Domain.CommandTests.Repositories
{
    public class FakeRepository : IRepository
    {
        public void Create(ToDoEntity todo)
        {
        }

        public IEnumerable<ToDoEntity> GetAll(string email)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ToDoEntity> GetAllDone(string email)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ToDoEntity> GetAllUndone(string email)
        {
            throw new NotImplementedException();
        }

        public ToDoEntity GetById(Guid id, string user)
        {
            return new ToDoEntity("Titulo exemplo", "kaoefff", DateTime.Now);
        }

        public IEnumerable<ToDoEntity> GetByPeriod(string email, DateTime date, bool done)
        {
            throw new NotImplementedException();
        }

        public void Update(ToDoEntity todo)
        {
        }
    }
}