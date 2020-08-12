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
  public class Request {
    /// <summary>
    /// Gets or Sets ClusterName
    /// </summary>
    [DataMember(Name="cluster_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cluster_name")]
    public string ClusterName { get; set; }

    /// <summary>
    /// Gets or Sets ResourceFilters
    /// </summary>
    [DataMember(Name="resource_filters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resource_filters")]
    public List<RequestResourceFilter> ResourceFilters { get; set; }

    /// <summary>
    /// Gets or Sets Exclusive
    /// </summary>
    [DataMember(Name="exclusive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exclusive")]
    public bool? Exclusive { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Request {\n");
      sb.Append("  ClusterName: ").Append(ClusterName).Append("\n");
      sb.Append("  ResourceFilters: ").Append(ResourceFilters).Append("\n");
      sb.Append("  Exclusive: ").Append(Exclusive).Append("\n");
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
