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
  public class RootServiceComponentWithHostComponentList {
    /// <summary>
    /// Gets or Sets HostComponents
    /// </summary>
    [DataMember(Name="hostComponents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hostComponents")]
    public List<RootServiceHostComponentResponseWrapper> HostComponents { get; set; }

    /// <summary>
    /// Gets or Sets RootServiceComponents
    /// </summary>
    [DataMember(Name="RootServiceComponents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RootServiceComponents")]
    public RootServiceComponentResponse RootServiceComponents { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RootServiceComponentWithHostComponentList {\n");
      sb.Append("  HostComponents: ").Append(HostComponents).Append("\n");
      sb.Append("  RootServiceComponents: ").Append(RootServiceComponents).Append("\n");
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
