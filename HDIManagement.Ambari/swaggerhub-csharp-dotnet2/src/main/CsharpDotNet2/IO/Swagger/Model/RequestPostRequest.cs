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
  public class RequestPostRequest {
    /// <summary>
    /// Gets or Sets Body
    /// </summary>
    [DataMember(Name="Body", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Body")]
    public Body Body { get; set; }

    /// <summary>
    /// Gets or Sets RequestInfo
    /// </summary>
    [DataMember(Name="RequestInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequestInfo")]
    public RequestInfo RequestInfo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RequestPostRequest {\n");
      sb.Append("  Body: ").Append(Body).Append("\n");
      sb.Append("  RequestInfo: ").Append(RequestInfo).Append("\n");
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
