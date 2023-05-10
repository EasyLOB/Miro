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
    /// Contains information about the style of an app card item, such as the fill color.
    /// </summary>
    [DataContract]
        public partial class AppCardStyle :  IEquatable<AppCardStyle>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppCardStyle" /> class.
        /// </summary>
        /// <param name="fillColor">Hex value of the border color of the app card. Default: &#x60;#2d9bf0&#x60;..</param>
        public AppCardStyle(string fillColor = default(string))
        {
            this.FillColor = fillColor;
        }
        
        /// <summary>
        /// Hex value of the border color of the app card. Default: &#x60;#2d9bf0&#x60;.
        /// </summary>
        /// <value>Hex value of the border color of the app card. Default: &#x60;#2d9bf0&#x60;.</value>
        [DataMember(Name="fillColor", EmitDefaultValue=false)]
        public string FillColor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppCardStyle {\n");
            sb.Append("  FillColor: ").Append(FillColor).Append("\n");
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
            return this.Equals(input as AppCardStyle);
        }

        /// <summary>
        /// Returns true if AppCardStyle instances are equal
        /// </summary>
        /// <param name="input">Instance of AppCardStyle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppCardStyle input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FillColor == input.FillColor ||
                    (this.FillColor != null &&
                    this.FillColor.Equals(input.FillColor))
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
                if (this.FillColor != null)
                    hashCode = hashCode * 59 + this.FillColor.GetHashCode();
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