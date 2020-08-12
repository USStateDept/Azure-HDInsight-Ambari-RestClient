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
  public class StackConfigurationResponse {
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
    /// Gets or Sets PropertyValue
    /// </summary>
    [DataMember(Name="property_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "property_value")]
    public string PropertyValue { get; set; }

    /// <summary>
    /// Gets or Sets PropertyDescription
    /// </summary>
    [DataMember(Name="property_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "property_description")]
    public string PropertyDescription { get; set; }

    /// <summary>
    /// Gets or Sets PropertyDisplayName
    /// </summary>
    [DataMember(Name="property_display_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "property_display_name")]
    public string PropertyDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets PropertyValueAttributes
    /// </summary>
    [DataMember(Name="property_value_attributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "property_value_attributes")]
    public ValueAttributesInfo PropertyValueAttributes { get; set; }

    /// <summary>
    /// Gets or Sets Dependencies
    /// </summary>
    [DataMember(Name="dependencies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dependencies")]
    public List<PropertyDependencyInfo> Dependencies { get; set; }

    /// <summary>
    /// Gets or Sets PropertyType
    /// </summary>
    [DataMember(Name="property_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "property_type")]
    public List<string> PropertyType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StackConfigurationResponse {\n");
      sb.Append("  StackName: ").Append(StackName).Append("\n");
      sb.Append("  StackVersion: ").Append(StackVersion).Append("\n");
      sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
      sb.Append("  PropertyName: ").Append(PropertyName).Append("\n");
      sb.Append("  PropertyValue: ").Append(PropertyValue).Append("\n");
      sb.Append("  PropertyDescription: ").Append(PropertyDescription).Append("\n");
      sb.Append("  PropertyDisplayName: ").Append(PropertyDisplayName).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  PropertyValueAttributes: ").Append(PropertyValueAttributes).Append("\n");
      sb.Append("  Dependencies: ").Append(Dependencies).Append("\n");
      sb.Append("  PropertyType: ").Append(PropertyType).Append("\n");
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
