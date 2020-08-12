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
  public class RootServiceComponentResponse {
    /// <summary>
    /// Gets or Sets ServiceName
    /// </summary>
    [DataMember(Name="service_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service_name")]
    public string ServiceName { get; set; }

    /// <summary>
    /// Gets or Sets ComponentName
    /// </summary>
    [DataMember(Name="component_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "component_name")]
    public string ComponentName { get; set; }

    /// <summary>
    /// Gets or Sets Properties
    /// </summary>
    [DataMember(Name="properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "properties")]
    public Dictionary<string, string> Properties { get; set; }

    /// <summary>
    /// Gets or Sets ComponentVersion
    /// </summary>
    [DataMember(Name="component_version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "component_version")]
    public string ComponentVersion { get; set; }

    /// <summary>
    /// Gets or Sets ServerClock
    /// </summary>
    [DataMember(Name="server_clock", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "server_clock")]
    public long? ServerClock { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RootServiceComponentResponse {\n");
      sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
      sb.Append("  ComponentName: ").Append(ComponentName).Append("\n");
      sb.Append("  Properties: ").Append(Properties).Append("\n");
      sb.Append("  ComponentVersion: ").Append(ComponentVersion).Append("\n");
      sb.Append("  ServerClock: ").Append(ServerClock).Append("\n");
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
