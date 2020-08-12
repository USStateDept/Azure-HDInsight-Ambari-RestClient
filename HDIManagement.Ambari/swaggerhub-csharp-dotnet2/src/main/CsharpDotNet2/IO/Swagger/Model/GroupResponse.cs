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
  public class GroupResponse {
    /// <summary>
    /// Gets or Sets GroupsgroupName
    /// </summary>
    [DataMember(Name="Groups/group_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Groups/group_name")]
    public string GroupsgroupName { get; set; }

    /// <summary>
    /// Gets or Sets GroupsldapGroup
    /// </summary>
    [DataMember(Name="Groups/ldap_group", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Groups/ldap_group")]
    public bool? GroupsldapGroup { get; set; }

    /// <summary>
    /// Gets or Sets GroupsgroupType
    /// </summary>
    [DataMember(Name="Groups/group_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Groups/group_type")]
    public string GroupsgroupType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GroupResponse {\n");
      sb.Append("  GroupsgroupName: ").Append(GroupsgroupName).Append("\n");
      sb.Append("  GroupsldapGroup: ").Append(GroupsldapGroup).Append("\n");
      sb.Append("  GroupsgroupType: ").Append(GroupsgroupType).Append("\n");
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
