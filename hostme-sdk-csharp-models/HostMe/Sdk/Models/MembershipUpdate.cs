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
    /// MembershipUpdate
    /// </summary>
    [DataContract]
    public partial class MembershipUpdate :  IEquatable<MembershipUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MembershipUpdate" /> class.
        /// </summary>
        /// <param name="Note">Note.</param>
        /// <param name="Profile">Profile.</param>
        /// <param name="Customer">Customer.</param>
        public MembershipUpdate(string Note = null, Profile Profile = null, MemberUser Customer = null)
        {
            this.Note = Note;
            this.Profile = Profile;
            this.Customer = Customer;
        }
        
        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue=true)]
        public string Note { get; set; }
        /// <summary>
        /// Gets or Sets Profile
        /// </summary>
        [DataMember(Name="profile", EmitDefaultValue=true)]
        public Profile Profile { get; set; }
        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name="customer", EmitDefaultValue=true)]
        public MemberUser Customer { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MembershipUpdate {\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
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
            return this.Equals(obj as MembershipUpdate);
        }

        /// <summary>
        /// Returns true if MembershipUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of MembershipUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MembershipUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
                ) && 
                (
                    this.Profile == other.Profile ||
                    this.Profile != null &&
                    this.Profile.Equals(other.Profile)
                ) && 
                (
                    this.Customer == other.Customer ||
                    this.Customer != null &&
                    this.Customer.Equals(other.Customer)
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
                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();
                if (this.Profile != null)
                    hash = hash * 59 + this.Profile.GetHashCode();
                if (this.Customer != null)
                    hash = hash * 59 + this.Customer.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}