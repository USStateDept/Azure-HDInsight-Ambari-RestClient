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
  public class AgentEnv {
    /// <summary>
    /// Gets or Sets StackFoldersAndFiles
    /// </summary>
    [DataMember(Name="stackFoldersAndFiles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stackFoldersAndFiles")]
    public List<Directory> StackFoldersAndFiles { get; set; }

    /// <summary>
    /// Gets or Sets Alternatives
    /// </summary>
    [DataMember(Name="alternatives", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alternatives")]
    public List<Alternative> Alternatives { get; set; }

    /// <summary>
    /// Gets or Sets ExistingUsers
    /// </summary>
    [DataMember(Name="existingUsers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "existingUsers")]
    public List<ExistingUser> ExistingUsers { get; set; }

    /// <summary>
    /// Gets or Sets ExistingRepos
    /// </summary>
    [DataMember(Name="existingRepos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "existingRepos")]
    public List<string> ExistingRepos { get; set; }

    /// <summary>
    /// Gets or Sets InstalledPackages
    /// </summary>
    [DataMember(Name="installedPackages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "installedPackages")]
    public List<PackageDetail> InstalledPackages { get; set; }

    /// <summary>
    /// Gets or Sets HostHealth
    /// </summary>
    [DataMember(Name="hostHealth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hostHealth")]
    public HostHealth HostHealth { get; set; }

    /// <summary>
    /// Gets or Sets Umask
    /// </summary>
    [DataMember(Name="umask", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "umask")]
    public int? Umask { get; set; }

    /// <summary>
    /// Gets or Sets TransparentHugePage
    /// </summary>
    [DataMember(Name="transparentHugePage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transparentHugePage")]
    public string TransparentHugePage { get; set; }

    /// <summary>
    /// Gets or Sets FirewallRunning
    /// </summary>
    [DataMember(Name="firewallRunning", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firewallRunning")]
    public bool? FirewallRunning { get; set; }

    /// <summary>
    /// Gets or Sets FirewallName
    /// </summary>
    [DataMember(Name="firewallName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firewallName")]
    public string FirewallName { get; set; }

    /// <summary>
    /// Gets or Sets HasUnlimitedJcePolicy
    /// </summary>
    [DataMember(Name="hasUnlimitedJcePolicy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hasUnlimitedJcePolicy")]
    public bool? HasUnlimitedJcePolicy { get; set; }

    /// <summary>
    /// Gets or Sets ReverseLookup
    /// </summary>
    [DataMember(Name="reverseLookup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reverseLookup")]
    public bool? ReverseLookup { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AgentEnv {\n");
      sb.Append("  StackFoldersAndFiles: ").Append(StackFoldersAndFiles).Append("\n");
      sb.Append("  Alternatives: ").Append(Alternatives).Append("\n");
      sb.Append("  ExistingUsers: ").Append(ExistingUsers).Append("\n");
      sb.Append("  ExistingRepos: ").Append(ExistingRepos).Append("\n");
      sb.Append("  InstalledPackages: ").Append(InstalledPackages).Append("\n");
      sb.Append("  HostHealth: ").Append(HostHealth).Append("\n");
      sb.Append("  Umask: ").Append(Umask).Append("\n");
      sb.Append("  TransparentHugePage: ").Append(TransparentHugePage).Append("\n");
      sb.Append("  FirewallRunning: ").Append(FirewallRunning).Append("\n");
      sb.Append("  FirewallName: ").Append(FirewallName).Append("\n");
      sb.Append("  HasUnlimitedJcePolicy: ").Append(HasUnlimitedJcePolicy).Append("\n");
      sb.Append("  ReverseLookup: ").Append(ReverseLookup).Append("\n");
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
