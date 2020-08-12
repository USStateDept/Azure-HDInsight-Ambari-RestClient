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
  public class ThemeConfiguration {
    /// <summary>
    /// Gets or Sets Placement
    /// </summary>
    [DataMember(Name="placement", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "placement")]
    public Placement Placement { get; set; }

    /// <summary>
    /// Gets or Sets Widgets
    /// </summary>
    [DataMember(Name="widgets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "widgets")]
    public List<WidgetEntry> Widgets { get; set; }

    /// <summary>
    /// Gets or Sets Layouts
    /// </summary>
    [DataMember(Name="layouts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "layouts")]
    public List<Layout> Layouts { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ThemeConfiguration {\n");
      sb.Append("  Placement: ").Append(Placement).Append("\n");
      sb.Append("  Widgets: ").Append(Widgets).Append("\n");
      sb.Append("  Layouts: ").Append(Layouts).Append("\n");
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
