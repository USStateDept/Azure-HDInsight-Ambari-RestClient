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
  public class ValueAttributesInfo {
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets Maximum
    /// </summary>
    [DataMember(Name="maximum", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maximum")]
    public string Maximum { get; set; }

    /// <summary>
    /// Gets or Sets Minimum
    /// </summary>
    [DataMember(Name="minimum", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minimum")]
    public string Minimum { get; set; }

    /// <summary>
    /// Gets or Sets Unit
    /// </summary>
    [DataMember(Name="unit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unit")]
    public string Unit { get; set; }

    /// <summary>
    /// Gets or Sets Delete
    /// </summary>
    [DataMember(Name="delete", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "delete")]
    public string Delete { get; set; }

    /// <summary>
    /// Gets or Sets Visible
    /// </summary>
    [DataMember(Name="visible", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visible")]
    public bool? Visible { get; set; }

    /// <summary>
    /// Gets or Sets Overridable
    /// </summary>
    [DataMember(Name="overridable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "overridable")]
    public bool? Overridable { get; set; }

    /// <summary>
    /// Gets or Sets Copy
    /// </summary>
    [DataMember(Name="copy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "copy")]
    public string Copy { get; set; }

    /// <summary>
    /// Gets or Sets EmptyValueValid
    /// </summary>
    [DataMember(Name="empty_value_valid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "empty_value_valid")]
    public bool? EmptyValueValid { get; set; }

    /// <summary>
    /// Gets or Sets UiOnlyProperty
    /// </summary>
    [DataMember(Name="ui_only_property", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ui_only_property")]
    public bool? UiOnlyProperty { get; set; }

    /// <summary>
    /// Gets or Sets ReadOnly
    /// </summary>
    [DataMember(Name="read_only", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "read_only")]
    public bool? ReadOnly { get; set; }

    /// <summary>
    /// Gets or Sets EditableOnlyAtInstall
    /// </summary>
    [DataMember(Name="editable_only_at_install", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "editable_only_at_install")]
    public bool? EditableOnlyAtInstall { get; set; }

    /// <summary>
    /// Gets or Sets ShowPropertyName
    /// </summary>
    [DataMember(Name="show_property_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "show_property_name")]
    public bool? ShowPropertyName { get; set; }

    /// <summary>
    /// Gets or Sets IncrementStep
    /// </summary>
    [DataMember(Name="increment_step", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "increment_step")]
    public string IncrementStep { get; set; }

    /// <summary>
    /// Gets or Sets Entries
    /// </summary>
    [DataMember(Name="entries", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entries")]
    public List<ValueEntryInfo> Entries { get; set; }

    /// <summary>
    /// Gets or Sets Hidden
    /// </summary>
    [DataMember(Name="hidden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hidden")]
    public string Hidden { get; set; }

    /// <summary>
    /// Gets or Sets EntriesEditable
    /// </summary>
    [DataMember(Name="entries_editable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entries_editable")]
    public bool? EntriesEditable { get; set; }

    /// <summary>
    /// Gets or Sets SelectionCardinality
    /// </summary>
    [DataMember(Name="selection_cardinality", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "selection_cardinality")]
    public string SelectionCardinality { get; set; }

    /// <summary>
    /// Gets or Sets PropertyFileName
    /// </summary>
    [DataMember(Name="property-file-name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "property-file-name")]
    public string PropertyFileName { get; set; }

    /// <summary>
    /// Gets or Sets PropertyFileType
    /// </summary>
    [DataMember(Name="property-file-type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "property-file-type")]
    public string PropertyFileType { get; set; }

    /// <summary>
    /// Gets or Sets UserGroupEntries
    /// </summary>
    [DataMember(Name="user-group-entries", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user-group-entries")]
    public List<UserGroupInfo> UserGroupEntries { get; set; }

    /// <summary>
    /// Gets or Sets Keystore
    /// </summary>
    [DataMember(Name="keystore", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "keystore")]
    public bool? Keystore { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ValueAttributesInfo {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Maximum: ").Append(Maximum).Append("\n");
      sb.Append("  Minimum: ").Append(Minimum).Append("\n");
      sb.Append("  Unit: ").Append(Unit).Append("\n");
      sb.Append("  Delete: ").Append(Delete).Append("\n");
      sb.Append("  Visible: ").Append(Visible).Append("\n");
      sb.Append("  Overridable: ").Append(Overridable).Append("\n");
      sb.Append("  Copy: ").Append(Copy).Append("\n");
      sb.Append("  EmptyValueValid: ").Append(EmptyValueValid).Append("\n");
      sb.Append("  UiOnlyProperty: ").Append(UiOnlyProperty).Append("\n");
      sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
      sb.Append("  EditableOnlyAtInstall: ").Append(EditableOnlyAtInstall).Append("\n");
      sb.Append("  ShowPropertyName: ").Append(ShowPropertyName).Append("\n");
      sb.Append("  IncrementStep: ").Append(IncrementStep).Append("\n");
      sb.Append("  Entries: ").Append(Entries).Append("\n");
      sb.Append("  Hidden: ").Append(Hidden).Append("\n");
      sb.Append("  EntriesEditable: ").Append(EntriesEditable).Append("\n");
      sb.Append("  SelectionCardinality: ").Append(SelectionCardinality).Append("\n");
      sb.Append("  PropertyFileName: ").Append(PropertyFileName).Append("\n");
      sb.Append("  PropertyFileType: ").Append(PropertyFileType).Append("\n");
      sb.Append("  UserGroupEntries: ").Append(UserGroupEntries).Append("\n");
      sb.Append("  Keystore: ").Append(Keystore).Append("\n");
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
