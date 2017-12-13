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
    /// DataHandler
    /// </summary>
    [DataContract]
    public partial class DataHandler :  IEquatable<DataHandler>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataHandler" /> class.
        /// </summary>
        /// <param name="DataSource">DataSource.</param>
        /// <param name="AllCommands">AllCommands.</param>
        /// <param name="PreferredCommands">PreferredCommands.</param>
        /// <param name="TransferDataFlavors">TransferDataFlavors.</param>
        /// <param name="Name">Name.</param>
        /// <param name="InputStream">InputStream.</param>
        /// <param name="Content">Content.</param>
        /// <param name="ContentType">ContentType.</param>
        /// <param name="OutputStream">OutputStream.</param>
        public DataHandler(DataSource DataSource = null, List<CommandInfo> AllCommands = null, List<CommandInfo> PreferredCommands = null, List<DataFlavor> TransferDataFlavors = null, string Name = null, InputStream InputStream = null, Object Content = null, string ContentType = null, OutputStream OutputStream = null)
        {
            this.DataSource = DataSource;
            this.AllCommands = AllCommands;
            this.PreferredCommands = PreferredCommands;
            this.TransferDataFlavors = TransferDataFlavors;
            this.Name = Name;
            this.InputStream = InputStream;
            this.Content = Content;
            this.ContentType = ContentType;
            this.OutputStream = OutputStream;
        }
        
        /// <summary>
        /// Gets or Sets DataSource
        /// </summary>
        [DataMember(Name="dataSource", EmitDefaultValue=false)]
        public DataSource DataSource { get; set; }
        /// <summary>
        /// Gets or Sets AllCommands
        /// </summary>
        [DataMember(Name="allCommands", EmitDefaultValue=false)]
        public List<CommandInfo> AllCommands { get; set; }
        /// <summary>
        /// Gets or Sets PreferredCommands
        /// </summary>
        [DataMember(Name="preferredCommands", EmitDefaultValue=false)]
        public List<CommandInfo> PreferredCommands { get; set; }
        /// <summary>
        /// Gets or Sets TransferDataFlavors
        /// </summary>
        [DataMember(Name="transferDataFlavors", EmitDefaultValue=false)]
        public List<DataFlavor> TransferDataFlavors { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets InputStream
        /// </summary>
        [DataMember(Name="inputStream", EmitDefaultValue=false)]
        public InputStream InputStream { get; set; }
        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public Object Content { get; set; }
        /// <summary>
        /// Gets or Sets ContentType
        /// </summary>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public string ContentType { get; set; }
        /// <summary>
        /// Gets or Sets OutputStream
        /// </summary>
        [DataMember(Name="outputStream", EmitDefaultValue=false)]
        public OutputStream OutputStream { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataHandler {\n");
            sb.Append("  DataSource: ").Append(DataSource).Append("\n");
            sb.Append("  AllCommands: ").Append(AllCommands).Append("\n");
            sb.Append("  PreferredCommands: ").Append(PreferredCommands).Append("\n");
            sb.Append("  TransferDataFlavors: ").Append(TransferDataFlavors).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  InputStream: ").Append(InputStream).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  OutputStream: ").Append(OutputStream).Append("\n");
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
            return this.Equals(obj as DataHandler);
        }

        /// <summary>
        /// Returns true if DataHandler instances are equal
        /// </summary>
        /// <param name="other">Instance of DataHandler to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataHandler other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DataSource == other.DataSource ||
                    this.DataSource != null &&
                    this.DataSource.Equals(other.DataSource)
                ) && 
                (
                    this.AllCommands == other.AllCommands ||
                    this.AllCommands != null &&
                    this.AllCommands.SequenceEqual(other.AllCommands)
                ) && 
                (
                    this.PreferredCommands == other.PreferredCommands ||
                    this.PreferredCommands != null &&
                    this.PreferredCommands.SequenceEqual(other.PreferredCommands)
                ) && 
                (
                    this.TransferDataFlavors == other.TransferDataFlavors ||
                    this.TransferDataFlavors != null &&
                    this.TransferDataFlavors.SequenceEqual(other.TransferDataFlavors)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.InputStream == other.InputStream ||
                    this.InputStream != null &&
                    this.InputStream.Equals(other.InputStream)
                ) && 
                (
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.Equals(other.Content)
                ) && 
                (
                    this.ContentType == other.ContentType ||
                    this.ContentType != null &&
                    this.ContentType.Equals(other.ContentType)
                ) && 
                (
                    this.OutputStream == other.OutputStream ||
                    this.OutputStream != null &&
                    this.OutputStream.Equals(other.OutputStream)
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
                if (this.DataSource != null)
                    hash = hash * 59 + this.DataSource.GetHashCode();
                if (this.AllCommands != null)
                    hash = hash * 59 + this.AllCommands.GetHashCode();
                if (this.PreferredCommands != null)
                    hash = hash * 59 + this.PreferredCommands.GetHashCode();
                if (this.TransferDataFlavors != null)
                    hash = hash * 59 + this.TransferDataFlavors.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.InputStream != null)
                    hash = hash * 59 + this.InputStream.GetHashCode();
                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();
                if (this.ContentType != null)
                    hash = hash * 59 + this.ContentType.GetHashCode();
                if (this.OutputStream != null)
                    hash = hash * 59 + this.OutputStream.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}