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
  public class ServiceComponentHostResponse {
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
    /// Gets or Sets ComponentName
    /// </summary>
    [DataMember(Name="component_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "component_name")]
    public string ComponentName { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name="display_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "display_name")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or Sets PublicHostName
    /// </summary>
    [DataMember(Name="public_host_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "public_host_name")]
    public string PublicHostName { get; set; }

    /// <summary>
    /// Gets or Sets HostName
    /// </summary>
    [DataMember(Name="host_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "host_name")]
    public string HostName { get; set; }

    /// <summary>
    /// Gets or Sets ActualConfigs
    /// </summary>
    [DataMember(Name="actual_configs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actual_configs")]
    public Dictionary<string, HostConfig> ActualConfigs { get; set; }

    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public string Version { get; set; }

    /// <summary>
    /// Gets or Sets DesiredStackId
    /// </summary>
    [DataMember(Name="desired_stack_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "desired_stack_id")]
    public string DesiredStackId { get; set; }

    /// <summary>
    /// Gets or Sets DesiredRepositoryVersion
    /// </summary>
    [DataMember(Name="desired_repository_version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "desired_repository_version")]
    public string DesiredRepositoryVersion { get; set; }

    /// <summary>
    /// Gets or Sets DesiredState
    /// </summary>
    [DataMember(Name="desired_state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "desired_state")]
    public string DesiredState { get; set; }

    /// <summary>
    /// Gets or Sets StaleConfigs
    /// </summary>
    [DataMember(Name="stale_configs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stale_configs")]
    public bool? StaleConfigs { get; set; }

    /// <summary>
    /// Gets or Sets ReloadConfigs
    /// </summary>
    [DataMember(Name="reload_configs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reload_configs")]
    public bool? ReloadConfigs { get; set; }

    /// <summary>
    /// Gets or Sets MaintenanceState
    /// </summary>
    [DataMember(Name="maintenance_state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maintenance_state")]
    public string MaintenanceState { get; set; }

    /// <summary>
    /// Gets or Sets UpgradeState
    /// </summary>
    [DataMember(Name="upgrade_state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "upgrade_state")]
    public string UpgradeState { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServiceComponentHostResponse {\n");
      sb.Append("  ClusterName: ").Append(ClusterName).Append("\n");
      sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
      sb.Append("  ComponentName: ").Append(ComponentName).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  PublicHostName: ").Append(PublicHostName).Append("\n");
      sb.Append("  HostName: ").Append(HostName).Append("\n");
      sb.Append("  ActualConfigs: ").Append(ActualConfigs).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  DesiredStackId: ").Append(DesiredStackId).Append("\n");
      sb.Append("  DesiredRepositoryVersion: ").Append(DesiredRepositoryVersion).Append("\n");
      sb.Append("  DesiredState: ").Append(DesiredState).Append("\n");
      sb.Append("  StaleConfigs: ").Append(StaleConfigs).Append("\n");
      sb.Append("  ReloadConfigs: ").Append(ReloadConfigs).Append("\n");
      sb.Append("  MaintenanceState: ").Append(MaintenanceState).Append("\n");
      sb.Append("  UpgradeState: ").Append(UpgradeState).Append("\n");
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
