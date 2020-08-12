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
  public class HostComponentSwagger {
    /// <summary>
    /// Gets or Sets Host
    /// </summary>
    [DataMember(Name="host", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "host")]
    public HostComponentHost Host { get; set; }

    /// <summary>
    /// Gets or Sets Component
    /// </summary>
    [DataMember(Name="component", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "component")]
    public List<HostComponentComponent> Component { get; set; }

    /// <summary>
    /// Gets or Sets Metrics
    /// </summary>
    [DataMember(Name="metrics", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metrics")]
    public HostComponentMetrics Metrics { get; set; }

    /// <summary>
    /// Gets or Sets Processes
    /// </summary>
    [DataMember(Name="processes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "processes")]
    public List<HostComponentProcesses> Processes { get; set; }

    /// <summary>
    /// Gets or Sets HostRoles
    /// </summary>
    [DataMember(Name="HostRoles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HostRoles")]
    public ServiceComponentHostResponse HostRoles { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class HostComponentSwagger {\n");
      sb.Append("  Host: ").Append(Host).Append("\n");
      sb.Append("  Component: ").Append(Component).Append("\n");
      sb.Append("  Metrics: ").Append(Metrics).Append("\n");
      sb.Append("  Processes: ").Append(Processes).Append("\n");
      sb.Append("  HostRoles: ").Append(HostRoles).Append("\n");
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
