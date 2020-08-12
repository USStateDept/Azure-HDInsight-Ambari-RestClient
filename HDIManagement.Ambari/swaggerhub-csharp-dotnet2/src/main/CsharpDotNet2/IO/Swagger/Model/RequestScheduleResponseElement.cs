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
  public class RequestScheduleResponseElement {
    /// <summary>
    /// Gets or Sets Schedule
    /// </summary>
    [DataMember(Name="schedule", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "schedule")]
    public ScheduleResponse Schedule { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets ClusterName
    /// </summary>
    [DataMember(Name="cluster_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cluster_name")]
    public string ClusterName { get; set; }

    /// <summary>
    /// Gets or Sets CreateTime
    /// </summary>
    [DataMember(Name="create_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create_time")]
    public string CreateTime { get; set; }

    /// <summary>
    /// Gets or Sets UpdateTime
    /// </summary>
    [DataMember(Name="update_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "update_time")]
    public string UpdateTime { get; set; }

    /// <summary>
    /// Gets or Sets CreateUser
    /// </summary>
    [DataMember(Name="create_user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create_user")]
    public string CreateUser { get; set; }

    /// <summary>
    /// Gets or Sets UpdateUser
    /// </summary>
    [DataMember(Name="update_user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "update_user")]
    public string UpdateUser { get; set; }

    /// <summary>
    /// Gets or Sets LastExecutionStatus
    /// </summary>
    [DataMember(Name="last_execution_status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_execution_status")]
    public string LastExecutionStatus { get; set; }

    /// <summary>
    /// Gets or Sets AuthenticatedUser
    /// </summary>
    [DataMember(Name="authenticated_user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authenticated_user")]
    public int? AuthenticatedUser { get; set; }

    /// <summary>
    /// Gets or Sets Batch
    /// </summary>
    [DataMember(Name="batch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "batch")]
    public BatchResponse Batch { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RequestScheduleResponseElement {\n");
      sb.Append("  Schedule: ").Append(Schedule).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  ClusterName: ").Append(ClusterName).Append("\n");
      sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
      sb.Append("  UpdateTime: ").Append(UpdateTime).Append("\n");
      sb.Append("  CreateUser: ").Append(CreateUser).Append("\n");
      sb.Append("  UpdateUser: ").Append(UpdateUser).Append("\n");
      sb.Append("  LastExecutionStatus: ").Append(LastExecutionStatus).Append("\n");
      sb.Append("  AuthenticatedUser: ").Append(AuthenticatedUser).Append("\n");
      sb.Append("  Batch: ").Append(Batch).Append("\n");
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
