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
    /// ReservationGuest
    /// </summary>
    [DataContract]
    public partial class ReservationGuest :  IEquatable<ReservationGuest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReservationGuest" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="TimeZone">TimeZone.</param>
        /// <param name="Email">Email.</param>
        /// <param name="Status">Status.</param>
        /// <param name="CustomerName">CustomerName.</param>
        /// <param name="Phone">Phone.</param>
        /// <param name="Areas">Areas.</param>
        /// <param name="SpecialRequests">SpecialRequests.</param>
        /// <param name="TableNumber">TableNumber.</param>
        /// <param name="DepositStatus">DepositStatus.</param>
        /// <param name="Source">Source.</param>
        /// <param name="Created">Created.</param>
        /// <param name="Closed">Closed.</param>
        /// <param name="ReservationTime">ReservationTime.</param>
        /// <param name="GroupSize">GroupSize.</param>
        /// <param name="RestaurantId">RestaurantId.</param>
        /// <param name="Amount">Amount.</param>
        /// <param name="Roles">Roles.</param>
        /// <param name="Token">Token.</param>
        /// <param name="HighChair">HighChair.</param>
        /// <param name="Stroller">Stroller.</param>
        /// <param name="Booth">Booth.</param>
        /// <param name="HighTop">HighTop.</param>
        /// <param name="Table">Table.</param>
        /// <param name="Party">Party.</param>
        /// <param name="PartyTypes">PartyTypes.</param>
        /// <param name="CustomerProfile">CustomerProfile.</param>
        /// <param name="EstimatedTurnOverTime">EstimatedTurnOverTime.</param>
        public ReservationGuest(string Id = null, string TimeZone = null, string Email = null, string Status = null, string CustomerName = null, string Phone = null, string Areas = null, string SpecialRequests = null, string TableNumber = null, string DepositStatus = null, string Source = null, DateTimeOffset? Created = null, DateTimeOffset? Closed = null, DateTimeOffset? ReservationTime = null, int? GroupSize = null, int? RestaurantId = null, int? Amount = null, List<string> Roles = null, string Token = null, bool? HighChair = null, bool? Stroller = null, bool? Booth = null, bool? HighTop = null, bool? Table = null, bool? Party = null, List<string> PartyTypes = null, ProfileData CustomerProfile = null, double? EstimatedTurnOverTime = null)
        {
            this.Id = Id;
            this.TimeZone = TimeZone;
            this.Email = Email;
            this.Status = Status;
            this.CustomerName = CustomerName;
            this.Phone = Phone;
            this.Areas = Areas;
            this.SpecialRequests = SpecialRequests;
            this.TableNumber = TableNumber;
            this.DepositStatus = DepositStatus;
            this.Source = Source;
            this.Created = Created;
            this.Closed = Closed;
            this.ReservationTime = ReservationTime;
            this.GroupSize = GroupSize;
            this.RestaurantId = RestaurantId;
            this.Amount = Amount;
            this.Roles = Roles;
            this.Token = Token;
            this.HighChair = HighChair;
            this.Stroller = Stroller;
            this.Booth = Booth;
            this.HighTop = HighTop;
            this.Table = Table;
            this.Party = Party;
            this.PartyTypes = PartyTypes;
            this.CustomerProfile = CustomerProfile;
            this.EstimatedTurnOverTime = EstimatedTurnOverTime;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets TimeZone
        /// </summary>
        [DataMember(Name="timeZone", EmitDefaultValue=true)]
        public string TimeZone { get; set; }
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=true)]
        public string Email { get; set; }
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
        /// Gets or Sets SpecialRequests
        /// </summary>
        [DataMember(Name="specialRequests", EmitDefaultValue=true)]
        public string SpecialRequests { get; set; }
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
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=true)]
        public string Source { get; set; }
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
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=true)]
        public int? Amount { get; set; }
        /// <summary>
        /// Gets or Sets Roles
        /// </summary>
        [DataMember(Name="roles", EmitDefaultValue=true)]
        public List<string> Roles { get; set; }
        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name="token", EmitDefaultValue=true)]
        public string Token { get; set; }
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
        public ProfileData CustomerProfile { get; set; }
        /// <summary>
        /// Gets or Sets EstimatedTurnOverTime
        /// </summary>
        [DataMember(Name="estimatedTurnOverTime", EmitDefaultValue=true)]
        public double? EstimatedTurnOverTime { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReservationGuest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Areas: ").Append(Areas).Append("\n");
            sb.Append("  SpecialRequests: ").Append(SpecialRequests).Append("\n");
            sb.Append("  TableNumber: ").Append(TableNumber).Append("\n");
            sb.Append("  DepositStatus: ").Append(DepositStatus).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Closed: ").Append(Closed).Append("\n");
            sb.Append("  ReservationTime: ").Append(ReservationTime).Append("\n");
            sb.Append("  GroupSize: ").Append(GroupSize).Append("\n");
            sb.Append("  RestaurantId: ").Append(RestaurantId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  HighChair: ").Append(HighChair).Append("\n");
            sb.Append("  Stroller: ").Append(Stroller).Append("\n");
            sb.Append("  Booth: ").Append(Booth).Append("\n");
            sb.Append("  HighTop: ").Append(HighTop).Append("\n");
            sb.Append("  Table: ").Append(Table).Append("\n");
            sb.Append("  Party: ").Append(Party).Append("\n");
            sb.Append("  PartyTypes: ").Append(PartyTypes).Append("\n");
            sb.Append("  CustomerProfile: ").Append(CustomerProfile).Append("\n");
            sb.Append("  EstimatedTurnOverTime: ").Append(EstimatedTurnOverTime).Append("\n");
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
            return this.Equals(obj as ReservationGuest);
        }

        /// <summary>
        /// Returns true if ReservationGuest instances are equal
        /// </summary>
        /// <param name="other">Instance of ReservationGuest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReservationGuest other)
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
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
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
                    this.SpecialRequests == other.SpecialRequests ||
                    this.SpecialRequests != null &&
                    this.SpecialRequests.Equals(other.SpecialRequests)
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
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
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
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.Roles == other.Roles ||
                    this.Roles != null &&
                    this.Roles.SequenceEqual(other.Roles)
                ) && 
                (
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
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
                    this.EstimatedTurnOverTime == other.EstimatedTurnOverTime ||
                    this.EstimatedTurnOverTime != null &&
                    this.EstimatedTurnOverTime.Equals(other.EstimatedTurnOverTime)
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
                if (this.TimeZone != null)
                    hash = hash * 59 + this.TimeZone.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.CustomerName != null)
                    hash = hash * 59 + this.CustomerName.GetHashCode();
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                if (this.Areas != null)
                    hash = hash * 59 + this.Areas.GetHashCode();
                if (this.SpecialRequests != null)
                    hash = hash * 59 + this.SpecialRequests.GetHashCode();
                if (this.TableNumber != null)
                    hash = hash * 59 + this.TableNumber.GetHashCode();
                if (this.DepositStatus != null)
                    hash = hash * 59 + this.DepositStatus.GetHashCode();
                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Closed != null)
                    hash = hash * 59 + this.Closed.GetHashCode();
                if (this.ReservationTime != null)
                    hash = hash * 59 + this.ReservationTime.GetHashCode();
                if (this.GroupSize != null)
                    hash = hash * 59 + this.GroupSize.GetHashCode();
                if (this.RestaurantId != null)
                    hash = hash * 59 + this.RestaurantId.GetHashCode();
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.Roles != null)
                    hash = hash * 59 + this.Roles.GetHashCode();
                if (this.Token != null)
                    hash = hash * 59 + this.Token.GetHashCode();
                if (this.HighChair != null)
                    hash = hash * 59 + this.HighChair.GetHashCode();
                if (this.Stroller != null)
                    hash = hash * 59 + this.Stroller.GetHashCode();
                if (this.Booth != null)
                    hash = hash * 59 + this.Booth.GetHashCode();
                if (this.HighTop != null)
                    hash = hash * 59 + this.HighTop.GetHashCode();
                if (this.Table != null)
                    hash = hash * 59 + this.Table.GetHashCode();
                if (this.Party != null)
                    hash = hash * 59 + this.Party.GetHashCode();
                if (this.PartyTypes != null)
                    hash = hash * 59 + this.PartyTypes.GetHashCode();
                if (this.CustomerProfile != null)
                    hash = hash * 59 + this.CustomerProfile.GetHashCode();
                if (this.EstimatedTurnOverTime != null)
                    hash = hash * 59 + this.EstimatedTurnOverTime.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}