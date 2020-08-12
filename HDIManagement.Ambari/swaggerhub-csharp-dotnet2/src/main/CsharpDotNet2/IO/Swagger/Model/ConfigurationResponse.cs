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
  public class ConfigurationResponse {
    /// <summary>
    /// Gets or Sets ConfigclusterName
    /// </summary>
    [DataMember(Name="Config/cluster_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Config/cluster_name")]
    public string ConfigclusterName { get; set; }

    /// <summary>
    /// Gets or Sets ConfigstackId
    /// </summary>
    [DataMember(Name="Config/stack_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Config/stack_id")]
    public string ConfigstackId { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets Tag
    /// </summary>
    [DataMember(Name="tag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tag")]
    public string Tag { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public long? Version { get; set; }

    /// <summary>
    /// Gets or Sets Properties
    /// </summary>
    [DataMember(Name="properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "properties")]
    public Dictionary<string, string> Properties { get; set; }

    /// <summary>
    /// Gets or Sets PropertiesAttributes
    /// </summary>
    [DataMember(Name="properties_attributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "properties_attributes")]
    public Dictionary<string, Dictionary<string, string>> PropertiesAttributes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ConfigurationResponse {\n");
      sb.Append("  ConfigclusterName: ").Append(ConfigclusterName).Append("\n");
      sb.Append("  ConfigstackId: ").Append(ConfigstackId).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Tag: ").Append(Tag).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  Properties: ").Append(Properties).Append("\n");
      sb.Append("  PropertiesAttributes: ").Append(PropertiesAttributes).Append("\n");
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
