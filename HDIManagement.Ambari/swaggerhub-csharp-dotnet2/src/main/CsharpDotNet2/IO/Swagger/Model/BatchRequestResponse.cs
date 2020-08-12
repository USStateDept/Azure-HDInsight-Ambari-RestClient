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
  public class BatchRequestResponse {
    /// <summary>
    /// Gets or Sets RequestType
    /// </summary>
    [DataMember(Name="request_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "request_type")]
    public string RequestType { get; set; }

    /// <summary>
    /// Gets or Sets RequestStatus
    /// </summary>
    [DataMember(Name="request_status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "request_status")]
    public string RequestStatus { get; set; }

    /// <summary>
    /// Gets or Sets RequestBody
    /// </summary>
    [DataMember(Name="request_body", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "request_body")]
    public string RequestBody { get; set; }

    /// <summary>
    /// Gets or Sets RequestUri
    /// </summary>
    [DataMember(Name="request_uri", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "request_uri")]
    public string RequestUri { get; set; }

    /// <summary>
    /// Gets or Sets ResponseMessage
    /// </summary>
    [DataMember(Name="response_message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "response_message")]
    public string ResponseMessage { get; set; }

    /// <summary>
    /// Gets or Sets ReturnCode
    /// </summary>
    [DataMember(Name="return_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "return_code")]
    public int? ReturnCode { get; set; }

    /// <summary>
    /// Gets or Sets OrderId
    /// </summary>
    [DataMember(Name="order_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_id")]
    public long? OrderId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BatchRequestResponse {\n");
      sb.Append("  RequestType: ").Append(RequestType).Append("\n");
      sb.Append("  RequestStatus: ").Append(RequestStatus).Append("\n");
      sb.Append("  RequestBody: ").Append(RequestBody).Append("\n");
      sb.Append("  RequestUri: ").Append(RequestUri).Append("\n");
      sb.Append("  ResponseMessage: ").Append(ResponseMessage).Append("\n");
      sb.Append("  ReturnCode: ").Append(ReturnCode).Append("\n");
      sb.Append("  OrderId: ").Append(OrderId).Append("\n");
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
