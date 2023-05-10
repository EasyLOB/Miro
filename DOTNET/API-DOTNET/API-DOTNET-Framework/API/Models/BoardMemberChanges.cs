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
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    /// BoardMemberChanges
    /// </summary>
    [DataContract]
        public partial class BoardMemberChanges :  IEquatable<BoardMemberChanges>, IValidatableObject
    {
        /// <summary>
        /// Role of the board member.
        /// </summary>
        /// <value>Role of the board member.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum RoleEnum
        {
            /// <summary>
            /// Enum Viewer for value: viewer
            /// </summary>
            [EnumMember(Value = "viewer")]
            Viewer = 1,
            /// <summary>
            /// Enum Commenter for value: commenter
            /// </summary>
            [EnumMember(Value = "commenter")]
            Commenter = 2,
            /// <summary>
            /// Enum Editor for value: editor
            /// </summary>
            [EnumMember(Value = "editor")]
            Editor = 3,
            /// <summary>
            /// Enum Coowner for value: coowner
            /// </summary>
            [EnumMember(Value = "coowner")]
            Coowner = 4,
            /// <summary>
            /// Enum Owner for value: owner
            /// </summary>
            [EnumMember(Value = "owner")]
            Owner = 5,
            /// <summary>
            /// Enum Guest for value: guest
            /// </summary>
            [EnumMember(Value = "guest")]
            Guest = 6        }
        /// <summary>
        /// Role of the board member.
        /// </summary>
        /// <value>Role of the board member.</value>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public RoleEnum? Role { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BoardMemberChanges" /> class.
        /// </summary>
        /// <param name="role">Role of the board member. (default to RoleEnum.Commenter).</param>
        public BoardMemberChanges(RoleEnum? role = RoleEnum.Commenter)
        {
            // use default value if no "role" provided
            if (role == null)
            {
                this.Role = RoleEnum.Commenter;
            }
            else
            {
                this.Role = role;
            }
        }
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BoardMemberChanges {\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
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
            return this.Equals(input as BoardMemberChanges);
        }

        /// <summary>
        /// Returns true if BoardMemberChanges instances are equal
        /// </summary>
        /// <param name="input">Instance of BoardMemberChanges to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BoardMemberChanges input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
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
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
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
