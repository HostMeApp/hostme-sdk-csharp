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
    /// PaymentCharge
    /// </summary>
    [DataContract]
    public partial class PaymentCharge :  IEquatable<PaymentCharge>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCharge" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Amount">Amount.</param>
        /// <param name="Created">Created.</param>
        /// <param name="Currency">Currency.</param>
        /// <param name="Paid">Paid.</param>
        /// <param name="Refunded">Refunded.</param>
        /// <param name="Status">Status.</param>
        /// <param name="AmountRefunded">AmountRefunded.</param>
        /// <param name="CustomerId">CustomerId.</param>
        public PaymentCharge(int? Id = null, int? Amount = null, DateTimeOffset? Created = null, string Currency = null, bool? Paid = null, bool? Refunded = null, string Status = null, int? AmountRefunded = null, string CustomerId = null)
        {
            this.Id = Id;
            this.Amount = Amount;
            this.Created = Created;
            this.Currency = Currency;
            this.Paid = Paid;
            this.Refunded = Refunded;
            this.Status = Status;
            this.AmountRefunded = AmountRefunded;
            this.CustomerId = CustomerId;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public int? Id { get; set; }
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=true)]
        public int? Amount { get; set; }
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=true)]
        public DateTimeOffset? Created { get; set; }
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=true)]
        public string Currency { get; set; }
        /// <summary>
        /// Gets or Sets Paid
        /// </summary>
        [DataMember(Name="paid", EmitDefaultValue=true)]
        public bool? Paid { get; set; }
        /// <summary>
        /// Gets or Sets Refunded
        /// </summary>
        [DataMember(Name="refunded", EmitDefaultValue=true)]
        public bool? Refunded { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public string Status { get; set; }
        /// <summary>
        /// Gets or Sets AmountRefunded
        /// </summary>
        [DataMember(Name="amountRefunded", EmitDefaultValue=true)]
        public int? AmountRefunded { get; set; }
        /// <summary>
        /// Gets or Sets CustomerId
        /// </summary>
        [DataMember(Name="customerId", EmitDefaultValue=true)]
        public string CustomerId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentCharge {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Paid: ").Append(Paid).Append("\n");
            sb.Append("  Refunded: ").Append(Refunded).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  AmountRefunded: ").Append(AmountRefunded).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
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
            return this.Equals(obj as PaymentCharge);
        }

        /// <summary>
        /// Returns true if PaymentCharge instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentCharge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentCharge other)
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
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.Paid == other.Paid ||
                    this.Paid != null &&
                    this.Paid.Equals(other.Paid)
                ) && 
                (
                    this.Refunded == other.Refunded ||
                    this.Refunded != null &&
                    this.Refunded.Equals(other.Refunded)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.AmountRefunded == other.AmountRefunded ||
                    this.AmountRefunded != null &&
                    this.AmountRefunded.Equals(other.AmountRefunded)
                ) && 
                (
                    this.CustomerId == other.CustomerId ||
                    this.CustomerId != null &&
                    this.CustomerId.Equals(other.CustomerId)
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
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.Paid != null)
                    hash = hash * 59 + this.Paid.GetHashCode();
                if (this.Refunded != null)
                    hash = hash * 59 + this.Refunded.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.AmountRefunded != null)
                    hash = hash * 59 + this.AmountRefunded.GetHashCode();
                if (this.CustomerId != null)
                    hash = hash * 59 + this.CustomerId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}