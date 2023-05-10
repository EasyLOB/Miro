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
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    /// ImageCreateRequest
    /// </summary>
    [DataContract]
        public partial class ImageCreateRequest :  IEquatable<ImageCreateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageCreateRequest" /> class.
        /// </summary>
        /// <param name="data">data (required).</param>
        /// <param name="position">position.</param>
        /// <param name="geometry">geometry.</param>
        /// <param name="parent">parent.</param>
        public ImageCreateRequest(ImageUrlData data = default(ImageUrlData), PositionChange position = default(PositionChange), FixedRatioGeometry geometry = default(FixedRatioGeometry), Parent parent = default(Parent))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new InvalidDataException("data is a required property for ImageCreateRequest and cannot be null");
            }
            else
            {
                this.Data = data;
            }
            this.Position = position;
            this.Geometry = geometry;
            this.Parent = parent;
        }
        
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public ImageUrlData Data { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public PositionChange Position { get; set; }

        /// <summary>
        /// Gets or Sets Geometry
        /// </summary>
        [DataMember(Name="geometry", EmitDefaultValue=false)]
        public FixedRatioGeometry Geometry { get; set; }

        /// <summary>
        /// Gets or Sets Parent
        /// </summary>
        [DataMember(Name="parent", EmitDefaultValue=false)]
        public Parent Parent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageCreateRequest {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
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
            return this.Equals(input as ImageCreateRequest);
        }

        /// <summary>
        /// Returns true if ImageCreateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageCreateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.Geometry == input.Geometry ||
                    (this.Geometry != null &&
                    this.Geometry.Equals(input.Geometry))
                ) && 
                (
                    this.Parent == input.Parent ||
                    (this.Parent != null &&
                    this.Parent.Equals(input.Parent))
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.Geometry != null)
                    hashCode = hashCode * 59 + this.Geometry.GetHashCode();
                if (this.Parent != null)
                    hashCode = hashCode * 59 + this.Parent.GetHashCode();
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
