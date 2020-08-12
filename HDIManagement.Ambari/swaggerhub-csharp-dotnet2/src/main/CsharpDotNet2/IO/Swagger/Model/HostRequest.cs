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
  public class HostRequest {
    /// <summary>
    /// Gets or Sets HostName
    /// </summary>
    [DataMember(Name="host_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "host_name")]
    public string HostName { get; set; }

    /// <summary>
    /// Gets or Sets RackInfo
    /// </summary>
    [DataMember(Name="rack_info", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rack_info")]
    public string RackInfo { get; set; }

    /// <summary>
    /// Gets or Sets DesiredConfigs
    /// </summary>
    [DataMember(Name="desired_configs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "desired_configs")]
    public List<ConfigurationRequest> DesiredConfigs { get; set; }

    /// <summary>
    /// Gets or Sets MaintenanceState
    /// </summary>
    [DataMember(Name="maintenance_state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maintenance_state")]
    public string MaintenanceState { get; set; }

    /// <summary>
    /// Gets or Sets HostGroup
    /// </summary>
    [DataMember(Name="host_group", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "host_group")]
    public string HostGroup { get; set; }

    /// <summary>
    /// Gets or Sets Blueprint
    /// </summary>
    [DataMember(Name="blueprint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blueprint")]
    public string Blueprint { get; set; }

    /// <summary>
    /// Gets or Sets PublicHostName
    /// </summary>
    [DataMember(Name="public_host_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "public_host_name")]
    public string PublicHostName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class HostRequest {\n");
      sb.Append("  HostName: ").Append(HostName).Append("\n");
      sb.Append("  RackInfo: ").Append(RackInfo).Append("\n");
      sb.Append("  DesiredConfigs: ").Append(DesiredConfigs).Append("\n");
      sb.Append("  MaintenanceState: ").Append(MaintenanceState).Append("\n");
      sb.Append("  HostGroup: ").Append(HostGroup).Append("\n");
      sb.Append("  Blueprint: ").Append(Blueprint).Append("\n");
      sb.Append("  PublicHostName: ").Append(PublicHostName).Append("\n");
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
