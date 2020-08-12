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
  public class ScheduleRequest {
    /// <summary>
    /// Gets or Sets DayOfWeek
    /// </summary>
    [DataMember(Name="day_of_week", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "day_of_week")]
    public string DayOfWeek { get; set; }

    /// <summary>
    /// Gets or Sets Month
    /// </summary>
    [DataMember(Name="month", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "month")]
    public string Month { get; set; }

    /// <summary>
    /// Gets or Sets Hours
    /// </summary>
    [DataMember(Name="hours", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hours")]
    public string Hours { get; set; }

    /// <summary>
    /// Gets or Sets Minutes
    /// </summary>
    [DataMember(Name="minutes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minutes")]
    public string Minutes { get; set; }

    /// <summary>
    /// Gets or Sets Year
    /// </summary>
    [DataMember(Name="year", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "year")]
    public string Year { get; set; }

    /// <summary>
    /// Gets or Sets StartTime
    /// </summary>
    [DataMember(Name="startTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startTime")]
    public string StartTime { get; set; }

    /// <summary>
    /// Gets or Sets EndTime
    /// </summary>
    [DataMember(Name="endTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endTime")]
    public string EndTime { get; set; }

    /// <summary>
    /// Gets or Sets DaysOfMonth
    /// </summary>
    [DataMember(Name="days_of_month", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "days_of_month")]
    public string DaysOfMonth { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ScheduleRequest {\n");
      sb.Append("  DayOfWeek: ").Append(DayOfWeek).Append("\n");
      sb.Append("  Month: ").Append(Month).Append("\n");
      sb.Append("  Hours: ").Append(Hours).Append("\n");
      sb.Append("  Minutes: ").Append(Minutes).Append("\n");
      sb.Append("  Year: ").Append(Year).Append("\n");
      sb.Append("  StartTime: ").Append(StartTime).Append("\n");
      sb.Append("  EndTime: ").Append(EndTime).Append("\n");
      sb.Append("  DaysOfMonth: ").Append(DaysOfMonth).Append("\n");
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
