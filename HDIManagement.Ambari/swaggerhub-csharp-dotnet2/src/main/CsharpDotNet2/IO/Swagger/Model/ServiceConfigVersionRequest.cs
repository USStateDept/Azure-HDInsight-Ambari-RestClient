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
  public class ServiceConfigVersionRequest {
    /// <summary>
    /// Gets or Sets ClusterName
    /// </summary>
    [DataMember(Name="cluster_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cluster_name")]
    public string ClusterName { get; set; }

    /// <summary>
    /// Gets or Sets ServiceName
    /// </summary>
    [DataMember(Name="service_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service_name")]
    public string ServiceName { get; set; }

    /// <summary>
    /// Gets or Sets ServiceConfigVersion
    /// </summary>
    [DataMember(Name="service_config_version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service_config_version")]
    public long? ServiceConfigVersion { get; set; }

    /// <summary>
    /// Gets or Sets Createtime
    /// </summary>
    [DataMember(Name="createtime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createtime")]
    public long? Createtime { get; set; }

    /// <summary>
    /// Gets or Sets Appliedtime
    /// </summary>
    [DataMember(Name="appliedtime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "appliedtime")]
    public long? Appliedtime { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public string User { get; set; }

    /// <summary>
    /// Gets or Sets ServiceConfigVersionNote
    /// </summary>
    [DataMember(Name="service_config_version_note", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service_config_version_note")]
    public string ServiceConfigVersionNote { get; set; }

    /// <summary>
    /// Gets or Sets IsCurrent
    /// </summary>
    [DataMember(Name="is_current", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_current")]
    public bool? IsCurrent { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServiceConfigVersionRequest {\n");
      sb.Append("  ClusterName: ").Append(ClusterName).Append("\n");
      sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
      sb.Append("  ServiceConfigVersion: ").Append(ServiceConfigVersion).Append("\n");
      sb.Append("  Createtime: ").Append(Createtime).Append("\n");
      sb.Append("  Appliedtime: ").Append(Appliedtime).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
      sb.Append("  ServiceConfigVersionNote: ").Append(ServiceConfigVersionNote).Append("\n");
      sb.Append("  IsCurrent: ").Append(IsCurrent).Append("\n");
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
