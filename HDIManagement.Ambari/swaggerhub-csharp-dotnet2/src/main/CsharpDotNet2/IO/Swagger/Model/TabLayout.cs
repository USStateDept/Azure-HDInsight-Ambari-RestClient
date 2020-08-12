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
  public class TabLayout {
    /// <summary>
    /// Gets or Sets TabRows
    /// </summary>
    [DataMember(Name="tab-rows", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tab-rows")]
    public string TabRows { get; set; }

    /// <summary>
    /// Gets or Sets Sections
    /// </summary>
    [DataMember(Name="sections", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sections")]
    public List<Section> Sections { get; set; }

    /// <summary>
    /// Gets or Sets TabColumns
    /// </summary>
    [DataMember(Name="tab-columns", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tab-columns")]
    public string TabColumns { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TabLayout {\n");
      sb.Append("  TabRows: ").Append(TabRows).Append("\n");
      sb.Append("  Sections: ").Append(Sections).Append("\n");
      sb.Append("  TabColumns: ").Append(TabColumns).Append("\n");
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
