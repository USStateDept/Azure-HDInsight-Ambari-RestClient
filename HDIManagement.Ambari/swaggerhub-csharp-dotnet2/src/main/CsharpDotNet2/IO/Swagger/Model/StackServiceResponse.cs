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
  public class StackServiceResponse {
    /// <summary>
    /// Gets or Sets StackName
    /// </summary>
    [DataMember(Name="stack_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stack_name")]
    public string StackName { get; set; }

    /// <summary>
    /// Gets or Sets StackVersion
    /// </summary>
    [DataMember(Name="stack_version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stack_version")]
    public string StackVersion { get; set; }

    /// <summary>
    /// Gets or Sets ServiceName
    /// </summary>
    [DataMember(Name="service_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service_name")]
    public string ServiceName { get; set; }

    /// <summary>
    /// Gets or Sets ServiceType
    /// </summary>
    [DataMember(Name="service_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service_type")]
    public string ServiceType { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name="display_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "display_name")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or Sets UserName
    /// </summary>
    [DataMember(Name="user_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_name")]
    public string UserName { get; set; }

    /// <summary>
    /// Gets or Sets Comments
    /// </summary>
    [DataMember(Name="comments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comments")]
    public string Comments { get; set; }

    /// <summary>
    /// Gets or Sets ServiceVersion
    /// </summary>
    [DataMember(Name="service_version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service_version")]
    public string ServiceVersion { get; set; }

    /// <summary>
    /// Gets or Sets Selection
    /// </summary>
    [DataMember(Name="selection", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "selection")]
    public string Selection { get; set; }

    /// <summary>
    /// Gets or Sets ServiceCheckSupported
    /// </summary>
    [DataMember(Name="service_check_supported", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service_check_supported")]
    public bool? ServiceCheckSupported { get; set; }

    /// <summary>
    /// Gets or Sets CustomCommands
    /// </summary>
    [DataMember(Name="custom_commands", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "custom_commands")]
    public List<string> CustomCommands { get; set; }

    /// <summary>
    /// Gets or Sets ConfigTypes
    /// </summary>
    [DataMember(Name="config_types", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "config_types")]
    public Dictionary<string, Dictionary<string, Dictionary<string, string>>> ConfigTypes { get; set; }

    /// <summary>
    /// Gets or Sets RequiredServices
    /// </summary>
    [DataMember(Name="required_services", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required_services")]
    public List<string> RequiredServices { get; set; }

    /// <summary>
    /// Gets or Sets Properties
    /// </summary>
    [DataMember(Name="properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "properties")]
    public Dictionary<string, string> Properties { get; set; }

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
    /// Gets or Sets CredentialStoreRequired
    /// </summary>
    [DataMember(Name="credential_store_required", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "credential_store_required")]
    public bool? CredentialStoreRequired { get; set; }

    /// <summary>
    /// Gets or Sets SsoIntegrationSupported
    /// </summary>
    [DataMember(Name="sso_integration_supported", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sso_integration_supported")]
    public bool? SsoIntegrationSupported { get; set; }

    /// <summary>
    /// Gets or Sets SsoIntegrationRequiresKerberos
    /// </summary>
    [DataMember(Name="sso_integration_requires_kerberos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sso_integration_requires_kerberos")]
    public bool? SsoIntegrationRequiresKerberos { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StackServiceResponse {\n");
      sb.Append("  StackName: ").Append(StackName).Append("\n");
      sb.Append("  StackVersion: ").Append(StackVersion).Append("\n");
      sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
      sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  UserName: ").Append(UserName).Append("\n");
      sb.Append("  Comments: ").Append(Comments).Append("\n");
      sb.Append("  ServiceVersion: ").Append(ServiceVersion).Append("\n");
      sb.Append("  Selection: ").Append(Selection).Append("\n");
      sb.Append("  ServiceCheckSupported: ").Append(ServiceCheckSupported).Append("\n");
      sb.Append("  CustomCommands: ").Append(CustomCommands).Append("\n");
      sb.Append("  ConfigTypes: ").Append(ConfigTypes).Append("\n");
      sb.Append("  RequiredServices: ").Append(RequiredServices).Append("\n");
      sb.Append("  Properties: ").Append(Properties).Append("\n");
      sb.Append("  CredentialStoreSupported: ").Append(CredentialStoreSupported).Append("\n");
      sb.Append("  CredentialStoreEnabled: ").Append(CredentialStoreEnabled).Append("\n");
      sb.Append("  CredentialStoreRequired: ").Append(CredentialStoreRequired).Append("\n");
      sb.Append("  SsoIntegrationSupported: ").Append(SsoIntegrationSupported).Append("\n");
      sb.Append("  SsoIntegrationRequiresKerberos: ").Append(SsoIntegrationRequiresKerberos).Append("\n");
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
