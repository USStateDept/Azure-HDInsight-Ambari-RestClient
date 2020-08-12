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
  public class HostResponse {
    /// <summary>
    /// Gets or Sets HostName
    /// </summary>
    [DataMember(Name="host_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "host_name")]
    public string HostName { get; set; }

    /// <summary>
    /// Gets or Sets ClusterName
    /// </summary>
    [DataMember(Name="cluster_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cluster_name")]
    public string ClusterName { get; set; }

    /// <summary>
    /// Gets or Sets Ip
    /// </summary>
    [DataMember(Name="ip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ip")]
    public string Ip { get; set; }

    /// <summary>
    /// Gets or Sets CpuCount
    /// </summary>
    [DataMember(Name="cpu_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cpu_count")]
    public long? CpuCount { get; set; }

    /// <summary>
    /// Gets or Sets PhCpuCount
    /// </summary>
    [DataMember(Name="ph_cpu_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ph_cpu_count")]
    public long? PhCpuCount { get; set; }

    /// <summary>
    /// Gets or Sets OsArch
    /// </summary>
    [DataMember(Name="os_arch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "os_arch")]
    public string OsArch { get; set; }

    /// <summary>
    /// Gets or Sets OsFamily
    /// </summary>
    [DataMember(Name="os_family", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "os_family")]
    public string OsFamily { get; set; }

    /// <summary>
    /// Gets or Sets OsType
    /// </summary>
    [DataMember(Name="os_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "os_type")]
    public string OsType { get; set; }

    /// <summary>
    /// Gets or Sets TotalMem
    /// </summary>
    [DataMember(Name="total_mem", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_mem")]
    public long? TotalMem { get; set; }

    /// <summary>
    /// Gets or Sets DiskInfo
    /// </summary>
    [DataMember(Name="disk_info", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "disk_info")]
    public List<DiskInfo> DiskInfo { get; set; }

    /// <summary>
    /// Gets or Sets LastHeartbeatTime
    /// </summary>
    [DataMember(Name="last_heartbeat_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_heartbeat_time")]
    public long? LastHeartbeatTime { get; set; }

    /// <summary>
    /// Gets or Sets LastAgentEnv
    /// </summary>
    [DataMember(Name="last_agent_env", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_agent_env")]
    public AgentEnv LastAgentEnv { get; set; }

    /// <summary>
    /// Gets or Sets LastRegistrationTime
    /// </summary>
    [DataMember(Name="last_registration_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_registration_time")]
    public long? LastRegistrationTime { get; set; }

    /// <summary>
    /// Gets or Sets RackInfo
    /// </summary>
    [DataMember(Name="rack_info", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rack_info")]
    public string RackInfo { get; set; }

    /// <summary>
    /// Gets or Sets RecoveryReport
    /// </summary>
    [DataMember(Name="recovery_report", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recovery_report")]
    public RecoveryReport RecoveryReport { get; set; }

    /// <summary>
    /// Gets or Sets RecoverySummary
    /// </summary>
    [DataMember(Name="recovery_summary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recovery_summary")]
    public string RecoverySummary { get; set; }

    /// <summary>
    /// Gets or Sets HostState
    /// </summary>
    [DataMember(Name="host_state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "host_state")]
    public string HostState { get; set; }

    /// <summary>
    /// Gets or Sets DesiredConfigs
    /// </summary>
    [DataMember(Name="desired_configs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "desired_configs")]
    public Dictionary<string, HostConfig> DesiredConfigs { get; set; }

    /// <summary>
    /// Gets or Sets HostStatus
    /// </summary>
    [DataMember(Name="host_status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "host_status")]
    public string HostStatus { get; set; }

    /// <summary>
    /// Gets or Sets MaintenanceState
    /// </summary>
    [DataMember(Name="maintenance_state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maintenance_state")]
    public string MaintenanceState { get; set; }

    /// <summary>
    /// Gets or Sets HostHealthReport
    /// </summary>
    [DataMember(Name="host_health_report", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "host_health_report")]
    public string HostHealthReport { get; set; }

    /// <summary>
    /// Gets or Sets PublicHostName
    /// </summary>
    [DataMember(Name="public_host_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "public_host_name")]
    public string PublicHostName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class HostResponse {\n");
      sb.Append("  HostName: ").Append(HostName).Append("\n");
      sb.Append("  ClusterName: ").Append(ClusterName).Append("\n");
      sb.Append("  Ip: ").Append(Ip).Append("\n");
      sb.Append("  CpuCount: ").Append(CpuCount).Append("\n");
      sb.Append("  PhCpuCount: ").Append(PhCpuCount).Append("\n");
      sb.Append("  OsArch: ").Append(OsArch).Append("\n");
      sb.Append("  OsFamily: ").Append(OsFamily).Append("\n");
      sb.Append("  OsType: ").Append(OsType).Append("\n");
      sb.Append("  TotalMem: ").Append(TotalMem).Append("\n");
      sb.Append("  DiskInfo: ").Append(DiskInfo).Append("\n");
      sb.Append("  LastHeartbeatTime: ").Append(LastHeartbeatTime).Append("\n");
      sb.Append("  LastAgentEnv: ").Append(LastAgentEnv).Append("\n");
      sb.Append("  LastRegistrationTime: ").Append(LastRegistrationTime).Append("\n");
      sb.Append("  RackInfo: ").Append(RackInfo).Append("\n");
      sb.Append("  RecoveryReport: ").Append(RecoveryReport).Append("\n");
      sb.Append("  RecoverySummary: ").Append(RecoverySummary).Append("\n");
      sb.Append("  HostState: ").Append(HostState).Append("\n");
      sb.Append("  DesiredConfigs: ").Append(DesiredConfigs).Append("\n");
      sb.Append("  HostStatus: ").Append(HostStatus).Append("\n");
      sb.Append("  MaintenanceState: ").Append(MaintenanceState).Append("\n");
      sb.Append("  HostHealthReport: ").Append(HostHealthReport).Append("\n");
      sb.Append("  PublicHostName: ").Append(PublicHostName).Append("\n");
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
