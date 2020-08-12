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
  public class RequestBodyInfo {
    /// <summary>
    /// Gets or Sets RequestInfo
    /// </summary>
    [DataMember(Name="RequestInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequestInfo")]
    public RequestInfo RequestInfo { get; set; }

    /// <summary>
    /// Gets or Sets RequestsresourceFilters
    /// </summary>
    [DataMember(Name="Requests/resource_filters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Requests/resource_filters")]
    public List<RequestResourceFilter> RequestsresourceFilters { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RequestBodyInfo {\n");
      sb.Append("  RequestInfo: ").Append(RequestInfo).Append("\n");
      sb.Append("  RequestsresourceFilters: ").Append(RequestsresourceFilters).Append("\n");
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
