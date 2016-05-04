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
    public partial class OnlineAvailability :  IEquatable<OnlineAvailability>
    { 
    
        /// <summary>
        /// Gets or Sets AvailabilityLevel
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AvailabilityLevelEnum {
            
            [EnumMember(Value = "Available")]
            Available,
            
            [EnumMember(Value = "AvailableForWait")]
            Availableforwait,
            
            [EnumMember(Value = "NotEnoughCovers")]
            Notenoughcovers,
            
            [EnumMember(Value = "Overbooked")]
            Overbooked
        }

    
        /// <summary>
        /// Gets or Sets AvailabilityLevel
        /// </summary>
        [DataMember(Name="availabilityLevel", EmitDefaultValue=true)]
        public AvailabilityLevelEnum? AvailabilityLevel { get; set; }
    
       
        
    
        /// <summary>
        /// Gets or Sets AcceptReservations
        /// </summary>
        [DataMember(Name="acceptReservations", EmitDefaultValue=true)]
        public bool? AcceptReservations { get; set; }
    
        /// <summary>
        /// Gets or Sets Open
        /// </summary>
        [DataMember(Name="open", EmitDefaultValue=true)]
        public bool? Open { get; set; }
    
        /// <summary>
        /// Gets or Sets RequestedTime
        /// </summary>
        [DataMember(Name="requestedTime", EmitDefaultValue=true)]
        public bool? RequestedTime { get; set; }
    
        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name="time", EmitDefaultValue=true)]
        public string Time { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OnlineAvailability {\n");
            sb.Append("  AcceptReservations: ").Append(AcceptReservations).Append("\n");
            sb.Append("  AvailabilityLevel: ").Append(AvailabilityLevel).Append("\n");
            sb.Append("  Open: ").Append(Open).Append("\n");
            sb.Append("  RequestedTime: ").Append(RequestedTime).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            
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
            return this.Equals(obj as OnlineAvailability);
        }

        /// <summary>
        /// Returns true if OnlineAvailability instances are equal
        /// </summary>
        /// <param name="other">Instance of OnlineAvailability to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OnlineAvailability other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AcceptReservations == other.AcceptReservations ||
                    this.AcceptReservations != null &&
                    this.AcceptReservations.Equals(other.AcceptReservations)
                ) && 
                (
                    this.AvailabilityLevel == other.AvailabilityLevel ||
                    this.AvailabilityLevel != null &&
                    this.AvailabilityLevel.Equals(other.AvailabilityLevel)
                ) && 
                (
                    this.Open == other.Open ||
                    this.Open != null &&
                    this.Open.Equals(other.Open)
                ) && 
                (
                    this.RequestedTime == other.RequestedTime ||
                    this.RequestedTime != null &&
                    this.RequestedTime.Equals(other.RequestedTime)
                ) && 
                (
                    this.Time == other.Time ||
                    this.Time != null &&
                    this.Time.Equals(other.Time)
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
                
                if (this.AcceptReservations != null)
                    hash = hash * 59 + this.AcceptReservations.GetHashCode();
                
                if (this.AvailabilityLevel != null)
                    hash = hash * 59 + this.AvailabilityLevel.GetHashCode();
                
                if (this.Open != null)
                    hash = hash * 59 + this.Open.GetHashCode();
                
                if (this.RequestedTime != null)
                    hash = hash * 59 + this.RequestedTime.GetHashCode();
                
                if (this.Time != null)
                    hash = hash * 59 + this.Time.GetHashCode();
                
                return hash;
            }
        }

    }


}
