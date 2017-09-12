using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiniChatFinal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniChatFinal.Tests
{
    [TestClass()]
    public class ServerTests
    {
        [TestMethod()]
        public void HandleClientTest()
        {
            String line = "";
            String returnline = MiniChatFinal.Server.HandleClient(line);

            Assert.AreEqual("",line);
        }
    }
}