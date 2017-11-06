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
    /// PaymentCreateSubscrition
    /// </summary>
    [DataContract]
    public partial class PaymentCreateSubscrition :  IEquatable<PaymentCreateSubscrition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCreateSubscrition" /> class.
        /// </summary>
        /// <param name="PlanId">PlanId.</param>
        /// <param name="SourceToken">SourceToken.</param>
        /// <param name="CouponId">CouponId.</param>
        public PaymentCreateSubscrition(string PlanId = null, string SourceToken = null, string CouponId = null)
        {
            this.PlanId = PlanId;
            this.SourceToken = SourceToken;
            this.CouponId = CouponId;
        }
        
        /// <summary>
        /// Gets or Sets PlanId
        /// </summary>
        [DataMember(Name="planId", EmitDefaultValue=true)]
        public string PlanId { get; set; }
        /// <summary>
        /// Gets or Sets SourceToken
        /// </summary>
        [DataMember(Name="sourceToken", EmitDefaultValue=true)]
        public string SourceToken { get; set; }
        /// <summary>
        /// Gets or Sets CouponId
        /// </summary>
        [DataMember(Name="couponId", EmitDefaultValue=true)]
        public string CouponId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentCreateSubscrition {\n");
            sb.Append("  PlanId: ").Append(PlanId).Append("\n");
            sb.Append("  SourceToken: ").Append(SourceToken).Append("\n");
            sb.Append("  CouponId: ").Append(CouponId).Append("\n");
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
            return this.Equals(obj as PaymentCreateSubscrition);
        }

        /// <summary>
        /// Returns true if PaymentCreateSubscrition instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentCreateSubscrition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentCreateSubscrition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PlanId == other.PlanId ||
                    this.PlanId != null &&
                    this.PlanId.Equals(other.PlanId)
                ) && 
                (
                    this.SourceToken == other.SourceToken ||
                    this.SourceToken != null &&
                    this.SourceToken.Equals(other.SourceToken)
                ) && 
                (
                    this.CouponId == other.CouponId ||
                    this.CouponId != null &&
                    this.CouponId.Equals(other.CouponId)
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
                if (this.PlanId != null)
                    hash = hash * 59 + this.PlanId.GetHashCode();
                if (this.SourceToken != null)
                    hash = hash * 59 + this.SourceToken.GetHashCode();
                if (this.CouponId != null)
                    hash = hash * 59 + this.CouponId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}