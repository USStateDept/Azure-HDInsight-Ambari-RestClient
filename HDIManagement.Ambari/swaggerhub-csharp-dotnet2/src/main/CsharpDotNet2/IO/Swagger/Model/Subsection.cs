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
  public class Subsection {
    /// <summary>
    /// Gets or Sets RowIndex
    /// </summary>
    [DataMember(Name="row-index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "row-index")]
    public string RowIndex { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name="display-name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "display-name")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or Sets ColumnSpan
    /// </summary>
    [DataMember(Name="column-span", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "column-span")]
    public string ColumnSpan { get; set; }

    /// <summary>
    /// Gets or Sets RowSpan
    /// </summary>
    [DataMember(Name="row-span", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "row-span")]
    public string RowSpan { get; set; }

    /// <summary>
    /// Gets or Sets ColumnIndex
    /// </summary>
    [DataMember(Name="column-index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "column-index")]
    public string ColumnIndex { get; set; }

    /// <summary>
    /// Gets or Sets Border
    /// </summary>
    [DataMember(Name="border", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "border")]
    public string Border { get; set; }

    /// <summary>
    /// Gets or Sets LeftVerticalSplitter
    /// </summary>
    [DataMember(Name="left-vertical-splitter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "left-vertical-splitter")]
    public bool? LeftVerticalSplitter { get; set; }

    /// <summary>
    /// Gets or Sets DependsOn
    /// </summary>
    [DataMember(Name="depends-on", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "depends-on")]
    public List<ConfigCondition> DependsOn { get; set; }

    /// <summary>
    /// Gets or Sets SubsectionTab
    /// </summary>
    [DataMember(Name="subsection-tab", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subsection-tab")]
    public List<SubsectionTab> SubsectionTab { get; set; }

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
      sb.Append("class Subsection {\n");
      sb.Append("  RowIndex: ").Append(RowIndex).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  ColumnSpan: ").Append(ColumnSpan).Append("\n");
      sb.Append("  RowSpan: ").Append(RowSpan).Append("\n");
      sb.Append("  ColumnIndex: ").Append(ColumnIndex).Append("\n");
      sb.Append("  Border: ").Append(Border).Append("\n");
      sb.Append("  LeftVerticalSplitter: ").Append(LeftVerticalSplitter).Append("\n");
      sb.Append("  DependsOn: ").Append(DependsOn).Append("\n");
      sb.Append("  SubsectionTab: ").Append(SubsectionTab).Append("\n");
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
