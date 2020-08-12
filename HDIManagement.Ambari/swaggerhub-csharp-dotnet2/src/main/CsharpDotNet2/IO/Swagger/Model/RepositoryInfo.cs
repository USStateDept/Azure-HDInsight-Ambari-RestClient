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
  public class RepositoryInfo {
    /// <summary>
    /// Gets or Sets BaseUrl
    /// </summary>
    [DataMember(Name="baseUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "baseUrl")]
    public string BaseUrl { get; set; }

    /// <summary>
    /// Gets or Sets OsType
    /// </summary>
    [DataMember(Name="osType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "osType")]
    public string OsType { get; set; }

    /// <summary>
    /// Gets or Sets RepoId
    /// </summary>
    [DataMember(Name="repoId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repoId")]
    public string RepoId { get; set; }

    /// <summary>
    /// Gets or Sets RepoName
    /// </summary>
    [DataMember(Name="repoName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repoName")]
    public string RepoName { get; set; }

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
    /// Gets or Sets MirrorsList
    /// </summary>
    [DataMember(Name="mirrorsList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mirrorsList")]
    public string MirrorsList { get; set; }

    /// <summary>
    /// Gets or Sets DefaultBaseUrl
    /// </summary>
    [DataMember(Name="defaultBaseUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultBaseUrl")]
    public string DefaultBaseUrl { get; set; }

    /// <summary>
    /// Gets or Sets RepoSaved
    /// </summary>
    [DataMember(Name="repoSaved", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repoSaved")]
    public bool? RepoSaved { get; set; }

    /// <summary>
    /// Gets or Sets Unique
    /// </summary>
    [DataMember(Name="unique", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unique")]
    public bool? Unique { get; set; }

    /// <summary>
    /// Gets or Sets AmbariManagedRepositories
    /// </summary>
    [DataMember(Name="ambariManagedRepositories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ambariManagedRepositories")]
    public bool? AmbariManagedRepositories { get; set; }

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
      sb.Append("class RepositoryInfo {\n");
      sb.Append("  BaseUrl: ").Append(BaseUrl).Append("\n");
      sb.Append("  OsType: ").Append(OsType).Append("\n");
      sb.Append("  RepoId: ").Append(RepoId).Append("\n");
      sb.Append("  RepoName: ").Append(RepoName).Append("\n");
      sb.Append("  Distribution: ").Append(Distribution).Append("\n");
      sb.Append("  Components: ").Append(Components).Append("\n");
      sb.Append("  MirrorsList: ").Append(MirrorsList).Append("\n");
      sb.Append("  DefaultBaseUrl: ").Append(DefaultBaseUrl).Append("\n");
      sb.Append("  RepoSaved: ").Append(RepoSaved).Append("\n");
      sb.Append("  Unique: ").Append(Unique).Append("\n");
      sb.Append("  AmbariManagedRepositories: ").Append(AmbariManagedRepositories).Append("\n");
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
