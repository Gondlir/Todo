using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Entities;
using System;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Linq;
using Todo.Domain.Queries;

namespace Todo.Domain.Tests.EntityTests
{
    [TestClass]
    public class ToDoQueriesTests
    {
        private List<ToDoEntity> _items;
        public ToDoQueriesTests()
        {
            _items = new List<ToDoEntity>();
            _items.Add(new ToDoEntity("Tarefa 1", "userKaoe", DateTime.Now));
            _items.Add(new ToDoEntity("Tarefa 2", "userKaas", DateTime.Now));
            _items.Add(new ToDoEntity("Tarefa 3", "userKacsc", DateTime.Now));
            _items.Add(new ToDoEntity("Tarefa 4", "userKaoe", DateTime.Now));
            _items.Add(new ToDoEntity("Tarefa 5", "userKacc", DateTime.Now));
        }
        [TestMethod]
        public void Consulta_Return_Tasks_From_user()
        {
            var result = _items.AsQueryable().Where(ToDoQueries.GetAll("userKaoe"));
            Assert.AreEqual(2, result.Count());
        }
    }
}