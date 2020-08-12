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
  public class Artifacts {
    /// <summary>
    /// Gets or Sets StackVersion
    /// </summary>
    [DataMember(Name="stack_version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stack_version")]
    public string StackVersion { get; set; }

    /// <summary>
    /// Gets or Sets ServiceName
    /// </summary>
    [DataMember(Name="service_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service_name")]
    public string ServiceName { get; set; }

    /// <summary>
    /// Gets or Sets StackName
    /// </summary>
    [DataMember(Name="stack_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stack_name")]
    public string StackName { get; set; }

    /// <summary>
    /// Gets or Sets ArtifactName
    /// </summary>
    [DataMember(Name="artifact_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "artifact_name")]
    public string ArtifactName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Artifacts {\n");
      sb.Append("  StackVersion: ").Append(StackVersion).Append("\n");
      sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
      sb.Append("  StackName: ").Append(StackName).Append("\n");
      sb.Append("  ArtifactName: ").Append(ArtifactName).Append("\n");
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
