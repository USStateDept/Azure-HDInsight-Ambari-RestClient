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
  public class Widget {
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets Units
    /// </summary>
    [DataMember(Name="units", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "units")]
    public List<Unit> Units { get; set; }

    /// <summary>
    /// Gets or Sets RequiredProperties
    /// </summary>
    [DataMember(Name="required-properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required-properties")]
    public Dictionary<string, string> RequiredProperties { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name="display-name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "display-name")]
    public string DisplayName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Widget {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Units: ").Append(Units).Append("\n");
      sb.Append("  RequiredProperties: ").Append(RequiredProperties).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
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
