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
    public partial class AverageWaitingTime :  IEquatable<AverageWaitingTime>
    { 
    
       
        
    
        /// <summary>
        /// Gets or Sets ValueMinutes
        /// </summary>
        [DataMember(Name="valueMinutes", EmitDefaultValue=true)]
        public int? ValueMinutes { get; set; }
    
        /// <summary>
        /// Gets or Sets TotalMinutes
        /// </summary>
        [DataMember(Name="totalMinutes", EmitDefaultValue=true)]
        public int? TotalMinutes { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AverageWaitingTime {\n");
            sb.Append("  ValueMinutes: ").Append(ValueMinutes).Append("\n");
sb.Append("  TotalMinutes: ").Append(TotalMinutes).Append("\n");
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
            return this.Equals(obj as AverageWaitingTime);
        }

        /// <summary>
        /// Returns true if AverageWaitingTime instances are equal
        /// </summary>
        /// <param name="other">Instance of AverageWaitingTime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AverageWaitingTime other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ValueMinutes == other.ValueMinutes ||
                    this.ValueMinutes != null &&
                    this.ValueMinutes.Equals(other.ValueMinutes)
                ) && 
                (
                    this.TotalMinutes == other.TotalMinutes ||
                    this.TotalMinutes != null &&
                    this.TotalMinutes.Equals(other.TotalMinutes)
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
                if (this.ValueMinutes != null)
                    hash = hash * 59 + this.ValueMinutes.GetHashCode();
                if (this.TotalMinutes != null)
                    hash = hash * 59 + this.TotalMinutes.GetHashCode();
                return hash;
            }
        }

    }
}
