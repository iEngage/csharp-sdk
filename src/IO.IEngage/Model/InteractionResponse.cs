/* 
 * Stakeholder engagement API
 *
 * This API enables Intelligent Engagement for your Business. iEngage is a platform that combines process, augmented intelligence and rewards to help you intelligently engage customers.
 *
 * OpenAPI spec version: 1.0
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

namespace IO.IEngage.Model
{
    /// <summary>
    /// InteractionResponse
    /// </summary>
    [DataContract]
    public partial class InteractionResponse :  IEquatable<InteractionResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InteractionResponse" /> class.
        /// </summary>
        /// <param name="ResponseId">ResponseId.</param>
        /// <param name="ResponseDescription">ResponseDescription.</param>
        /// <param name="InteractionId">InteractionId.</param>
        /// <param name="RespondingUser">RespondingUser.</param>
        /// <param name="CreatedDate">CreatedDate.</param>
        /// <param name="IsMarkedResponse">IsMarkedResponse (default to false).</param>
        /// <param name="NoOfLikes">NoOfLikes.</param>
        /// <param name="NoOfDislikes">NoOfDislikes.</param>
        /// <param name="ReplyCount">ReplyCount.</param>
        /// <param name="IsLiked">IsLiked (default to false).</param>
        /// <param name="IsDisliked">IsDisliked (default to false).</param>
        /// <param name="InteractionType">InteractionType.</param>
        public InteractionResponse(long? ResponseId = null, string ResponseDescription = null, long? InteractionId = null, User RespondingUser = null, DateTime? CreatedDate = null, bool? IsMarkedResponse = null, int? NoOfLikes = null, int? NoOfDislikes = null, int? ReplyCount = null, bool? IsLiked = null, bool? IsDisliked = null, string InteractionType = null)
        {
            this.ResponseId = ResponseId;
            this.ResponseDescription = ResponseDescription;
            this.InteractionId = InteractionId;
            this.RespondingUser = RespondingUser;
            this.CreatedDate = CreatedDate;
            // use default value if no "IsMarkedResponse" provided
            if (IsMarkedResponse == null)
            {
                this.IsMarkedResponse = false;
            }
            else
            {
                this.IsMarkedResponse = IsMarkedResponse;
            }
            this.NoOfLikes = NoOfLikes;
            this.NoOfDislikes = NoOfDislikes;
            this.ReplyCount = ReplyCount;
            // use default value if no "IsLiked" provided
            if (IsLiked == null)
            {
                this.IsLiked = false;
            }
            else
            {
                this.IsLiked = IsLiked;
            }
            // use default value if no "IsDisliked" provided
            if (IsDisliked == null)
            {
                this.IsDisliked = false;
            }
            else
            {
                this.IsDisliked = IsDisliked;
            }
            this.InteractionType = InteractionType;
        }
        
        /// <summary>
        /// Gets or Sets ResponseId
        /// </summary>
        [DataMember(Name="responseId", EmitDefaultValue=false)]
        public long? ResponseId { get; set; }
        /// <summary>
        /// Gets or Sets ResponseDescription
        /// </summary>
        [DataMember(Name="responseDescription", EmitDefaultValue=false)]
        public string ResponseDescription { get; set; }
        /// <summary>
        /// Gets or Sets InteractionId
        /// </summary>
        [DataMember(Name="interactionId", EmitDefaultValue=false)]
        public long? InteractionId { get; set; }
        /// <summary>
        /// Gets or Sets RespondingUser
        /// </summary>
        [DataMember(Name="respondingUser", EmitDefaultValue=false)]
        public User RespondingUser { get; set; }
        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }
        /// <summary>
        /// Gets or Sets IsMarkedResponse
        /// </summary>
        [DataMember(Name="isMarkedResponse", EmitDefaultValue=false)]
        public bool? IsMarkedResponse { get; set; }
        /// <summary>
        /// Gets or Sets NoOfLikes
        /// </summary>
        [DataMember(Name="noOfLikes", EmitDefaultValue=false)]
        public int? NoOfLikes { get; set; }
        /// <summary>
        /// Gets or Sets NoOfDislikes
        /// </summary>
        [DataMember(Name="noOfDislikes", EmitDefaultValue=false)]
        public int? NoOfDislikes { get; set; }
        /// <summary>
        /// Gets or Sets ReplyCount
        /// </summary>
        [DataMember(Name="replyCount", EmitDefaultValue=false)]
        public int? ReplyCount { get; set; }
        /// <summary>
        /// Gets or Sets IsLiked
        /// </summary>
        [DataMember(Name="isLiked", EmitDefaultValue=false)]
        public bool? IsLiked { get; set; }
        /// <summary>
        /// Gets or Sets IsDisliked
        /// </summary>
        [DataMember(Name="isDisliked", EmitDefaultValue=false)]
        public bool? IsDisliked { get; set; }
        /// <summary>
        /// Gets or Sets InteractionType
        /// </summary>
        [DataMember(Name="interactionType", EmitDefaultValue=false)]
        public string InteractionType { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InteractionResponse {\n");
            sb.Append("  ResponseId: ").Append(ResponseId).Append("\n");
            sb.Append("  ResponseDescription: ").Append(ResponseDescription).Append("\n");
            sb.Append("  InteractionId: ").Append(InteractionId).Append("\n");
            sb.Append("  RespondingUser: ").Append(RespondingUser).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  IsMarkedResponse: ").Append(IsMarkedResponse).Append("\n");
            sb.Append("  NoOfLikes: ").Append(NoOfLikes).Append("\n");
            sb.Append("  NoOfDislikes: ").Append(NoOfDislikes).Append("\n");
            sb.Append("  ReplyCount: ").Append(ReplyCount).Append("\n");
            sb.Append("  IsLiked: ").Append(IsLiked).Append("\n");
            sb.Append("  IsDisliked: ").Append(IsDisliked).Append("\n");
            sb.Append("  InteractionType: ").Append(InteractionType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as InteractionResponse);
        }

        /// <summary>
        /// Returns true if InteractionResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of InteractionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InteractionResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ResponseId == other.ResponseId ||
                    this.ResponseId != null &&
                    this.ResponseId.Equals(other.ResponseId)
                ) && 
                (
                    this.ResponseDescription == other.ResponseDescription ||
                    this.ResponseDescription != null &&
                    this.ResponseDescription.Equals(other.ResponseDescription)
                ) && 
                (
                    this.InteractionId == other.InteractionId ||
                    this.InteractionId != null &&
                    this.InteractionId.Equals(other.InteractionId)
                ) && 
                (
                    this.RespondingUser == other.RespondingUser ||
                    this.RespondingUser != null &&
                    this.RespondingUser.Equals(other.RespondingUser)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.IsMarkedResponse == other.IsMarkedResponse ||
                    this.IsMarkedResponse != null &&
                    this.IsMarkedResponse.Equals(other.IsMarkedResponse)
                ) && 
                (
                    this.NoOfLikes == other.NoOfLikes ||
                    this.NoOfLikes != null &&
                    this.NoOfLikes.Equals(other.NoOfLikes)
                ) && 
                (
                    this.NoOfDislikes == other.NoOfDislikes ||
                    this.NoOfDislikes != null &&
                    this.NoOfDislikes.Equals(other.NoOfDislikes)
                ) && 
                (
                    this.ReplyCount == other.ReplyCount ||
                    this.ReplyCount != null &&
                    this.ReplyCount.Equals(other.ReplyCount)
                ) && 
                (
                    this.IsLiked == other.IsLiked ||
                    this.IsLiked != null &&
                    this.IsLiked.Equals(other.IsLiked)
                ) && 
                (
                    this.IsDisliked == other.IsDisliked ||
                    this.IsDisliked != null &&
                    this.IsDisliked.Equals(other.IsDisliked)
                ) && 
                (
                    this.InteractionType == other.InteractionType ||
                    this.InteractionType != null &&
                    this.InteractionType.Equals(other.InteractionType)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ResponseId != null)
                    hash = hash * 59 + this.ResponseId.GetHashCode();
                if (this.ResponseDescription != null)
                    hash = hash * 59 + this.ResponseDescription.GetHashCode();
                if (this.InteractionId != null)
                    hash = hash * 59 + this.InteractionId.GetHashCode();
                if (this.RespondingUser != null)
                    hash = hash * 59 + this.RespondingUser.GetHashCode();
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.IsMarkedResponse != null)
                    hash = hash * 59 + this.IsMarkedResponse.GetHashCode();
                if (this.NoOfLikes != null)
                    hash = hash * 59 + this.NoOfLikes.GetHashCode();
                if (this.NoOfDislikes != null)
                    hash = hash * 59 + this.NoOfDislikes.GetHashCode();
                if (this.ReplyCount != null)
                    hash = hash * 59 + this.ReplyCount.GetHashCode();
                if (this.IsLiked != null)
                    hash = hash * 59 + this.IsLiked.GetHashCode();
                if (this.IsDisliked != null)
                    hash = hash * 59 + this.IsDisliked.GetHashCode();
                if (this.InteractionType != null)
                    hash = hash * 59 + this.InteractionType.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
