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
  public class ExistingUser {
    /// <summary>
    /// Gets or Sets UserName
    /// </summary>
    [DataMember(Name="userName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userName")]
    public string UserName { get; set; }

    /// <summary>
    /// Gets or Sets UserStatus
    /// </summary>
    [DataMember(Name="userStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userStatus")]
    public string UserStatus { get; set; }

    /// <summary>
    /// Gets or Sets UserHomeDir
    /// </summary>
    [DataMember(Name="userHomeDir", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userHomeDir")]
    public string UserHomeDir { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets HomeDir
    /// </summary>
    [DataMember(Name="homeDir", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "homeDir")]
    public string HomeDir { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ExistingUser {\n");
      sb.Append("  UserName: ").Append(UserName).Append("\n");
      sb.Append("  UserStatus: ").Append(UserStatus).Append("\n");
      sb.Append("  UserHomeDir: ").Append(UserHomeDir).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  HomeDir: ").Append(HomeDir).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
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
