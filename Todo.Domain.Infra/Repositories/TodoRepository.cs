using System;
using System.Collections.Generic;
using Todo.Domain.Entities;
using Todo.Domain.Infra.Contexts;
using Todo.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Todo.Domain.Queries;

namespace Todo.Domain.Infra.Repositories
{
    public class TodoRepository : IRepository
    {
        private readonly DataContext _context;
        public TodoRepository(DataContext context)
        {
            _context = context;
        }
        public void Create(ToDoEntity todo)
        {
            _context.Todos.Add(todo);
            _context.SaveChanges();
        }

        public IEnumerable<ToDoEntity> GetAll(string email)
        {
            return _context.Todos.AsNoTracking().Where(ToDoQueries.GetAll(email)).OrderBy(x => x.Date);
        }

        public IEnumerable<ToDoEntity> GetAllDone(string email)
        {
            return _context.Todos.AsNoTracking().Where(ToDoQueries.GetAllDone(email)).OrderBy(x => x.Date);
        }

        public IEnumerable<ToDoEntity> GetAllUndone(string email)
        {
            return _context.Todos.AsNoTracking().Where(ToDoQueries.GetAllUnDone(email)).OrderBy(x => x.Date);
        }

        public ToDoEntity GetById(Guid id, string user)
        {
            return _context.Todos.FirstOrDefault(x => x.Id == id && x.RefUser == user);
        }

        public IEnumerable<ToDoEntity> GetByPeriod(string email, DateTime date, bool done)
        {
            return _context.Todos.AsNoTracking().Where(ToDoQueries.GetByPeriod(email, date, done)).OrderBy(x => x.Date);
        }

        public void Update(ToDoEntity todo)
        {
            _context.Entry(todo).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}