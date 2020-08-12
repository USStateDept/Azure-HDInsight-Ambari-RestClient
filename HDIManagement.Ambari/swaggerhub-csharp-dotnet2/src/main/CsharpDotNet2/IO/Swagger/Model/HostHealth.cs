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
  public class HostHealth {
    /// <summary>
    /// Gets or Sets ActiveJavaProcs
    /// </summary>
    [DataMember(Name="activeJavaProcs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activeJavaProcs")]
    public List<JavaProc> ActiveJavaProcs { get; set; }

    /// <summary>
    /// Gets or Sets AgentTimeStampAtReporting
    /// </summary>
    [DataMember(Name="agentTimeStampAtReporting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "agentTimeStampAtReporting")]
    public long? AgentTimeStampAtReporting { get; set; }

    /// <summary>
    /// Gets or Sets ServerTimeStampAtReporting
    /// </summary>
    [DataMember(Name="serverTimeStampAtReporting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serverTimeStampAtReporting")]
    public long? ServerTimeStampAtReporting { get; set; }

    /// <summary>
    /// Gets or Sets LiveServices
    /// </summary>
    [DataMember(Name="liveServices", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "liveServices")]
    public List<LiveService> LiveServices { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class HostHealth {\n");
      sb.Append("  ActiveJavaProcs: ").Append(ActiveJavaProcs).Append("\n");
      sb.Append("  AgentTimeStampAtReporting: ").Append(AgentTimeStampAtReporting).Append("\n");
      sb.Append("  ServerTimeStampAtReporting: ").Append(ServerTimeStampAtReporting).Append("\n");
      sb.Append("  LiveServices: ").Append(LiveServices).Append("\n");
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
