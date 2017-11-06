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
    /// CreateMobileReservation
    /// </summary>
    [DataContract]
    public partial class CreateMobileReservation :  IEquatable<CreateMobileReservation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMobileReservation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateMobileReservation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMobileReservation" /> class.
        /// </summary>
        /// <param name="ReservationTime">ReservationTime (required).</param>
        /// <param name="GroupSize">GroupSize (required).</param>
        /// <param name="RestaurantId">RestaurantId.</param>
        /// <param name="ReservationSource">ReservationSource.</param>
        /// <param name="CustomerName">CustomerName.</param>
        /// <param name="PhoneNumber">PhoneNumber.</param>
        /// <param name="Email">Email.</param>
        /// <param name="Areas">Areas.</param>
        /// <param name="Note">Note.</param>
        /// <param name="SpecialRequests">SpecialRequests.</param>
        /// <param name="AboutGuestNotes">AboutGuestNotes.</param>
        /// <param name="TableNumber">TableNumber.</param>
        /// <param name="HighChair">HighChair.</param>
        /// <param name="Language">Language.</param>
        /// <param name="Stroller">Stroller.</param>
        /// <param name="Party">Party.</param>
        /// <param name="Vip">Vip.</param>
        /// <param name="DepositToken">DepositToken.</param>
        /// <param name="PartyTypes">PartyTypes.</param>
        /// <param name="EstimatedTurnOverTime">EstimatedTurnOverTime.</param>
        /// <param name="CustomerProfile">CustomerProfile.</param>
        public CreateMobileReservation(DateTimeOffset? ReservationTime = null, int? GroupSize = null, int? RestaurantId = null, string ReservationSource = null, string CustomerName = null, string PhoneNumber = null, string Email = null, string Areas = null, string Note = null, string SpecialRequests = null, string AboutGuestNotes = null, string TableNumber = null, bool? HighChair = null, string Language = null, bool? Stroller = null, bool? Party = null, bool? Vip = null, string DepositToken = null, List<string> PartyTypes = null, int? EstimatedTurnOverTime = null, Profile CustomerProfile = null)
        {
            // to ensure "ReservationTime" is required (not null)
            if (ReservationTime == null)
            {
                throw new InvalidDataException("ReservationTime is a required property for CreateMobileReservation and cannot be null");
            }
            else
            {
                this.ReservationTime = ReservationTime;
            }
            // to ensure "GroupSize" is required (not null)
            if (GroupSize == null)
            {
                throw new InvalidDataException("GroupSize is a required property for CreateMobileReservation and cannot be null");
            }
            else
            {
                this.GroupSize = GroupSize;
            }
            this.RestaurantId = RestaurantId;
            this.ReservationSource = ReservationSource;
            this.CustomerName = CustomerName;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.Areas = Areas;
            this.Note = Note;
            this.SpecialRequests = SpecialRequests;
            this.AboutGuestNotes = AboutGuestNotes;
            this.TableNumber = TableNumber;
            this.HighChair = HighChair;
            this.Language = Language;
            this.Stroller = Stroller;
            this.Party = Party;
            this.Vip = Vip;
            this.DepositToken = DepositToken;
            this.PartyTypes = PartyTypes;
            this.EstimatedTurnOverTime = EstimatedTurnOverTime;
            this.CustomerProfile = CustomerProfile;
        }
        
        /// <summary>
        /// Gets or Sets ReservationTime
        /// </summary>
        [DataMember(Name="reservationTime", EmitDefaultValue=true)]
        public DateTimeOffset? ReservationTime { get; set; }
        /// <summary>
        /// Gets or Sets GroupSize
        /// </summary>
        [DataMember(Name="groupSize", EmitDefaultValue=true)]
        public int? GroupSize { get; set; }
        /// <summary>
        /// Gets or Sets RestaurantId
        /// </summary>
        [DataMember(Name="restaurantId", EmitDefaultValue=true)]
        public int? RestaurantId { get; set; }
        /// <summary>
        /// Gets or Sets ReservationSource
        /// </summary>
        [DataMember(Name="reservationSource", EmitDefaultValue=true)]
        public string ReservationSource { get; set; }
        /// <summary>
        /// Gets or Sets CustomerName
        /// </summary>
        [DataMember(Name="customerName", EmitDefaultValue=true)]
        public string CustomerName { get; set; }
        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="phoneNumber", EmitDefaultValue=true)]
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=true)]
        public string Email { get; set; }
        /// <summary>
        /// Gets or Sets Areas
        /// </summary>
        [DataMember(Name="areas", EmitDefaultValue=true)]
        public string Areas { get; set; }
        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue=true)]
        public string Note { get; set; }
        /// <summary>
        /// Gets or Sets SpecialRequests
        /// </summary>
        [DataMember(Name="specialRequests", EmitDefaultValue=true)]
        public string SpecialRequests { get; set; }
        /// <summary>
        /// Gets or Sets AboutGuestNotes
        /// </summary>
        [DataMember(Name="aboutGuestNotes", EmitDefaultValue=true)]
        public string AboutGuestNotes { get; set; }
        /// <summary>
        /// Gets or Sets TableNumber
        /// </summary>
        [DataMember(Name="tableNumber", EmitDefaultValue=true)]
        public string TableNumber { get; set; }
        /// <summary>
        /// Gets or Sets HighChair
        /// </summary>
        [DataMember(Name="highChair", EmitDefaultValue=true)]
        public bool? HighChair { get; set; }
        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=true)]
        public string Language { get; set; }
        /// <summary>
        /// Gets or Sets Stroller
        /// </summary>
        [DataMember(Name="stroller", EmitDefaultValue=true)]
        public bool? Stroller { get; set; }
        /// <summary>
        /// Gets or Sets Party
        /// </summary>
        [DataMember(Name="party", EmitDefaultValue=true)]
        public bool? Party { get; set; }
        /// <summary>
        /// Gets or Sets Vip
        /// </summary>
        [DataMember(Name="vip", EmitDefaultValue=true)]
        public bool? Vip { get; set; }
        /// <summary>
        /// Gets or Sets DepositToken
        /// </summary>
        [DataMember(Name="depositToken", EmitDefaultValue=true)]
        public string DepositToken { get; set; }
        /// <summary>
        /// Gets or Sets PartyTypes
        /// </summary>
        [DataMember(Name="partyTypes", EmitDefaultValue=true)]
        public List<string> PartyTypes { get; set; }
        /// <summary>
        /// Gets or Sets EstimatedTurnOverTime
        /// </summary>
        [DataMember(Name="estimatedTurnOverTime", EmitDefaultValue=true)]
        public int? EstimatedTurnOverTime { get; set; }
        /// <summary>
        /// Gets or Sets CustomerProfile
        /// </summary>
        [DataMember(Name="customerProfile", EmitDefaultValue=true)]
        public Profile CustomerProfile { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateMobileReservation {\n");
            sb.Append("  ReservationTime: ").Append(ReservationTime).Append("\n");
            sb.Append("  GroupSize: ").Append(GroupSize).Append("\n");
            sb.Append("  RestaurantId: ").Append(RestaurantId).Append("\n");
            sb.Append("  ReservationSource: ").Append(ReservationSource).Append("\n");
            sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Areas: ").Append(Areas).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  SpecialRequests: ").Append(SpecialRequests).Append("\n");
            sb.Append("  AboutGuestNotes: ").Append(AboutGuestNotes).Append("\n");
            sb.Append("  TableNumber: ").Append(TableNumber).Append("\n");
            sb.Append("  HighChair: ").Append(HighChair).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Stroller: ").Append(Stroller).Append("\n");
            sb.Append("  Party: ").Append(Party).Append("\n");
            sb.Append("  Vip: ").Append(Vip).Append("\n");
            sb.Append("  DepositToken: ").Append(DepositToken).Append("\n");
            sb.Append("  PartyTypes: ").Append(PartyTypes).Append("\n");
            sb.Append("  EstimatedTurnOverTime: ").Append(EstimatedTurnOverTime).Append("\n");
            sb.Append("  CustomerProfile: ").Append(CustomerProfile).Append("\n");
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
            return this.Equals(obj as CreateMobileReservation);
        }

        /// <summary>
        /// Returns true if CreateMobileReservation instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateMobileReservation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateMobileReservation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ReservationTime == other.ReservationTime ||
                    this.ReservationTime != null &&
                    this.ReservationTime.Equals(other.ReservationTime)
                ) && 
                (
                    this.GroupSize == other.GroupSize ||
                    this.GroupSize != null &&
                    this.GroupSize.Equals(other.GroupSize)
                ) && 
                (
                    this.RestaurantId == other.RestaurantId ||
                    this.RestaurantId != null &&
                    this.RestaurantId.Equals(other.RestaurantId)
                ) && 
                (
                    this.ReservationSource == other.ReservationSource ||
                    this.ReservationSource != null &&
                    this.ReservationSource.Equals(other.ReservationSource)
                ) && 
                (
                    this.CustomerName == other.CustomerName ||
                    this.CustomerName != null &&
                    this.CustomerName.Equals(other.CustomerName)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Areas == other.Areas ||
                    this.Areas != null &&
                    this.Areas.Equals(other.Areas)
                ) && 
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
                ) && 
                (
                    this.SpecialRequests == other.SpecialRequests ||
                    this.SpecialRequests != null &&
                    this.SpecialRequests.Equals(other.SpecialRequests)
                ) && 
                (
                    this.AboutGuestNotes == other.AboutGuestNotes ||
                    this.AboutGuestNotes != null &&
                    this.AboutGuestNotes.Equals(other.AboutGuestNotes)
                ) && 
                (
                    this.TableNumber == other.TableNumber ||
                    this.TableNumber != null &&
                    this.TableNumber.Equals(other.TableNumber)
                ) && 
                (
                    this.HighChair == other.HighChair ||
                    this.HighChair != null &&
                    this.HighChair.Equals(other.HighChair)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.Stroller == other.Stroller ||
                    this.Stroller != null &&
                    this.Stroller.Equals(other.Stroller)
                ) && 
                (
                    this.Party == other.Party ||
                    this.Party != null &&
                    this.Party.Equals(other.Party)
                ) && 
                (
                    this.Vip == other.Vip ||
                    this.Vip != null &&
                    this.Vip.Equals(other.Vip)
                ) && 
                (
                    this.DepositToken == other.DepositToken ||
                    this.DepositToken != null &&
                    this.DepositToken.Equals(other.DepositToken)
                ) && 
                (
                    this.PartyTypes == other.PartyTypes ||
                    this.PartyTypes != null &&
                    this.PartyTypes.SequenceEqual(other.PartyTypes)
                ) && 
                (
                    this.EstimatedTurnOverTime == other.EstimatedTurnOverTime ||
                    this.EstimatedTurnOverTime != null &&
                    this.EstimatedTurnOverTime.Equals(other.EstimatedTurnOverTime)
                ) && 
                (
                    this.CustomerProfile == other.CustomerProfile ||
                    this.CustomerProfile != null &&
                    this.CustomerProfile.Equals(other.CustomerProfile)
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
                if (this.ReservationTime != null)
                    hash = hash * 59 + this.ReservationTime.GetHashCode();
                if (this.GroupSize != null)
                    hash = hash * 59 + this.GroupSize.GetHashCode();
                if (this.RestaurantId != null)
                    hash = hash * 59 + this.RestaurantId.GetHashCode();
                if (this.ReservationSource != null)
                    hash = hash * 59 + this.ReservationSource.GetHashCode();
                if (this.CustomerName != null)
                    hash = hash * 59 + this.CustomerName.GetHashCode();
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Areas != null)
                    hash = hash * 59 + this.Areas.GetHashCode();
                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();
                if (this.SpecialRequests != null)
                    hash = hash * 59 + this.SpecialRequests.GetHashCode();
                if (this.AboutGuestNotes != null)
                    hash = hash * 59 + this.AboutGuestNotes.GetHashCode();
                if (this.TableNumber != null)
                    hash = hash * 59 + this.TableNumber.GetHashCode();
                if (this.HighChair != null)
                    hash = hash * 59 + this.HighChair.GetHashCode();
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                if (this.Stroller != null)
                    hash = hash * 59 + this.Stroller.GetHashCode();
                if (this.Party != null)
                    hash = hash * 59 + this.Party.GetHashCode();
                if (this.Vip != null)
                    hash = hash * 59 + this.Vip.GetHashCode();
                if (this.DepositToken != null)
                    hash = hash * 59 + this.DepositToken.GetHashCode();
                if (this.PartyTypes != null)
                    hash = hash * 59 + this.PartyTypes.GetHashCode();
                if (this.EstimatedTurnOverTime != null)
                    hash = hash * 59 + this.EstimatedTurnOverTime.GetHashCode();
                if (this.CustomerProfile != null)
                    hash = hash * 59 + this.CustomerProfile.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // GroupSize (int?) maximum
            if(this.GroupSize > (int?)999.0)
            {
                yield return new ValidationResult("Invalid value for GroupSize, must be a value less than or equal to 999.0.", new [] { "GroupSize" });
            }

            // GroupSize (int?) minimum
            if(this.GroupSize < (int?)0.0)
            {
                yield return new ValidationResult("Invalid value for GroupSize, must be a value greater than or equal to 0.0.", new [] { "GroupSize" });
            }

            yield break;
        }
    }

}