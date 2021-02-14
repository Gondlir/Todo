using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Todo.Domain.Commands;
using Todo.Domain.CommandTests.Repositories;
using Todo.Domain.Handlers;

namespace Todo.Domain.Tests.HandlerTests
{
    [TestClass]
    public class CreateHandlerTests
    {
        private readonly CreateToDoCommands _invalidCommand = new CreateToDoCommands("", "", DateTime.Now);
        private readonly CreateToDoCommands _validCommand = new CreateToDoCommands("Teste Exemplo", "DrManhattan", DateTime.Now);
        private readonly ToDoHandler _handler = new ToDoHandler(new FakeRepository());
        private GenericCommandResult _result = new GenericCommandResult();
        public CreateHandlerTests()
        {

        }

        [TestMethod]
        public void GiveInvalidImputInterruptExecition()
        {
            _result = (GenericCommandResult)_handler.Handle(_invalidCommand);
            Assert.AreEqual(_result.Success, false);
        }
        [TestMethod]
        public void GiveValidImputCreateTask()
        {
            _result = (GenericCommandResult)_handler.Handle(_validCommand);
            Assert.AreEqual(_result.Success, true);
        }
    }
}
