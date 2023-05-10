/* 
 * Platform
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Contains sticky note item data, such as the content or shape of the sticky note.
    /// </summary>
    [DataContract]
        public partial class StickyNoteData :  IEquatable<StickyNoteData>, IValidatableObject
    {
        /// <summary>
        /// Defines the geometric shape of the sticky note and aspect ratio for its dimensions.
        /// </summary>
        /// <value>Defines the geometric shape of the sticky note and aspect ratio for its dimensions.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ShapeEnum
        {
            /// <summary>
            /// Enum Square for value: square
            /// </summary>
            [EnumMember(Value = "square")]
            Square = 1,
            /// <summary>
            /// Enum Rectangle for value: rectangle
            /// </summary>
            [EnumMember(Value = "rectangle")]
            Rectangle = 2        }
        /// <summary>
        /// Defines the geometric shape of the sticky note and aspect ratio for its dimensions.
        /// </summary>
        /// <value>Defines the geometric shape of the sticky note and aspect ratio for its dimensions.</value>
        [DataMember(Name="shape", EmitDefaultValue=false)]
        public ShapeEnum? Shape { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StickyNoteData" /> class.
        /// </summary>
        /// <param name="content">The actual text (content) that appears in the sticky note item..</param>
        /// <param name="shape">Defines the geometric shape of the sticky note and aspect ratio for its dimensions. (default to ShapeEnum.Square).</param>
        public StickyNoteData(string content = default(string), ShapeEnum? shape = ShapeEnum.Square)
        {
            this.Content = content;
            // use default value if no "shape" provided
            if (shape == null)
            {
                this.Shape = ShapeEnum.Square;
            }
            else
            {
                this.Shape = shape;
            }
        }
        
        /// <summary>
        /// The actual text (content) that appears in the sticky note item.
        /// </summary>
        /// <value>The actual text (content) that appears in the sticky note item.</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StickyNoteData {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Shape: ").Append(Shape).Append("\n");
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
            return this.Equals(input as StickyNoteData);
        }

        /// <summary>
        /// Returns true if StickyNoteData instances are equal
        /// </summary>
        /// <param name="input">Instance of StickyNoteData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StickyNoteData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Shape == input.Shape ||
                    (this.Shape != null &&
                    this.Shape.Equals(input.Shape))
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
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Shape != null)
                    hashCode = hashCode * 59 + this.Shape.GetHashCode();
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
