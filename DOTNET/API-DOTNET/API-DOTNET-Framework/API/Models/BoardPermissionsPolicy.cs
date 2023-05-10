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
    /// Defines the permissions policies for the board.
    /// </summary>
    [DataContract]
        public partial class BoardPermissionsPolicy :  IEquatable<BoardPermissionsPolicy>, IValidatableObject
    {
        /// <summary>
        /// Defines who can start or stop timer, voting, video chat, screen sharing, attention management. Others will only be able to join. To change the value for the &#x60;collaborationToolsStartAccess&#x60; parameter, contact Miro Customer Support.
        /// </summary>
        /// <value>Defines who can start or stop timer, voting, video chat, screen sharing, attention management. Others will only be able to join. To change the value for the &#x60;collaborationToolsStartAccess&#x60; parameter, contact Miro Customer Support.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum CollaborationToolsStartAccessEnum
        {
            /// <summary>
            /// Enum Alleditors for value: all_editors
            /// </summary>
            [EnumMember(Value = "all_editors")]
            Alleditors = 1,
            /// <summary>
            /// Enum Boardownersandcoowners for value: board_owners_and_coowners
            /// </summary>
            [EnumMember(Value = "board_owners_and_coowners")]
            Boardownersandcoowners = 2        }
        /// <summary>
        /// Defines who can start or stop timer, voting, video chat, screen sharing, attention management. Others will only be able to join. To change the value for the &#x60;collaborationToolsStartAccess&#x60; parameter, contact Miro Customer Support.
        /// </summary>
        /// <value>Defines who can start or stop timer, voting, video chat, screen sharing, attention management. Others will only be able to join. To change the value for the &#x60;collaborationToolsStartAccess&#x60; parameter, contact Miro Customer Support.</value>
        [DataMember(Name="collaborationToolsStartAccess", EmitDefaultValue=false)]
        public CollaborationToolsStartAccessEnum? CollaborationToolsStartAccess { get; set; }
        /// <summary>
        /// Defines who can copy the board, copy objects, download images, and save the board as a template or PDF.
        /// </summary>
        /// <value>Defines who can copy the board, copy objects, download images, and save the board as a template or PDF.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum CopyAccessEnum
        {
            /// <summary>
            /// Enum Anyone for value: anyone
            /// </summary>
            [EnumMember(Value = "anyone")]
            Anyone = 1,
            /// <summary>
            /// Enum Teammembers for value: team_members
            /// </summary>
            [EnumMember(Value = "team_members")]
            Teammembers = 2,
            /// <summary>
            /// Enum Teameditors for value: team_editors
            /// </summary>
            [EnumMember(Value = "team_editors")]
            Teameditors = 3,
            /// <summary>
            /// Enum Boardowner for value: board_owner
            /// </summary>
            [EnumMember(Value = "board_owner")]
            Boardowner = 4        }
        /// <summary>
        /// Defines who can copy the board, copy objects, download images, and save the board as a template or PDF.
        /// </summary>
        /// <value>Defines who can copy the board, copy objects, download images, and save the board as a template or PDF.</value>
        [DataMember(Name="copyAccess", EmitDefaultValue=false)]
        public CopyAccessEnum? CopyAccess { get; set; }
        /// <summary>
        /// Defines who can change access and invite users to this board. To change the value for the &#x60;sharingAccess&#x60; parameter, contact Miro Customer Support.
        /// </summary>
        /// <value>Defines who can change access and invite users to this board. To change the value for the &#x60;sharingAccess&#x60; parameter, contact Miro Customer Support.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum SharingAccessEnum
        {
            /// <summary>
            /// Enum Teammemberswitheditingrights for value: team_members_with_editing_rights
            /// </summary>
            [EnumMember(Value = "team_members_with_editing_rights")]
            Teammemberswitheditingrights = 1,
            /// <summary>
            /// Enum Ownerandcoowners for value: owner_and_coowners
            /// </summary>
            [EnumMember(Value = "owner_and_coowners")]
            Ownerandcoowners = 2        }
        /// <summary>
        /// Defines who can change access and invite users to this board. To change the value for the &#x60;sharingAccess&#x60; parameter, contact Miro Customer Support.
        /// </summary>
        /// <value>Defines who can change access and invite users to this board. To change the value for the &#x60;sharingAccess&#x60; parameter, contact Miro Customer Support.</value>
        [DataMember(Name="sharingAccess", EmitDefaultValue=false)]
        public SharingAccessEnum? SharingAccess { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BoardPermissionsPolicy" /> class.
        /// </summary>
        /// <param name="collaborationToolsStartAccess">Defines who can start or stop timer, voting, video chat, screen sharing, attention management. Others will only be able to join. To change the value for the &#x60;collaborationToolsStartAccess&#x60; parameter, contact Miro Customer Support. (default to CollaborationToolsStartAccessEnum.Alleditors).</param>
        /// <param name="copyAccess">Defines who can copy the board, copy objects, download images, and save the board as a template or PDF. (default to CopyAccessEnum.Anyone).</param>
        /// <param name="sharingAccess">Defines who can change access and invite users to this board. To change the value for the &#x60;sharingAccess&#x60; parameter, contact Miro Customer Support. (default to SharingAccessEnum.Teammemberswitheditingrights).</param>
        public BoardPermissionsPolicy(CollaborationToolsStartAccessEnum? collaborationToolsStartAccess = CollaborationToolsStartAccessEnum.Alleditors, CopyAccessEnum? copyAccess = CopyAccessEnum.Anyone, SharingAccessEnum? sharingAccess = SharingAccessEnum.Teammemberswitheditingrights)
        {
            // use default value if no "collaborationToolsStartAccess" provided
            if (collaborationToolsStartAccess == null)
            {
                this.CollaborationToolsStartAccess = CollaborationToolsStartAccessEnum.Alleditors;
            }
            else
            {
                this.CollaborationToolsStartAccess = collaborationToolsStartAccess;
            }
            // use default value if no "copyAccess" provided
            if (copyAccess == null)
            {
                this.CopyAccess = CopyAccessEnum.Anyone;
            }
            else
            {
                this.CopyAccess = copyAccess;
            }
            // use default value if no "sharingAccess" provided
            if (sharingAccess == null)
            {
                this.SharingAccess = SharingAccessEnum.Teammemberswitheditingrights;
            }
            else
            {
                this.SharingAccess = sharingAccess;
            }
        }
        



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BoardPermissionsPolicy {\n");
            sb.Append("  CollaborationToolsStartAccess: ").Append(CollaborationToolsStartAccess).Append("\n");
            sb.Append("  CopyAccess: ").Append(CopyAccess).Append("\n");
            sb.Append("  SharingAccess: ").Append(SharingAccess).Append("\n");
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
            return this.Equals(input as BoardPermissionsPolicy);
        }

        /// <summary>
        /// Returns true if BoardPermissionsPolicy instances are equal
        /// </summary>
        /// <param name="input">Instance of BoardPermissionsPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BoardPermissionsPolicy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CollaborationToolsStartAccess == input.CollaborationToolsStartAccess ||
                    (this.CollaborationToolsStartAccess != null &&
                    this.CollaborationToolsStartAccess.Equals(input.CollaborationToolsStartAccess))
                ) && 
                (
                    this.CopyAccess == input.CopyAccess ||
                    (this.CopyAccess != null &&
                    this.CopyAccess.Equals(input.CopyAccess))
                ) && 
                (
                    this.SharingAccess == input.SharingAccess ||
                    (this.SharingAccess != null &&
                    this.SharingAccess.Equals(input.SharingAccess))
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
                if (this.CollaborationToolsStartAccess != null)
                    hashCode = hashCode * 59 + this.CollaborationToolsStartAccess.GetHashCode();
                if (this.CopyAccess != null)
                    hashCode = hashCode * 59 + this.CopyAccess.GetHashCode();
                if (this.SharingAccess != null)
                    hashCode = hashCode * 59 + this.SharingAccess.GetHashCode();
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
