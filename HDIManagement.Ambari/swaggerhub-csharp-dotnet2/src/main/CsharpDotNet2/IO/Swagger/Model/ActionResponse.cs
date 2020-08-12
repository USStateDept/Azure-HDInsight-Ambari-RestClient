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
  public class ActionResponse {
    /// <summary>
    /// Gets or Sets ActionName
    /// </summary>
    [DataMember(Name="action_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "action_name")]
    public string ActionName { get; set; }

    /// <summary>
    /// Gets or Sets ActionType
    /// </summary>
    [DataMember(Name="action_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "action_type")]
    public string ActionType { get; set; }

    /// <summary>
    /// Gets or Sets Inputs
    /// </summary>
    [DataMember(Name="inputs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inputs")]
    public string Inputs { get; set; }

    /// <summary>
    /// Gets or Sets TargetService
    /// </summary>
    [DataMember(Name="target_service", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "target_service")]
    public string TargetService { get; set; }

    /// <summary>
    /// Gets or Sets TargetComponent
    /// </summary>
    [DataMember(Name="target_component", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "target_component")]
    public string TargetComponent { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets TargetType
    /// </summary>
    [DataMember(Name="target_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "target_type")]
    public string TargetType { get; set; }

    /// <summary>
    /// Gets or Sets DefaultTimeout
    /// </summary>
    [DataMember(Name="default_timeout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default_timeout")]
    public string DefaultTimeout { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ActionResponse {\n");
      sb.Append("  ActionName: ").Append(ActionName).Append("\n");
      sb.Append("  ActionType: ").Append(ActionType).Append("\n");
      sb.Append("  Inputs: ").Append(Inputs).Append("\n");
      sb.Append("  TargetService: ").Append(TargetService).Append("\n");
      sb.Append("  TargetComponent: ").Append(TargetComponent).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  TargetType: ").Append(TargetType).Append("\n");
      sb.Append("  DefaultTimeout: ").Append(DefaultTimeout).Append("\n");
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
