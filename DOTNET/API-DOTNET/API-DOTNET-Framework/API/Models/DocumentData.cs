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
    /// DocumentData
    /// </summary>
    [DataContract]
        public partial class DocumentData :  IEquatable<DocumentData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentData" /> class.
        /// </summary>
        /// <param name="documentUrl">The URL to download the resource. You must use your access token to access the URL. The URL contains the &#x60;redirect&#x60; parameter to control the request execution.  &#x60;redirect&#x60;: By default, the &#x60;redirect&#x60; parameter is set to &#x60;false&#x60; and the resource object containing the URL and the resource type is returned with a 200 OK HTTP code. This URL is valid for 60 seconds. You can use this URL to retrieve the resource file. If the &#x60;redirect&#x60; parameter is set to &#x60;true&#x60;, a 307 TEMPORARY_REDIRECT HTTP response is returned. If you follow HTTP 3xx responses as redirects, you will automatically be redirected to the resource file and the content type returned is &#x60;application/octet-stream&#x60;..</param>
        /// <param name="title">A short text header to identify the document..</param>
        public DocumentData(string documentUrl = default(string), string title = default(string))
        {
            this.DocumentUrl = documentUrl;
            this.Title = title;
        }
        
        /// <summary>
        /// The URL to download the resource. You must use your access token to access the URL. The URL contains the &#x60;redirect&#x60; parameter to control the request execution.  &#x60;redirect&#x60;: By default, the &#x60;redirect&#x60; parameter is set to &#x60;false&#x60; and the resource object containing the URL and the resource type is returned with a 200 OK HTTP code. This URL is valid for 60 seconds. You can use this URL to retrieve the resource file. If the &#x60;redirect&#x60; parameter is set to &#x60;true&#x60;, a 307 TEMPORARY_REDIRECT HTTP response is returned. If you follow HTTP 3xx responses as redirects, you will automatically be redirected to the resource file and the content type returned is &#x60;application/octet-stream&#x60;.
        /// </summary>
        /// <value>The URL to download the resource. You must use your access token to access the URL. The URL contains the &#x60;redirect&#x60; parameter to control the request execution.  &#x60;redirect&#x60;: By default, the &#x60;redirect&#x60; parameter is set to &#x60;false&#x60; and the resource object containing the URL and the resource type is returned with a 200 OK HTTP code. This URL is valid for 60 seconds. You can use this URL to retrieve the resource file. If the &#x60;redirect&#x60; parameter is set to &#x60;true&#x60;, a 307 TEMPORARY_REDIRECT HTTP response is returned. If you follow HTTP 3xx responses as redirects, you will automatically be redirected to the resource file and the content type returned is &#x60;application/octet-stream&#x60;.</value>
        [DataMember(Name="documentUrl", EmitDefaultValue=false)]
        public string DocumentUrl { get; set; }

        /// <summary>
        /// A short text header to identify the document.
        /// </summary>
        /// <value>A short text header to identify the document.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentData {\n");
            sb.Append("  DocumentUrl: ").Append(DocumentUrl).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as DocumentData);
        }

        /// <summary>
        /// Returns true if DocumentData instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocumentUrl == input.DocumentUrl ||
                    (this.DocumentUrl != null &&
                    this.DocumentUrl.Equals(input.DocumentUrl))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.DocumentUrl != null)
                    hashCode = hashCode * 59 + this.DocumentUrl.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
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
