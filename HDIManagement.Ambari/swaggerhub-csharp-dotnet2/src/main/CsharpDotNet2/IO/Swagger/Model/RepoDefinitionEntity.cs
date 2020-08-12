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
  public class RepoDefinitionEntity {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Gets or Sets RepoOs
    /// </summary>
    [DataMember(Name="repoOs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repoOs")]
    public RepoOsEntity RepoOs { get; set; }

    /// <summary>
    /// Gets or Sets RepoName
    /// </summary>
    [DataMember(Name="repoName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repoName")]
    public string RepoName { get; set; }

    /// <summary>
    /// Gets or Sets RepoID
    /// </summary>
    [DataMember(Name="repoID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repoID")]
    public string RepoID { get; set; }

    /// <summary>
    /// Gets or Sets BaseUrl
    /// </summary>
    [DataMember(Name="baseUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "baseUrl")]
    public string BaseUrl { get; set; }

    /// <summary>
    /// Gets or Sets Mirrors
    /// </summary>
    [DataMember(Name="mirrors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mirrors")]
    public string Mirrors { get; set; }

    /// <summary>
    /// Gets or Sets Distribution
    /// </summary>
    [DataMember(Name="distribution", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "distribution")]
    public string Distribution { get; set; }

    /// <summary>
    /// Gets or Sets Components
    /// </summary>
    [DataMember(Name="components", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "components")]
    public string Components { get; set; }

    /// <summary>
    /// Gets or Sets Unique
    /// </summary>
    [DataMember(Name="unique", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unique")]
    public bool? Unique { get; set; }

    /// <summary>
    /// Gets or Sets ApplicableServices
    /// </summary>
    [DataMember(Name="applicableServices", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "applicableServices")]
    public List<string> ApplicableServices { get; set; }

    /// <summary>
    /// Gets or Sets Tags
    /// </summary>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<string> Tags { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RepoDefinitionEntity {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  RepoOs: ").Append(RepoOs).Append("\n");
      sb.Append("  RepoName: ").Append(RepoName).Append("\n");
      sb.Append("  RepoID: ").Append(RepoID).Append("\n");
      sb.Append("  BaseUrl: ").Append(BaseUrl).Append("\n");
      sb.Append("  Mirrors: ").Append(Mirrors).Append("\n");
      sb.Append("  Distribution: ").Append(Distribution).Append("\n");
      sb.Append("  Components: ").Append(Components).Append("\n");
      sb.Append("  Unique: ").Append(Unique).Append("\n");
      sb.Append("  ApplicableServices: ").Append(ApplicableServices).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
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
