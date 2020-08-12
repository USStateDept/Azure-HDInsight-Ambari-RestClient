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
  public class ClusterResponse {
    /// <summary>
    /// Gets or Sets ClusterId
    /// </summary>
    [DataMember(Name="cluster_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cluster_id")]
    public long? ClusterId { get; set; }

    /// <summary>
    /// Gets or Sets ClusterName
    /// </summary>
    [DataMember(Name="cluster_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cluster_name")]
    public string ClusterName { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public string Version { get; set; }

    /// <summary>
    /// Gets or Sets ProvisioningState
    /// </summary>
    [DataMember(Name="provisioning_state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "provisioning_state")]
    public string ProvisioningState { get; set; }

    /// <summary>
    /// Gets or Sets SecurityType
    /// </summary>
    [DataMember(Name="security_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "security_type")]
    public string SecurityType { get; set; }

    /// <summary>
    /// Gets or Sets TotalHosts
    /// </summary>
    [DataMember(Name="total_hosts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_hosts")]
    public int? TotalHosts { get; set; }

    /// <summary>
    /// Gets or Sets DesiredConfigs
    /// </summary>
    [DataMember(Name="desired_configs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "desired_configs")]
    public Dictionary<string, DesiredConfig> DesiredConfigs { get; set; }

    /// <summary>
    /// Gets or Sets DesiredServiceConfigVersions
    /// </summary>
    [DataMember(Name="desired_service_config_versions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "desired_service_config_versions")]
    public Dictionary<string, List<ServiceConfigVersionResponse>> DesiredServiceConfigVersions { get; set; }

    /// <summary>
    /// Gets or Sets HealthReport
    /// </summary>
    [DataMember(Name="health_report", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "health_report")]
    public ClusterHealthReport HealthReport { get; set; }

    /// <summary>
    /// Gets or Sets CredentialStoreProperties
    /// </summary>
    [DataMember(Name="credential_store_properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "credential_store_properties")]
    public Dictionary<string, string> CredentialStoreProperties { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ClusterResponse {\n");
      sb.Append("  ClusterId: ").Append(ClusterId).Append("\n");
      sb.Append("  ClusterName: ").Append(ClusterName).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  ProvisioningState: ").Append(ProvisioningState).Append("\n");
      sb.Append("  SecurityType: ").Append(SecurityType).Append("\n");
      sb.Append("  TotalHosts: ").Append(TotalHosts).Append("\n");
      sb.Append("  DesiredConfigs: ").Append(DesiredConfigs).Append("\n");
      sb.Append("  DesiredServiceConfigVersions: ").Append(DesiredServiceConfigVersions).Append("\n");
      sb.Append("  HealthReport: ").Append(HealthReport).Append("\n");
      sb.Append("  CredentialStoreProperties: ").Append(CredentialStoreProperties).Append("\n");
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
