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
  public class RequestInfo {
    /// <summary>
    /// Gets or Sets Action
    /// </summary>
    [DataMember(Name="action", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "action")]
    public string Action { get; set; }

    /// <summary>
    /// Gets or Sets Parameters
    /// </summary>
    [DataMember(Name="parameters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parameters")]
    public Dictionary<string, Object> Parameters { get; set; }

    /// <summary>
    /// Gets or Sets Command
    /// </summary>
    [DataMember(Name="command", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "command")]
    public string Command { get; set; }

    /// <summary>
    /// Gets or Sets OperationLevel
    /// </summary>
    [DataMember(Name="operation_level", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operation_level")]
    public OperationLevel OperationLevel { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RequestInfo {\n");
      sb.Append("  Action: ").Append(Action).Append("\n");
      sb.Append("  Parameters: ").Append(Parameters).Append("\n");
      sb.Append("  Command: ").Append(Command).Append("\n");
      sb.Append("  OperationLevel: ").Append(OperationLevel).Append("\n");
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
