using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Services.Rest.Docker.Server.Contracts
{
    [ServiceContract]
    public interface IRestService
    {

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        string GetMessage(string inputMessage);

        [OperationContract]
        [WebInvoke]
        string PostMessage(string inputMessage);
    }
}
