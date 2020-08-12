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
  public class ViewInstanceResponseInfo {
    /// <summary>
    /// Gets or Sets ViewName
    /// </summary>
    [DataMember(Name="view_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "view_name")]
    public string ViewName { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public string Version { get; set; }

    /// <summary>
    /// Gets or Sets InstanceName
    /// </summary>
    [DataMember(Name="instance_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "instance_name")]
    public string InstanceName { get; set; }

    /// <summary>
    /// Gets or Sets Label
    /// </summary>
    [DataMember(Name="label", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "label")]
    public string Label { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Visible
    /// </summary>
    [DataMember(Name="visible", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visible")]
    public bool? Visible { get; set; }

    /// <summary>
    /// Gets or Sets IconPath
    /// </summary>
    [DataMember(Name="icon_path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "icon_path")]
    public string IconPath { get; set; }

    /// <summary>
    /// Gets or Sets Icon64Path
    /// </summary>
    [DataMember(Name="icon64_path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "icon64_path")]
    public string Icon64Path { get; set; }

    /// <summary>
    /// Gets or Sets Properties
    /// </summary>
    [DataMember(Name="properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "properties")]
    public Dictionary<string, string> Properties { get; set; }

    /// <summary>
    /// Gets or Sets InstanceData
    /// </summary>
    [DataMember(Name="instance_data", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "instance_data")]
    public Dictionary<string, string> InstanceData { get; set; }

    /// <summary>
    /// Gets or Sets ClusterHandle
    /// </summary>
    [DataMember(Name="cluster_handle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cluster_handle")]
    public int? ClusterHandle { get; set; }

    /// <summary>
    /// Gets or Sets ClusterType
    /// </summary>
    [DataMember(Name="cluster_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cluster_type")]
    public string ClusterType { get; set; }

    /// <summary>
    /// Gets or Sets ContextPath
    /// </summary>
    [DataMember(Name="context_path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "context_path")]
    public string ContextPath { get; set; }

    /// <summary>
    /// Gets or Sets Static
    /// </summary>
    [DataMember(Name="static", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "static")]
    public bool? Static { get; set; }

    /// <summary>
    /// Gets or Sets ShortUrl
    /// </summary>
    [DataMember(Name="short_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "short_url")]
    public string ShortUrl { get; set; }

    /// <summary>
    /// Gets or Sets ShortUrlName
    /// </summary>
    [DataMember(Name="short_url_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "short_url_name")]
    public string ShortUrlName { get; set; }

    /// <summary>
    /// Gets or Sets ValidationResult
    /// </summary>
    [DataMember(Name="validation_result", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "validation_result")]
    public ValidationResult ValidationResult { get; set; }

    /// <summary>
    /// Gets or Sets PropertyValidationResults
    /// </summary>
    [DataMember(Name="property_validation_results", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "property_validation_results")]
    public Dictionary<string, ValidationResult> PropertyValidationResults { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ViewInstanceResponseInfo {\n");
      sb.Append("  ViewName: ").Append(ViewName).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  InstanceName: ").Append(InstanceName).Append("\n");
      sb.Append("  Label: ").Append(Label).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Visible: ").Append(Visible).Append("\n");
      sb.Append("  IconPath: ").Append(IconPath).Append("\n");
      sb.Append("  Icon64Path: ").Append(Icon64Path).Append("\n");
      sb.Append("  Properties: ").Append(Properties).Append("\n");
      sb.Append("  InstanceData: ").Append(InstanceData).Append("\n");
      sb.Append("  ClusterHandle: ").Append(ClusterHandle).Append("\n");
      sb.Append("  ClusterType: ").Append(ClusterType).Append("\n");
      sb.Append("  ContextPath: ").Append(ContextPath).Append("\n");
      sb.Append("  Static: ").Append(Static).Append("\n");
      sb.Append("  ShortUrl: ").Append(ShortUrl).Append("\n");
      sb.Append("  ShortUrlName: ").Append(ShortUrlName).Append("\n");
      sb.Append("  ValidationResult: ").Append(ValidationResult).Append("\n");
      sb.Append("  PropertyValidationResults: ").Append(PropertyValidationResults).Append("\n");
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
