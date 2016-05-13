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
    public partial class MembershipVisitItem :  IEquatable<MembershipVisitItem>
    { 
    
       
        
    
        /// <summary>
        /// Gets or Sets Areas
        /// </summary>
        [DataMember(Name="areas", EmitDefaultValue=true)]
        public string Areas { get; set; }
    
        /// <summary>
        /// Gets or Sets Table
        /// </summary>
        [DataMember(Name="table", EmitDefaultValue=true)]
        public string Table { get; set; }
    
        /// <summary>
        /// Gets or Sets GroupSize
        /// </summary>
        [DataMember(Name="groupSize", EmitDefaultValue=true)]
        public int? GroupSize { get; set; }
    
        /// <summary>
        /// Gets or Sets VisitDate
        /// </summary>
        [DataMember(Name="visitDate", EmitDefaultValue=true)]
        public DateTimeOffset? VisitDate { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MembershipVisitItem {\n");
            sb.Append("  Areas: ").Append(Areas).Append("\n");
sb.Append("  Table: ").Append(Table).Append("\n");
sb.Append("  GroupSize: ").Append(GroupSize).Append("\n");
sb.Append("  VisitDate: ").Append(VisitDate).Append("\n");
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
            return this.Equals(obj as MembershipVisitItem);
        }

        /// <summary>
        /// Returns true if MembershipVisitItem instances are equal
        /// </summary>
        /// <param name="other">Instance of MembershipVisitItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MembershipVisitItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Areas == other.Areas ||
                    this.Areas != null &&
                    this.Areas.Equals(other.Areas)
                ) && 
                (
                    this.Table == other.Table ||
                    this.Table != null &&
                    this.Table.Equals(other.Table)
                ) && 
                (
                    this.GroupSize == other.GroupSize ||
                    this.GroupSize != null &&
                    this.GroupSize.Equals(other.GroupSize)
                ) && 
                (
                    this.VisitDate == other.VisitDate ||
                    this.VisitDate != null &&
                    this.VisitDate.Equals(other.VisitDate)
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
                if (this.Table != null)
                    hash = hash * 59 + this.Table.GetHashCode();
                if (this.GroupSize != null)
                    hash = hash * 59 + this.GroupSize.GetHashCode();
                if (this.VisitDate != null)
                    hash = hash * 59 + this.VisitDate.GetHashCode();
                return hash;
            }
        }

    }
}
