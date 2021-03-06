/* 
 * Qa full api
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: all
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
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace HostMe.Sdk.Model
{
    /// <summary>
    /// PartiesStatReportItem
    /// </summary>
    [DataContract]
    public partial class PartiesStatReportItem :  IEquatable<PartiesStatReportItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartiesStatReportItem" /> class.
        /// </summary>
        /// <param name="Dimensions">Dimensions.</param>
        /// <param name="WaitingItems">WaitingItems.</param>
        /// <param name="Reservations">Reservations.</param>
        /// <param name="Registrations">Registrations.</param>
        public PartiesStatReportItem(PartiesDimensional Dimensions = null, int? WaitingItems = null, int? Reservations = null, int? Registrations = null)
        {
            this.Dimensions = Dimensions;
            this.WaitingItems = WaitingItems;
            this.Reservations = Reservations;
            this.Registrations = Registrations;
        }
        
        /// <summary>
        /// Gets or Sets Dimensions
        /// </summary>
        [DataMember(Name="dimensions", EmitDefaultValue=true)]
        public PartiesDimensional Dimensions { get; set; }
        /// <summary>
        /// Gets or Sets WaitingItems
        /// </summary>
        [DataMember(Name="waitingItems", EmitDefaultValue=true)]
        public int? WaitingItems { get; set; }
        /// <summary>
        /// Gets or Sets Reservations
        /// </summary>
        [DataMember(Name="reservations", EmitDefaultValue=true)]
        public int? Reservations { get; set; }
        /// <summary>
        /// Gets or Sets Registrations
        /// </summary>
        [DataMember(Name="registrations", EmitDefaultValue=true)]
        public int? Registrations { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PartiesStatReportItem {\n");
            sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("  WaitingItems: ").Append(WaitingItems).Append("\n");
            sb.Append("  Reservations: ").Append(Reservations).Append("\n");
            sb.Append("  Registrations: ").Append(Registrations).Append("\n");
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
            return this.Equals(obj as PartiesStatReportItem);
        }

        /// <summary>
        /// Returns true if PartiesStatReportItem instances are equal
        /// </summary>
        /// <param name="other">Instance of PartiesStatReportItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PartiesStatReportItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Dimensions == other.Dimensions ||
                    this.Dimensions != null &&
                    this.Dimensions.Equals(other.Dimensions)
                ) && 
                (
                    this.WaitingItems == other.WaitingItems ||
                    this.WaitingItems != null &&
                    this.WaitingItems.Equals(other.WaitingItems)
                ) && 
                (
                    this.Reservations == other.Reservations ||
                    this.Reservations != null &&
                    this.Reservations.Equals(other.Reservations)
                ) && 
                (
                    this.Registrations == other.Registrations ||
                    this.Registrations != null &&
                    this.Registrations.Equals(other.Registrations)
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
                if (this.Dimensions != null)
                    hash = hash * 59 + this.Dimensions.GetHashCode();
                if (this.WaitingItems != null)
                    hash = hash * 59 + this.WaitingItems.GetHashCode();
                if (this.Reservations != null)
                    hash = hash * 59 + this.Reservations.GetHashCode();
                if (this.Registrations != null)
                    hash = hash * 59 + this.Registrations.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}