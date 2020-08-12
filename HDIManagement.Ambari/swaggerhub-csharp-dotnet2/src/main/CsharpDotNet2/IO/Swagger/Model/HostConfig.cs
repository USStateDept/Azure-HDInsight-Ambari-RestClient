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
  public class HostConfig {
    /// <summary>
    /// Gets or Sets ConfigGroupOverrides
    /// </summary>
    [DataMember(Name="configGroupOverrides", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "configGroupOverrides")]
    public Dictionary<string, string> ConfigGroupOverrides { get; set; }

    /// <summary>
    /// Gets or Sets DefaultVersionTag
    /// </summary>
    [DataMember(Name="defaultVersionTag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultVersionTag")]
    public string DefaultVersionTag { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class HostConfig {\n");
      sb.Append("  ConfigGroupOverrides: ").Append(ConfigGroupOverrides).Append("\n");
      sb.Append("  DefaultVersionTag: ").Append(DefaultVersionTag).Append("\n");
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
