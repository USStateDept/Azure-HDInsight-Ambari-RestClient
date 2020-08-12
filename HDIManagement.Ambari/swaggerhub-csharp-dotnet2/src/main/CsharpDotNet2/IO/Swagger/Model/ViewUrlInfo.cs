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
  public class ViewUrlInfo {
    /// <summary>
    /// Gets or Sets ViewInstanceName
    /// </summary>
    [DataMember(Name="view_instance_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "view_instance_name")]
    public string ViewInstanceName { get; set; }

    /// <summary>
    /// Gets or Sets UrlName
    /// </summary>
    [DataMember(Name="url_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url_name")]
    public string UrlName { get; set; }

    /// <summary>
    /// Gets or Sets UrlSuffix
    /// </summary>
    [DataMember(Name="url_suffix", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url_suffix")]
    public string UrlSuffix { get; set; }

    /// <summary>
    /// Gets or Sets ViewInstanceCommonName
    /// </summary>
    [DataMember(Name="view_instance_common_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "view_instance_common_name")]
    public string ViewInstanceCommonName { get; set; }

    /// <summary>
    /// Gets or Sets ViewInstanceVersion
    /// </summary>
    [DataMember(Name="view_instance_version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "view_instance_version")]
    public string ViewInstanceVersion { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ViewUrlInfo {\n");
      sb.Append("  ViewInstanceName: ").Append(ViewInstanceName).Append("\n");
      sb.Append("  UrlName: ").Append(UrlName).Append("\n");
      sb.Append("  UrlSuffix: ").Append(UrlSuffix).Append("\n");
      sb.Append("  ViewInstanceCommonName: ").Append(ViewInstanceCommonName).Append("\n");
      sb.Append("  ViewInstanceVersion: ").Append(ViewInstanceVersion).Append("\n");
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
