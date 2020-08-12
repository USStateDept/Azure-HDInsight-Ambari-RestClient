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
  public class StackEntity {
    /// <summary>
    /// Gets or Sets StackId
    /// </summary>
    [DataMember(Name="stackId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stackId")]
    public long? StackId { get; set; }

    /// <summary>
    /// Gets or Sets StackName
    /// </summary>
    [DataMember(Name="stackName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stackName")]
    public string StackName { get; set; }

    /// <summary>
    /// Gets or Sets StackVersion
    /// </summary>
    [DataMember(Name="stackVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stackVersion")]
    public string StackVersion { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StackEntity {\n");
      sb.Append("  StackId: ").Append(StackId).Append("\n");
      sb.Append("  StackName: ").Append(StackName).Append("\n");
      sb.Append("  StackVersion: ").Append(StackVersion).Append("\n");
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
