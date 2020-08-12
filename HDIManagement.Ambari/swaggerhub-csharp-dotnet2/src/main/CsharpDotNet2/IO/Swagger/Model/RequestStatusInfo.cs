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
  public class RequestStatusInfo {
    /// <summary>
    /// Gets or Sets TaskCount
    /// </summary>
    [DataMember(Name="task_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "task_count")]
    public int? TaskCount { get; set; }

    /// <summary>
    /// Gets or Sets CompletedTaskCount
    /// </summary>
    [DataMember(Name="completed_task_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "completed_task_count")]
    public string CompletedTaskCount { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets StartTime
    /// </summary>
    [DataMember(Name="start_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_time")]
    public string StartTime { get; set; }

    /// <summary>
    /// Gets or Sets RequestContext
    /// </summary>
    [DataMember(Name="request_context", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "request_context")]
    public string RequestContext { get; set; }

    /// <summary>
    /// Gets or Sets RequestStatus
    /// </summary>
    [DataMember(Name="request_status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "request_status")]
    public string RequestStatus { get; set; }

    /// <summary>
    /// Gets or Sets EndTime
    /// </summary>
    [DataMember(Name="end_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "end_time")]
    public string EndTime { get; set; }

    /// <summary>
    /// Gets or Sets RequestSchedule
    /// </summary>
    [DataMember(Name="request_schedule", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "request_schedule")]
    public string RequestSchedule { get; set; }

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
    public long? CreateTime { get; set; }

    /// <summary>
    /// Gets or Sets Inputs
    /// </summary>
    [DataMember(Name="inputs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inputs")]
    public string Inputs { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets AbortedTaskCount
    /// </summary>
    [DataMember(Name="aborted_task_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "aborted_task_count")]
    public int? AbortedTaskCount { get; set; }

    /// <summary>
    /// Gets or Sets ProgressPercent
    /// </summary>
    [DataMember(Name="progress_percent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "progress_percent")]
    public double? ProgressPercent { get; set; }

    /// <summary>
    /// Gets or Sets QueuedTaskCount
    /// </summary>
    [DataMember(Name="queued_task_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "queued_task_count")]
    public int? QueuedTaskCount { get; set; }

    /// <summary>
    /// Gets or Sets RequestScheduleId
    /// </summary>
    [DataMember(Name="request_schedule_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "request_schedule_id")]
    public long? RequestScheduleId { get; set; }

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
    /// Gets or Sets FailedTaskCount
    /// </summary>
    [DataMember(Name="failed_task_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "failed_task_count")]
    public int? FailedTaskCount { get; set; }

    /// <summary>
    /// Gets or Sets OperationLevel
    /// </summary>
    [DataMember(Name="operation_level", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operation_level")]
    public string OperationLevel { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RequestStatusInfo {\n");
      sb.Append("  TaskCount: ").Append(TaskCount).Append("\n");
      sb.Append("  CompletedTaskCount: ").Append(CompletedTaskCount).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  StartTime: ").Append(StartTime).Append("\n");
      sb.Append("  RequestContext: ").Append(RequestContext).Append("\n");
      sb.Append("  RequestStatus: ").Append(RequestStatus).Append("\n");
      sb.Append("  EndTime: ").Append(EndTime).Append("\n");
      sb.Append("  RequestSchedule: ").Append(RequestSchedule).Append("\n");
      sb.Append("  ClusterName: ").Append(ClusterName).Append("\n");
      sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
      sb.Append("  Inputs: ").Append(Inputs).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  AbortedTaskCount: ").Append(AbortedTaskCount).Append("\n");
      sb.Append("  ProgressPercent: ").Append(ProgressPercent).Append("\n");
      sb.Append("  QueuedTaskCount: ").Append(QueuedTaskCount).Append("\n");
      sb.Append("  RequestScheduleId: ").Append(RequestScheduleId).Append("\n");
      sb.Append("  ResourceFilters: ").Append(ResourceFilters).Append("\n");
      sb.Append("  Exclusive: ").Append(Exclusive).Append("\n");
      sb.Append("  FailedTaskCount: ").Append(FailedTaskCount).Append("\n");
      sb.Append("  OperationLevel: ").Append(OperationLevel).Append("\n");
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
