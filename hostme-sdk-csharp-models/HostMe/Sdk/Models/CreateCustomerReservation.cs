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
    public partial class CreateCustomerReservation :  IEquatable<CreateCustomerReservation>
    { 
    
       
        
    
        /// <summary>
        /// Gets or Sets RestaurantId
        /// </summary>
        [DataMember(Name="restaurantId", EmitDefaultValue=true)]
        public int? RestaurantId { get; set; }
    
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
        /// Gets or Sets NotificationUrl
        /// </summary>
        [DataMember(Name="notificationUrl", EmitDefaultValue=true)]
        public string NotificationUrl { get; set; }
    
        /// <summary>
        /// Gets or Sets DeviceType
        /// </summary>
        [DataMember(Name="deviceType", EmitDefaultValue=true)]
        public string DeviceType { get; set; }
    
        /// <summary>
        /// Gets or Sets Areas
        /// </summary>
        [DataMember(Name="areas", EmitDefaultValue=true)]
        public string Areas { get; set; }
    
        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue=true)]
        public string Note { get; set; }
    
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCustomerReservation {\n");
            sb.Append("  RestaurantId: ").Append(RestaurantId).Append("\n");
sb.Append("  ReservationTime: ").Append(ReservationTime).Append("\n");
sb.Append("  GroupSize: ").Append(GroupSize).Append("\n");
sb.Append("  NotificationUrl: ").Append(NotificationUrl).Append("\n");
sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
sb.Append("  Areas: ").Append(Areas).Append("\n");
sb.Append("  Note: ").Append(Note).Append("\n");
sb.Append("  HighChair: ").Append(HighChair).Append("\n");
sb.Append("  Stroller: ").Append(Stroller).Append("\n");
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
            return this.Equals(obj as CreateCustomerReservation);
        }

        /// <summary>
        /// Returns true if CreateCustomerReservation instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateCustomerReservation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCustomerReservation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RestaurantId == other.RestaurantId ||
                    this.RestaurantId != null &&
                    this.RestaurantId.Equals(other.RestaurantId)
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
                    this.NotificationUrl == other.NotificationUrl ||
                    this.NotificationUrl != null &&
                    this.NotificationUrl.Equals(other.NotificationUrl)
                ) && 
                (
                    this.DeviceType == other.DeviceType ||
                    this.DeviceType != null &&
                    this.DeviceType.Equals(other.DeviceType)
                ) && 
                (
                    this.Areas == other.Areas ||
                    this.Areas != null &&
                    this.Areas.Equals(other.Areas)
                ) && 
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
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
                if (this.RestaurantId != null)
                    hash = hash * 59 + this.RestaurantId.GetHashCode();
                if (this.ReservationTime != null)
                    hash = hash * 59 + this.ReservationTime.GetHashCode();
                if (this.GroupSize != null)
                    hash = hash * 59 + this.GroupSize.GetHashCode();
                if (this.NotificationUrl != null)
                    hash = hash * 59 + this.NotificationUrl.GetHashCode();
                if (this.DeviceType != null)
                    hash = hash * 59 + this.DeviceType.GetHashCode();
                if (this.Areas != null)
                    hash = hash * 59 + this.Areas.GetHashCode();
                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();
                if (this.HighChair != null)
                    hash = hash * 59 + this.HighChair.GetHashCode();
                if (this.Stroller != null)
                    hash = hash * 59 + this.Stroller.GetHashCode();
                return hash;
            }
        }

    }
}
