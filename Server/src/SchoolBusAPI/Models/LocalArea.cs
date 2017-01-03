/*
 * REST API Documentation for Schoolbus
 *
 * API Sample
 *
 * OpenAPI spec version: v1
 * 
 * 
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

namespace SchoolBusAPI.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class LocalArea : IEquatable<LocalArea>
    {
        /// <summary>
        /// Default constructor, required by entity framework
        /// </summary>
        public LocalArea()
        {
            this.Id = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalArea" /> class.
        /// </summary>
        /// <param name="Id">Primary Key (required).</param>
        /// <param name="Name">City Name.</param>
        /// <param name="Region">Region.</param>
        public LocalArea(int Id, string Name = null, Region Region = null)
        {
            
            this.Id = Id;
            this.Name = Name;
            this.Region = Region;
            
        }

        /// <summary>
        /// Primary Key
        /// </summary>
        /// <value>Primary Key</value>
        [MetaDataExtension (Description = "Primary Key")]
        public int Id { get; set; }

        /// <summary>
        /// City Name
        /// </summary>
        /// <value>City Name</value>
        [MetaDataExtension (Description = "City Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        public Region Region { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocalArea {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
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
            if (ReferenceEquals(null, obj)) { return false; }
            if (ReferenceEquals(this, obj)) { return true; }
            if (obj.GetType() != GetType()) { return false; }
            return Equals((LocalArea)obj);
        }

        /// <summary>
        /// Returns true if LocalArea instances are equal
        /// </summary>
        /// <param name="other">Instance of LocalArea to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocalArea other)
        {

            if (ReferenceEquals(null, other)) { return false; }
            if (ReferenceEquals(this, other)) { return true; }

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Region == other.Region ||
                    this.Region != null &&
                    this.Region.Equals(other.Region)
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
                // Suitable nullity checks
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hash = hash * 59 + this.Name.GetHashCode();
                }
                if (this.Region != null)
                {
                    hash = hash * 59 + this.Region.GetHashCode();
                }
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(LocalArea left, LocalArea right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(LocalArea left, LocalArea right)
        {
            return !Equals(left, right);
        }

        #endregion Operators
    }
}
