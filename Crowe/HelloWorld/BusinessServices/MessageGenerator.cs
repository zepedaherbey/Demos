using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public interface IMessageGenerator
    {
        string GetHelloWorldMessage();
    }
    public class MessageGenerator : IMessageGenerator
    {
        public string GetHelloWorldMessage()
        {
            return "Hello World";
        }
    }
}
