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
  public class Release {
    /// <summary>
    /// Gets or Sets RepositoryType
    /// </summary>
    [DataMember(Name="repositoryType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repositoryType")]
    public string RepositoryType { get; set; }

    /// <summary>
    /// Gets or Sets StackId
    /// </summary>
    [DataMember(Name="stackId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stackId")]
    public string StackId { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public string Version { get; set; }

    /// <summary>
    /// Gets or Sets Build
    /// </summary>
    [DataMember(Name="build", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "build")]
    public string Build { get; set; }

    /// <summary>
    /// Gets or Sets CompatibleWith
    /// </summary>
    [DataMember(Name="compatibleWith", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "compatibleWith")]
    public string CompatibleWith { get; set; }

    /// <summary>
    /// Gets or Sets ReleaseNotes
    /// </summary>
    [DataMember(Name="releaseNotes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "releaseNotes")]
    public string ReleaseNotes { get; set; }

    /// <summary>
    /// Gets or Sets Display
    /// </summary>
    [DataMember(Name="display", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "display")]
    public string Display { get; set; }

    /// <summary>
    /// Gets or Sets FullVersion
    /// </summary>
    [DataMember(Name="fullVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fullVersion")]
    public string FullVersion { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Release {\n");
      sb.Append("  RepositoryType: ").Append(RepositoryType).Append("\n");
      sb.Append("  StackId: ").Append(StackId).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  Build: ").Append(Build).Append("\n");
      sb.Append("  CompatibleWith: ").Append(CompatibleWith).Append("\n");
      sb.Append("  ReleaseNotes: ").Append(ReleaseNotes).Append("\n");
      sb.Append("  Display: ").Append(Display).Append("\n");
      sb.Append("  FullVersion: ").Append(FullVersion).Append("\n");
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
