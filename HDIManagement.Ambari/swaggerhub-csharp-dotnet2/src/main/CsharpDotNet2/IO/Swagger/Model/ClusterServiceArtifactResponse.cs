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
  public class ClusterServiceArtifactResponse {
    /// <summary>
    /// Gets or Sets Artifacts
    /// </summary>
    [DataMember(Name="Artifacts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Artifacts")]
    public ClusterServiceArtifactResponseInfo Artifacts { get; set; }

    /// <summary>
    /// Gets or Sets ArtifactData
    /// </summary>
    [DataMember(Name="artifact_data", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "artifact_data")]
    public Dictionary<string, Object> ArtifactData { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ClusterServiceArtifactResponse {\n");
      sb.Append("  Artifacts: ").Append(Artifacts).Append("\n");
      sb.Append("  ArtifactData: ").Append(ArtifactData).Append("\n");
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
