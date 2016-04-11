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
    public partial class Member :  IEquatable<Member>
    { 
    
       
        
    
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
        public UserProfile Customer { get; set; }
    
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
                return hash;
            }
        }

    }
}
