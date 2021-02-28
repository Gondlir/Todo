using System;
using System.Linq.Expressions;
using Todo.Domain.Entities;

namespace Todo.Domain.Queries
{
    public static class ToDoQueries
    {
        public static Expression<Func<ToDoEntity, bool>> GetAll(string user)
        {
            return x => x.RefUser == user;
        }
        public static Expression<Func<ToDoEntity, bool>> GetAllDone(string user)
        {
            return x => x.RefUser == user && x.IsDone;
        }
        public static Expression<Func<ToDoEntity, bool>> GetAllUnDone(string user)
        {
            return x => x.RefUser == user && x.IsDone == false;
        }
        public static Expression<Func<ToDoEntity, bool>> GetByPeriod(string user, DateTime date, bool done)
        {
            return x => x.RefUser == user && x.IsDone && x.Date.Date == date.Date;
        }
    }
}