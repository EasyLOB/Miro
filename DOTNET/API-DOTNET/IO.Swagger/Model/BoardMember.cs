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
    /// Contains the current user&#x27;s board membership details. The current user could be different from the board owner.
    /// </summary>
    [DataContract]
        public partial class BoardMember :  IEquatable<BoardMember>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="BoardMember" /> class.
        /// </summary>
        /// <param name="id">Unique identifier (ID) of the user. (required).</param>
        /// <param name="name">Name of the user. (required).</param>
        /// <param name="role">Role of the board member..</param>
        /// <param name="type">Type of the object that is returned. In this case, &#x60;type&#x60; returns &#x60;board_member&#x60;. (required).</param>
        public BoardMember(long? id = default(long?), string name = default(string), RoleEnum? role = default(RoleEnum?), string type = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for BoardMember and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for BoardMember and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for BoardMember and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.Role = role;
        }
        
        /// <summary>
        /// Unique identifier (ID) of the user.
        /// </summary>
        /// <value>Unique identifier (ID) of the user.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Name of the user.
        /// </summary>
        /// <value>Name of the user.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Type of the object that is returned. In this case, &#x60;type&#x60; returns &#x60;board_member&#x60;.
        /// </summary>
        /// <value>Type of the object that is returned. In this case, &#x60;type&#x60; returns &#x60;board_member&#x60;.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BoardMember {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as BoardMember);
        }

        /// <summary>
        /// Returns true if BoardMember instances are equal
        /// </summary>
        /// <param name="input">Instance of BoardMember to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BoardMember input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
