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
  public class HostComponentComponent {
    /// <summary>
    /// Gets or Sets Href
    /// </summary>
    [DataMember(Name="href", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "href")]
    public string Href { get; set; }

    /// <summary>
    /// Gets or Sets ServiceComponentInfo
    /// </summary>
    [DataMember(Name="ServiceComponentInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceComponentInfo")]
    public HostComponentServiceComponentInfo ServiceComponentInfo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class HostComponentComponent {\n");
      sb.Append("  Href: ").Append(Href).Append("\n");
      sb.Append("  ServiceComponentInfo: ").Append(ServiceComponentInfo).Append("\n");
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
