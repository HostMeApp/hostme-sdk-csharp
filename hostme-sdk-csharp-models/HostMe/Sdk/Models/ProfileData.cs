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
    /// ProfileData
    /// </summary>
    [DataContract]
    public partial class ProfileData :  IEquatable<ProfileData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileData" /> class.
        /// </summary>
        /// <param name="Allergy">Allergy.</param>
        /// <param name="Vegetarian">Vegetarian.</param>
        /// <param name="Vip">Vip.</param>
        /// <param name="HandicapAccessible">HandicapAccessible.</param>
        /// <param name="Anniversary">Anniversary.</param>
        /// <param name="CompanyName">CompanyName.</param>
        /// <param name="OfficePhone">OfficePhone.</param>
        /// <param name="OfficeAddress">OfficeAddress.</param>
        /// <param name="TablePreferences">TablePreferences.</param>
        public ProfileData(List<string> Allergy = null, bool? Vegetarian = null, bool? Vip = null, bool? HandicapAccessible = null, DateTimeOffset? Anniversary = null, string CompanyName = null, string OfficePhone = null, string OfficeAddress = null, string TablePreferences = null)
        {
            this.Allergy = Allergy;
            this.Vegetarian = Vegetarian;
            this.Vip = Vip;
            this.HandicapAccessible = HandicapAccessible;
            this.Anniversary = Anniversary;
            this.CompanyName = CompanyName;
            this.OfficePhone = OfficePhone;
            this.OfficeAddress = OfficeAddress;
            this.TablePreferences = TablePreferences;
        }
        
        /// <summary>
        /// Gets or Sets Allergy
        /// </summary>
        [DataMember(Name="allergy", EmitDefaultValue=true)]
        public List<string> Allergy { get; set; }
        /// <summary>
        /// Gets or Sets Vegetarian
        /// </summary>
        [DataMember(Name="vegetarian", EmitDefaultValue=true)]
        public bool? Vegetarian { get; set; }
        /// <summary>
        /// Gets or Sets Vip
        /// </summary>
        [DataMember(Name="vip", EmitDefaultValue=true)]
        public bool? Vip { get; set; }
        /// <summary>
        /// Gets or Sets HandicapAccessible
        /// </summary>
        [DataMember(Name="handicapAccessible", EmitDefaultValue=true)]
        public bool? HandicapAccessible { get; set; }
        /// <summary>
        /// Gets or Sets Anniversary
        /// </summary>
        [DataMember(Name="anniversary", EmitDefaultValue=true)]
        public DateTimeOffset? Anniversary { get; set; }
        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name="companyName", EmitDefaultValue=true)]
        public string CompanyName { get; set; }
        /// <summary>
        /// Gets or Sets OfficePhone
        /// </summary>
        [DataMember(Name="officePhone", EmitDefaultValue=true)]
        public string OfficePhone { get; set; }
        /// <summary>
        /// Gets or Sets OfficeAddress
        /// </summary>
        [DataMember(Name="officeAddress", EmitDefaultValue=true)]
        public string OfficeAddress { get; set; }
        /// <summary>
        /// Gets or Sets TablePreferences
        /// </summary>
        [DataMember(Name="tablePreferences", EmitDefaultValue=true)]
        public string TablePreferences { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProfileData {\n");
            sb.Append("  Allergy: ").Append(Allergy).Append("\n");
            sb.Append("  Vegetarian: ").Append(Vegetarian).Append("\n");
            sb.Append("  Vip: ").Append(Vip).Append("\n");
            sb.Append("  HandicapAccessible: ").Append(HandicapAccessible).Append("\n");
            sb.Append("  Anniversary: ").Append(Anniversary).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  OfficePhone: ").Append(OfficePhone).Append("\n");
            sb.Append("  OfficeAddress: ").Append(OfficeAddress).Append("\n");
            sb.Append("  TablePreferences: ").Append(TablePreferences).Append("\n");
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
            return this.Equals(obj as ProfileData);
        }

        /// <summary>
        /// Returns true if ProfileData instances are equal
        /// </summary>
        /// <param name="other">Instance of ProfileData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProfileData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Allergy == other.Allergy ||
                    this.Allergy != null &&
                    this.Allergy.SequenceEqual(other.Allergy)
                ) && 
                (
                    this.Vegetarian == other.Vegetarian ||
                    this.Vegetarian != null &&
                    this.Vegetarian.Equals(other.Vegetarian)
                ) && 
                (
                    this.Vip == other.Vip ||
                    this.Vip != null &&
                    this.Vip.Equals(other.Vip)
                ) && 
                (
                    this.HandicapAccessible == other.HandicapAccessible ||
                    this.HandicapAccessible != null &&
                    this.HandicapAccessible.Equals(other.HandicapAccessible)
                ) && 
                (
                    this.Anniversary == other.Anniversary ||
                    this.Anniversary != null &&
                    this.Anniversary.Equals(other.Anniversary)
                ) && 
                (
                    this.CompanyName == other.CompanyName ||
                    this.CompanyName != null &&
                    this.CompanyName.Equals(other.CompanyName)
                ) && 
                (
                    this.OfficePhone == other.OfficePhone ||
                    this.OfficePhone != null &&
                    this.OfficePhone.Equals(other.OfficePhone)
                ) && 
                (
                    this.OfficeAddress == other.OfficeAddress ||
                    this.OfficeAddress != null &&
                    this.OfficeAddress.Equals(other.OfficeAddress)
                ) && 
                (
                    this.TablePreferences == other.TablePreferences ||
                    this.TablePreferences != null &&
                    this.TablePreferences.Equals(other.TablePreferences)
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
                if (this.Allergy != null)
                    hash = hash * 59 + this.Allergy.GetHashCode();
                if (this.Vegetarian != null)
                    hash = hash * 59 + this.Vegetarian.GetHashCode();
                if (this.Vip != null)
                    hash = hash * 59 + this.Vip.GetHashCode();
                if (this.HandicapAccessible != null)
                    hash = hash * 59 + this.HandicapAccessible.GetHashCode();
                if (this.Anniversary != null)
                    hash = hash * 59 + this.Anniversary.GetHashCode();
                if (this.CompanyName != null)
                    hash = hash * 59 + this.CompanyName.GetHashCode();
                if (this.OfficePhone != null)
                    hash = hash * 59 + this.OfficePhone.GetHashCode();
                if (this.OfficeAddress != null)
                    hash = hash * 59 + this.OfficeAddress.GetHashCode();
                if (this.TablePreferences != null)
                    hash = hash * 59 + this.TablePreferences.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}