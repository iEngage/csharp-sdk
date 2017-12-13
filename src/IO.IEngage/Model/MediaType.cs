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
    /// MediaType
    /// </summary>
    [DataContract]
    public partial class MediaType :  IEquatable<MediaType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaType" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="Subtype">Subtype.</param>
        /// <param name="Parameters">Parameters.</param>
        /// <param name="WildcardType">WildcardType (default to false).</param>
        /// <param name="WildcardSubtype">WildcardSubtype (default to false).</param>
        public MediaType(string Type = null, string Subtype = null, Dictionary<string, string> Parameters = null, bool? WildcardType = null, bool? WildcardSubtype = null)
        {
            this.Type = Type;
            this.Subtype = Subtype;
            this.Parameters = Parameters;
            // use default value if no "WildcardType" provided
            if (WildcardType == null)
            {
                this.WildcardType = false;
            }
            else
            {
                this.WildcardType = WildcardType;
            }
            // use default value if no "WildcardSubtype" provided
            if (WildcardSubtype == null)
            {
                this.WildcardSubtype = false;
            }
            else
            {
                this.WildcardSubtype = WildcardSubtype;
            }
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets Subtype
        /// </summary>
        [DataMember(Name="subtype", EmitDefaultValue=false)]
        public string Subtype { get; set; }
        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public Dictionary<string, string> Parameters { get; set; }
        /// <summary>
        /// Gets or Sets WildcardType
        /// </summary>
        [DataMember(Name="wildcardType", EmitDefaultValue=false)]
        public bool? WildcardType { get; set; }
        /// <summary>
        /// Gets or Sets WildcardSubtype
        /// </summary>
        [DataMember(Name="wildcardSubtype", EmitDefaultValue=false)]
        public bool? WildcardSubtype { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaType {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Subtype: ").Append(Subtype).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  WildcardType: ").Append(WildcardType).Append("\n");
            sb.Append("  WildcardSubtype: ").Append(WildcardSubtype).Append("\n");
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
            return this.Equals(obj as MediaType);
        }

        /// <summary>
        /// Returns true if MediaType instances are equal
        /// </summary>
        /// <param name="other">Instance of MediaType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaType other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Subtype == other.Subtype ||
                    this.Subtype != null &&
                    this.Subtype.Equals(other.Subtype)
                ) && 
                (
                    this.Parameters == other.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(other.Parameters)
                ) && 
                (
                    this.WildcardType == other.WildcardType ||
                    this.WildcardType != null &&
                    this.WildcardType.Equals(other.WildcardType)
                ) && 
                (
                    this.WildcardSubtype == other.WildcardSubtype ||
                    this.WildcardSubtype != null &&
                    this.WildcardSubtype.Equals(other.WildcardSubtype)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Subtype != null)
                    hash = hash * 59 + this.Subtype.GetHashCode();
                if (this.Parameters != null)
                    hash = hash * 59 + this.Parameters.GetHashCode();
                if (this.WildcardType != null)
                    hash = hash * 59 + this.WildcardType.GetHashCode();
                if (this.WildcardSubtype != null)
                    hash = hash * 59 + this.WildcardSubtype.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
