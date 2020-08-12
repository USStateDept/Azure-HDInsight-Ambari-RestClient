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
  public class ConfigGroupRequest {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Gets or Sets ClusterName
    /// </summary>
    [DataMember(Name="cluster_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cluster_name")]
    public string ClusterName { get; set; }

    /// <summary>
    /// Gets or Sets GroupName
    /// </summary>
    [DataMember(Name="group_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group_name")]
    public string GroupName { get; set; }

    /// <summary>
    /// Gets or Sets Tag
    /// </summary>
    [DataMember(Name="tag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tag")]
    public string Tag { get; set; }

    /// <summary>
    /// Gets or Sets ServiceName
    /// </summary>
    [DataMember(Name="service_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service_name")]
    public string ServiceName { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets ServiceConfigVersionNote
    /// </summary>
    [DataMember(Name="service_config_version_note", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service_config_version_note")]
    public string ServiceConfigVersionNote { get; set; }

    /// <summary>
    /// Gets or Sets Hosts
    /// </summary>
    [DataMember(Name="hosts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hosts")]
    public List<string> Hosts { get; set; }

    /// <summary>
    /// Gets or Sets DesiredConfigs
    /// </summary>
    [DataMember(Name="desired_configs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "desired_configs")]
    public Dictionary<string, Config> DesiredConfigs { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ConfigGroupRequest {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ClusterName: ").Append(ClusterName).Append("\n");
      sb.Append("  GroupName: ").Append(GroupName).Append("\n");
      sb.Append("  Tag: ").Append(Tag).Append("\n");
      sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  ServiceConfigVersionNote: ").Append(ServiceConfigVersionNote).Append("\n");
      sb.Append("  Hosts: ").Append(Hosts).Append("\n");
      sb.Append("  DesiredConfigs: ").Append(DesiredConfigs).Append("\n");
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
