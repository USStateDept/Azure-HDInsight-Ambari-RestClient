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
  public class ActiveWidgetLayoutRequest {
    /// <summary>
    /// Gets or Sets WidgetLayouts
    /// </summary>
    [DataMember(Name="WidgetLayouts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WidgetLayouts")]
    public List<WidgetLayoutIdWrapper> WidgetLayouts { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ActiveWidgetLayoutRequest {\n");
      sb.Append("  WidgetLayouts: ").Append(WidgetLayouts).Append("\n");
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
