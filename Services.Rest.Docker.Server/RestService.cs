using Services.Rest.Docker.Server.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Rest.Docker.Server
{
    public class RestService : IRestService
    {
        public string GetMessage(string inputMessage)
        {
            Console.WriteLine($"Info - Input: {inputMessage}");
            return "Calling Get for you " + inputMessage;
        }

        public string PostMessage(string inputMessage)
        {
            return "Calling Post for you " + inputMessage;
        }
    }
}
