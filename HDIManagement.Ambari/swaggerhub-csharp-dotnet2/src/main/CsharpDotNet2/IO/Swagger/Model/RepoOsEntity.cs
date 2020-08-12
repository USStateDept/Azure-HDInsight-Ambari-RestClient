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
  public class RepoOsEntity {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Gets or Sets Family
    /// </summary>
    [DataMember(Name="family", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "family")]
    public string Family { get; set; }

    /// <summary>
    /// Gets or Sets AmbariManaged
    /// </summary>
    [DataMember(Name="ambariManaged", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ambariManaged")]
    public bool? AmbariManaged { get; set; }

    /// <summary>
    /// Gets or Sets RepoDefinitionEntities
    /// </summary>
    [DataMember(Name="repoDefinitionEntities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repoDefinitionEntities")]
    public List<RepoDefinitionEntity> RepoDefinitionEntities { get; set; }

    /// <summary>
    /// Gets or Sets RepositoryVersionEntity
    /// </summary>
    [DataMember(Name="repositoryVersionEntity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repositoryVersionEntity")]
    public RepositoryVersionEntity RepositoryVersionEntity { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RepoOsEntity {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Family: ").Append(Family).Append("\n");
      sb.Append("  AmbariManaged: ").Append(AmbariManaged).Append("\n");
      sb.Append("  RepoDefinitionEntities: ").Append(RepoDefinitionEntities).Append("\n");
      sb.Append("  RepositoryVersionEntity: ").Append(RepositoryVersionEntity).Append("\n");
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
