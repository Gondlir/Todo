using Todo.Domain.Entities;
using Todo.Domain.Repositories;

namespace Todo.Domain.CommandTests.Repositories
{
    public class FakeRepository : IRepository
    {
        public void Create(ToDoEntity todo)
        {
        }

        public void Update(ToDoEntity todo)
        {
        }
    }
}