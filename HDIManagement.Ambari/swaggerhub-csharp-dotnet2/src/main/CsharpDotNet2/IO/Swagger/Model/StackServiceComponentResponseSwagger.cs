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
  public class StackServiceComponentResponseSwagger {
    /// <summary>
    /// Gets or Sets StackServiceComponents
    /// </summary>
    [DataMember(Name="StackServiceComponents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StackServiceComponents")]
    public StackServiceComponentResponse StackServiceComponents { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StackServiceComponentResponseSwagger {\n");
      sb.Append("  StackServiceComponents: ").Append(StackServiceComponents).Append("\n");
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
