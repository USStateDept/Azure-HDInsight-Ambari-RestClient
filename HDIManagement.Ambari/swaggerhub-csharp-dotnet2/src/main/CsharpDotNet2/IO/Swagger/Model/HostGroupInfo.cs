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
  public class HostGroupInfo {
    /// <summary>
    /// Gets or Sets Components
    /// </summary>
    [DataMember(Name="components", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "components")]
    public List<ComponentInfo> Components { get; set; }

    /// <summary>
    /// Gets or Sets Configurations
    /// </summary>
    [DataMember(Name="configurations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "configurations")]
    public List<Dictionary<string, Object>> Configurations { get; set; }

    /// <summary>
    /// Gets or Sets Cardinality
    /// </summary>
    [DataMember(Name="cardinality", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cardinality")]
    public int? Cardinality { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class HostGroupInfo {\n");
      sb.Append("  Components: ").Append(Components).Append("\n");
      sb.Append("  Configurations: ").Append(Configurations).Append("\n");
      sb.Append("  Cardinality: ").Append(Cardinality).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
