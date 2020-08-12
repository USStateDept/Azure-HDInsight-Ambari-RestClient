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
  public class Config {
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
    /// Gets or Sets ServiceConfigVersions
    /// </summary>
    [DataMember(Name="serviceConfigVersions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serviceConfigVersions")]
    public List<long?> ServiceConfigVersions { get; set; }

    /// <summary>
    /// Gets or Sets PropertiesTypes
    /// </summary>
    [DataMember(Name="propertiesTypes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "propertiesTypes")]
    public Dictionary<string, List<string>> PropertiesTypes { get; set; }

    /// <summary>
    /// Gets or Sets PropertiesAttributes
    /// </summary>
    [DataMember(Name="propertiesAttributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "propertiesAttributes")]
    public Dictionary<string, Dictionary<string, string>> PropertiesAttributes { get; set; }

    /// <summary>
    /// Gets or Sets StackId
    /// </summary>
    [DataMember(Name="stackId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stackId")]
    public StackId StackId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Config {\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  Properties: ").Append(Properties).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Tag: ").Append(Tag).Append("\n");
      sb.Append("  ServiceConfigVersions: ").Append(ServiceConfigVersions).Append("\n");
      sb.Append("  PropertiesTypes: ").Append(PropertiesTypes).Append("\n");
      sb.Append("  PropertiesAttributes: ").Append(PropertiesAttributes).Append("\n");
      sb.Append("  StackId: ").Append(StackId).Append("\n");
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
