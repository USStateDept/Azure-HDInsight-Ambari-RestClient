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
  public class StackId {
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
    /// Gets or Sets _StackId
    /// </summary>
    [DataMember(Name="stackId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stackId")]
    public string _StackId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StackId {\n");
      sb.Append("  StackName: ").Append(StackName).Append("\n");
      sb.Append("  StackVersion: ").Append(StackVersion).Append("\n");
      sb.Append("  _StackId: ").Append(_StackId).Append("\n");
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
