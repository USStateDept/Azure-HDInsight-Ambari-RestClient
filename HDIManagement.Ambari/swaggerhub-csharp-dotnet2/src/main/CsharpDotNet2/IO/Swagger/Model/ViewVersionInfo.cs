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
  public class ViewVersionInfo {
    /// <summary>
    /// Gets or Sets Archive
    /// </summary>
    [DataMember(Name="archive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "archive")]
    public string Archive { get; set; }

    /// <summary>
    /// Gets or Sets BuildNumber
    /// </summary>
    [DataMember(Name="build_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "build_number")]
    public string BuildNumber { get; set; }

    /// <summary>
    /// Gets or Sets ClusterConfigurable
    /// </summary>
    [DataMember(Name="cluster_configurable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cluster_configurable")]
    public bool? ClusterConfigurable { get; set; }

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
    /// Gets or Sets MaskerClass
    /// </summary>
    [DataMember(Name="masker_class", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "masker_class")]
    public string MaskerClass { get; set; }

    /// <summary>
    /// Gets or Sets MaxAmbariVersion
    /// </summary>
    [DataMember(Name="max_ambari_version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "max_ambari_version")]
    public string MaxAmbariVersion { get; set; }

    /// <summary>
    /// Gets or Sets MinAmbariVersion
    /// </summary>
    [DataMember(Name="min_ambari_version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "min_ambari_version")]
    public string MinAmbariVersion { get; set; }

    /// <summary>
    /// Gets or Sets Parameters
    /// </summary>
    [DataMember(Name="parameters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parameters")]
    public List<ParameterConfig> Parameters { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets StatusDetail
    /// </summary>
    [DataMember(Name="status_detail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status_detail")]
    public string StatusDetail { get; set; }

    /// <summary>
    /// Gets or Sets System
    /// </summary>
    [DataMember(Name="system", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "system")]
    public bool? System { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public string Version { get; set; }

    /// <summary>
    /// Gets or Sets ViewName
    /// </summary>
    [DataMember(Name="view_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "view_name")]
    public string ViewName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ViewVersionInfo {\n");
      sb.Append("  Archive: ").Append(Archive).Append("\n");
      sb.Append("  BuildNumber: ").Append(BuildNumber).Append("\n");
      sb.Append("  ClusterConfigurable: ").Append(ClusterConfigurable).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Label: ").Append(Label).Append("\n");
      sb.Append("  MaskerClass: ").Append(MaskerClass).Append("\n");
      sb.Append("  MaxAmbariVersion: ").Append(MaxAmbariVersion).Append("\n");
      sb.Append("  MinAmbariVersion: ").Append(MinAmbariVersion).Append("\n");
      sb.Append("  Parameters: ").Append(Parameters).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  StatusDetail: ").Append(StatusDetail).Append("\n");
      sb.Append("  System: ").Append(System).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  ViewName: ").Append(ViewName).Append("\n");
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
