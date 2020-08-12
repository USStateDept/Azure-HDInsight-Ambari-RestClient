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
  public class ServiceResponse {
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
    /// Gets or Sets DesiredRepositoryVersion
    /// </summary>
    [DataMember(Name="desiredRepositoryVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "desiredRepositoryVersion")]
    public string DesiredRepositoryVersion { get; set; }

    /// <summary>
    /// Gets or Sets DesiredRepositoryVersionId
    /// </summary>
    [DataMember(Name="desiredRepositoryVersionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "desiredRepositoryVersionId")]
    public long? DesiredRepositoryVersionId { get; set; }

    /// <summary>
    /// Gets or Sets RepositoryVersionState
    /// </summary>
    [DataMember(Name="repositoryVersionState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repositoryVersionState")]
    public string RepositoryVersionState { get; set; }

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
    /// Gets or Sets CredentialStoreSupported
    /// </summary>
    [DataMember(Name="credential_store_supported", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "credential_store_supported")]
    public bool? CredentialStoreSupported { get; set; }

    /// <summary>
    /// Gets or Sets CredentialStoreEnabled
    /// </summary>
    [DataMember(Name="credential_store_enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "credential_store_enabled")]
    public bool? CredentialStoreEnabled { get; set; }

    /// <summary>
    /// Gets or Sets SsoIntegrationSupported
    /// </summary>
    [DataMember(Name="sso_integration_supported", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sso_integration_supported")]
    public bool? SsoIntegrationSupported { get; set; }

    /// <summary>
    /// Gets or Sets SsoIntegrationDesired
    /// </summary>
    [DataMember(Name="sso_integration_desired", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sso_integration_desired")]
    public bool? SsoIntegrationDesired { get; set; }

    /// <summary>
    /// Gets or Sets SsoIntegrationEnabled
    /// </summary>
    [DataMember(Name="sso_integration_enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sso_integration_enabled")]
    public bool? SsoIntegrationEnabled { get; set; }

    /// <summary>
    /// Gets or Sets SsoIntegrationRequiresKerberos
    /// </summary>
    [DataMember(Name="sso_integration_requires_kerberos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sso_integration_requires_kerberos")]
    public bool? SsoIntegrationRequiresKerberos { get; set; }

    /// <summary>
    /// Gets or Sets KerberosEnabled
    /// </summary>
    [DataMember(Name="kerberos_enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kerberos_enabled")]
    public bool? KerberosEnabled { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServiceResponse {\n");
      sb.Append("  ClusterName: ").Append(ClusterName).Append("\n");
      sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
      sb.Append("  DesiredRepositoryVersion: ").Append(DesiredRepositoryVersion).Append("\n");
      sb.Append("  DesiredRepositoryVersionId: ").Append(DesiredRepositoryVersionId).Append("\n");
      sb.Append("  RepositoryVersionState: ").Append(RepositoryVersionState).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  MaintenanceState: ").Append(MaintenanceState).Append("\n");
      sb.Append("  CredentialStoreSupported: ").Append(CredentialStoreSupported).Append("\n");
      sb.Append("  CredentialStoreEnabled: ").Append(CredentialStoreEnabled).Append("\n");
      sb.Append("  SsoIntegrationSupported: ").Append(SsoIntegrationSupported).Append("\n");
      sb.Append("  SsoIntegrationDesired: ").Append(SsoIntegrationDesired).Append("\n");
      sb.Append("  SsoIntegrationEnabled: ").Append(SsoIntegrationEnabled).Append("\n");
      sb.Append("  SsoIntegrationRequiresKerberos: ").Append(SsoIntegrationRequiresKerberos).Append("\n");
      sb.Append("  KerberosEnabled: ").Append(KerberosEnabled).Append("\n");
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
