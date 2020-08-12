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
  public class ServiceConfigVersionResponse {
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
    /// Gets or Sets GroupId
    /// </summary>
    [DataMember(Name="group_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group_id")]
    public long? GroupId { get; set; }

    /// <summary>
    /// Gets or Sets GroupName
    /// </summary>
    [DataMember(Name="group_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group_name")]
    public string GroupName { get; set; }

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
    /// Gets or Sets StackId
    /// </summary>
    [DataMember(Name="stack_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stack_id")]
    public string StackId { get; set; }

    /// <summary>
    /// Gets or Sets IsCurrent
    /// </summary>
    [DataMember(Name="is_current", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_current")]
    public bool? IsCurrent { get; set; }

    /// <summary>
    /// Gets or Sets Configurations
    /// </summary>
    [DataMember(Name="configurations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "configurations")]
    public List<ConfigurationResponse> Configurations { get; set; }

    /// <summary>
    /// Gets or Sets Hosts
    /// </summary>
    [DataMember(Name="hosts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hosts")]
    public List<string> Hosts { get; set; }

    /// <summary>
    /// Gets or Sets IsClusterCompatible
    /// </summary>
    [DataMember(Name="is_cluster_compatible", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_cluster_compatible")]
    public bool? IsClusterCompatible { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServiceConfigVersionResponse {\n");
      sb.Append("  ClusterName: ").Append(ClusterName).Append("\n");
      sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
      sb.Append("  ServiceConfigVersion: ").Append(ServiceConfigVersion).Append("\n");
      sb.Append("  Createtime: ").Append(Createtime).Append("\n");
      sb.Append("  GroupId: ").Append(GroupId).Append("\n");
      sb.Append("  GroupName: ").Append(GroupName).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
      sb.Append("  ServiceConfigVersionNote: ").Append(ServiceConfigVersionNote).Append("\n");
      sb.Append("  StackId: ").Append(StackId).Append("\n");
      sb.Append("  IsCurrent: ").Append(IsCurrent).Append("\n");
      sb.Append("  Configurations: ").Append(Configurations).Append("\n");
      sb.Append("  Hosts: ").Append(Hosts).Append("\n");
      sb.Append("  IsClusterCompatible: ").Append(IsClusterCompatible).Append("\n");
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
