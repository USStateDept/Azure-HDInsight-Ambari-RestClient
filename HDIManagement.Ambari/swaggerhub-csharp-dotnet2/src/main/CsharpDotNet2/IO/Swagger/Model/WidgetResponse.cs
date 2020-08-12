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
  public class WidgetResponse {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Gets or Sets WidgetName
    /// </summary>
    [DataMember(Name="widgetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "widgetName")]
    public string WidgetName { get; set; }

    /// <summary>
    /// Gets or Sets WidgetType
    /// </summary>
    [DataMember(Name="widgetType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "widgetType")]
    public string WidgetType { get; set; }

    /// <summary>
    /// Gets or Sets Metrics
    /// </summary>
    [DataMember(Name="metrics", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metrics")]
    public string Metrics { get; set; }

    /// <summary>
    /// Gets or Sets TimeCreated
    /// </summary>
    [DataMember(Name="timeCreated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timeCreated")]
    public long? TimeCreated { get; set; }

    /// <summary>
    /// Gets or Sets Author
    /// </summary>
    [DataMember(Name="author", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "author")]
    public string Author { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name="displayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or Sets Scope
    /// </summary>
    [DataMember(Name="scope", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scope")]
    public string Scope { get; set; }

    /// <summary>
    /// Gets or Sets WidgetValues
    /// </summary>
    [DataMember(Name="widgetValues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "widgetValues")]
    public string WidgetValues { get; set; }

    /// <summary>
    /// Gets or Sets Properties
    /// </summary>
    [DataMember(Name="properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "properties")]
    public string Properties { get; set; }

    /// <summary>
    /// Gets or Sets ClusterName
    /// </summary>
    [DataMember(Name="clusterName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clusterName")]
    public string ClusterName { get; set; }

    /// <summary>
    /// Gets or Sets Tag
    /// </summary>
    [DataMember(Name="tag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tag")]
    public string Tag { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WidgetResponse {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  WidgetName: ").Append(WidgetName).Append("\n");
      sb.Append("  WidgetType: ").Append(WidgetType).Append("\n");
      sb.Append("  Metrics: ").Append(Metrics).Append("\n");
      sb.Append("  TimeCreated: ").Append(TimeCreated).Append("\n");
      sb.Append("  Author: ").Append(Author).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  Scope: ").Append(Scope).Append("\n");
      sb.Append("  WidgetValues: ").Append(WidgetValues).Append("\n");
      sb.Append("  Properties: ").Append(Properties).Append("\n");
      sb.Append("  ClusterName: ").Append(ClusterName).Append("\n");
      sb.Append("  Tag: ").Append(Tag).Append("\n");
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
