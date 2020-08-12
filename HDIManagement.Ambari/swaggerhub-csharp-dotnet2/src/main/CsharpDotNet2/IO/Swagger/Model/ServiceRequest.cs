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
  public class ServiceRequest {
    /// <summary>
    /// Gets or Sets ClusterName
    /// </summary>
    [DataMember(Name="cluster_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cluster_name")]
    public string ClusterName { get; set; }

    /// <summary>
    /// Gets or Sets ServiceName
    /// </summary>
    [DataMember(Name="service_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service_name")]
    public string ServiceName { get; set; }

    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// Gets or Sets MaintenanceState
    /// </summary>
    [DataMember(Name="maintenance_state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maintenance_state")]
    public string MaintenanceState { get; set; }

    /// <summary>
    /// Gets or Sets CredentialStoreEnabled
    /// </summary>
    [DataMember(Name="credential_store_enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "credential_store_enabled")]
    public string CredentialStoreEnabled { get; set; }

    /// <summary>
    /// Gets or Sets CredentialStoreSupporteds
    /// </summary>
    [DataMember(Name="credential_store_supporteds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "credential_store_supporteds")]
    public string CredentialStoreSupporteds { get; set; }

    /// <summary>
    /// Gets or Sets DesiredRepositoryVersionId
    /// </summary>
    [DataMember(Name="desiredRepositoryVersionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "desiredRepositoryVersionId")]
    public long? DesiredRepositoryVersionId { get; set; }

    /// <summary>
    /// Gets or Sets ResolvedRepository
    /// </summary>
    [DataMember(Name="resolvedRepository", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resolvedRepository")]
    public RepositoryVersionEntity ResolvedRepository { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServiceRequest {\n");
      sb.Append("  ClusterName: ").Append(ClusterName).Append("\n");
      sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  MaintenanceState: ").Append(MaintenanceState).Append("\n");
      sb.Append("  CredentialStoreEnabled: ").Append(CredentialStoreEnabled).Append("\n");
      sb.Append("  CredentialStoreSupporteds: ").Append(CredentialStoreSupporteds).Append("\n");
      sb.Append("  DesiredRepositoryVersionId: ").Append(DesiredRepositoryVersionId).Append("\n");
      sb.Append("  ResolvedRepository: ").Append(ResolvedRepository).Append("\n");
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
