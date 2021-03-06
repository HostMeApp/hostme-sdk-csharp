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
    /// ReservationInvitation
    /// </summary>
    [DataContract]
    public partial class ReservationInvitation :  IEquatable<ReservationInvitation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReservationInvitation" /> class.
        /// </summary>
        /// <param name="Email">Email.</param>
        /// <param name="PhoneNumber">PhoneNumber.</param>
        /// <param name="Restaurant">Restaurant.</param>
        /// <param name="GroupSize">GroupSize.</param>
        /// <param name="IsRedeemed">IsRedeemed.</param>
        /// <param name="ReservationTime">ReservationTime.</param>
        /// <param name="ReservationStatus">ReservationStatus.</param>
        /// <param name="PartyTypes">PartyTypes.</param>
        /// <param name="Party">Party.</param>
        public ReservationInvitation(string Email = null, string PhoneNumber = null, RestaurantInfo Restaurant = null, int? GroupSize = null, bool? IsRedeemed = null, DateTimeOffset? ReservationTime = null, string ReservationStatus = null, List<string> PartyTypes = null, bool? Party = null)
        {
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.Restaurant = Restaurant;
            this.GroupSize = GroupSize;
            this.IsRedeemed = IsRedeemed;
            this.ReservationTime = ReservationTime;
            this.ReservationStatus = ReservationStatus;
            this.PartyTypes = PartyTypes;
            this.Party = Party;
        }
        
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=true)]
        public string Email { get; set; }
        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="phoneNumber", EmitDefaultValue=true)]
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Gets or Sets Restaurant
        /// </summary>
        [DataMember(Name="restaurant", EmitDefaultValue=true)]
        public RestaurantInfo Restaurant { get; set; }
        /// <summary>
        /// Gets or Sets GroupSize
        /// </summary>
        [DataMember(Name="groupSize", EmitDefaultValue=true)]
        public int? GroupSize { get; set; }
        /// <summary>
        /// Gets or Sets IsRedeemed
        /// </summary>
        [DataMember(Name="isRedeemed", EmitDefaultValue=true)]
        public bool? IsRedeemed { get; set; }
        /// <summary>
        /// Gets or Sets ReservationTime
        /// </summary>
        [DataMember(Name="reservationTime", EmitDefaultValue=true)]
        public DateTimeOffset? ReservationTime { get; set; }
        /// <summary>
        /// Gets or Sets ReservationStatus
        /// </summary>
        [DataMember(Name="reservationStatus", EmitDefaultValue=true)]
        public string ReservationStatus { get; set; }
        /// <summary>
        /// Gets or Sets PartyTypes
        /// </summary>
        [DataMember(Name="partyTypes", EmitDefaultValue=true)]
        public List<string> PartyTypes { get; set; }
        /// <summary>
        /// Gets or Sets Party
        /// </summary>
        [DataMember(Name="party", EmitDefaultValue=true)]
        public bool? Party { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReservationInvitation {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Restaurant: ").Append(Restaurant).Append("\n");
            sb.Append("  GroupSize: ").Append(GroupSize).Append("\n");
            sb.Append("  IsRedeemed: ").Append(IsRedeemed).Append("\n");
            sb.Append("  ReservationTime: ").Append(ReservationTime).Append("\n");
            sb.Append("  ReservationStatus: ").Append(ReservationStatus).Append("\n");
            sb.Append("  PartyTypes: ").Append(PartyTypes).Append("\n");
            sb.Append("  Party: ").Append(Party).Append("\n");
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
            return this.Equals(obj as ReservationInvitation);
        }

        /// <summary>
        /// Returns true if ReservationInvitation instances are equal
        /// </summary>
        /// <param name="other">Instance of ReservationInvitation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReservationInvitation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    this.Restaurant == other.Restaurant ||
                    this.Restaurant != null &&
                    this.Restaurant.Equals(other.Restaurant)
                ) && 
                (
                    this.GroupSize == other.GroupSize ||
                    this.GroupSize != null &&
                    this.GroupSize.Equals(other.GroupSize)
                ) && 
                (
                    this.IsRedeemed == other.IsRedeemed ||
                    this.IsRedeemed != null &&
                    this.IsRedeemed.Equals(other.IsRedeemed)
                ) && 
                (
                    this.ReservationTime == other.ReservationTime ||
                    this.ReservationTime != null &&
                    this.ReservationTime.Equals(other.ReservationTime)
                ) && 
                (
                    this.ReservationStatus == other.ReservationStatus ||
                    this.ReservationStatus != null &&
                    this.ReservationStatus.Equals(other.ReservationStatus)
                ) && 
                (
                    this.PartyTypes == other.PartyTypes ||
                    this.PartyTypes != null &&
                    this.PartyTypes.SequenceEqual(other.PartyTypes)
                ) && 
                (
                    this.Party == other.Party ||
                    this.Party != null &&
                    this.Party.Equals(other.Party)
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
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                if (this.Restaurant != null)
                    hash = hash * 59 + this.Restaurant.GetHashCode();
                if (this.GroupSize != null)
                    hash = hash * 59 + this.GroupSize.GetHashCode();
                if (this.IsRedeemed != null)
                    hash = hash * 59 + this.IsRedeemed.GetHashCode();
                if (this.ReservationTime != null)
                    hash = hash * 59 + this.ReservationTime.GetHashCode();
                if (this.ReservationStatus != null)
                    hash = hash * 59 + this.ReservationStatus.GetHashCode();
                if (this.PartyTypes != null)
                    hash = hash * 59 + this.PartyTypes.GetHashCode();
                if (this.Party != null)
                    hash = hash * 59 + this.Party.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}