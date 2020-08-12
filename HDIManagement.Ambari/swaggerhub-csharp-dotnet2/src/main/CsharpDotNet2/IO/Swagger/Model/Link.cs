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
  public class Link {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Label
    /// </summary>
    [DataMember(Name="label", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "label")]
    public string Label { get; set; }

    /// <summary>
    /// Gets or Sets ComponentName
    /// </summary>
    [DataMember(Name="componentName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "componentName")]
    public string ComponentName { get; set; }

    /// <summary>
    /// Gets or Sets RequiresUserName
    /// </summary>
    [DataMember(Name="requiresUserName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requiresUserName")]
    public string RequiresUserName { get; set; }

    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets Port
    /// </summary>
    [DataMember(Name="port", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "port")]
    public Port Port { get; set; }

    /// <summary>
    /// Gets or Sets Host
    /// </summary>
    [DataMember(Name="host", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "host")]
    public Host Host { get; set; }

    /// <summary>
    /// Gets or Sets Protocol
    /// </summary>
    [DataMember(Name="protocol", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "protocol")]
    public Protocol Protocol { get; set; }

    /// <summary>
    /// Gets or Sets Attributes
    /// </summary>
    [DataMember(Name="attributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributes")]
    public List<string> Attributes { get; set; }

    /// <summary>
    /// Gets or Sets Visible
    /// </summary>
    [DataMember(Name="visible", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visible")]
    public bool? Visible { get; set; }

    /// <summary>
    /// Gets or Sets Removed
    /// </summary>
    [DataMember(Name="removed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "removed")]
    public bool? Removed { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Link {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Label: ").Append(Label).Append("\n");
      sb.Append("  ComponentName: ").Append(ComponentName).Append("\n");
      sb.Append("  RequiresUserName: ").Append(RequiresUserName).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Port: ").Append(Port).Append("\n");
      sb.Append("  Host: ").Append(Host).Append("\n");
      sb.Append("  Protocol: ").Append(Protocol).Append("\n");
      sb.Append("  Attributes: ").Append(Attributes).Append("\n");
      sb.Append("  Visible: ").Append(Visible).Append("\n");
      sb.Append("  Removed: ").Append(Removed).Append("\n");
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
