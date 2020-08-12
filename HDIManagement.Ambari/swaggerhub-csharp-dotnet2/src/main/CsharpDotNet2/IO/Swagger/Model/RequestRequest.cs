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
  public class RequestRequest {
    /// <summary>
    /// Gets or Sets ClusterName
    /// </summary>
    [DataMember(Name="cluster_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cluster_name")]
    public string ClusterName { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Gets or Sets RequestStatus
    /// </summary>
    [DataMember(Name="request_status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "request_status")]
    public string RequestStatus { get; set; }

    /// <summary>
    /// Gets or Sets AbortReason
    /// </summary>
    [DataMember(Name="abort_reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "abort_reason")]
    public string AbortReason { get; set; }

    /// <summary>
    /// Gets or Sets RemovePendingHostRequests
    /// </summary>
    [DataMember(Name="removePendingHostRequests", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "removePendingHostRequests")]
    public bool? RemovePendingHostRequests { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RequestRequest {\n");
      sb.Append("  ClusterName: ").Append(ClusterName).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  RequestStatus: ").Append(RequestStatus).Append("\n");
      sb.Append("  AbortReason: ").Append(AbortReason).Append("\n");
      sb.Append("  RemovePendingHostRequests: ").Append(RemovePendingHostRequests).Append("\n");
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
