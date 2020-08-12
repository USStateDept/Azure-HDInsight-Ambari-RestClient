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
  public class DiskInfo {
    /// <summary>
    /// Gets or Sets Available
    /// </summary>
    [DataMember(Name="available", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "available")]
    public string Available { get; set; }

    /// <summary>
    /// Gets or Sets Device
    /// </summary>
    [DataMember(Name="device", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "device")]
    public string Device { get; set; }

    /// <summary>
    /// Gets or Sets Used
    /// </summary>
    [DataMember(Name="used", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "used")]
    public string Used { get; set; }

    /// <summary>
    /// Gets or Sets Percent
    /// </summary>
    [DataMember(Name="percent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "percent")]
    public string Percent { get; set; }

    /// <summary>
    /// Gets or Sets Size
    /// </summary>
    [DataMember(Name="size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "size")]
    public string Size { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets Mountpoint
    /// </summary>
    [DataMember(Name="mountpoint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mountpoint")]
    public string Mountpoint { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DiskInfo {\n");
      sb.Append("  Available: ").Append(Available).Append("\n");
      sb.Append("  Device: ").Append(Device).Append("\n");
      sb.Append("  Used: ").Append(Used).Append("\n");
      sb.Append("  Percent: ").Append(Percent).Append("\n");
      sb.Append("  Size: ").Append(Size).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Mountpoint: ").Append(Mountpoint).Append("\n");
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
