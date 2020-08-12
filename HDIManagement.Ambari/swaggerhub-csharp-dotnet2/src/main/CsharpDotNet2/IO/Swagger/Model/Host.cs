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
  public class Host {
    /// <summary>
    /// Gets or Sets HttpProperty
    /// </summary>
    [DataMember(Name="httpProperty", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "httpProperty")]
    public string HttpProperty { get; set; }

    /// <summary>
    /// Gets or Sets HttpsProperty
    /// </summary>
    [DataMember(Name="httpsProperty", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "httpsProperty")]
    public string HttpsProperty { get; set; }

    /// <summary>
    /// Gets or Sets Site
    /// </summary>
    [DataMember(Name="site", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "site")]
    public string Site { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Host {\n");
      sb.Append("  HttpProperty: ").Append(HttpProperty).Append("\n");
      sb.Append("  HttpsProperty: ").Append(HttpsProperty).Append("\n");
      sb.Append("  Site: ").Append(Site).Append("\n");
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
