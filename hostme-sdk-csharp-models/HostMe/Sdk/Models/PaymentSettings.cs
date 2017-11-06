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
    /// PaymentSettings
    /// </summary>
    [DataContract]
    public partial class PaymentSettings :  IEquatable<PaymentSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSettings" /> class.
        /// </summary>
        /// <param name="PartiesFromWaitings">PartiesFromWaitings.</param>
        /// <param name="PartiesFromReservations">PartiesFromReservations.</param>
        /// <param name="PartiesFromTables">PartiesFromTables.</param>
        /// <param name="LastWeekParties">LastWeekParties.</param>
        /// <param name="LimitsExceededDate">LimitsExceededDate.</param>
        /// <param name="Plans">Plans.</param>
        public PaymentSettings(int? PartiesFromWaitings = null, int? PartiesFromReservations = null, int? PartiesFromTables = null, int? LastWeekParties = null, DateTimeOffset? LimitsExceededDate = null, List<PaymentPlan> Plans = null)
        {
            this.PartiesFromWaitings = PartiesFromWaitings;
            this.PartiesFromReservations = PartiesFromReservations;
            this.PartiesFromTables = PartiesFromTables;
            this.LastWeekParties = LastWeekParties;
            this.LimitsExceededDate = LimitsExceededDate;
            this.Plans = Plans;
        }
        
        /// <summary>
        /// Gets or Sets PartiesFromWaitings
        /// </summary>
        [DataMember(Name="partiesFromWaitings", EmitDefaultValue=true)]
        public int? PartiesFromWaitings { get; set; }
        /// <summary>
        /// Gets or Sets PartiesFromReservations
        /// </summary>
        [DataMember(Name="partiesFromReservations", EmitDefaultValue=true)]
        public int? PartiesFromReservations { get; set; }
        /// <summary>
        /// Gets or Sets PartiesFromTables
        /// </summary>
        [DataMember(Name="partiesFromTables", EmitDefaultValue=true)]
        public int? PartiesFromTables { get; set; }
        /// <summary>
        /// Gets or Sets LastWeekParties
        /// </summary>
        [DataMember(Name="lastWeekParties", EmitDefaultValue=true)]
        public int? LastWeekParties { get; set; }
        /// <summary>
        /// Gets or Sets LimitsExceededDate
        /// </summary>
        [DataMember(Name="limitsExceededDate", EmitDefaultValue=true)]
        public DateTimeOffset? LimitsExceededDate { get; set; }
        /// <summary>
        /// Gets or Sets Plans
        /// </summary>
        [DataMember(Name="plans", EmitDefaultValue=true)]
        public List<PaymentPlan> Plans { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentSettings {\n");
            sb.Append("  PartiesFromWaitings: ").Append(PartiesFromWaitings).Append("\n");
            sb.Append("  PartiesFromReservations: ").Append(PartiesFromReservations).Append("\n");
            sb.Append("  PartiesFromTables: ").Append(PartiesFromTables).Append("\n");
            sb.Append("  LastWeekParties: ").Append(LastWeekParties).Append("\n");
            sb.Append("  LimitsExceededDate: ").Append(LimitsExceededDate).Append("\n");
            sb.Append("  Plans: ").Append(Plans).Append("\n");
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
            return this.Equals(obj as PaymentSettings);
        }

        /// <summary>
        /// Returns true if PaymentSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PartiesFromWaitings == other.PartiesFromWaitings ||
                    this.PartiesFromWaitings != null &&
                    this.PartiesFromWaitings.Equals(other.PartiesFromWaitings)
                ) && 
                (
                    this.PartiesFromReservations == other.PartiesFromReservations ||
                    this.PartiesFromReservations != null &&
                    this.PartiesFromReservations.Equals(other.PartiesFromReservations)
                ) && 
                (
                    this.PartiesFromTables == other.PartiesFromTables ||
                    this.PartiesFromTables != null &&
                    this.PartiesFromTables.Equals(other.PartiesFromTables)
                ) && 
                (
                    this.LastWeekParties == other.LastWeekParties ||
                    this.LastWeekParties != null &&
                    this.LastWeekParties.Equals(other.LastWeekParties)
                ) && 
                (
                    this.LimitsExceededDate == other.LimitsExceededDate ||
                    this.LimitsExceededDate != null &&
                    this.LimitsExceededDate.Equals(other.LimitsExceededDate)
                ) && 
                (
                    this.Plans == other.Plans ||
                    this.Plans != null &&
                    this.Plans.SequenceEqual(other.Plans)
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
                if (this.PartiesFromWaitings != null)
                    hash = hash * 59 + this.PartiesFromWaitings.GetHashCode();
                if (this.PartiesFromReservations != null)
                    hash = hash * 59 + this.PartiesFromReservations.GetHashCode();
                if (this.PartiesFromTables != null)
                    hash = hash * 59 + this.PartiesFromTables.GetHashCode();
                if (this.LastWeekParties != null)
                    hash = hash * 59 + this.LastWeekParties.GetHashCode();
                if (this.LimitsExceededDate != null)
                    hash = hash * 59 + this.LimitsExceededDate.GetHashCode();
                if (this.Plans != null)
                    hash = hash * 59 + this.Plans.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}