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
  public class UserResponse {
    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name="display_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "display_name")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or Sets UserType
    /// </summary>
    [DataMember(Name="user_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_type")]
    public string UserType { get; set; }

    /// <summary>
    /// Gets or Sets Groups
    /// </summary>
    [DataMember(Name="groups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groups")]
    public List<string> Groups { get; set; }

    /// <summary>
    /// Gets or Sets Created
    /// </summary>
    [DataMember(Name="created", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    /// <summary>
    /// Gets or Sets ConsecutiveFailures
    /// </summary>
    [DataMember(Name="consecutive_failures", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "consecutive_failures")]
    public int? ConsecutiveFailures { get; set; }

    /// <summary>
    /// Gets or Sets Active
    /// </summary>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public bool? Active { get; set; }

    /// <summary>
    /// Gets or Sets UserName
    /// </summary>
    [DataMember(Name="user_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_name")]
    public string UserName { get; set; }

    /// <summary>
    /// Gets or Sets LdapUser
    /// </summary>
    [DataMember(Name="ldap_user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ldap_user")]
    public bool? LdapUser { get; set; }

    /// <summary>
    /// Gets or Sets Admin
    /// </summary>
    [DataMember(Name="admin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "admin")]
    public bool? Admin { get; set; }

    /// <summary>
    /// Gets or Sets LocalUserName
    /// </summary>
    [DataMember(Name="local_user_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "local_user_name")]
    public string LocalUserName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserResponse {\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  UserType: ").Append(UserType).Append("\n");
      sb.Append("  Groups: ").Append(Groups).Append("\n");
      sb.Append("  Created: ").Append(Created).Append("\n");
      sb.Append("  ConsecutiveFailures: ").Append(ConsecutiveFailures).Append("\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  UserName: ").Append(UserName).Append("\n");
      sb.Append("  LdapUser: ").Append(LdapUser).Append("\n");
      sb.Append("  Admin: ").Append(Admin).Append("\n");
      sb.Append("  LocalUserName: ").Append(LocalUserName).Append("\n");
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
