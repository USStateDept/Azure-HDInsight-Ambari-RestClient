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
  public class ActiveWidgetLayoutResponse {
    /// <summary>
    /// Gets or Sets WidgetLayoutInfoclusterName
    /// </summary>
    [DataMember(Name="WidgetLayoutInfo/cluster_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WidgetLayoutInfo/cluster_name")]
    public string WidgetLayoutInfoclusterName { get; set; }

    /// <summary>
    /// Gets or Sets WidgetLayoutInfodisplayName
    /// </summary>
    [DataMember(Name="WidgetLayoutInfo/display_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WidgetLayoutInfo/display_name")]
    public string WidgetLayoutInfodisplayName { get; set; }

    /// <summary>
    /// Gets or Sets WidgetLayoutInfolayoutName
    /// </summary>
    [DataMember(Name="WidgetLayoutInfo/layout_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WidgetLayoutInfo/layout_name")]
    public string WidgetLayoutInfolayoutName { get; set; }

    /// <summary>
    /// Gets or Sets WidgetLayoutInfoscope
    /// </summary>
    [DataMember(Name="WidgetLayoutInfo/scope", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WidgetLayoutInfo/scope")]
    public string WidgetLayoutInfoscope { get; set; }

    /// <summary>
    /// Gets or Sets WidgetLayoutInfosectionName
    /// </summary>
    [DataMember(Name="WidgetLayoutInfo/section_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WidgetLayoutInfo/section_name")]
    public string WidgetLayoutInfosectionName { get; set; }

    /// <summary>
    /// Gets or Sets WidgetLayoutInfouserName
    /// </summary>
    [DataMember(Name="WidgetLayoutInfo/user_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WidgetLayoutInfo/user_name")]
    public string WidgetLayoutInfouserName { get; set; }

    /// <summary>
    /// Gets or Sets WidgetLayoutInfowidgets
    /// </summary>
    [DataMember(Name="WidgetLayoutInfo/widgets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WidgetLayoutInfo/widgets")]
    public List<Dictionary<string, WidgetResponse>> WidgetLayoutInfowidgets { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ActiveWidgetLayoutResponse {\n");
      sb.Append("  WidgetLayoutInfoclusterName: ").Append(WidgetLayoutInfoclusterName).Append("\n");
      sb.Append("  WidgetLayoutInfodisplayName: ").Append(WidgetLayoutInfodisplayName).Append("\n");
      sb.Append("  WidgetLayoutInfolayoutName: ").Append(WidgetLayoutInfolayoutName).Append("\n");
      sb.Append("  WidgetLayoutInfoscope: ").Append(WidgetLayoutInfoscope).Append("\n");
      sb.Append("  WidgetLayoutInfosectionName: ").Append(WidgetLayoutInfosectionName).Append("\n");
      sb.Append("  WidgetLayoutInfouserName: ").Append(WidgetLayoutInfouserName).Append("\n");
      sb.Append("  WidgetLayoutInfowidgets: ").Append(WidgetLayoutInfowidgets).Append("\n");
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
