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
  public class RepositoryVersionEntity {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Gets or Sets Stack
    /// </summary>
    [DataMember(Name="stack", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stack")]
    public StackEntity Stack { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public string Version { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name="displayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or Sets RepoOsEntities
    /// </summary>
    [DataMember(Name="repoOsEntities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repoOsEntities")]
    public List<RepoOsEntity> RepoOsEntities { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets VersionXml
    /// </summary>
    [DataMember(Name="versionXml", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "versionXml")]
    public string VersionXml { get; set; }

    /// <summary>
    /// Gets or Sets VersionUrl
    /// </summary>
    [DataMember(Name="versionUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "versionUrl")]
    public string VersionUrl { get; set; }

    /// <summary>
    /// Gets or Sets VersionXsd
    /// </summary>
    [DataMember(Name="versionXsd", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "versionXsd")]
    public string VersionXsd { get; set; }

    /// <summary>
    /// Gets or Sets Resolved
    /// </summary>
    [DataMember(Name="resolved", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resolved")]
    public bool? Resolved { get; set; }

    /// <summary>
    /// Gets or Sets Children
    /// </summary>
    [DataMember(Name="children", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "children")]
    public List<RepositoryVersionEntity> Children { get; set; }

    /// <summary>
    /// Gets or Sets Hidden
    /// </summary>
    [DataMember(Name="hidden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hidden")]
    public bool? Hidden { get; set; }

    /// <summary>
    /// Gets or Sets StackVersion
    /// </summary>
    [DataMember(Name="stackVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stackVersion")]
    public string StackVersion { get; set; }

    /// <summary>
    /// Gets or Sets StackId
    /// </summary>
    [DataMember(Name="stackId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stackId")]
    public StackId StackId { get; set; }

    /// <summary>
    /// Gets or Sets StackName
    /// </summary>
    [DataMember(Name="stackName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stackName")]
    public string StackName { get; set; }

    /// <summary>
    /// Gets or Sets Legacy
    /// </summary>
    [DataMember(Name="legacy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "legacy")]
    public bool? Legacy { get; set; }

    /// <summary>
    /// Gets or Sets ParentId
    /// </summary>
    [DataMember(Name="parentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parentId")]
    public long? ParentId { get; set; }

    /// <summary>
    /// Gets or Sets RepositoryXml
    /// </summary>
    [DataMember(Name="repositoryXml", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repositoryXml")]
    public VersionDefinitionXml RepositoryXml { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RepositoryVersionEntity {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Stack: ").Append(Stack).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  RepoOsEntities: ").Append(RepoOsEntities).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  VersionXml: ").Append(VersionXml).Append("\n");
      sb.Append("  VersionUrl: ").Append(VersionUrl).Append("\n");
      sb.Append("  VersionXsd: ").Append(VersionXsd).Append("\n");
      sb.Append("  Resolved: ").Append(Resolved).Append("\n");
      sb.Append("  Children: ").Append(Children).Append("\n");
      sb.Append("  Hidden: ").Append(Hidden).Append("\n");
      sb.Append("  StackVersion: ").Append(StackVersion).Append("\n");
      sb.Append("  StackId: ").Append(StackId).Append("\n");
      sb.Append("  StackName: ").Append(StackName).Append("\n");
      sb.Append("  Legacy: ").Append(Legacy).Append("\n");
      sb.Append("  ParentId: ").Append(ParentId).Append("\n");
      sb.Append("  RepositoryXml: ").Append(RepositoryXml).Append("\n");
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
