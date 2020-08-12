using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class ClusterPrivilegeInfoRequest
    {
        public string permission_name { get; set; }
        public string principal_name { get; set; }
        public string principal_type { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class ClusterPrivilegeInfoRequestSwagger
    {
        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name = "PrivilegeInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "PrivilegeInfo")]
        public ClusterPrivilegeInfoRequest PrivilegeInfo { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class ClusterPrivilegeUpdateUserRequestSwagger: List<ClusterPrivilegeInfoRequestSwagger>
    {

    }

}

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