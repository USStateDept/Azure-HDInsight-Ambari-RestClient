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
  public class ViewPrivilegeResponse {
    /// <summary>
    /// Gets or Sets PermissionLabel
    /// </summary>
    [DataMember(Name="permission_label", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "permission_label")]
    public string PermissionLabel { get; set; }

    /// <summary>
    /// Gets or Sets PrivilegeId
    /// </summary>
    [DataMember(Name="privilege_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "privilege_id")]
    public int? PrivilegeId { get; set; }

    /// <summary>
    /// Gets or Sets PermissionName
    /// </summary>
    [DataMember(Name="permission_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "permission_name")]
    public string PermissionName { get; set; }

    /// <summary>
    /// Gets or Sets PrincipalType
    /// </summary>
    [DataMember(Name="principal_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "principal_type")]
    public string PrincipalType { get; set; }

    /// <summary>
    /// Gets or Sets PrincipalName
    /// </summary>
    [DataMember(Name="principal_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "principal_name")]
    public string PrincipalName { get; set; }

    /// <summary>
    /// Gets or Sets ViewName
    /// </summary>
    [DataMember(Name="view_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "view_name")]
    public string ViewName { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public string Version { get; set; }

    /// <summary>
    /// Gets or Sets InstanceName
    /// </summary>
    [DataMember(Name="instance_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "instance_name")]
    public string InstanceName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ViewPrivilegeResponse {\n");
      sb.Append("  PermissionLabel: ").Append(PermissionLabel).Append("\n");
      sb.Append("  PrivilegeId: ").Append(PrivilegeId).Append("\n");
      sb.Append("  PermissionName: ").Append(PermissionName).Append("\n");
      sb.Append("  PrincipalType: ").Append(PrincipalType).Append("\n");
      sb.Append("  PrincipalName: ").Append(PrincipalName).Append("\n");
      sb.Append("  ViewName: ").Append(ViewName).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  InstanceName: ").Append(InstanceName).Append("\n");
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
