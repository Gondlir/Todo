using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commands;
using System;
namespace Todo.Domain.CommandTests
{
    [TestClass]
    public class CreateCommandTests
    {
        [TestMethod]
        public void GiveIvalidImput()
        {
            var command = new CreateToDoCommands("op", "op", DateTime.Now);
            command.Validate();
            Assert.AreEqual(command.Valid, false);
        }
        [TestMethod]
        public void GiveValidImput()
        {
            var command = new CreateToDoCommands("Exemplo Teste", "DrManhattan", DateTime.Now);
            command.Validate();
            Assert.AreEqual(command.Valid, true);
        }
    }
}
