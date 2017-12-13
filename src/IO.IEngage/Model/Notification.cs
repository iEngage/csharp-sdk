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
    /// Notification
    /// </summary>
    [DataContract]
    public partial class Notification :  IEquatable<Notification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Notification" /> class.
        /// </summary>
        /// <param name="NotificationId">NotificationId.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Message">Message.</param>
        /// <param name="Date">Date.</param>
        /// <param name="ByUser">ByUser.</param>
        /// <param name="Entity">Entity.</param>
        /// <param name="ParentEntity">ParentEntity.</param>
        /// <param name="ExtraData">ExtraData.</param>
        /// <param name="Read">Read (default to false).</param>
        public Notification(long? NotificationId = null, string Type = null, string Message = null, DateTime? Date = null, User ByUser = null, Entity Entity = null, Entity ParentEntity = null, string ExtraData = null, bool? Read = null)
        {
            this.NotificationId = NotificationId;
            this.Type = Type;
            this.Message = Message;
            this.Date = Date;
            this.ByUser = ByUser;
            this.Entity = Entity;
            this.ParentEntity = ParentEntity;
            this.ExtraData = ExtraData;
            // use default value if no "Read" provided
            if (Read == null)
            {
                this.Read = false;
            }
            else
            {
                this.Read = Read;
            }
        }
        
        /// <summary>
        /// Gets or Sets NotificationId
        /// </summary>
        [DataMember(Name="notificationId", EmitDefaultValue=false)]
        public long? NotificationId { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }
        /// <summary>
        /// Gets or Sets ByUser
        /// </summary>
        [DataMember(Name="byUser", EmitDefaultValue=false)]
        public User ByUser { get; set; }
        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public Entity Entity { get; set; }
        /// <summary>
        /// Gets or Sets ParentEntity
        /// </summary>
        [DataMember(Name="parentEntity", EmitDefaultValue=false)]
        public Entity ParentEntity { get; set; }
        /// <summary>
        /// Gets or Sets ExtraData
        /// </summary>
        [DataMember(Name="extraData", EmitDefaultValue=false)]
        public string ExtraData { get; set; }
        /// <summary>
        /// Gets or Sets Read
        /// </summary>
        [DataMember(Name="read", EmitDefaultValue=false)]
        public bool? Read { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Notification {\n");
            sb.Append("  NotificationId: ").Append(NotificationId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  ByUser: ").Append(ByUser).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  ParentEntity: ").Append(ParentEntity).Append("\n");
            sb.Append("  ExtraData: ").Append(ExtraData).Append("\n");
            sb.Append("  Read: ").Append(Read).Append("\n");
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
            return this.Equals(obj as Notification);
        }

        /// <summary>
        /// Returns true if Notification instances are equal
        /// </summary>
        /// <param name="other">Instance of Notification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Notification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NotificationId == other.NotificationId ||
                    this.NotificationId != null &&
                    this.NotificationId.Equals(other.NotificationId)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
                ) && 
                (
                    this.ByUser == other.ByUser ||
                    this.ByUser != null &&
                    this.ByUser.Equals(other.ByUser)
                ) && 
                (
                    this.Entity == other.Entity ||
                    this.Entity != null &&
                    this.Entity.Equals(other.Entity)
                ) && 
                (
                    this.ParentEntity == other.ParentEntity ||
                    this.ParentEntity != null &&
                    this.ParentEntity.Equals(other.ParentEntity)
                ) && 
                (
                    this.ExtraData == other.ExtraData ||
                    this.ExtraData != null &&
                    this.ExtraData.Equals(other.ExtraData)
                ) && 
                (
                    this.Read == other.Read ||
                    this.Read != null &&
                    this.Read.Equals(other.Read)
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
                if (this.NotificationId != null)
                    hash = hash * 59 + this.NotificationId.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();
                if (this.ByUser != null)
                    hash = hash * 59 + this.ByUser.GetHashCode();
                if (this.Entity != null)
                    hash = hash * 59 + this.Entity.GetHashCode();
                if (this.ParentEntity != null)
                    hash = hash * 59 + this.ParentEntity.GetHashCode();
                if (this.ExtraData != null)
                    hash = hash * 59 + this.ExtraData.GetHashCode();
                if (this.Read != null)
                    hash = hash * 59 + this.Read.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
