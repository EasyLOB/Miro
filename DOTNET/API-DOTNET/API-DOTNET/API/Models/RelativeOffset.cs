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
    /// The relative position of the point on an item where the connector is attached. Position with x&#x3D;0% and y&#x3D;0% correspond to the top-left corner of the item, x&#x3D;100% and y&#x3D;100% correspond to the right-bottom corner.
    /// </summary>
    [DataContract]
        public partial class RelativeOffset :  IEquatable<RelativeOffset>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RelativeOffset" /> class.
        /// </summary>
        /// <param name="x">X-axis relative coordinate of the location where the connector connects with an item, in percentage, minimum 0%, maximum 100%..</param>
        /// <param name="y">Y-axis relative coordinate of the location where the connector connects with an item, in percentage, minimum 0%, maximum 100%..</param>
        public RelativeOffset(string x = default(string), string y = default(string))
        {
            this.X = x;
            this.Y = y;
        }
        
        /// <summary>
        /// X-axis relative coordinate of the location where the connector connects with an item, in percentage, minimum 0%, maximum 100%.
        /// </summary>
        /// <value>X-axis relative coordinate of the location where the connector connects with an item, in percentage, minimum 0%, maximum 100%.</value>
        [DataMember(Name="x", EmitDefaultValue=false)]
        public string X { get; set; }

        /// <summary>
        /// Y-axis relative coordinate of the location where the connector connects with an item, in percentage, minimum 0%, maximum 100%.
        /// </summary>
        /// <value>Y-axis relative coordinate of the location where the connector connects with an item, in percentage, minimum 0%, maximum 100%.</value>
        [DataMember(Name="y", EmitDefaultValue=false)]
        public string Y { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelativeOffset {\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
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
            return this.Equals(input as RelativeOffset);
        }

        /// <summary>
        /// Returns true if RelativeOffset instances are equal
        /// </summary>
        /// <param name="input">Instance of RelativeOffset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelativeOffset input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.X == input.X ||
                    (this.X != null &&
                    this.X.Equals(input.X))
                ) && 
                (
                    this.Y == input.Y ||
                    (this.Y != null &&
                    this.Y.Equals(input.Y))
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
                if (this.X != null)
                    hashCode = hashCode * 59 + this.X.GetHashCode();
                if (this.Y != null)
                    hashCode = hashCode * 59 + this.Y.GetHashCode();
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
