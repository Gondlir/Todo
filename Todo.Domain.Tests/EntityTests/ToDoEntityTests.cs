using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Todo.Domain.Commands;
using Todo.Domain.CommandTests.Repositories;
using Todo.Domain.Entities;
using Todo.Domain.Handlers;

namespace Todo.Domain.Tests.EntityTests
{
    [TestClass]
    public class ToDoEntityTests
    {
        private readonly ToDoEntity _validtodo = new ToDoEntity("Titulo exemplo", "kaoe feerr", DateTime.Now);
        private readonly ToDoEntity _invalidtodo = new ToDoEntity("", "", DateTime.Now);
        [TestMethod]
        public void GiveNewToDoCantBeComplet()
        {
            Assert.AreEqual(_invalidtodo.IsDone, false);
        }
        public void GiveNewToDoCanBeComplet()
        {

            Assert.AreEqual(_validtodo.IsDone, false);
        }
    }
}