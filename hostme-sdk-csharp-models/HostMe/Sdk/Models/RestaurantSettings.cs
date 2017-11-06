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
    /// RestaurantSettings
    /// </summary>
    [DataContract]
    public partial class RestaurantSettings :  IEquatable<RestaurantSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestaurantSettings" /> class.
        /// </summary>
        /// <param name="Areas">Areas.</param>
        /// <param name="OpeningHours">OpeningHours.</param>
        /// <param name="OpeningHoursTemplates">OpeningHoursTemplates.</param>
        /// <param name="SpecialPeriods">SpecialPeriods.</param>
        /// <param name="TableSizes">TableSizes.</param>
        /// <param name="AllGuestsInGuestbook">AllGuestsInGuestbook.</param>
        /// <param name="EnableHoursTemplates">EnableHoursTemplates.</param>
        /// <param name="Time24HourFormat">Time24HourFormat.</param>
        /// <param name="Language">Language.</param>
        /// <param name="ChatWithSupportDisabled">ChatWithSupportDisabled.</param>
        /// <param name="SkipBookWizard">SkipBookWizard.</param>
        public RestaurantSettings(List<string> Areas = null, List<WeekDayOpenHours> OpeningHours = null, List<HourlyInterval> OpeningHoursTemplates = null, List<SpecialPeriod> SpecialPeriods = null, List<int?> TableSizes = null, bool? AllGuestsInGuestbook = null, bool? EnableHoursTemplates = null, bool? Time24HourFormat = null, string Language = null, bool? ChatWithSupportDisabled = null, bool? SkipBookWizard = null)
        {
            this.Areas = Areas;
            this.OpeningHours = OpeningHours;
            this.OpeningHoursTemplates = OpeningHoursTemplates;
            this.SpecialPeriods = SpecialPeriods;
            this.TableSizes = TableSizes;
            this.AllGuestsInGuestbook = AllGuestsInGuestbook;
            this.EnableHoursTemplates = EnableHoursTemplates;
            this.Time24HourFormat = Time24HourFormat;
            this.Language = Language;
            this.ChatWithSupportDisabled = ChatWithSupportDisabled;
            this.SkipBookWizard = SkipBookWizard;
        }
        
        /// <summary>
        /// Gets or Sets Areas
        /// </summary>
        [DataMember(Name="areas", EmitDefaultValue=true)]
        public List<string> Areas { get; set; }
        /// <summary>
        /// Gets or Sets OpeningHours
        /// </summary>
        [DataMember(Name="openingHours", EmitDefaultValue=true)]
        public List<WeekDayOpenHours> OpeningHours { get; set; }
        /// <summary>
        /// Gets or Sets OpeningHoursTemplates
        /// </summary>
        [DataMember(Name="openingHoursTemplates", EmitDefaultValue=true)]
        public List<HourlyInterval> OpeningHoursTemplates { get; set; }
        /// <summary>
        /// Gets or Sets SpecialPeriods
        /// </summary>
        [DataMember(Name="specialPeriods", EmitDefaultValue=true)]
        public List<SpecialPeriod> SpecialPeriods { get; set; }
        /// <summary>
        /// Gets or Sets TableSizes
        /// </summary>
        [DataMember(Name="tableSizes", EmitDefaultValue=true)]
        public List<int?> TableSizes { get; set; }
        /// <summary>
        /// Gets or Sets AllGuestsInGuestbook
        /// </summary>
        [DataMember(Name="allGuestsInGuestbook", EmitDefaultValue=true)]
        public bool? AllGuestsInGuestbook { get; set; }
        /// <summary>
        /// Gets or Sets EnableHoursTemplates
        /// </summary>
        [DataMember(Name="enableHoursTemplates", EmitDefaultValue=true)]
        public bool? EnableHoursTemplates { get; set; }
        /// <summary>
        /// Gets or Sets Time24HourFormat
        /// </summary>
        [DataMember(Name="time24HourFormat", EmitDefaultValue=true)]
        public bool? Time24HourFormat { get; set; }
        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=true)]
        public string Language { get; set; }
        /// <summary>
        /// Gets or Sets ChatWithSupportDisabled
        /// </summary>
        [DataMember(Name="chatWithSupportDisabled", EmitDefaultValue=true)]
        public bool? ChatWithSupportDisabled { get; set; }
        /// <summary>
        /// Gets or Sets SkipBookWizard
        /// </summary>
        [DataMember(Name="skipBookWizard", EmitDefaultValue=true)]
        public bool? SkipBookWizard { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestaurantSettings {\n");
            sb.Append("  Areas: ").Append(Areas).Append("\n");
            sb.Append("  OpeningHours: ").Append(OpeningHours).Append("\n");
            sb.Append("  OpeningHoursTemplates: ").Append(OpeningHoursTemplates).Append("\n");
            sb.Append("  SpecialPeriods: ").Append(SpecialPeriods).Append("\n");
            sb.Append("  TableSizes: ").Append(TableSizes).Append("\n");
            sb.Append("  AllGuestsInGuestbook: ").Append(AllGuestsInGuestbook).Append("\n");
            sb.Append("  EnableHoursTemplates: ").Append(EnableHoursTemplates).Append("\n");
            sb.Append("  Time24HourFormat: ").Append(Time24HourFormat).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  ChatWithSupportDisabled: ").Append(ChatWithSupportDisabled).Append("\n");
            sb.Append("  SkipBookWizard: ").Append(SkipBookWizard).Append("\n");
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
            return this.Equals(obj as RestaurantSettings);
        }

        /// <summary>
        /// Returns true if RestaurantSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of RestaurantSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestaurantSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Areas == other.Areas ||
                    this.Areas != null &&
                    this.Areas.SequenceEqual(other.Areas)
                ) && 
                (
                    this.OpeningHours == other.OpeningHours ||
                    this.OpeningHours != null &&
                    this.OpeningHours.SequenceEqual(other.OpeningHours)
                ) && 
                (
                    this.OpeningHoursTemplates == other.OpeningHoursTemplates ||
                    this.OpeningHoursTemplates != null &&
                    this.OpeningHoursTemplates.SequenceEqual(other.OpeningHoursTemplates)
                ) && 
                (
                    this.SpecialPeriods == other.SpecialPeriods ||
                    this.SpecialPeriods != null &&
                    this.SpecialPeriods.SequenceEqual(other.SpecialPeriods)
                ) && 
                (
                    this.TableSizes == other.TableSizes ||
                    this.TableSizes != null &&
                    this.TableSizes.SequenceEqual(other.TableSizes)
                ) && 
                (
                    this.AllGuestsInGuestbook == other.AllGuestsInGuestbook ||
                    this.AllGuestsInGuestbook != null &&
                    this.AllGuestsInGuestbook.Equals(other.AllGuestsInGuestbook)
                ) && 
                (
                    this.EnableHoursTemplates == other.EnableHoursTemplates ||
                    this.EnableHoursTemplates != null &&
                    this.EnableHoursTemplates.Equals(other.EnableHoursTemplates)
                ) && 
                (
                    this.Time24HourFormat == other.Time24HourFormat ||
                    this.Time24HourFormat != null &&
                    this.Time24HourFormat.Equals(other.Time24HourFormat)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.ChatWithSupportDisabled == other.ChatWithSupportDisabled ||
                    this.ChatWithSupportDisabled != null &&
                    this.ChatWithSupportDisabled.Equals(other.ChatWithSupportDisabled)
                ) && 
                (
                    this.SkipBookWizard == other.SkipBookWizard ||
                    this.SkipBookWizard != null &&
                    this.SkipBookWizard.Equals(other.SkipBookWizard)
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
                if (this.Areas != null)
                    hash = hash * 59 + this.Areas.GetHashCode();
                if (this.OpeningHours != null)
                    hash = hash * 59 + this.OpeningHours.GetHashCode();
                if (this.OpeningHoursTemplates != null)
                    hash = hash * 59 + this.OpeningHoursTemplates.GetHashCode();
                if (this.SpecialPeriods != null)
                    hash = hash * 59 + this.SpecialPeriods.GetHashCode();
                if (this.TableSizes != null)
                    hash = hash * 59 + this.TableSizes.GetHashCode();
                if (this.AllGuestsInGuestbook != null)
                    hash = hash * 59 + this.AllGuestsInGuestbook.GetHashCode();
                if (this.EnableHoursTemplates != null)
                    hash = hash * 59 + this.EnableHoursTemplates.GetHashCode();
                if (this.Time24HourFormat != null)
                    hash = hash * 59 + this.Time24HourFormat.GetHashCode();
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                if (this.ChatWithSupportDisabled != null)
                    hash = hash * 59 + this.ChatWithSupportDisabled.GetHashCode();
                if (this.SkipBookWizard != null)
                    hash = hash * 59 + this.SkipBookWizard.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}