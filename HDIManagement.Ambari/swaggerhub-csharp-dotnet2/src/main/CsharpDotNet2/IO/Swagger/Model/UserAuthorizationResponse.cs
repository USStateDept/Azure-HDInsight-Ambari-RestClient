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
  public class UserAuthorizationResponse {
    /// <summary>
    /// Gets or Sets AuthorizationInfoauthorizationId
    /// </summary>
    [DataMember(Name="AuthorizationInfo/authorization_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AuthorizationInfo/authorization_id")]
    public string AuthorizationInfoauthorizationId { get; set; }

    /// <summary>
    /// Gets or Sets AuthorizationInfoauthorizationName
    /// </summary>
    [DataMember(Name="AuthorizationInfo/authorization_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AuthorizationInfo/authorization_name")]
    public string AuthorizationInfoauthorizationName { get; set; }

    /// <summary>
    /// Gets or Sets AuthorizationInforesourceType
    /// </summary>
    [DataMember(Name="AuthorizationInfo/resource_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AuthorizationInfo/resource_type")]
    public string AuthorizationInforesourceType { get; set; }

    /// <summary>
    /// Gets or Sets AuthorizationInfouserName
    /// </summary>
    [DataMember(Name="AuthorizationInfo/user_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AuthorizationInfo/user_name")]
    public string AuthorizationInfouserName { get; set; }

    /// <summary>
    /// Gets or Sets AuthorizationInfoclusterName
    /// </summary>
    [DataMember(Name="AuthorizationInfo/cluster_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AuthorizationInfo/cluster_name")]
    public string AuthorizationInfoclusterName { get; set; }

    /// <summary>
    /// Gets or Sets AuthorizationInfoviewName
    /// </summary>
    [DataMember(Name="AuthorizationInfo/view_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AuthorizationInfo/view_name")]
    public string AuthorizationInfoviewName { get; set; }

    /// <summary>
    /// Gets or Sets AuthorizationInfoviewVersion
    /// </summary>
    [DataMember(Name="AuthorizationInfo/view_version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AuthorizationInfo/view_version")]
    public string AuthorizationInfoviewVersion { get; set; }

    /// <summary>
    /// Gets or Sets AuthorizationInfoviewInstanceName
    /// </summary>
    [DataMember(Name="AuthorizationInfo/view_instance_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AuthorizationInfo/view_instance_name")]
    public string AuthorizationInfoviewInstanceName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserAuthorizationResponse {\n");
      sb.Append("  AuthorizationInfoauthorizationId: ").Append(AuthorizationInfoauthorizationId).Append("\n");
      sb.Append("  AuthorizationInfoauthorizationName: ").Append(AuthorizationInfoauthorizationName).Append("\n");
      sb.Append("  AuthorizationInforesourceType: ").Append(AuthorizationInforesourceType).Append("\n");
      sb.Append("  AuthorizationInfouserName: ").Append(AuthorizationInfouserName).Append("\n");
      sb.Append("  AuthorizationInfoclusterName: ").Append(AuthorizationInfoclusterName).Append("\n");
      sb.Append("  AuthorizationInfoviewName: ").Append(AuthorizationInfoviewName).Append("\n");
      sb.Append("  AuthorizationInfoviewVersion: ").Append(AuthorizationInfoviewVersion).Append("\n");
      sb.Append("  AuthorizationInfoviewInstanceName: ").Append(AuthorizationInfoviewInstanceName).Append("\n");
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
