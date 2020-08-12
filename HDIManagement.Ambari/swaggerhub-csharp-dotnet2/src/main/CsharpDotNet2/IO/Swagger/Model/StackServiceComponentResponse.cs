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
  public class StackServiceComponentResponse {
    /// <summary>
    /// Gets or Sets StackName
    /// </summary>
    [DataMember(Name="stack_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stack_name")]
    public string StackName { get; set; }

    /// <summary>
    /// Gets or Sets StackVersion
    /// </summary>
    [DataMember(Name="stack_version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stack_version")]
    public string StackVersion { get; set; }

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
    /// Gets or Sets ComponentCategory
    /// </summary>
    [DataMember(Name="component_category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "component_category")]
    public string ComponentCategory { get; set; }

    /// <summary>
    /// Gets or Sets Cardinality
    /// </summary>
    [DataMember(Name="cardinality", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cardinality")]
    public string Cardinality { get; set; }

    /// <summary>
    /// Gets or Sets AdvertiseVersion
    /// </summary>
    [DataMember(Name="advertise_version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "advertise_version")]
    public bool? AdvertiseVersion { get; set; }

    /// <summary>
    /// Gets or Sets RollingRestartSupported
    /// </summary>
    [DataMember(Name="rollingRestartSupported", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rollingRestartSupported")]
    public bool? RollingRestartSupported { get; set; }

    /// <summary>
    /// Gets or Sets CustomCommands
    /// </summary>
    [DataMember(Name="customCommands", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customCommands")]
    public List<string> CustomCommands { get; set; }

    /// <summary>
    /// Gets or Sets CustomCommands
    /// </summary>
    //[DataMember(Name="custom_commands", EmitDefaultValue=false)]
    //[JsonProperty(PropertyName = "custom_commands")]
    //public List<string> CustomCommands { get; set; }

    /// <summary>
    /// Gets or Sets RecoveryEnabled
    /// </summary>
    [DataMember(Name="recovery_enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recovery_enabled")]
    public bool? RecoveryEnabled { get; set; }

    /// <summary>
    /// Gets or Sets BulkCommandsDisplayName
    /// </summary>
    [DataMember(Name="bulkCommandsDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bulkCommandsDisplayName")]
    public string BulkCommandsDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets ComponentType
    /// </summary>
    [DataMember(Name="componentType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "componentType")]
    public string ComponentType { get; set; }

    /// <summary>
    /// Gets or Sets IsMaster
    /// </summary>
    [DataMember(Name="is_master", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_master")]
    public bool? IsMaster { get; set; }

    /// <summary>
    /// Gets or Sets IsClient
    /// </summary>
    [DataMember(Name="is_client", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_client")]
    public bool? IsClient { get; set; }

    /// <summary>
    /// Gets or Sets BulkCommandsMasterComponentNamen
    /// </summary>
    [DataMember(Name="bulk_commands_master_component_namen", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bulk_commands_master_component_namen")]
    public string BulkCommandsMasterComponentNamen { get; set; }

    /// <summary>
    /// Gets or Sets DecommissionAllowed
    /// </summary>
    [DataMember(Name="decommission_allowed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "decommission_allowed")]
    public bool? DecommissionAllowed { get; set; }

    /// <summary>
    /// Gets or Sets ReassignAllowed
    /// </summary>
    [DataMember(Name="reassign_allowed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reassign_allowed")]
    public bool? ReassignAllowed { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StackServiceComponentResponse {\n");
      sb.Append("  StackName: ").Append(StackName).Append("\n");
      sb.Append("  StackVersion: ").Append(StackVersion).Append("\n");
      sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
      sb.Append("  ComponentName: ").Append(ComponentName).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  ComponentCategory: ").Append(ComponentCategory).Append("\n");
      sb.Append("  Cardinality: ").Append(Cardinality).Append("\n");
      sb.Append("  AdvertiseVersion: ").Append(AdvertiseVersion).Append("\n");
      sb.Append("  RollingRestartSupported: ").Append(RollingRestartSupported).Append("\n");
      sb.Append("  CustomCommands: ").Append(CustomCommands).Append("\n");
      sb.Append("  CustomCommands: ").Append(CustomCommands).Append("\n");
      sb.Append("  RecoveryEnabled: ").Append(RecoveryEnabled).Append("\n");
      sb.Append("  BulkCommandsDisplayName: ").Append(BulkCommandsDisplayName).Append("\n");
      sb.Append("  ComponentType: ").Append(ComponentType).Append("\n");
      sb.Append("  IsMaster: ").Append(IsMaster).Append("\n");
      sb.Append("  IsClient: ").Append(IsClient).Append("\n");
      sb.Append("  BulkCommandsMasterComponentNamen: ").Append(BulkCommandsMasterComponentNamen).Append("\n");
      sb.Append("  DecommissionAllowed: ").Append(DecommissionAllowed).Append("\n");
      sb.Append("  ReassignAllowed: ").Append(ReassignAllowed).Append("\n");
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
