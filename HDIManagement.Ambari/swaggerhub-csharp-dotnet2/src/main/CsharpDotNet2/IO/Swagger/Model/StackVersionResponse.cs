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
  public class StackVersionResponse {
    /// <summary>
    /// Gets or Sets MinJdk
    /// </summary>
    [DataMember(Name="min_jdk", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "min_jdk")]
    public string MinJdk { get; set; }

    /// <summary>
    /// Gets or Sets MaxJdk
    /// </summary>
    [DataMember(Name="max_jdk", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "max_jdk")]
    public string MaxJdk { get; set; }

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
    /// Gets or Sets MinUpgradeVersion
    /// </summary>
    [DataMember(Name="min_upgrade_version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "min_upgrade_version")]
    public string MinUpgradeVersion { get; set; }

    /// <summary>
    /// Gets or Sets Active
    /// </summary>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public bool? Active { get; set; }

    /// <summary>
    /// Gets or Sets Valid
    /// </summary>
    [DataMember(Name="valid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "valid")]
    public bool? Valid { get; set; }

    /// <summary>
    /// Gets or Sets ParentStackVersion
    /// </summary>
    [DataMember(Name="parent_stack_version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parent_stack_version")]
    public string ParentStackVersion { get; set; }

    /// <summary>
    /// Gets or Sets ConfigTypes
    /// </summary>
    [DataMember(Name="config_types", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "config_types")]
    public Dictionary<string, Dictionary<string, Dictionary<string, string>>> ConfigTypes { get; set; }

    /// <summary>
    /// Gets or Sets UpgradePacks
    /// </summary>
    [DataMember(Name="upgrade_packs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "upgrade_packs")]
    public List<string> UpgradePacks { get; set; }

    /// <summary>
    /// Gets or Sets StackErrors
    /// </summary>
    [DataMember(Name="stack-errors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stack-errors")]
    public List<string> StackErrors { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StackVersionResponse {\n");
      sb.Append("  MinJdk: ").Append(MinJdk).Append("\n");
      sb.Append("  MaxJdk: ").Append(MaxJdk).Append("\n");
      sb.Append("  StackName: ").Append(StackName).Append("\n");
      sb.Append("  StackVersion: ").Append(StackVersion).Append("\n");
      sb.Append("  MinUpgradeVersion: ").Append(MinUpgradeVersion).Append("\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  Valid: ").Append(Valid).Append("\n");
      sb.Append("  ParentStackVersion: ").Append(ParentStackVersion).Append("\n");
      sb.Append("  ConfigTypes: ").Append(ConfigTypes).Append("\n");
      sb.Append("  UpgradePacks: ").Append(UpgradePacks).Append("\n");
      sb.Append("  StackErrors: ").Append(StackErrors).Append("\n");
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
