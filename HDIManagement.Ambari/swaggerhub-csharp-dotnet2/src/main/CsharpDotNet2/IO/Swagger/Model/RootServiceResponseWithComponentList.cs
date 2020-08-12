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
  public class RootServiceResponseWithComponentList {
    /// <summary>
    /// Gets or Sets Components
    /// </summary>
    [DataMember(Name="components", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "components")]
    public List<RootServiceComponentResponseWrapper> Components { get; set; }

    /// <summary>
    /// Gets or Sets RootService
    /// </summary>
    [DataMember(Name="RootService", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RootService")]
    public RootServiceResponse RootService { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RootServiceResponseWithComponentList {\n");
      sb.Append("  Components: ").Append(Components).Append("\n");
      sb.Append("  RootService: ").Append(RootService).Append("\n");
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
