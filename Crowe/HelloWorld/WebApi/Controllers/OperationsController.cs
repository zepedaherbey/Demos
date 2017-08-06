using BusinessServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class OperationsController : ApiController
    {
        private readonly ICustomValueWriter _writer;
        private readonly IItemRemoval _itemRemoval;
        private readonly IMessageGenerator _messageGenerator;

        //Constructor injection via Autofac (look at IoConfig.cs)
        public OperationsController(
            ICustomValueWriter writer, 
            IItemRemoval itemRemoval, 
            IMessageGenerator messageGenerator)
        {
            _writer = writer;
            _itemRemoval = itemRemoval;
            _messageGenerator = messageGenerator;
        }

        // GET api/values
        public string Get()
        {
            return _messageGenerator.GetHelloWorldMessage();
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            _writer.WriteItem(value);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            _itemRemoval.Remove(id);
        }
    }
}
