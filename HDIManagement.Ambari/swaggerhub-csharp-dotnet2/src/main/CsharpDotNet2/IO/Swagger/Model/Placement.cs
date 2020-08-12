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
  public class Placement {
    /// <summary>
    /// Gets or Sets Configs
    /// </summary>
    [DataMember(Name="configs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "configs")]
    public List<ConfigPlacement> Configs { get; set; }

    /// <summary>
    /// Gets or Sets ConfigurationLayout
    /// </summary>
    [DataMember(Name="configurationLayout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "configurationLayout")]
    public string ConfigurationLayout { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Placement {\n");
      sb.Append("  Configs: ").Append(Configs).Append("\n");
      sb.Append("  ConfigurationLayout: ").Append(ConfigurationLayout).Append("\n");
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
