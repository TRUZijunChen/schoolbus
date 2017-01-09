/*
 * REST API Documentation for the MOTI School Bus Application
 *
 * The School Bus application tracks that inspections are performed in a timely fashion. For each school bus the application tracks information about the bus (including data from ICBC, NSC, etc.), it's past and next inspection dates and results, contacts, and the inspector responsible for next inspecting the bus.
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
    /// A list of cities in BC. Authoritative source to be determined.
    /// </summary>
    public partial class City : IEquatable<City>
    {
        /// <summary>
        /// Default constructor, required by entity framework
        /// </summary>
        public City()
        {
            this.Id = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="City" /> class.
        /// </summary>
        /// <param name="Id">Primary Key (required).</param>
        /// <param name="_City">The name of the City.</param>
        public City(int Id, string _City = null)
        {
            
            this.Id = Id;
            this._City = _City;
            
        }

        /// <summary>
        /// Primary Key
        /// </summary>
        /// <value>Primary Key</value>
        [MetaDataExtension (Description = "Primary Key")]
        public int Id { get; set; }

        /// <summary>
        /// The name of the City
        /// </summary>
        /// <value>The name of the City</value>
        [MetaDataExtension (Description = "The name of the City")]
        public string _City { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class City {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  _City: ").Append(_City).Append("\n");
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
            return Equals((City)obj);
        }

        /// <summary>
        /// Returns true if City instances are equal
        /// </summary>
        /// <param name="other">Instance of City to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(City other)
        {

            if (ReferenceEquals(null, other)) { return false; }
            if (ReferenceEquals(this, other)) { return true; }

            return 
                (
                    this.Id == other.Id ||
                    
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this._City == other._City ||
                    this._City != null &&
                    this._City.Equals(other._City)
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
                if (this._City != null)
                {
                    hash = hash * 59 + this._City.GetHashCode();
                }
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(City left, City right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(City left, City right)
        {
            return !Equals(left, right);
        }

        #endregion Operators
    }
}
