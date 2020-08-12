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
  public class StackConfigurationDependencyResponseSwagger {
    /// <summary>
    /// Gets or Sets StackConfigurationDependency
    /// </summary>
    [DataMember(Name="StackConfigurationDependency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StackConfigurationDependency")]
    public StackConfigurationDependencyResponse StackConfigurationDependency { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StackConfigurationDependencyResponseSwagger {\n");
      sb.Append("  StackConfigurationDependency: ").Append(StackConfigurationDependency).Append("\n");
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
