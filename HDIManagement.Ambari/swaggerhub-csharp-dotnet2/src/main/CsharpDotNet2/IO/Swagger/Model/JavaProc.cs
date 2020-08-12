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
  public class JavaProc {
    /// <summary>
    /// Gets or Sets Hadoop
    /// </summary>
    [DataMember(Name="hadoop", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hadoop")]
    public bool? Hadoop { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public string User { get; set; }

    /// <summary>
    /// Gets or Sets Pid
    /// </summary>
    [DataMember(Name="pid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pid")]
    public int? Pid { get; set; }

    /// <summary>
    /// Gets or Sets Command
    /// </summary>
    [DataMember(Name="command", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "command")]
    public string Command { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class JavaProc {\n");
      sb.Append("  Hadoop: ").Append(Hadoop).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
      sb.Append("  Pid: ").Append(Pid).Append("\n");
      sb.Append("  Command: ").Append(Command).Append("\n");
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
