using IO.Swagger.Client;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ambari.Test
{
    public class AmbariRestClient : ApiClient
    {
        public AmbariRestClient(string basePath, string userName, string password) :
            base(basePath)
        {
            var credentials = new System.Net.NetworkCredential(userName, password);
            base.RestClient.Authenticator = new NtlmAuthenticator(credentials);
            base.RestClient.DefaultParameters.Add(new RestSharp.Parameter("X-Requested-By", "my_computer_name", RestSharp.ParameterType.HttpHeader));
        }
    }
}
