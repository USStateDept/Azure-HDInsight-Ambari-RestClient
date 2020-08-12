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
  public class ClusterHealthReport {
    /// <summary>
    /// Gets or Sets HoststaleConfig
    /// </summary>
    [DataMember(Name="Host/stale_config", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Host/stale_config")]
    public int? HoststaleConfig { get; set; }

    /// <summary>
    /// Gets or Sets HostmaintenanceState
    /// </summary>
    [DataMember(Name="Host/maintenance_state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Host/maintenance_state")]
    public int? HostmaintenanceState { get; set; }

    /// <summary>
    /// Gets or Sets HosthostStateHEALTHY
    /// </summary>
    [DataMember(Name="Host/host_state/HEALTHY", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Host/host_state/HEALTHY")]
    public int? HosthostStateHEALTHY { get; set; }

    /// <summary>
    /// Gets or Sets HosthostStateUNHEALTHY
    /// </summary>
    [DataMember(Name="Host/host_state/UNHEALTHY", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Host/host_state/UNHEALTHY")]
    public int? HosthostStateUNHEALTHY { get; set; }

    /// <summary>
    /// Gets or Sets HosthostStateHEARTBEATLOST
    /// </summary>
    [DataMember(Name="Host/host_state/HEARTBEAT_LOST", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Host/host_state/HEARTBEAT_LOST")]
    public int? HosthostStateHEARTBEATLOST { get; set; }

    /// <summary>
    /// Gets or Sets HosthostStateINIT
    /// </summary>
    [DataMember(Name="Host/host_state/INIT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Host/host_state/INIT")]
    public int? HosthostStateINIT { get; set; }

    /// <summary>
    /// Gets or Sets HosthostStatusHEALTHY
    /// </summary>
    [DataMember(Name="Host/host_status/HEALTHY", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Host/host_status/HEALTHY")]
    public int? HosthostStatusHEALTHY { get; set; }

    /// <summary>
    /// Gets or Sets HosthostStatusUNHEALTHY
    /// </summary>
    [DataMember(Name="Host/host_status/UNHEALTHY", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Host/host_status/UNHEALTHY")]
    public int? HosthostStatusUNHEALTHY { get; set; }

    /// <summary>
    /// Gets or Sets HosthostStatusUNKNOWN
    /// </summary>
    [DataMember(Name="Host/host_status/UNKNOWN", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Host/host_status/UNKNOWN")]
    public int? HosthostStatusUNKNOWN { get; set; }

    /// <summary>
    /// Gets or Sets HosthostStatusALERT
    /// </summary>
    [DataMember(Name="Host/host_status/ALERT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Host/host_status/ALERT")]
    public int? HosthostStatusALERT { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ClusterHealthReport {\n");
      sb.Append("  HoststaleConfig: ").Append(HoststaleConfig).Append("\n");
      sb.Append("  HostmaintenanceState: ").Append(HostmaintenanceState).Append("\n");
      sb.Append("  HosthostStateHEALTHY: ").Append(HosthostStateHEALTHY).Append("\n");
      sb.Append("  HosthostStateUNHEALTHY: ").Append(HosthostStateUNHEALTHY).Append("\n");
      sb.Append("  HosthostStateHEARTBEATLOST: ").Append(HosthostStateHEARTBEATLOST).Append("\n");
      sb.Append("  HosthostStateINIT: ").Append(HosthostStateINIT).Append("\n");
      sb.Append("  HosthostStatusHEALTHY: ").Append(HosthostStatusHEALTHY).Append("\n");
      sb.Append("  HosthostStatusUNHEALTHY: ").Append(HosthostStatusUNHEALTHY).Append("\n");
      sb.Append("  HosthostStatusUNKNOWN: ").Append(HosthostStatusUNKNOWN).Append("\n");
      sb.Append("  HosthostStatusALERT: ").Append(HosthostStatusALERT).Append("\n");
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
