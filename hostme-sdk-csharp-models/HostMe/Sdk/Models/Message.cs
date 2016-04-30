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
    public partial class Message :  IEquatable<Message>
    { 
    
       
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public int? Id { get; set; }
    
        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name="body", EmitDefaultValue=true)]
        public string Body { get; set; }
    
        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name="time", EmitDefaultValue=true)]
        public DateTimeOffset? Time { get; set; }
    
        /// <summary>
        /// Gets or Sets Origin
        /// </summary>
        [DataMember(Name="origin", EmitDefaultValue=true)]
        public string Origin { get; set; }
    
        /// <summary>
        /// Gets or Sets IsAutoMessage
        /// </summary>
        [DataMember(Name="isAutoMessage", EmitDefaultValue=true)]
        public bool? IsAutoMessage { get; set; }
    
        /// <summary>
        /// Gets or Sets DeliveryStatus
        /// </summary>
        [DataMember(Name="deliveryStatus", EmitDefaultValue=true)]
        public string DeliveryStatus { get; set; }
    
        /// <summary>
        /// Gets or Sets DeliveryTime
        /// </summary>
        [DataMember(Name="deliveryTime", EmitDefaultValue=true)]
        public DateTimeOffset? DeliveryTime { get; set; }
    
        /// <summary>
        /// Gets or Sets DeliveryFailureReason
        /// </summary>
        [DataMember(Name="deliveryFailureReason", EmitDefaultValue=true)]
        public string DeliveryFailureReason { get; set; }
    
        /// <summary>
        /// Gets or Sets IsRead
        /// </summary>
        [DataMember(Name="isRead", EmitDefaultValue=true)]
        public bool? IsRead { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Message {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
sb.Append("  Body: ").Append(Body).Append("\n");
sb.Append("  Time: ").Append(Time).Append("\n");
sb.Append("  Origin: ").Append(Origin).Append("\n");
sb.Append("  IsAutoMessage: ").Append(IsAutoMessage).Append("\n");
sb.Append("  DeliveryStatus: ").Append(DeliveryStatus).Append("\n");
sb.Append("  DeliveryTime: ").Append(DeliveryTime).Append("\n");
sb.Append("  DeliveryFailureReason: ").Append(DeliveryFailureReason).Append("\n");
sb.Append("  IsRead: ").Append(IsRead).Append("\n");
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
            return this.Equals(obj as Message);
        }

        /// <summary>
        /// Returns true if Message instances are equal
        /// </summary>
        /// <param name="other">Instance of Message to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Message other)
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
                    this.Body == other.Body ||
                    this.Body != null &&
                    this.Body.Equals(other.Body)
                ) && 
                (
                    this.Time == other.Time ||
                    this.Time != null &&
                    this.Time.Equals(other.Time)
                ) && 
                (
                    this.Origin == other.Origin ||
                    this.Origin != null &&
                    this.Origin.Equals(other.Origin)
                ) && 
                (
                    this.IsAutoMessage == other.IsAutoMessage ||
                    this.IsAutoMessage != null &&
                    this.IsAutoMessage.Equals(other.IsAutoMessage)
                ) && 
                (
                    this.DeliveryStatus == other.DeliveryStatus ||
                    this.DeliveryStatus != null &&
                    this.DeliveryStatus.Equals(other.DeliveryStatus)
                ) && 
                (
                    this.DeliveryTime == other.DeliveryTime ||
                    this.DeliveryTime != null &&
                    this.DeliveryTime.Equals(other.DeliveryTime)
                ) && 
                (
                    this.DeliveryFailureReason == other.DeliveryFailureReason ||
                    this.DeliveryFailureReason != null &&
                    this.DeliveryFailureReason.Equals(other.DeliveryFailureReason)
                ) && 
                (
                    this.IsRead == other.IsRead ||
                    this.IsRead != null &&
                    this.IsRead.Equals(other.IsRead)
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
                if (this.Body != null)
                    hash = hash * 59 + this.Body.GetHashCode();
                if (this.Time != null)
                    hash = hash * 59 + this.Time.GetHashCode();
                if (this.Origin != null)
                    hash = hash * 59 + this.Origin.GetHashCode();
                if (this.IsAutoMessage != null)
                    hash = hash * 59 + this.IsAutoMessage.GetHashCode();
                if (this.DeliveryStatus != null)
                    hash = hash * 59 + this.DeliveryStatus.GetHashCode();
                if (this.DeliveryTime != null)
                    hash = hash * 59 + this.DeliveryTime.GetHashCode();
                if (this.DeliveryFailureReason != null)
                    hash = hash * 59 + this.DeliveryFailureReason.GetHashCode();
                if (this.IsRead != null)
                    hash = hash * 59 + this.IsRead.GetHashCode();
                return hash;
            }
        }

    }
}
