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
    /// CreateReservation
    /// </summary>
    [DataContract]
    public partial class CreateReservation :  IEquatable<CreateReservation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReservation" /> class.
        /// </summary>
        /// <param name="ReservationTime">ReservationTime.</param>
        /// <param name="GroupSize">GroupSize.</param>
        /// <param name="Amount">Amount.</param>
        /// <param name="ReservationSource">ReservationSource.</param>
        /// <param name="CustomerName">CustomerName.</param>
        /// <param name="Phone">Phone.</param>
        /// <param name="Email">Email.</param>
        /// <param name="Areas">Areas.</param>
        /// <param name="Language">Language.</param>
        /// <param name="InternalNotes">InternalNotes.</param>
        /// <param name="SpecialRequests">SpecialRequests.</param>
        /// <param name="AboutGuestNotes">AboutGuestNotes.</param>
        /// <param name="TableNumber">TableNumber.</param>
        /// <param name="DepositToken">DepositToken.</param>
        /// <param name="HighChair">HighChair.</param>
        /// <param name="Stroller">Stroller.</param>
        /// <param name="Party">Party.</param>
        /// <param name="Vip">Vip.</param>
        /// <param name="Booth">Booth.</param>
        /// <param name="HighTop">HighTop.</param>
        /// <param name="Table">Table.</param>
        /// <param name="HandicapAccessible">HandicapAccessible.</param>
        /// <param name="PartyTypes">PartyTypes.</param>
        /// <param name="EstimatedTurnOverTime">EstimatedTurnOverTime.</param>
        /// <param name="CustomerProfile">CustomerProfile.</param>
        /// <param name="IsOnline">IsOnline.</param>
        public CreateReservation(DateTimeOffset? ReservationTime = null, int? GroupSize = null, int? Amount = null, string ReservationSource = null, string CustomerName = null, string Phone = null, string Email = null, string Areas = null, string Language = null, string InternalNotes = null, string SpecialRequests = null, string AboutGuestNotes = null, string TableNumber = null, string DepositToken = null, bool? HighChair = null, bool? Stroller = null, bool? Party = null, bool? Vip = null, bool? Booth = null, bool? HighTop = null, bool? Table = null, bool? HandicapAccessible = null, List<string> PartyTypes = null, int? EstimatedTurnOverTime = null, Profile CustomerProfile = null, bool? IsOnline = null)
        {
            this.ReservationTime = ReservationTime;
            this.GroupSize = GroupSize;
            this.Amount = Amount;
            this.ReservationSource = ReservationSource;
            this.CustomerName = CustomerName;
            this.Phone = Phone;
            this.Email = Email;
            this.Areas = Areas;
            this.Language = Language;
            this.InternalNotes = InternalNotes;
            this.SpecialRequests = SpecialRequests;
            this.AboutGuestNotes = AboutGuestNotes;
            this.TableNumber = TableNumber;
            this.DepositToken = DepositToken;
            this.HighChair = HighChair;
            this.Stroller = Stroller;
            this.Party = Party;
            this.Vip = Vip;
            this.Booth = Booth;
            this.HighTop = HighTop;
            this.Table = Table;
            this.HandicapAccessible = HandicapAccessible;
            this.PartyTypes = PartyTypes;
            this.EstimatedTurnOverTime = EstimatedTurnOverTime;
            this.CustomerProfile = CustomerProfile;
            this.IsOnline = IsOnline;
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
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=true)]
        public int? Amount { get; set; }
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
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=true)]
        public string Phone { get; set; }
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
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=true)]
        public string Language { get; set; }
        /// <summary>
        /// Gets or Sets InternalNotes
        /// </summary>
        [DataMember(Name="internalNotes", EmitDefaultValue=true)]
        public string InternalNotes { get; set; }
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
        /// Gets or Sets DepositToken
        /// </summary>
        [DataMember(Name="depositToken", EmitDefaultValue=true)]
        public string DepositToken { get; set; }
        /// <summary>
        /// Gets or Sets HighChair
        /// </summary>
        [DataMember(Name="highChair", EmitDefaultValue=true)]
        public bool? HighChair { get; set; }
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
        /// Gets or Sets Booth
        /// </summary>
        [DataMember(Name="booth", EmitDefaultValue=true)]
        public bool? Booth { get; set; }
        /// <summary>
        /// Gets or Sets HighTop
        /// </summary>
        [DataMember(Name="highTop", EmitDefaultValue=true)]
        public bool? HighTop { get; set; }
        /// <summary>
        /// Gets or Sets Table
        /// </summary>
        [DataMember(Name="table", EmitDefaultValue=true)]
        public bool? Table { get; set; }
        /// <summary>
        /// Gets or Sets HandicapAccessible
        /// </summary>
        [DataMember(Name="handicapAccessible", EmitDefaultValue=true)]
        public bool? HandicapAccessible { get; set; }
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
        /// Gets or Sets IsOnline
        /// </summary>
        [DataMember(Name="isOnline", EmitDefaultValue=true)]
        public bool? IsOnline { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateReservation {\n");
            sb.Append("  ReservationTime: ").Append(ReservationTime).Append("\n");
            sb.Append("  GroupSize: ").Append(GroupSize).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ReservationSource: ").Append(ReservationSource).Append("\n");
            sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Areas: ").Append(Areas).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  InternalNotes: ").Append(InternalNotes).Append("\n");
            sb.Append("  SpecialRequests: ").Append(SpecialRequests).Append("\n");
            sb.Append("  AboutGuestNotes: ").Append(AboutGuestNotes).Append("\n");
            sb.Append("  TableNumber: ").Append(TableNumber).Append("\n");
            sb.Append("  DepositToken: ").Append(DepositToken).Append("\n");
            sb.Append("  HighChair: ").Append(HighChair).Append("\n");
            sb.Append("  Stroller: ").Append(Stroller).Append("\n");
            sb.Append("  Party: ").Append(Party).Append("\n");
            sb.Append("  Vip: ").Append(Vip).Append("\n");
            sb.Append("  Booth: ").Append(Booth).Append("\n");
            sb.Append("  HighTop: ").Append(HighTop).Append("\n");
            sb.Append("  Table: ").Append(Table).Append("\n");
            sb.Append("  HandicapAccessible: ").Append(HandicapAccessible).Append("\n");
            sb.Append("  PartyTypes: ").Append(PartyTypes).Append("\n");
            sb.Append("  EstimatedTurnOverTime: ").Append(EstimatedTurnOverTime).Append("\n");
            sb.Append("  CustomerProfile: ").Append(CustomerProfile).Append("\n");
            sb.Append("  IsOnline: ").Append(IsOnline).Append("\n");
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
            return this.Equals(obj as CreateReservation);
        }

        /// <summary>
        /// Returns true if CreateReservation instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateReservation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateReservation other)
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
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
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
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
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
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.InternalNotes == other.InternalNotes ||
                    this.InternalNotes != null &&
                    this.InternalNotes.Equals(other.InternalNotes)
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
                    this.DepositToken == other.DepositToken ||
                    this.DepositToken != null &&
                    this.DepositToken.Equals(other.DepositToken)
                ) && 
                (
                    this.HighChair == other.HighChair ||
                    this.HighChair != null &&
                    this.HighChair.Equals(other.HighChair)
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
                    this.Booth == other.Booth ||
                    this.Booth != null &&
                    this.Booth.Equals(other.Booth)
                ) && 
                (
                    this.HighTop == other.HighTop ||
                    this.HighTop != null &&
                    this.HighTop.Equals(other.HighTop)
                ) && 
                (
                    this.Table == other.Table ||
                    this.Table != null &&
                    this.Table.Equals(other.Table)
                ) && 
                (
                    this.HandicapAccessible == other.HandicapAccessible ||
                    this.HandicapAccessible != null &&
                    this.HandicapAccessible.Equals(other.HandicapAccessible)
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
                ) && 
                (
                    this.IsOnline == other.IsOnline ||
                    this.IsOnline != null &&
                    this.IsOnline.Equals(other.IsOnline)
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
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.ReservationSource != null)
                    hash = hash * 59 + this.ReservationSource.GetHashCode();
                if (this.CustomerName != null)
                    hash = hash * 59 + this.CustomerName.GetHashCode();
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Areas != null)
                    hash = hash * 59 + this.Areas.GetHashCode();
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                if (this.InternalNotes != null)
                    hash = hash * 59 + this.InternalNotes.GetHashCode();
                if (this.SpecialRequests != null)
                    hash = hash * 59 + this.SpecialRequests.GetHashCode();
                if (this.AboutGuestNotes != null)
                    hash = hash * 59 + this.AboutGuestNotes.GetHashCode();
                if (this.TableNumber != null)
                    hash = hash * 59 + this.TableNumber.GetHashCode();
                if (this.DepositToken != null)
                    hash = hash * 59 + this.DepositToken.GetHashCode();
                if (this.HighChair != null)
                    hash = hash * 59 + this.HighChair.GetHashCode();
                if (this.Stroller != null)
                    hash = hash * 59 + this.Stroller.GetHashCode();
                if (this.Party != null)
                    hash = hash * 59 + this.Party.GetHashCode();
                if (this.Vip != null)
                    hash = hash * 59 + this.Vip.GetHashCode();
                if (this.Booth != null)
                    hash = hash * 59 + this.Booth.GetHashCode();
                if (this.HighTop != null)
                    hash = hash * 59 + this.HighTop.GetHashCode();
                if (this.Table != null)
                    hash = hash * 59 + this.Table.GetHashCode();
                if (this.HandicapAccessible != null)
                    hash = hash * 59 + this.HandicapAccessible.GetHashCode();
                if (this.PartyTypes != null)
                    hash = hash * 59 + this.PartyTypes.GetHashCode();
                if (this.EstimatedTurnOverTime != null)
                    hash = hash * 59 + this.EstimatedTurnOverTime.GetHashCode();
                if (this.CustomerProfile != null)
                    hash = hash * 59 + this.CustomerProfile.GetHashCode();
                if (this.IsOnline != null)
                    hash = hash * 59 + this.IsOnline.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}