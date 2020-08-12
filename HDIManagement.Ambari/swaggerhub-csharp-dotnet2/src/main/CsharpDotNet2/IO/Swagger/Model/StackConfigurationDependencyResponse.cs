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
  public class StackConfigurationDependencyResponse {
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
    /// Gets or Sets PropertyName
    /// </summary>
    [DataMember(Name="property_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "property_name")]
    public string PropertyName { get; set; }

    /// <summary>
    /// Gets or Sets DependencyName
    /// </summary>
    [DataMember(Name="dependency_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dependency_name")]
    public string DependencyName { get; set; }

    /// <summary>
    /// Gets or Sets DependencyType
    /// </summary>
    [DataMember(Name="dependency_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dependency_type")]
    public string DependencyType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StackConfigurationDependencyResponse {\n");
      sb.Append("  StackName: ").Append(StackName).Append("\n");
      sb.Append("  StackVersion: ").Append(StackVersion).Append("\n");
      sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
      sb.Append("  PropertyName: ").Append(PropertyName).Append("\n");
      sb.Append("  DependencyName: ").Append(DependencyName).Append("\n");
      sb.Append("  DependencyType: ").Append(DependencyType).Append("\n");
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
