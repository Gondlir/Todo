using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commands;
using System;
namespace Todo.Domain.CommandTests
{
    [TestClass]
    public class CreateCommandTests
    {
        private readonly CreateToDoCommands _invalidCommand = new CreateToDoCommands("", "", DateTime.Now);
        private readonly CreateToDoCommands _validCommand = new CreateToDoCommands("Teste Exemplo", "DrManhattan", DateTime.Now);

        public CreateCommandTests()
        {
            _invalidCommand.Validate();
            _validCommand.Validate();
        }
        [TestMethod]
        public void GiveIvalidImput()
        {
            Assert.AreEqual(_invalidCommand.Valid, false);
        }
        [TestMethod]
        public void GiveValidImput()
        {
            Assert.AreEqual(_validCommand.Valid, true);
        }
    }
}
