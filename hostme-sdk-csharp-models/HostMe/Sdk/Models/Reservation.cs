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
    /// Reservation
    /// </summary>
    [DataContract]
    public partial class Reservation :  IEquatable<Reservation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Reservation" /> class.
        /// </summary>
        /// <param name="UnreadMessageCount">UnreadMessageCount.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Restaurant">Restaurant.</param>
        /// <param name="Created">Created.</param>
        /// <param name="Closed">Closed.</param>
        /// <param name="ReservationTime">ReservationTime.</param>
        /// <param name="Status">Status.</param>
        /// <param name="CustomerName">CustomerName.</param>
        /// <param name="GroupSize">GroupSize.</param>
        /// <param name="Phone">Phone.</param>
        /// <param name="Areas">Areas.</param>
        /// <param name="InternalNotes">InternalNotes.</param>
        /// <param name="SpecialRequests">SpecialRequests.</param>
        /// <param name="AboutGuestNotes">AboutGuestNotes.</param>
        /// <param name="TableNumber">TableNumber.</param>
        /// <param name="DepositStatus">DepositStatus.</param>
        /// <param name="CardAttached">CardAttached.</param>
        /// <param name="HighChair">HighChair.</param>
        /// <param name="Stroller">Stroller.</param>
        /// <param name="Vip">Vip.</param>
        /// <param name="Email">Email.</param>
        /// <param name="Source">Source.</param>
        /// <param name="Amount">Amount.</param>
        /// <param name="RegistrationStatus">RegistrationStatus.</param>
        /// <param name="RegistrationId">RegistrationId.</param>
        /// <param name="EstimatedReleaseTime">EstimatedReleaseTime.</param>
        /// <param name="RegistrationTime">RegistrationTime.</param>
        /// <param name="EstimatedTurnOverTime">EstimatedTurnOverTime.</param>
        /// <param name="Messages">Messages.</param>
        /// <param name="Membership">Membership.</param>
        /// <param name="Party">Party.</param>
        /// <param name="PartyTypes">PartyTypes.</param>
        /// <param name="CustomerProfile">CustomerProfile.</param>
        /// <param name="Booth">Booth.</param>
        /// <param name="HighTop">HighTop.</param>
        /// <param name="Table">Table.</param>
        /// <param name="HandicapAccessible">HandicapAccessible.</param>
        public Reservation(int? UnreadMessageCount = null, string Id = null, RestaurantContactInfo Restaurant = null, DateTimeOffset? Created = null, DateTimeOffset? Closed = null, DateTimeOffset? ReservationTime = null, string Status = null, string CustomerName = null, int? GroupSize = null, string Phone = null, string Areas = null, string InternalNotes = null, string SpecialRequests = null, string AboutGuestNotes = null, string TableNumber = null, string DepositStatus = null, bool? CardAttached = null, bool? HighChair = null, bool? Stroller = null, bool? Vip = null, string Email = null, string Source = null, int? Amount = null, int? RegistrationStatus = null, int? RegistrationId = null, DateTimeOffset? EstimatedReleaseTime = null, DateTimeOffset? RegistrationTime = null, double? EstimatedTurnOverTime = null, List<Message> Messages = null, MembershipInfo Membership = null, bool? Party = null, List<string> PartyTypes = null, Profile CustomerProfile = null, bool? Booth = null, bool? HighTop = null, bool? Table = null, bool? HandicapAccessible = null)
        {
            this.UnreadMessageCount = UnreadMessageCount;
            this.Id = Id;
            this.Restaurant = Restaurant;
            this.Created = Created;
            this.Closed = Closed;
            this.ReservationTime = ReservationTime;
            this.Status = Status;
            this.CustomerName = CustomerName;
            this.GroupSize = GroupSize;
            this.Phone = Phone;
            this.Areas = Areas;
            this.InternalNotes = InternalNotes;
            this.SpecialRequests = SpecialRequests;
            this.AboutGuestNotes = AboutGuestNotes;
            this.TableNumber = TableNumber;
            this.DepositStatus = DepositStatus;
            this.CardAttached = CardAttached;
            this.HighChair = HighChair;
            this.Stroller = Stroller;
            this.Vip = Vip;
            this.Email = Email;
            this.Source = Source;
            this.Amount = Amount;
            this.RegistrationStatus = RegistrationStatus;
            this.RegistrationId = RegistrationId;
            this.EstimatedReleaseTime = EstimatedReleaseTime;
            this.RegistrationTime = RegistrationTime;
            this.EstimatedTurnOverTime = EstimatedTurnOverTime;
            this.Messages = Messages;
            this.Membership = Membership;
            this.Party = Party;
            this.PartyTypes = PartyTypes;
            this.CustomerProfile = CustomerProfile;
            this.Booth = Booth;
            this.HighTop = HighTop;
            this.Table = Table;
            this.HandicapAccessible = HandicapAccessible;
        }
        
        /// <summary>
        /// Gets or Sets UnreadMessageCount
        /// </summary>
        [DataMember(Name="unreadMessageCount", EmitDefaultValue=true)]
        public int? UnreadMessageCount { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Restaurant
        /// </summary>
        [DataMember(Name="restaurant", EmitDefaultValue=true)]
        public RestaurantContactInfo Restaurant { get; set; }
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=true)]
        public DateTimeOffset? Created { get; set; }
        /// <summary>
        /// Gets or Sets Closed
        /// </summary>
        [DataMember(Name="closed", EmitDefaultValue=true)]
        public DateTimeOffset? Closed { get; set; }
        /// <summary>
        /// Gets or Sets ReservationTime
        /// </summary>
        [DataMember(Name="reservationTime", EmitDefaultValue=true)]
        public DateTimeOffset? ReservationTime { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public string Status { get; set; }
        /// <summary>
        /// Gets or Sets CustomerName
        /// </summary>
        [DataMember(Name="customerName", EmitDefaultValue=true)]
        public string CustomerName { get; set; }
        /// <summary>
        /// Gets or Sets GroupSize
        /// </summary>
        [DataMember(Name="groupSize", EmitDefaultValue=true)]
        public int? GroupSize { get; set; }
        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=true)]
        public string Phone { get; set; }
        /// <summary>
        /// Gets or Sets Areas
        /// </summary>
        [DataMember(Name="areas", EmitDefaultValue=true)]
        public string Areas { get; set; }
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
        /// Gets or Sets DepositStatus
        /// </summary>
        [DataMember(Name="depositStatus", EmitDefaultValue=true)]
        public string DepositStatus { get; set; }
        /// <summary>
        /// Gets or Sets CardAttached
        /// </summary>
        [DataMember(Name="cardAttached", EmitDefaultValue=true)]
        public bool? CardAttached { get; set; }
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
        /// Gets or Sets Vip
        /// </summary>
        [DataMember(Name="vip", EmitDefaultValue=true)]
        public bool? Vip { get; set; }
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=true)]
        public string Email { get; set; }
        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=true)]
        public string Source { get; set; }
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=true)]
        public int? Amount { get; set; }
        /// <summary>
        /// Gets or Sets RegistrationStatus
        /// </summary>
        [DataMember(Name="registrationStatus", EmitDefaultValue=true)]
        public int? RegistrationStatus { get; set; }
        /// <summary>
        /// Gets or Sets RegistrationId
        /// </summary>
        [DataMember(Name="registrationId", EmitDefaultValue=true)]
        public int? RegistrationId { get; set; }
        /// <summary>
        /// Gets or Sets EstimatedReleaseTime
        /// </summary>
        [DataMember(Name="estimatedReleaseTime", EmitDefaultValue=true)]
        public DateTimeOffset? EstimatedReleaseTime { get; set; }
        /// <summary>
        /// Gets or Sets RegistrationTime
        /// </summary>
        [DataMember(Name="registrationTime", EmitDefaultValue=true)]
        public DateTimeOffset? RegistrationTime { get; set; }
        /// <summary>
        /// Gets or Sets EstimatedTurnOverTime
        /// </summary>
        [DataMember(Name="estimatedTurnOverTime", EmitDefaultValue=true)]
        public double? EstimatedTurnOverTime { get; set; }
        /// <summary>
        /// Gets or Sets Messages
        /// </summary>
        [DataMember(Name="messages", EmitDefaultValue=true)]
        public List<Message> Messages { get; set; }
        /// <summary>
        /// Gets or Sets Membership
        /// </summary>
        [DataMember(Name="membership", EmitDefaultValue=true)]
        public MembershipInfo Membership { get; set; }
        /// <summary>
        /// Gets or Sets Party
        /// </summary>
        [DataMember(Name="party", EmitDefaultValue=true)]
        public bool? Party { get; set; }
        /// <summary>
        /// Gets or Sets PartyTypes
        /// </summary>
        [DataMember(Name="partyTypes", EmitDefaultValue=true)]
        public List<string> PartyTypes { get; set; }
        /// <summary>
        /// Gets or Sets CustomerProfile
        /// </summary>
        [DataMember(Name="customerProfile", EmitDefaultValue=true)]
        public Profile CustomerProfile { get; set; }
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Reservation {\n");
            sb.Append("  UnreadMessageCount: ").Append(UnreadMessageCount).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Restaurant: ").Append(Restaurant).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Closed: ").Append(Closed).Append("\n");
            sb.Append("  ReservationTime: ").Append(ReservationTime).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
            sb.Append("  GroupSize: ").Append(GroupSize).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Areas: ").Append(Areas).Append("\n");
            sb.Append("  InternalNotes: ").Append(InternalNotes).Append("\n");
            sb.Append("  SpecialRequests: ").Append(SpecialRequests).Append("\n");
            sb.Append("  AboutGuestNotes: ").Append(AboutGuestNotes).Append("\n");
            sb.Append("  TableNumber: ").Append(TableNumber).Append("\n");
            sb.Append("  DepositStatus: ").Append(DepositStatus).Append("\n");
            sb.Append("  CardAttached: ").Append(CardAttached).Append("\n");
            sb.Append("  HighChair: ").Append(HighChair).Append("\n");
            sb.Append("  Stroller: ").Append(Stroller).Append("\n");
            sb.Append("  Vip: ").Append(Vip).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  RegistrationStatus: ").Append(RegistrationStatus).Append("\n");
            sb.Append("  RegistrationId: ").Append(RegistrationId).Append("\n");
            sb.Append("  EstimatedReleaseTime: ").Append(EstimatedReleaseTime).Append("\n");
            sb.Append("  RegistrationTime: ").Append(RegistrationTime).Append("\n");
            sb.Append("  EstimatedTurnOverTime: ").Append(EstimatedTurnOverTime).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  Membership: ").Append(Membership).Append("\n");
            sb.Append("  Party: ").Append(Party).Append("\n");
            sb.Append("  PartyTypes: ").Append(PartyTypes).Append("\n");
            sb.Append("  CustomerProfile: ").Append(CustomerProfile).Append("\n");
            sb.Append("  Booth: ").Append(Booth).Append("\n");
            sb.Append("  HighTop: ").Append(HighTop).Append("\n");
            sb.Append("  Table: ").Append(Table).Append("\n");
            sb.Append("  HandicapAccessible: ").Append(HandicapAccessible).Append("\n");
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
            return this.Equals(obj as Reservation);
        }

        /// <summary>
        /// Returns true if Reservation instances are equal
        /// </summary>
        /// <param name="other">Instance of Reservation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Reservation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UnreadMessageCount == other.UnreadMessageCount ||
                    this.UnreadMessageCount != null &&
                    this.UnreadMessageCount.Equals(other.UnreadMessageCount)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Restaurant == other.Restaurant ||
                    this.Restaurant != null &&
                    this.Restaurant.Equals(other.Restaurant)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.Closed == other.Closed ||
                    this.Closed != null &&
                    this.Closed.Equals(other.Closed)
                ) && 
                (
                    this.ReservationTime == other.ReservationTime ||
                    this.ReservationTime != null &&
                    this.ReservationTime.Equals(other.ReservationTime)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.CustomerName == other.CustomerName ||
                    this.CustomerName != null &&
                    this.CustomerName.Equals(other.CustomerName)
                ) && 
                (
                    this.GroupSize == other.GroupSize ||
                    this.GroupSize != null &&
                    this.GroupSize.Equals(other.GroupSize)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.Areas == other.Areas ||
                    this.Areas != null &&
                    this.Areas.Equals(other.Areas)
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
                    this.DepositStatus == other.DepositStatus ||
                    this.DepositStatus != null &&
                    this.DepositStatus.Equals(other.DepositStatus)
                ) && 
                (
                    this.CardAttached == other.CardAttached ||
                    this.CardAttached != null &&
                    this.CardAttached.Equals(other.CardAttached)
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
                    this.Vip == other.Vip ||
                    this.Vip != null &&
                    this.Vip.Equals(other.Vip)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
                ) && 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.RegistrationStatus == other.RegistrationStatus ||
                    this.RegistrationStatus != null &&
                    this.RegistrationStatus.Equals(other.RegistrationStatus)
                ) && 
                (
                    this.RegistrationId == other.RegistrationId ||
                    this.RegistrationId != null &&
                    this.RegistrationId.Equals(other.RegistrationId)
                ) && 
                (
                    this.EstimatedReleaseTime == other.EstimatedReleaseTime ||
                    this.EstimatedReleaseTime != null &&
                    this.EstimatedReleaseTime.Equals(other.EstimatedReleaseTime)
                ) && 
                (
                    this.RegistrationTime == other.RegistrationTime ||
                    this.RegistrationTime != null &&
                    this.RegistrationTime.Equals(other.RegistrationTime)
                ) && 
                (
                    this.EstimatedTurnOverTime == other.EstimatedTurnOverTime ||
                    this.EstimatedTurnOverTime != null &&
                    this.EstimatedTurnOverTime.Equals(other.EstimatedTurnOverTime)
                ) && 
                (
                    this.Messages == other.Messages ||
                    this.Messages != null &&
                    this.Messages.SequenceEqual(other.Messages)
                ) && 
                (
                    this.Membership == other.Membership ||
                    this.Membership != null &&
                    this.Membership.Equals(other.Membership)
                ) && 
                (
                    this.Party == other.Party ||
                    this.Party != null &&
                    this.Party.Equals(other.Party)
                ) && 
                (
                    this.PartyTypes == other.PartyTypes ||
                    this.PartyTypes != null &&
                    this.PartyTypes.SequenceEqual(other.PartyTypes)
                ) && 
                (
                    this.CustomerProfile == other.CustomerProfile ||
                    this.CustomerProfile != null &&
                    this.CustomerProfile.Equals(other.CustomerProfile)
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
                if (this.UnreadMessageCount != null)
                    hash = hash * 59 + this.UnreadMessageCount.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Restaurant != null)
                    hash = hash * 59 + this.Restaurant.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Closed != null)
                    hash = hash * 59 + this.Closed.GetHashCode();
                if (this.ReservationTime != null)
                    hash = hash * 59 + this.ReservationTime.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.CustomerName != null)
                    hash = hash * 59 + this.CustomerName.GetHashCode();
                if (this.GroupSize != null)
                    hash = hash * 59 + this.GroupSize.GetHashCode();
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                if (this.Areas != null)
                    hash = hash * 59 + this.Areas.GetHashCode();
                if (this.InternalNotes != null)
                    hash = hash * 59 + this.InternalNotes.GetHashCode();
                if (this.SpecialRequests != null)
                    hash = hash * 59 + this.SpecialRequests.GetHashCode();
                if (this.AboutGuestNotes != null)
                    hash = hash * 59 + this.AboutGuestNotes.GetHashCode();
                if (this.TableNumber != null)
                    hash = hash * 59 + this.TableNumber.GetHashCode();
                if (this.DepositStatus != null)
                    hash = hash * 59 + this.DepositStatus.GetHashCode();
                if (this.CardAttached != null)
                    hash = hash * 59 + this.CardAttached.GetHashCode();
                if (this.HighChair != null)
                    hash = hash * 59 + this.HighChair.GetHashCode();
                if (this.Stroller != null)
                    hash = hash * 59 + this.Stroller.GetHashCode();
                if (this.Vip != null)
                    hash = hash * 59 + this.Vip.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.RegistrationStatus != null)
                    hash = hash * 59 + this.RegistrationStatus.GetHashCode();
                if (this.RegistrationId != null)
                    hash = hash * 59 + this.RegistrationId.GetHashCode();
                if (this.EstimatedReleaseTime != null)
                    hash = hash * 59 + this.EstimatedReleaseTime.GetHashCode();
                if (this.RegistrationTime != null)
                    hash = hash * 59 + this.RegistrationTime.GetHashCode();
                if (this.EstimatedTurnOverTime != null)
                    hash = hash * 59 + this.EstimatedTurnOverTime.GetHashCode();
                if (this.Messages != null)
                    hash = hash * 59 + this.Messages.GetHashCode();
                if (this.Membership != null)
                    hash = hash * 59 + this.Membership.GetHashCode();
                if (this.Party != null)
                    hash = hash * 59 + this.Party.GetHashCode();
                if (this.PartyTypes != null)
                    hash = hash * 59 + this.PartyTypes.GetHashCode();
                if (this.CustomerProfile != null)
                    hash = hash * 59 + this.CustomerProfile.GetHashCode();
                if (this.Booth != null)
                    hash = hash * 59 + this.Booth.GetHashCode();
                if (this.HighTop != null)
                    hash = hash * 59 + this.HighTop.GetHashCode();
                if (this.Table != null)
                    hash = hash * 59 + this.Table.GetHashCode();
                if (this.HandicapAccessible != null)
                    hash = hash * 59 + this.HandicapAccessible.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}