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
  public class RepositoryXml {
    /// <summary>
    /// Gets or Sets Oses
    /// </summary>
    [DataMember(Name="oses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "oses")]
    public List<Os> Oses { get; set; }

    /// <summary>
    /// Gets or Sets Valid
    /// </summary>
    [DataMember(Name="valid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "valid")]
    public bool? Valid { get; set; }

    /// <summary>
    /// Gets or Sets Errors
    /// </summary>
    [DataMember(Name="errors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "errors")]
    public List<string> Errors { get; set; }

    /// <summary>
    /// Gets or Sets Repositories
    /// </summary>
    [DataMember(Name="repositories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repositories")]
    public List<RepositoryInfo> Repositories { get; set; }

    /// <summary>
    /// Gets or Sets LatestURI
    /// </summary>
    [DataMember(Name="latestURI", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latestURI")]
    public string LatestURI { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RepositoryXml {\n");
      sb.Append("  Oses: ").Append(Oses).Append("\n");
      sb.Append("  Valid: ").Append(Valid).Append("\n");
      sb.Append("  Errors: ").Append(Errors).Append("\n");
      sb.Append("  Repositories: ").Append(Repositories).Append("\n");
      sb.Append("  LatestURI: ").Append(LatestURI).Append("\n");
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
