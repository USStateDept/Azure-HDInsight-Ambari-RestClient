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
  public class Os {
    /// <summary>
    /// Gets or Sets Family
    /// </summary>
    [DataMember(Name="family", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "family")]
    public string Family { get; set; }

    /// <summary>
    /// Gets or Sets PackageVersion
    /// </summary>
    [DataMember(Name="packageVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "packageVersion")]
    public string PackageVersion { get; set; }

    /// <summary>
    /// Gets or Sets Repos
    /// </summary>
    [DataMember(Name="repos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repos")]
    public List<Repo> Repos { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Os {\n");
      sb.Append("  Family: ").Append(Family).Append("\n");
      sb.Append("  PackageVersion: ").Append(PackageVersion).Append("\n");
      sb.Append("  Repos: ").Append(Repos).Append("\n");
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
