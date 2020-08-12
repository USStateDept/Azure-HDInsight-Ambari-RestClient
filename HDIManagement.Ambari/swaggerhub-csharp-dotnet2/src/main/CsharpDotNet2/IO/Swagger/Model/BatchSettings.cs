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
  public class BatchSettings {
    /// <summary>
    /// Gets or Sets BatchSeparationInSeconds
    /// </summary>
    [DataMember(Name="batch_separation_in_seconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "batch_separation_in_seconds")]
    public int? BatchSeparationInSeconds { get; set; }

    /// <summary>
    /// Gets or Sets TaskFailureToleranceLimit
    /// </summary>
    [DataMember(Name="task_failure_tolerance_limit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "task_failure_tolerance_limit")]
    public int? TaskFailureToleranceLimit { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BatchSettings {\n");
      sb.Append("  BatchSeparationInSeconds: ").Append(BatchSeparationInSeconds).Append("\n");
      sb.Append("  TaskFailureToleranceLimit: ").Append(TaskFailureToleranceLimit).Append("\n");
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
