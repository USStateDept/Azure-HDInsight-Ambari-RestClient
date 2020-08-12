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
  public class ComponentDependencyResponseInfo {
    /// <summary>
    /// Gets or Sets Scope
    /// </summary>
    [DataMember(Name="scope", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scope")]
    public string Scope { get; set; }

    /// <summary>
    /// Gets or Sets ComponentName
    /// </summary>
    [DataMember(Name="component_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "component_name")]
    public string ComponentName { get; set; }

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
    /// Gets or Sets StackName
    /// </summary>
    [DataMember(Name="stack_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stack_name")]
    public string StackName { get; set; }

    /// <summary>
    /// Gets or Sets Conditions
    /// </summary>
    [DataMember(Name="conditions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "conditions")]
    public List<DependencyConditionInfo> Conditions { get; set; }

    /// <summary>
    /// Gets or Sets DependentComponentName
    /// </summary>
    [DataMember(Name="dependent_component_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dependent_component_name")]
    public string DependentComponentName { get; set; }

    /// <summary>
    /// Gets or Sets DependentServiceName
    /// </summary>
    [DataMember(Name="dependent_service_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dependent_service_name")]
    public string DependentServiceName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ComponentDependencyResponseInfo {\n");
      sb.Append("  Scope: ").Append(Scope).Append("\n");
      sb.Append("  ComponentName: ").Append(ComponentName).Append("\n");
      sb.Append("  StackVersion: ").Append(StackVersion).Append("\n");
      sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
      sb.Append("  StackName: ").Append(StackName).Append("\n");
      sb.Append("  Conditions: ").Append(Conditions).Append("\n");
      sb.Append("  DependentComponentName: ").Append(DependentComponentName).Append("\n");
      sb.Append("  DependentServiceName: ").Append(DependentServiceName).Append("\n");
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
