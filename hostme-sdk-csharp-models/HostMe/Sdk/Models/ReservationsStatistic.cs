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
    public partial class ReservationsStatistic :  IEquatable<ReservationsStatistic>
    { 
    
       
        
    
        /// <summary>
        /// Gets or Sets Today
        /// </summary>
        [DataMember(Name="today", EmitDefaultValue=true)]
        public int? Today { get; set; }
    
        /// <summary>
        /// Gets or Sets Week
        /// </summary>
        [DataMember(Name="week", EmitDefaultValue=true)]
        public int? Week { get; set; }
    
        /// <summary>
        /// Gets or Sets Canceled
        /// </summary>
        [DataMember(Name="canceled", EmitDefaultValue=true)]
        public int? Canceled { get; set; }
    
        /// <summary>
        /// Gets or Sets Breakfast
        /// </summary>
        [DataMember(Name="breakfast", EmitDefaultValue=true)]
        public ReservationsDaypartStats Breakfast { get; set; }
    
        /// <summary>
        /// Gets or Sets Lunch
        /// </summary>
        [DataMember(Name="lunch", EmitDefaultValue=true)]
        public ReservationsDaypartStats Lunch { get; set; }
    
        /// <summary>
        /// Gets or Sets Dinner
        /// </summary>
        [DataMember(Name="dinner", EmitDefaultValue=true)]
        public ReservationsDaypartStats Dinner { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReservationsStatistic {\n");
            sb.Append("  Today: ").Append(Today).Append("\n");
sb.Append("  Week: ").Append(Week).Append("\n");
sb.Append("  Canceled: ").Append(Canceled).Append("\n");
sb.Append("  Breakfast: ").Append(Breakfast).Append("\n");
sb.Append("  Lunch: ").Append(Lunch).Append("\n");
sb.Append("  Dinner: ").Append(Dinner).Append("\n");
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
            return this.Equals(obj as ReservationsStatistic);
        }

        /// <summary>
        /// Returns true if ReservationsStatistic instances are equal
        /// </summary>
        /// <param name="other">Instance of ReservationsStatistic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReservationsStatistic other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Today == other.Today ||
                    this.Today != null &&
                    this.Today.Equals(other.Today)
                ) && 
                (
                    this.Week == other.Week ||
                    this.Week != null &&
                    this.Week.Equals(other.Week)
                ) && 
                (
                    this.Canceled == other.Canceled ||
                    this.Canceled != null &&
                    this.Canceled.Equals(other.Canceled)
                ) && 
                (
                    this.Breakfast == other.Breakfast ||
                    this.Breakfast != null &&
                    this.Breakfast.Equals(other.Breakfast)
                ) && 
                (
                    this.Lunch == other.Lunch ||
                    this.Lunch != null &&
                    this.Lunch.Equals(other.Lunch)
                ) && 
                (
                    this.Dinner == other.Dinner ||
                    this.Dinner != null &&
                    this.Dinner.Equals(other.Dinner)
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
                if (this.Today != null)
                    hash = hash * 59 + this.Today.GetHashCode();
                if (this.Week != null)
                    hash = hash * 59 + this.Week.GetHashCode();
                if (this.Canceled != null)
                    hash = hash * 59 + this.Canceled.GetHashCode();
                if (this.Breakfast != null)
                    hash = hash * 59 + this.Breakfast.GetHashCode();
                if (this.Lunch != null)
                    hash = hash * 59 + this.Lunch.GetHashCode();
                if (this.Dinner != null)
                    hash = hash * 59 + this.Dinner.GetHashCode();
                return hash;
            }
        }

    }
}
