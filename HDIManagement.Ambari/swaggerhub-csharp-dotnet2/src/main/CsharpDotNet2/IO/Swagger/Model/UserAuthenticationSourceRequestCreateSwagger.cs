using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class UserAuthenticationSourceRequestCreateSwagger {
    /// <summary>
    /// Gets or Sets AuthenticationSourceInfo
    /// </summary>
    [DataMember(Name="AuthenticationSourceInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AuthenticationSourceInfo")]
    public CreateUserAuthenticationSourceInfo AuthenticationSourceInfo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserAuthenticationSourceRequestCreateSwagger {\n");
      sb.Append("  AuthenticationSourceInfo: ").Append(AuthenticationSourceInfo).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
