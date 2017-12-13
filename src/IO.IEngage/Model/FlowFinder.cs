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
    /// FlowFinder
    /// </summary>
    [DataContract]
    public partial class FlowFinder :  IEquatable<FlowFinder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowFinder" /> class.
        /// </summary>
        /// <param name="Question">Question.</param>
        /// <param name="Complaint">Complaint.</param>
        /// <param name="Suggestion">Suggestion.</param>
        /// <param name="Appreciation">Appreciation.</param>
        /// <param name="Comment">Comment.</param>
        public FlowFinder(double? Question = null, double? Complaint = null, double? Suggestion = null, double? Appreciation = null, double? Comment = null)
        {
            this.Question = Question;
            this.Complaint = Complaint;
            this.Suggestion = Suggestion;
            this.Appreciation = Appreciation;
            this.Comment = Comment;
        }
        
        /// <summary>
        /// Gets or Sets Question
        /// </summary>
        [DataMember(Name="question", EmitDefaultValue=false)]
        public double? Question { get; set; }
        /// <summary>
        /// Gets or Sets Complaint
        /// </summary>
        [DataMember(Name="complaint", EmitDefaultValue=false)]
        public double? Complaint { get; set; }
        /// <summary>
        /// Gets or Sets Suggestion
        /// </summary>
        [DataMember(Name="suggestion", EmitDefaultValue=false)]
        public double? Suggestion { get; set; }
        /// <summary>
        /// Gets or Sets Appreciation
        /// </summary>
        [DataMember(Name="appreciation", EmitDefaultValue=false)]
        public double? Appreciation { get; set; }
        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public double? Comment { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowFinder {\n");
            sb.Append("  Question: ").Append(Question).Append("\n");
            sb.Append("  Complaint: ").Append(Complaint).Append("\n");
            sb.Append("  Suggestion: ").Append(Suggestion).Append("\n");
            sb.Append("  Appreciation: ").Append(Appreciation).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
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
            return this.Equals(obj as FlowFinder);
        }

        /// <summary>
        /// Returns true if FlowFinder instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowFinder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowFinder other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Question == other.Question ||
                    this.Question != null &&
                    this.Question.Equals(other.Question)
                ) && 
                (
                    this.Complaint == other.Complaint ||
                    this.Complaint != null &&
                    this.Complaint.Equals(other.Complaint)
                ) && 
                (
                    this.Suggestion == other.Suggestion ||
                    this.Suggestion != null &&
                    this.Suggestion.Equals(other.Suggestion)
                ) && 
                (
                    this.Appreciation == other.Appreciation ||
                    this.Appreciation != null &&
                    this.Appreciation.Equals(other.Appreciation)
                ) && 
                (
                    this.Comment == other.Comment ||
                    this.Comment != null &&
                    this.Comment.Equals(other.Comment)
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
                if (this.Question != null)
                    hash = hash * 59 + this.Question.GetHashCode();
                if (this.Complaint != null)
                    hash = hash * 59 + this.Complaint.GetHashCode();
                if (this.Suggestion != null)
                    hash = hash * 59 + this.Suggestion.GetHashCode();
                if (this.Appreciation != null)
                    hash = hash * 59 + this.Appreciation.GetHashCode();
                if (this.Comment != null)
                    hash = hash * 59 + this.Comment.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
