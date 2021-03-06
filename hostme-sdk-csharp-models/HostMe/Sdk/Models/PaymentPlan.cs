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
    /// PaymentPlan
    /// </summary>
    [DataContract]
    public partial class PaymentPlan :  IEquatable<PaymentPlan>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentPlan" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Currency">Currency.</param>
        /// <param name="Created">Created.</param>
        /// <param name="Amount">Amount.</param>
        /// <param name="Interval">Interval.</param>
        /// <param name="IntervalCount">IntervalCount.</param>
        /// <param name="LiveMode">LiveMode.</param>
        /// <param name="StatementDescriptor">StatementDescriptor.</param>
        /// <param name="TrialPeriodDays">TrialPeriodDays.</param>
        /// <param name="Metadata">Metadata.</param>
        public PaymentPlan(string Id = null, string Name = null, string Currency = null, DateTimeOffset? Created = null, int? Amount = null, string Interval = null, int? IntervalCount = null, bool? LiveMode = null, string StatementDescriptor = null, int? TrialPeriodDays = null, Dictionary<string, string> Metadata = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Currency = Currency;
            this.Created = Created;
            this.Amount = Amount;
            this.Interval = Interval;
            this.IntervalCount = IntervalCount;
            this.LiveMode = LiveMode;
            this.StatementDescriptor = StatementDescriptor;
            this.TrialPeriodDays = TrialPeriodDays;
            this.Metadata = Metadata;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=true)]
        public string Currency { get; set; }
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=true)]
        public DateTimeOffset? Created { get; set; }
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=true)]
        public int? Amount { get; set; }
        /// <summary>
        /// Gets or Sets Interval
        /// </summary>
        [DataMember(Name="interval", EmitDefaultValue=true)]
        public string Interval { get; set; }
        /// <summary>
        /// Gets or Sets IntervalCount
        /// </summary>
        [DataMember(Name="intervalCount", EmitDefaultValue=true)]
        public int? IntervalCount { get; set; }
        /// <summary>
        /// Gets or Sets LiveMode
        /// </summary>
        [DataMember(Name="liveMode", EmitDefaultValue=true)]
        public bool? LiveMode { get; set; }
        /// <summary>
        /// Gets or Sets StatementDescriptor
        /// </summary>
        [DataMember(Name="statementDescriptor", EmitDefaultValue=true)]
        public string StatementDescriptor { get; set; }
        /// <summary>
        /// Gets or Sets TrialPeriodDays
        /// </summary>
        [DataMember(Name="trialPeriodDays", EmitDefaultValue=true)]
        public int? TrialPeriodDays { get; set; }
        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=true)]
        public Dictionary<string, string> Metadata { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentPlan {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  IntervalCount: ").Append(IntervalCount).Append("\n");
            sb.Append("  LiveMode: ").Append(LiveMode).Append("\n");
            sb.Append("  StatementDescriptor: ").Append(StatementDescriptor).Append("\n");
            sb.Append("  TrialPeriodDays: ").Append(TrialPeriodDays).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(obj as PaymentPlan);
        }

        /// <summary>
        /// Returns true if PaymentPlan instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentPlan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentPlan other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

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
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.Interval == other.Interval ||
                    this.Interval != null &&
                    this.Interval.Equals(other.Interval)
                ) && 
                (
                    this.IntervalCount == other.IntervalCount ||
                    this.IntervalCount != null &&
                    this.IntervalCount.Equals(other.IntervalCount)
                ) && 
                (
                    this.LiveMode == other.LiveMode ||
                    this.LiveMode != null &&
                    this.LiveMode.Equals(other.LiveMode)
                ) && 
                (
                    this.StatementDescriptor == other.StatementDescriptor ||
                    this.StatementDescriptor != null &&
                    this.StatementDescriptor.Equals(other.StatementDescriptor)
                ) && 
                (
                    this.TrialPeriodDays == other.TrialPeriodDays ||
                    this.TrialPeriodDays != null &&
                    this.TrialPeriodDays.Equals(other.TrialPeriodDays)
                ) && 
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.SequenceEqual(other.Metadata)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.Interval != null)
                    hash = hash * 59 + this.Interval.GetHashCode();
                if (this.IntervalCount != null)
                    hash = hash * 59 + this.IntervalCount.GetHashCode();
                if (this.LiveMode != null)
                    hash = hash * 59 + this.LiveMode.GetHashCode();
                if (this.StatementDescriptor != null)
                    hash = hash * 59 + this.StatementDescriptor.GetHashCode();
                if (this.TrialPeriodDays != null)
                    hash = hash * 59 + this.TrialPeriodDays.GetHashCode();
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}