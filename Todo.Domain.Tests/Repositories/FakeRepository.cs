using System;
using Todo.Domain.Entities;
using Todo.Domain.Repositories;

namespace Todo.Domain.CommandTests.Repositories
{
    public class FakeRepository : IRepository
    {
        public void Create(ToDoEntity todo)
        {
        }

        public ToDoEntity GetById(Guid id, string user)
        {
            return new ToDoEntity("Titulo exemplo", "kaoefff", DateTime.Now);
        }

        public void Update(ToDoEntity todo)
        {
        }
    }
}