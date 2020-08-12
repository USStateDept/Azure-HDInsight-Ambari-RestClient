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
  public class UserAuthenticationSourceResponse {
    /// <summary>
    /// Gets or Sets UserName
    /// </summary>
    [DataMember(Name="user_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_name")]
    public string UserName { get; set; }

    /// <summary>
    /// Gets or Sets SourceId
    /// </summary>
    [DataMember(Name="source_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source_id")]
    public long? SourceId { get; set; }

    /// <summary>
    /// Gets or Sets AuthenticationType
    /// </summary>
    [DataMember(Name="authentication_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authentication_type")]
    public string AuthenticationType { get; set; }

    /// <summary>
    /// Gets or Sets Key
    /// </summary>
    [DataMember(Name="key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "key")]
    public string Key { get; set; }

    /// <summary>
    /// Gets or Sets Created
    /// </summary>
    [DataMember(Name="created", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created")]
    public DateTime? Created { get; set; }

    /// <summary>
    /// Gets or Sets Updated
    /// </summary>
    [DataMember(Name="updated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated")]
    public DateTime? Updated { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserAuthenticationSourceResponse {\n");
      sb.Append("  UserName: ").Append(UserName).Append("\n");
      sb.Append("  SourceId: ").Append(SourceId).Append("\n");
      sb.Append("  AuthenticationType: ").Append(AuthenticationType).Append("\n");
      sb.Append("  Key: ").Append(Key).Append("\n");
      sb.Append("  Created: ").Append(Created).Append("\n");
      sb.Append("  Updated: ").Append(Updated).Append("\n");
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
