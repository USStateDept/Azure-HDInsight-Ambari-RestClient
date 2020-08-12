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
  public class ParameterConfig {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Label
    /// </summary>
    [DataMember(Name="label", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "label")]
    public string Label { get; set; }

    /// <summary>
    /// Gets or Sets Placeholder
    /// </summary>
    [DataMember(Name="placeholder", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "placeholder")]
    public string Placeholder { get; set; }

    /// <summary>
    /// Gets or Sets DefaultValue
    /// </summary>
    [DataMember(Name="defaultValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultValue")]
    public string DefaultValue { get; set; }

    /// <summary>
    /// Gets or Sets ClusterConfig
    /// </summary>
    [DataMember(Name="clusterConfig", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clusterConfig")]
    public string ClusterConfig { get; set; }

    /// <summary>
    /// Gets or Sets Required
    /// </summary>
    [DataMember(Name="required", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required")]
    public bool? Required { get; set; }

    /// <summary>
    /// Gets or Sets Masked
    /// </summary>
    [DataMember(Name="masked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "masked")]
    public bool? Masked { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ParameterConfig {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Label: ").Append(Label).Append("\n");
      sb.Append("  Placeholder: ").Append(Placeholder).Append("\n");
      sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
      sb.Append("  ClusterConfig: ").Append(ClusterConfig).Append("\n");
      sb.Append("  Required: ").Append(Required).Append("\n");
      sb.Append("  Masked: ").Append(Masked).Append("\n");
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
