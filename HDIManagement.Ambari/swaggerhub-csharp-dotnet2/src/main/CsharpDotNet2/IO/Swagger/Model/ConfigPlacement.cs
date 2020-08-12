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
  public class ConfigPlacement {
    /// <summary>
    /// Gets or Sets Config
    /// </summary>
    [DataMember(Name="config", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "config")]
    public string Config { get; set; }

    /// <summary>
    /// Gets or Sets SubsectionName
    /// </summary>
    [DataMember(Name="subsection-name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subsection-name")]
    public string SubsectionName { get; set; }

    /// <summary>
    /// Gets or Sets SubsectionTabName
    /// </summary>
    [DataMember(Name="subsection-tab-name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subsection-tab-name")]
    public string SubsectionTabName { get; set; }

    /// <summary>
    /// Gets or Sets PropertyValueAttributes
    /// </summary>
    [DataMember(Name="property_value_attributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "property_value_attributes")]
    public ValueAttributesInfo PropertyValueAttributes { get; set; }

    /// <summary>
    /// Gets or Sets DependsOn
    /// </summary>
    [DataMember(Name="depends-on", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "depends-on")]
    public List<ConfigCondition> DependsOn { get; set; }

    /// <summary>
    /// Gets or Sets Removed
    /// </summary>
    [DataMember(Name="removed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "removed")]
    public bool? Removed { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ConfigPlacement {\n");
      sb.Append("  Config: ").Append(Config).Append("\n");
      sb.Append("  SubsectionName: ").Append(SubsectionName).Append("\n");
      sb.Append("  SubsectionTabName: ").Append(SubsectionTabName).Append("\n");
      sb.Append("  PropertyValueAttributes: ").Append(PropertyValueAttributes).Append("\n");
      sb.Append("  DependsOn: ").Append(DependsOn).Append("\n");
      sb.Append("  Removed: ").Append(Removed).Append("\n");
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
