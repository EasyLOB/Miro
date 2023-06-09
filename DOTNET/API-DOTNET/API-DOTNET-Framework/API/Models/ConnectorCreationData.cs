/* 
 * Platform
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    /// startItem.id must be different from endItem.id
    /// </summary>
    [DataContract]
        public partial class ConnectorCreationData :  IEquatable<ConnectorCreationData>, IValidatableObject
    {
        /// <summary>
        /// The path type of the connector line, defines curvature. Default: curved.
        /// </summary>
        /// <value>The path type of the connector line, defines curvature. Default: curved.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ShapeEnum
        {
            /// <summary>
            /// Enum Straight for value: straight
            /// </summary>
            [EnumMember(Value = "straight")]
            Straight = 1,
            /// <summary>
            /// Enum Elbowed for value: elbowed
            /// </summary>
            [EnumMember(Value = "elbowed")]
            Elbowed = 2,
            /// <summary>
            /// Enum Curved for value: curved
            /// </summary>
            [EnumMember(Value = "curved")]
            Curved = 3        }
        /// <summary>
        /// The path type of the connector line, defines curvature. Default: curved.
        /// </summary>
        /// <value>The path type of the connector line, defines curvature. Default: curved.</value>
        [DataMember(Name="shape", EmitDefaultValue=false)]
        public ShapeEnum? Shape { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorCreationData" /> class.
        /// </summary>
        /// <param name="startItem">startItem (required).</param>
        /// <param name="endItem">endItem (required).</param>
        /// <param name="shape">The path type of the connector line, defines curvature. Default: curved..</param>
        /// <param name="captions">Blocks of text you want to display on the connector..</param>
        /// <param name="style">style.</param>
        public ConnectorCreationData(ItemConnectionCreationData startItem = default(ItemConnectionCreationData), ItemConnectionCreationData endItem = default(ItemConnectionCreationData), ShapeEnum? shape = default(ShapeEnum?), List<Caption> captions = default(List<Caption>), ConnectorStyle style = default(ConnectorStyle))
        {
            // to ensure "startItem" is required (not null)
            if (startItem == null)
            {
                throw new InvalidDataException("startItem is a required property for ConnectorCreationData and cannot be null");
            }
            else
            {
                this.StartItem = startItem;
            }
            // to ensure "endItem" is required (not null)
            if (endItem == null)
            {
                throw new InvalidDataException("endItem is a required property for ConnectorCreationData and cannot be null");
            }
            else
            {
                this.EndItem = endItem;
            }
            this.Shape = shape;
            this.Captions = captions;
            this.Style = style;
        }
        
        /// <summary>
        /// Gets or Sets StartItem
        /// </summary>
        [DataMember(Name="startItem", EmitDefaultValue=false)]
        public ItemConnectionCreationData StartItem { get; set; }

        /// <summary>
        /// Gets or Sets EndItem
        /// </summary>
        [DataMember(Name="endItem", EmitDefaultValue=false)]
        public ItemConnectionCreationData EndItem { get; set; }


        /// <summary>
        /// Blocks of text you want to display on the connector.
        /// </summary>
        /// <value>Blocks of text you want to display on the connector.</value>
        [DataMember(Name="captions", EmitDefaultValue=false)]
        public List<Caption> Captions { get; set; }

        /// <summary>
        /// Gets or Sets Style
        /// </summary>
        [DataMember(Name="style", EmitDefaultValue=false)]
        public ConnectorStyle Style { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectorCreationData {\n");
            sb.Append("  StartItem: ").Append(StartItem).Append("\n");
            sb.Append("  EndItem: ").Append(EndItem).Append("\n");
            sb.Append("  Shape: ").Append(Shape).Append("\n");
            sb.Append("  Captions: ").Append(Captions).Append("\n");
            sb.Append("  Style: ").Append(Style).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConnectorCreationData);
        }

        /// <summary>
        /// Returns true if ConnectorCreationData instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectorCreationData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectorCreationData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartItem == input.StartItem ||
                    (this.StartItem != null &&
                    this.StartItem.Equals(input.StartItem))
                ) && 
                (
                    this.EndItem == input.EndItem ||
                    (this.EndItem != null &&
                    this.EndItem.Equals(input.EndItem))
                ) && 
                (
                    this.Shape == input.Shape ||
                    (this.Shape != null &&
                    this.Shape.Equals(input.Shape))
                ) && 
                (
                    this.Captions == input.Captions ||
                    this.Captions != null &&
                    input.Captions != null &&
                    this.Captions.SequenceEqual(input.Captions)
                ) && 
                (
                    this.Style == input.Style ||
                    (this.Style != null &&
                    this.Style.Equals(input.Style))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.StartItem != null)
                    hashCode = hashCode * 59 + this.StartItem.GetHashCode();
                if (this.EndItem != null)
                    hashCode = hashCode * 59 + this.EndItem.GetHashCode();
                if (this.Shape != null)
                    hashCode = hashCode * 59 + this.Shape.GetHashCode();
                if (this.Captions != null)
                    hashCode = hashCode * 59 + this.Captions.GetHashCode();
                if (this.Style != null)
                    hashCode = hashCode * 59 + this.Style.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
