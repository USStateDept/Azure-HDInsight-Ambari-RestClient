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
  public class ConfigCondition {
    /// <summary>
    /// Gets or Sets Configs
    /// </summary>
    [DataMember(Name="configs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "configs")]
    public List<string> Configs { get; set; }

    /// <summary>
    /// Gets or Sets Resource
    /// </summary>
    [DataMember(Name="resource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resource")]
    public string Resource { get; set; }

    /// <summary>
    /// Gets or Sets If
    /// </summary>
    [DataMember(Name="if", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "if")]
    public string If { get; set; }

    /// <summary>
    /// Gets or Sets Then
    /// </summary>
    [DataMember(Name="then", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "then")]
    public ConfigConditionResult Then { get; set; }

    /// <summary>
    /// Gets or Sets Else
    /// </summary>
    [DataMember(Name="else", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "else")]
    public ConfigConditionResult Else { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ConfigCondition {\n");
      sb.Append("  Configs: ").Append(Configs).Append("\n");
      sb.Append("  Resource: ").Append(Resource).Append("\n");
      sb.Append("  If: ").Append(If).Append("\n");
      sb.Append("  Then: ").Append(Then).Append("\n");
      sb.Append("  Else: ").Append(Else).Append("\n");
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
