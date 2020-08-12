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
  public class ExtensionLinkResponseInfo {
    /// <summary>
    /// Gets or Sets LinkId
    /// </summary>
    [DataMember(Name="link_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "link_id")]
    public string LinkId { get; set; }

    /// <summary>
    /// Gets or Sets StackName
    /// </summary>
    [DataMember(Name="stack_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stack_name")]
    public string StackName { get; set; }

    /// <summary>
    /// Gets or Sets StackVersion
    /// </summary>
    [DataMember(Name="stack_version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stack_version")]
    public string StackVersion { get; set; }

    /// <summary>
    /// Gets or Sets ExtensionName
    /// </summary>
    [DataMember(Name="extension_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "extension_name")]
    public string ExtensionName { get; set; }

    /// <summary>
    /// Gets or Sets ExtensionVersion
    /// </summary>
    [DataMember(Name="extension_version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "extension_version")]
    public string ExtensionVersion { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ExtensionLinkResponseInfo {\n");
      sb.Append("  LinkId: ").Append(LinkId).Append("\n");
      sb.Append("  StackName: ").Append(StackName).Append("\n");
      sb.Append("  StackVersion: ").Append(StackVersion).Append("\n");
      sb.Append("  ExtensionName: ").Append(ExtensionName).Append("\n");
      sb.Append("  ExtensionVersion: ").Append(ExtensionVersion).Append("\n");
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
