using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Net.Http;
using RestSharp.Authenticators;
using System.Text;
using RestSharp;
using System.Diagnostics;
using IO.Swagger.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using IO.Swagger.Client;

namespace Ambari.Test
{
    //https://app.swaggerhub.com/apis/rvq/swagger-spec_for_ambari_rest_api/v1
    //for tests that do not use db, set all times to UTC
    [TestClass]
    public class SwaggerHub
    {
        private const string UserName = "user1";
        private const string Password = "password1";
        private const string ClusterNetworkName = "mycluster-int";
        private const string ClusterName = "mycluster";

        public TestContext TestContext { get; set; }

        [TestMethod]
        public async Task GetUsers()
        {

            var client = new AmbariRestClient($"https://{ClusterNetworkName}.azurehdinsight.net/api/v1/", UserName, Password);

            var api = new IO.Swagger.Api.UsersApi(client);

            var users = api.GetUsers("*", null, null, null, null);

            Assert.IsTrue(users.Count > 0);

        }

        [TestMethod]
        public async Task GetUserUserPrivileges()
        {

            var client = new AmbariRestClient($"https://{ClusterNetworkName}.azurehdinsight.net/api/v1/", UserName, Password);

            var api = new IO.Swagger.Api.UsersApi(client);

            var result = api.UserPrivilegeServiceGetPrivileges(UserName, "*", null, null, null, null);
            Trace.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));

        }

        [TestMethod]
        public async Task GetActions()
        {

            var client = new AmbariRestClient($"https://{ClusterNetworkName}.azurehdinsight.net/api/v1/", UserName, Password);

            var api = new IO.Swagger.Api.ActionsApi(client);

            var actions = api.ActionServiceGetActionDefinitions("*", null, null, null, null);

            Trace.WriteLine(JsonConvert.SerializeObject(actions, Formatting.Indented));

        }

        [TestMethod]
        public async Task CreateUser()
        {

            var client = new AmbariRestClient($"https://{ClusterNetworkName}.azurehdinsight.net/api/v1/", UserName, Password);

            var api = new IO.Swagger.Api.UsersApi(client);

            var body = new UserRequestCreateUserSwagger()
            {
                Users = new CreateUserInfo()
                {
                    Active = true,
                    Admin = false,
                   // DisplayName = "Three, User",
                    LocalUserName = "user3",
                    Password = "PPPPPaaaaa!!11"
                }
            };

            api.CreateUser(body.Users.LocalUserName, body);


        }
        [TestMethod]
        public async Task UpdateUserClusterPriviledge()
        {
            //https://community.cloudera.com/t5/Support-Questions/REST-API-to-assign-Sandbox-roles-to-Ambari-users/td-p/107627
            //does not look like this is part of the API/json

            //[{
            //    "PrivilegeInfo": {
            //        "permission_name": "SERVICE.OPERATOR",
            //        "principal_name": "testuser",
            //        "principal_type": "USER"
            //        }
            //}]

            //' https://<ambari_host>:8080/api/v1/clusters/<cluster_name>/privileges

            //permission_name could be one of the below:
            //CLUSTER.ADMINISTRATOR
            //CLUSTER.OPERATOR
            //SERVICE.ADMINISTRATOR
            //SERVICE.OPERATOR
            //CLUSTER.USER
            //principal_type could be either: USER or GROUP


            var client = new AmbariRestClient($"https://{ClusterNetworkName}.azurehdinsight.net/api/v1/", UserName, Password);

            var api = new IO.Swagger.Api.ClustersApi(client);

            var body = new ClusterPrivilegeUpdateUserRequestSwagger()
            {
                new ClusterPrivilegeInfoRequestSwagger()
                {
                    PrivilegeInfo =  new ClusterPrivilegeInfoRequest()
                    {
                        permission_name = "CLUSTER.USER",
                        principal_name = "user3",
                        principal_type = "USER"
                    }
                }
            };

            api.UpdateUserClusterPriviledge(ClusterName, body);

        }

        [TestMethod]
        public async Task GetUserClusterPriviledge()
        {
            //https://community.cloudera.com/t5/Support-Questions/REST-API-to-assign-Sandbox-roles-to-Ambari-users/td-p/107627
            //does not look like this is part of the API/json

            var client = new AmbariRestClient($"https://{ClusterNetworkName}.azurehdinsight.net/api/v1/", UserName, Password);

            var request = new RestSharp.RestRequest($"clusters/{ClusterNetworkName}/privileges", Method.GET);
            var sz = await client.RestClient.ExecuteGetAsync<string>(request);

        }

    }

}

//WORKS
//GET https://h1245.azurehdinsight.net/api/v1/users HTTP/1.1
//Host: h1245.azurehdinsight.net


//FAILS
//GET https://h1245.azurehdinsight.net/api/v1/users HTTP/1.1
//Host: h1245.azurehdinsight.net
//>>>Accept: application/json, text/json, text/x-json, text/javascript, application/xml, text/xml
//User-Agent: RestSharp/106.11.4.0
//Connection: Keep-Alive
//Accept-Encoding: gzip, deflate

//WORKS
//GET https://h1245.azurehdinsight.net/api/v1/users HTTP/1.1
//Host: h1245.azurehdinsight.net
//User-Agent: RestSharp/106.11.4.0
//Connection: Keep-Alive
//Accept-Encoding: gzip, deflate
//Authorization: Basic YWRtaW46QUFBQUFkZGRkZCEhMTE =
