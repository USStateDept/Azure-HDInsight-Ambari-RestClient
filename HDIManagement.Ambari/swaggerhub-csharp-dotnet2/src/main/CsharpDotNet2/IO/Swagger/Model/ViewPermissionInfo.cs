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
  public class ViewPermissionInfo {
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
    /// Gets or Sets PermissionId
    /// </summary>
    [DataMember(Name="permission_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "permission_id")]
    public int? PermissionId { get; set; }

    /// <summary>
    /// Gets or Sets PermissionName
    /// </summary>
    [DataMember(Name="permission_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "permission_name")]
    public string PermissionName { get; set; }

    /// <summary>
    /// Gets or Sets ResourceName
    /// </summary>
    [DataMember(Name="resource_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resource_name")]
    public string ResourceName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ViewPermissionInfo {\n");
      sb.Append("  ViewName: ").Append(ViewName).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  PermissionId: ").Append(PermissionId).Append("\n");
      sb.Append("  PermissionName: ").Append(PermissionName).Append("\n");
      sb.Append("  ResourceName: ").Append(ResourceName).Append("\n");
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
