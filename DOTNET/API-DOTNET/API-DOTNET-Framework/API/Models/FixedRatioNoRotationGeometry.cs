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
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Contains geometrical information about the item. You can set either the width or height. You cannot set both the at the same time. For information about the JSON properties, see [Geometry](https://developers.miro.com/reference/geometry).
    /// </summary>
    [DataContract]
        public partial class FixedRatioNoRotationGeometry :  IEquatable<FixedRatioNoRotationGeometry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FixedRatioNoRotationGeometry" /> class.
        /// </summary>
        /// <param name="height">Height of the item, in pixels..</param>
        /// <param name="width">Width of the item, in pixels..</param>
        public FixedRatioNoRotationGeometry(double? height = default(double?), double? width = default(double?))
        {
            this.Height = height;
            this.Width = width;
        }
        
        /// <summary>
        /// Height of the item, in pixels.
        /// </summary>
        /// <value>Height of the item, in pixels.</value>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public double? Height { get; set; }

        /// <summary>
        /// Width of the item, in pixels.
        /// </summary>
        /// <value>Width of the item, in pixels.</value>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public double? Width { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FixedRatioNoRotationGeometry {\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
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
            return this.Equals(input as FixedRatioNoRotationGeometry);
        }

        /// <summary>
        /// Returns true if FixedRatioNoRotationGeometry instances are equal
        /// </summary>
        /// <param name="input">Instance of FixedRatioNoRotationGeometry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FixedRatioNoRotationGeometry input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
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
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
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