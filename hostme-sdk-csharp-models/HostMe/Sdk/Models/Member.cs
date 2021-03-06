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
    /// Member
    /// </summary>
    [DataContract]
    public partial class Member :  IEquatable<Member>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Member" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="MembershipLevel">MembershipLevel.</param>
        /// <param name="Points">Points.</param>
        /// <param name="JoinDate">JoinDate.</param>
        /// <param name="Status">Status.</param>
        /// <param name="NumberOfVisits30Days">NumberOfVisits30Days.</param>
        /// <param name="NumberOfVisitsTotal">NumberOfVisitsTotal.</param>
        /// <param name="LastVisitDate">LastVisitDate.</param>
        /// <param name="Customer">Customer.</param>
        /// <param name="CustomerProfile">CustomerProfile.</param>
        /// <param name="AboutGuestNotes">AboutGuestNotes.</param>
        /// <param name="CancelCount">CancelCount.</param>
        /// <param name="NoShowCount">NoShowCount.</param>
        /// <param name="IsAuto">IsAuto.</param>
        /// <param name="Image">Image.</param>
        public Member(int? Id = null, string MembershipLevel = null, long? Points = null, DateTimeOffset? JoinDate = null, string Status = null, int? NumberOfVisits30Days = null, int? NumberOfVisitsTotal = null, DateTimeOffset? LastVisitDate = null, MemberUser Customer = null, ProfileData CustomerProfile = null, string AboutGuestNotes = null, int? CancelCount = null, int? NoShowCount = null, bool? IsAuto = null, string Image = null)
        {
            this.Id = Id;
            this.MembershipLevel = MembershipLevel;
            this.Points = Points;
            this.JoinDate = JoinDate;
            this.Status = Status;
            this.NumberOfVisits30Days = NumberOfVisits30Days;
            this.NumberOfVisitsTotal = NumberOfVisitsTotal;
            this.LastVisitDate = LastVisitDate;
            this.Customer = Customer;
            this.CustomerProfile = CustomerProfile;
            this.AboutGuestNotes = AboutGuestNotes;
            this.CancelCount = CancelCount;
            this.NoShowCount = NoShowCount;
            this.IsAuto = IsAuto;
            this.Image = Image;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public int? Id { get; set; }
        /// <summary>
        /// Gets or Sets MembershipLevel
        /// </summary>
        [DataMember(Name="membershipLevel", EmitDefaultValue=true)]
        public string MembershipLevel { get; set; }
        /// <summary>
        /// Gets or Sets Points
        /// </summary>
        [DataMember(Name="points", EmitDefaultValue=true)]
        public long? Points { get; set; }
        /// <summary>
        /// Gets or Sets JoinDate
        /// </summary>
        [DataMember(Name="joinDate", EmitDefaultValue=true)]
        public DateTimeOffset? JoinDate { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public string Status { get; set; }
        /// <summary>
        /// Gets or Sets NumberOfVisits30Days
        /// </summary>
        [DataMember(Name="numberOfVisits30Days", EmitDefaultValue=true)]
        public int? NumberOfVisits30Days { get; set; }
        /// <summary>
        /// Gets or Sets NumberOfVisitsTotal
        /// </summary>
        [DataMember(Name="numberOfVisitsTotal", EmitDefaultValue=true)]
        public int? NumberOfVisitsTotal { get; set; }
        /// <summary>
        /// Gets or Sets LastVisitDate
        /// </summary>
        [DataMember(Name="lastVisitDate", EmitDefaultValue=true)]
        public DateTimeOffset? LastVisitDate { get; set; }
        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name="customer", EmitDefaultValue=true)]
        public MemberUser Customer { get; set; }
        /// <summary>
        /// Gets or Sets CustomerProfile
        /// </summary>
        [DataMember(Name="customerProfile", EmitDefaultValue=true)]
        public ProfileData CustomerProfile { get; set; }
        /// <summary>
        /// Gets or Sets AboutGuestNotes
        /// </summary>
        [DataMember(Name="aboutGuestNotes", EmitDefaultValue=true)]
        public string AboutGuestNotes { get; set; }
        /// <summary>
        /// Gets or Sets CancelCount
        /// </summary>
        [DataMember(Name="cancelCount", EmitDefaultValue=true)]
        public int? CancelCount { get; set; }
        /// <summary>
        /// Gets or Sets NoShowCount
        /// </summary>
        [DataMember(Name="noShowCount", EmitDefaultValue=true)]
        public int? NoShowCount { get; set; }
        /// <summary>
        /// Gets or Sets IsAuto
        /// </summary>
        [DataMember(Name="isAuto", EmitDefaultValue=true)]
        public bool? IsAuto { get; set; }
        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue=true)]
        public string Image { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Member {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MembershipLevel: ").Append(MembershipLevel).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
            sb.Append("  JoinDate: ").Append(JoinDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  NumberOfVisits30Days: ").Append(NumberOfVisits30Days).Append("\n");
            sb.Append("  NumberOfVisitsTotal: ").Append(NumberOfVisitsTotal).Append("\n");
            sb.Append("  LastVisitDate: ").Append(LastVisitDate).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  CustomerProfile: ").Append(CustomerProfile).Append("\n");
            sb.Append("  AboutGuestNotes: ").Append(AboutGuestNotes).Append("\n");
            sb.Append("  CancelCount: ").Append(CancelCount).Append("\n");
            sb.Append("  NoShowCount: ").Append(NoShowCount).Append("\n");
            sb.Append("  IsAuto: ").Append(IsAuto).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
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
            return this.Equals(obj as Member);
        }

        /// <summary>
        /// Returns true if Member instances are equal
        /// </summary>
        /// <param name="other">Instance of Member to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Member other)
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
                    this.MembershipLevel == other.MembershipLevel ||
                    this.MembershipLevel != null &&
                    this.MembershipLevel.Equals(other.MembershipLevel)
                ) && 
                (
                    this.Points == other.Points ||
                    this.Points != null &&
                    this.Points.Equals(other.Points)
                ) && 
                (
                    this.JoinDate == other.JoinDate ||
                    this.JoinDate != null &&
                    this.JoinDate.Equals(other.JoinDate)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.NumberOfVisits30Days == other.NumberOfVisits30Days ||
                    this.NumberOfVisits30Days != null &&
                    this.NumberOfVisits30Days.Equals(other.NumberOfVisits30Days)
                ) && 
                (
                    this.NumberOfVisitsTotal == other.NumberOfVisitsTotal ||
                    this.NumberOfVisitsTotal != null &&
                    this.NumberOfVisitsTotal.Equals(other.NumberOfVisitsTotal)
                ) && 
                (
                    this.LastVisitDate == other.LastVisitDate ||
                    this.LastVisitDate != null &&
                    this.LastVisitDate.Equals(other.LastVisitDate)
                ) && 
                (
                    this.Customer == other.Customer ||
                    this.Customer != null &&
                    this.Customer.Equals(other.Customer)
                ) && 
                (
                    this.CustomerProfile == other.CustomerProfile ||
                    this.CustomerProfile != null &&
                    this.CustomerProfile.Equals(other.CustomerProfile)
                ) && 
                (
                    this.AboutGuestNotes == other.AboutGuestNotes ||
                    this.AboutGuestNotes != null &&
                    this.AboutGuestNotes.Equals(other.AboutGuestNotes)
                ) && 
                (
                    this.CancelCount == other.CancelCount ||
                    this.CancelCount != null &&
                    this.CancelCount.Equals(other.CancelCount)
                ) && 
                (
                    this.NoShowCount == other.NoShowCount ||
                    this.NoShowCount != null &&
                    this.NoShowCount.Equals(other.NoShowCount)
                ) && 
                (
                    this.IsAuto == other.IsAuto ||
                    this.IsAuto != null &&
                    this.IsAuto.Equals(other.IsAuto)
                ) && 
                (
                    this.Image == other.Image ||
                    this.Image != null &&
                    this.Image.Equals(other.Image)
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
                if (this.MembershipLevel != null)
                    hash = hash * 59 + this.MembershipLevel.GetHashCode();
                if (this.Points != null)
                    hash = hash * 59 + this.Points.GetHashCode();
                if (this.JoinDate != null)
                    hash = hash * 59 + this.JoinDate.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.NumberOfVisits30Days != null)
                    hash = hash * 59 + this.NumberOfVisits30Days.GetHashCode();
                if (this.NumberOfVisitsTotal != null)
                    hash = hash * 59 + this.NumberOfVisitsTotal.GetHashCode();
                if (this.LastVisitDate != null)
                    hash = hash * 59 + this.LastVisitDate.GetHashCode();
                if (this.Customer != null)
                    hash = hash * 59 + this.Customer.GetHashCode();
                if (this.CustomerProfile != null)
                    hash = hash * 59 + this.CustomerProfile.GetHashCode();
                if (this.AboutGuestNotes != null)
                    hash = hash * 59 + this.AboutGuestNotes.GetHashCode();
                if (this.CancelCount != null)
                    hash = hash * 59 + this.CancelCount.GetHashCode();
                if (this.NoShowCount != null)
                    hash = hash * 59 + this.NoShowCount.GetHashCode();
                if (this.IsAuto != null)
                    hash = hash * 59 + this.IsAuto.GetHashCode();
                if (this.Image != null)
                    hash = hash * 59 + this.Image.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}