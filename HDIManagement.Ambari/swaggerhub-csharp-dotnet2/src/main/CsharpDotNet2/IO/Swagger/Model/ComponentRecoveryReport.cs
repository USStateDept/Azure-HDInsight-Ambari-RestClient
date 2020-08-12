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
  public class ComponentRecoveryReport {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets NumAttempts
    /// </summary>
    [DataMember(Name="numAttempts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numAttempts")]
    public int? NumAttempts { get; set; }

    /// <summary>
    /// Gets or Sets LimitReached
    /// </summary>
    [DataMember(Name="limitReached", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "limitReached")]
    public bool? LimitReached { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ComponentRecoveryReport {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  NumAttempts: ").Append(NumAttempts).Append("\n");
      sb.Append("  LimitReached: ").Append(LimitReached).Append("\n");
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
