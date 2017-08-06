using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessServices;

namespace BusinessServicesTests
{
    //We unit test the business layer 
    [TestClass]
    public class MessageGeneratorTests
    {
        [TestMethod]
        public void GetHelloWorldMessageTest()
        {
            var messageGenerator = new MessageGenerator();
            Assert.AreEqual(messageGenerator.GetHelloWorldMessage(), "Hello World");
        }
    }
}
