/* 
 * iEngage 2.0 API
 *
 * This API enables Intelligent Engagement for your Business. iEngage is a platform that combines process, augmented intelligence and rewards to help you intelligently engage customers.
 *
 * OpenAPI spec version: 2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IO.IEngage.Model
{
    /// <summary>
    /// User
    /// </summary>
    [DataContract]
    public partial class User :  IEquatable<User>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="UserId">UserId.</param>
        /// <param name="FirstName">FirstName.</param>
        /// <param name="LastName">LastName.</param>
        /// <param name="EmailId">EmailId.</param>
        /// <param name="ProfileImage">ProfileImage.</param>
        /// <param name="HasInterestUpdated">HasInterestUpdated (default to false).</param>
        /// <param name="BirthDate">BirthDate.</param>
        /// <param name="AccessToken">AccessToken.</param>
        /// <param name="CurrentUserFollowing">CurrentUserFollowing (default to false).</param>
        /// <param name="CurrentUserFriend">CurrentUserFriend (default to false).</param>
        /// <param name="EquityScore">EquityScore.</param>
        /// <param name="ExtraData">ExtraData.</param>
        public User(long? UserId = null, string FirstName = null, string LastName = null, string EmailId = null, string ProfileImage = null, bool? HasInterestUpdated = null, DateTime? BirthDate = null, string AccessToken = null, bool? CurrentUserFollowing = null, bool? CurrentUserFriend = null, long? EquityScore = null, string ExtraData = null)
        {
            this.UserId = UserId;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.EmailId = EmailId;
            this.ProfileImage = ProfileImage;
            // use default value if no "HasInterestUpdated" provided
            if (HasInterestUpdated == null)
            {
                this.HasInterestUpdated = false;
            }
            else
            {
                this.HasInterestUpdated = HasInterestUpdated;
            }
            this.BirthDate = BirthDate;
            this.AccessToken = AccessToken;
            // use default value if no "CurrentUserFollowing" provided
            if (CurrentUserFollowing == null)
            {
                this.CurrentUserFollowing = false;
            }
            else
            {
                this.CurrentUserFollowing = CurrentUserFollowing;
            }
            // use default value if no "CurrentUserFriend" provided
            if (CurrentUserFriend == null)
            {
                this.CurrentUserFriend = false;
            }
            else
            {
                this.CurrentUserFriend = CurrentUserFriend;
            }
            this.EquityScore = EquityScore;
            this.ExtraData = ExtraData;
        }
        
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public long? UserId { get; set; }
        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }
        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }
        /// <summary>
        /// Gets or Sets EmailId
        /// </summary>
        [DataMember(Name="emailId", EmitDefaultValue=false)]
        public string EmailId { get; set; }
        /// <summary>
        /// Gets or Sets ProfileImage
        /// </summary>
        [DataMember(Name="profileImage", EmitDefaultValue=false)]
        public string ProfileImage { get; set; }
        /// <summary>
        /// Gets or Sets HasInterestUpdated
        /// </summary>
        [DataMember(Name="hasInterestUpdated", EmitDefaultValue=false)]
        public bool? HasInterestUpdated { get; set; }
        /// <summary>
        /// Gets or Sets BirthDate
        /// </summary>
        [DataMember(Name="birthDate", EmitDefaultValue=false)]
        public DateTime? BirthDate { get; set; }
        /// <summary>
        /// Gets or Sets AccessToken
        /// </summary>
        [DataMember(Name="accessToken", EmitDefaultValue=false)]
        public string AccessToken { get; set; }
        /// <summary>
        /// Gets or Sets CurrentUserFollowing
        /// </summary>
        [DataMember(Name="currentUserFollowing", EmitDefaultValue=false)]
        public bool? CurrentUserFollowing { get; set; }
        /// <summary>
        /// Gets or Sets CurrentUserFriend
        /// </summary>
        [DataMember(Name="currentUserFriend", EmitDefaultValue=false)]
        public bool? CurrentUserFriend { get; set; }
        /// <summary>
        /// Gets or Sets EquityScore
        /// </summary>
        [DataMember(Name="equityScore", EmitDefaultValue=false)]
        public long? EquityScore { get; set; }
        /// <summary>
        /// Gets or Sets ExtraData
        /// </summary>
        [DataMember(Name="extraData", EmitDefaultValue=false)]
        public string ExtraData { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  EmailId: ").Append(EmailId).Append("\n");
            sb.Append("  ProfileImage: ").Append(ProfileImage).Append("\n");
            sb.Append("  HasInterestUpdated: ").Append(HasInterestUpdated).Append("\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  CurrentUserFollowing: ").Append(CurrentUserFollowing).Append("\n");
            sb.Append("  CurrentUserFriend: ").Append(CurrentUserFriend).Append("\n");
            sb.Append("  EquityScore: ").Append(EquityScore).Append("\n");
            sb.Append("  ExtraData: ").Append(ExtraData).Append("\n");
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
            return this.Equals(obj as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="other">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.EmailId == other.EmailId ||
                    this.EmailId != null &&
                    this.EmailId.Equals(other.EmailId)
                ) && 
                (
                    this.ProfileImage == other.ProfileImage ||
                    this.ProfileImage != null &&
                    this.ProfileImage.Equals(other.ProfileImage)
                ) && 
                (
                    this.HasInterestUpdated == other.HasInterestUpdated ||
                    this.HasInterestUpdated != null &&
                    this.HasInterestUpdated.Equals(other.HasInterestUpdated)
                ) && 
                (
                    this.BirthDate == other.BirthDate ||
                    this.BirthDate != null &&
                    this.BirthDate.Equals(other.BirthDate)
                ) && 
                (
                    this.AccessToken == other.AccessToken ||
                    this.AccessToken != null &&
                    this.AccessToken.Equals(other.AccessToken)
                ) && 
                (
                    this.CurrentUserFollowing == other.CurrentUserFollowing ||
                    this.CurrentUserFollowing != null &&
                    this.CurrentUserFollowing.Equals(other.CurrentUserFollowing)
                ) && 
                (
                    this.CurrentUserFriend == other.CurrentUserFriend ||
                    this.CurrentUserFriend != null &&
                    this.CurrentUserFriend.Equals(other.CurrentUserFriend)
                ) && 
                (
                    this.EquityScore == other.EquityScore ||
                    this.EquityScore != null &&
                    this.EquityScore.Equals(other.EquityScore)
                ) && 
                (
                    this.ExtraData == other.ExtraData ||
                    this.ExtraData != null &&
                    this.ExtraData.Equals(other.ExtraData)
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
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.EmailId != null)
                    hash = hash * 59 + this.EmailId.GetHashCode();
                if (this.ProfileImage != null)
                    hash = hash * 59 + this.ProfileImage.GetHashCode();
                if (this.HasInterestUpdated != null)
                    hash = hash * 59 + this.HasInterestUpdated.GetHashCode();
                if (this.BirthDate != null)
                    hash = hash * 59 + this.BirthDate.GetHashCode();
                if (this.AccessToken != null)
                    hash = hash * 59 + this.AccessToken.GetHashCode();
                if (this.CurrentUserFollowing != null)
                    hash = hash * 59 + this.CurrentUserFollowing.GetHashCode();
                if (this.CurrentUserFriend != null)
                    hash = hash * 59 + this.CurrentUserFriend.GetHashCode();
                if (this.EquityScore != null)
                    hash = hash * 59 + this.EquityScore.GetHashCode();
                if (this.ExtraData != null)
                    hash = hash * 59 + this.ExtraData.GetHashCode();
                return hash;
            }
        }
    }

}
