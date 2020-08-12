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
  public class BatchResponse {
    /// <summary>
    /// Gets or Sets BatchSettings
    /// </summary>
    [DataMember(Name="batch_settings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "batch_settings")]
    public BatchSettings BatchSettings { get; set; }

    /// <summary>
    /// Gets or Sets BatchRequests
    /// </summary>
    [DataMember(Name="batch_requests", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "batch_requests")]
    public List<BatchRequestResponse> BatchRequests { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BatchResponse {\n");
      sb.Append("  BatchSettings: ").Append(BatchSettings).Append("\n");
      sb.Append("  BatchRequests: ").Append(BatchRequests).Append("\n");
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
