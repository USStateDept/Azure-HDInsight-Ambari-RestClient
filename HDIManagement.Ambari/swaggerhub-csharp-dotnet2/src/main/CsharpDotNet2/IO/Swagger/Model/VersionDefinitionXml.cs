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
  public class VersionDefinitionXml {
    /// <summary>
    /// Gets or Sets Release
    /// </summary>
    [DataMember(Name="release", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "release")]
    public Release Release { get; set; }

    /// <summary>
    /// Gets or Sets RepositoryInfo
    /// </summary>
    [DataMember(Name="repositoryInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repositoryInfo")]
    public RepositoryXml RepositoryInfo { get; set; }

    /// <summary>
    /// Gets or Sets XsdLocation
    /// </summary>
    [DataMember(Name="xsdLocation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "xsdLocation")]
    public string XsdLocation { get; set; }

    /// <summary>
    /// Gets or Sets StackDefault
    /// </summary>
    [DataMember(Name="stackDefault", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stackDefault")]
    public bool? StackDefault { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VersionDefinitionXml {\n");
      sb.Append("  Release: ").Append(Release).Append("\n");
      sb.Append("  RepositoryInfo: ").Append(RepositoryInfo).Append("\n");
      sb.Append("  XsdLocation: ").Append(XsdLocation).Append("\n");
      sb.Append("  StackDefault: ").Append(StackDefault).Append("\n");
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
