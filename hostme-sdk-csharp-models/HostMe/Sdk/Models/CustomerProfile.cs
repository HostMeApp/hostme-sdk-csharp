using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HostMe.Sdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class CustomerProfile :  IEquatable<CustomerProfile>
    { 
    
       
        
    
        /// <summary>
        /// Gets or Sets LastVisitDate
        /// </summary>
        [DataMember(Name="lastVisitDate", EmitDefaultValue=true)]
        public DateTimeOffset? LastVisitDate { get; set; }
    
        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="phoneNumber", EmitDefaultValue=true)]
        public string PhoneNumber { get; set; }
    
        /// <summary>
        /// Gets or Sets VisitsCount
        /// </summary>
        [DataMember(Name="visitsCount", EmitDefaultValue=true)]
        public int? VisitsCount { get; set; }
    
        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name="fullName", EmitDefaultValue=true)]
        public string FullName { get; set; }
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public string Status { get; set; }
    
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerProfile {\n");
            sb.Append("  LastVisitDate: ").Append(LastVisitDate).Append("\n");
sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
sb.Append("  VisitsCount: ").Append(VisitsCount).Append("\n");
sb.Append("  FullName: ").Append(FullName).Append("\n");
sb.Append("  Status: ").Append(Status).Append("\n");
sb.Append("  MembershipLevel: ").Append(MembershipLevel).Append("\n");
sb.Append("  Points: ").Append(Points).Append("\n");
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
            return this.Equals(obj as CustomerProfile);
        }

        /// <summary>
        /// Returns true if CustomerProfile instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomerProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerProfile other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LastVisitDate == other.LastVisitDate ||
                    this.LastVisitDate != null &&
                    this.LastVisitDate.Equals(other.LastVisitDate)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    this.VisitsCount == other.VisitsCount ||
                    this.VisitsCount != null &&
                    this.VisitsCount.Equals(other.VisitsCount)
                ) && 
                (
                    this.FullName == other.FullName ||
                    this.FullName != null &&
                    this.FullName.Equals(other.FullName)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                if (this.LastVisitDate != null)
                    hash = hash * 59 + this.LastVisitDate.GetHashCode();
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                if (this.VisitsCount != null)
                    hash = hash * 59 + this.VisitsCount.GetHashCode();
                if (this.FullName != null)
                    hash = hash * 59 + this.FullName.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.MembershipLevel != null)
                    hash = hash * 59 + this.MembershipLevel.GetHashCode();
                if (this.Points != null)
                    hash = hash * 59 + this.Points.GetHashCode();
                return hash;
            }
        }

    }
}
