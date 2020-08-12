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
  public class BlueprintSwagger {
    /// <summary>
    /// Gets or Sets Configurations
    /// </summary>
    [DataMember(Name="configurations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "configurations")]
    public List<Dictionary<string, Object>> Configurations { get; set; }

    /// <summary>
    /// Gets or Sets HostGroups
    /// </summary>
    [DataMember(Name="host_groups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "host_groups")]
    public List<HostGroupInfo> HostGroups { get; set; }

    /// <summary>
    /// Gets or Sets Blueprints
    /// </summary>
    [DataMember(Name="Blueprints", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Blueprints")]
    public BlueprintInfo Blueprints { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BlueprintSwagger {\n");
      sb.Append("  Configurations: ").Append(Configurations).Append("\n");
      sb.Append("  HostGroups: ").Append(HostGroups).Append("\n");
      sb.Append("  Blueprints: ").Append(Blueprints).Append("\n");
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
