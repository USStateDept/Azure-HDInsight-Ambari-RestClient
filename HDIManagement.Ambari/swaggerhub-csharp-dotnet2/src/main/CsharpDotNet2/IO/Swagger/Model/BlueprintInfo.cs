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
  public class BlueprintInfo {
    /// <summary>
    /// Gets or Sets Security
    /// </summary>
    [DataMember(Name="security", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "security")]
    public SecurityInfo Security { get; set; }

    /// <summary>
    /// Gets or Sets StackVersion
    /// </summary>
    [DataMember(Name="stack_version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stack_version")]
    public string StackVersion { get; set; }

    /// <summary>
    /// Gets or Sets StackName
    /// </summary>
    [DataMember(Name="stack_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stack_name")]
    public string StackName { get; set; }

    /// <summary>
    /// Gets or Sets BlueprintName
    /// </summary>
    [DataMember(Name="blueprint_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blueprint_name")]
    public string BlueprintName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BlueprintInfo {\n");
      sb.Append("  Security: ").Append(Security).Append("\n");
      sb.Append("  StackVersion: ").Append(StackVersion).Append("\n");
      sb.Append("  StackName: ").Append(StackName).Append("\n");
      sb.Append("  BlueprintName: ").Append(BlueprintName).Append("\n");
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
