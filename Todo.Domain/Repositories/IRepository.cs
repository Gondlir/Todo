using Todo.Domain.Entities;

namespace Todo.Domain.Repositories
{
    public interface IRepository
    {
        void Create(ToDoEntity todo);
        void Update(ToDoEntity todo);
    }
}