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

namespace HostMe.Sdk.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class WaitingItem :  IEquatable<WaitingItem>
    { 
    
       
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public int? Id { get; set; }
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public string Status { get; set; }
    
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=true)]
        public DateTimeOffset? Created { get; set; }
    
        /// <summary>
        /// Gets or Sets Closed
        /// </summary>
        [DataMember(Name="closed", EmitDefaultValue=true)]
        public DateTimeOffset? Closed { get; set; }
    
        /// <summary>
        /// Gets or Sets ConfirmationCode
        /// </summary>
        [DataMember(Name="confirmationCode", EmitDefaultValue=true)]
        public int? ConfirmationCode { get; set; }
    
        /// <summary>
        /// Gets or Sets CustomerName
        /// </summary>
        [DataMember(Name="customerName", EmitDefaultValue=true)]
        public string CustomerName { get; set; }
    
        /// <summary>
        /// Gets or Sets GroupSize
        /// </summary>
        [DataMember(Name="groupSize", EmitDefaultValue=true)]
        public int? GroupSize { get; set; }
    
        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=true)]
        public string Phone { get; set; }
    
        /// <summary>
        /// Gets or Sets RegistrationMethod
        /// </summary>
        [DataMember(Name="registrationMethod", EmitDefaultValue=true)]
        public string RegistrationMethod { get; set; }
    
        /// <summary>
        /// Gets or Sets DeviceType
        /// </summary>
        [DataMember(Name="deviceType", EmitDefaultValue=true)]
        public string DeviceType { get; set; }
    
        /// <summary>
        /// Gets or Sets NotificationUrl
        /// </summary>
        [DataMember(Name="notificationUrl", EmitDefaultValue=true)]
        public string NotificationUrl { get; set; }
    
        /// <summary>
        /// Gets or Sets Areas
        /// </summary>
        [DataMember(Name="areas", EmitDefaultValue=true)]
        public string Areas { get; set; }
    
        /// <summary>
        /// Gets or Sets ExpectedTime
        /// </summary>
        [DataMember(Name="expectedTime", EmitDefaultValue=true)]
        public DateTimeOffset? ExpectedTime { get; set; }
    
        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=true)]
        public int? Position { get; set; }
    
        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue=true)]
        public string Note { get; set; }
    
        /// <summary>
        /// Gets or Sets TableNumber
        /// </summary>
        [DataMember(Name="tableNumber", EmitDefaultValue=true)]
        public string TableNumber { get; set; }
    
        /// <summary>
        /// Gets or Sets StatusTime
        /// </summary>
        [DataMember(Name="statusTime", EmitDefaultValue=true)]
        public DateTimeOffset? StatusTime { get; set; }
    
        /// <summary>
        /// Gets or Sets RestaurantId
        /// </summary>
        [DataMember(Name="restaurantId", EmitDefaultValue=true)]
        public int? RestaurantId { get; set; }
    
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
        /// Gets or Sets OnHoldMode
        /// </summary>
        [DataMember(Name="onHoldMode", EmitDefaultValue=true)]
        public string OnHoldMode { get; set; }
    
        /// <summary>
        /// Gets or Sets OnHoldTime
        /// </summary>
        [DataMember(Name="onHoldTime", EmitDefaultValue=true)]
        public DateTimeOffset? OnHoldTime { get; set; }
    
        /// <summary>
        /// Gets or Sets OnHoldEndTime
        /// </summary>
        [DataMember(Name="onHoldEndTime", EmitDefaultValue=true)]
        public DateTimeOffset? OnHoldEndTime { get; set; }
    
        /// <summary>
        /// Gets or Sets Messages
        /// </summary>
        [DataMember(Name="messages", EmitDefaultValue=true)]
        public List<Message> Messages { get; set; }
    
        /// <summary>
        /// Gets or Sets Membership
        /// </summary>
        [DataMember(Name="membership", EmitDefaultValue=true)]
        public MembershipInfo Membership { get; set; }
    
        /// <summary>
        /// Gets or Sets Reservation
        /// </summary>
        [DataMember(Name="reservation", EmitDefaultValue=true)]
        public ReservationInfo Reservation { get; set; }
    
        /// <summary>
        /// Gets or Sets EstimatedTurnOverTime
        /// </summary>
        [DataMember(Name="estimatedTurnOverTime", EmitDefaultValue=true)]
        public double? EstimatedTurnOverTime { get; set; }
    
        /// <summary>
        /// Gets or Sets UnreadMessageCount
        /// </summary>
        [DataMember(Name="unreadMessageCount", EmitDefaultValue=true)]
        public int? UnreadMessageCount { get; set; }
    
        /// <summary>
        /// Gets or Sets Restaurant
        /// </summary>
        [DataMember(Name="restaurant", EmitDefaultValue=true)]
        public RestaurantContactInfo Restaurant { get; set; }
    
        /// <summary>
        /// Gets or Sets CustomerProfile
        /// </summary>
        [DataMember(Name="customerProfile", EmitDefaultValue=true)]
        public Profile CustomerProfile { get; set; }
    
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
            sb.Append("class WaitingItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
sb.Append("  Status: ").Append(Status).Append("\n");
sb.Append("  Created: ").Append(Created).Append("\n");
sb.Append("  Closed: ").Append(Closed).Append("\n");
sb.Append("  ConfirmationCode: ").Append(ConfirmationCode).Append("\n");
sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
sb.Append("  GroupSize: ").Append(GroupSize).Append("\n");
sb.Append("  Phone: ").Append(Phone).Append("\n");
sb.Append("  RegistrationMethod: ").Append(RegistrationMethod).Append("\n");
sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
sb.Append("  NotificationUrl: ").Append(NotificationUrl).Append("\n");
sb.Append("  Areas: ").Append(Areas).Append("\n");
sb.Append("  ExpectedTime: ").Append(ExpectedTime).Append("\n");
sb.Append("  Position: ").Append(Position).Append("\n");
sb.Append("  Note: ").Append(Note).Append("\n");
sb.Append("  TableNumber: ").Append(TableNumber).Append("\n");
sb.Append("  StatusTime: ").Append(StatusTime).Append("\n");
sb.Append("  RestaurantId: ").Append(RestaurantId).Append("\n");
sb.Append("  HighChair: ").Append(HighChair).Append("\n");
sb.Append("  Stroller: ").Append(Stroller).Append("\n");
sb.Append("  OnHoldMode: ").Append(OnHoldMode).Append("\n");
sb.Append("  OnHoldTime: ").Append(OnHoldTime).Append("\n");
sb.Append("  OnHoldEndTime: ").Append(OnHoldEndTime).Append("\n");
sb.Append("  Messages: ").Append(Messages).Append("\n");
sb.Append("  Membership: ").Append(Membership).Append("\n");
sb.Append("  Reservation: ").Append(Reservation).Append("\n");
sb.Append("  EstimatedTurnOverTime: ").Append(EstimatedTurnOverTime).Append("\n");
sb.Append("  UnreadMessageCount: ").Append(UnreadMessageCount).Append("\n");
sb.Append("  Restaurant: ").Append(Restaurant).Append("\n");
sb.Append("  CustomerProfile: ").Append(CustomerProfile).Append("\n");
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
            return this.Equals(obj as WaitingItem);
        }

        /// <summary>
        /// Returns true if WaitingItem instances are equal
        /// </summary>
        /// <param name="other">Instance of WaitingItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WaitingItem other)
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
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.Closed == other.Closed ||
                    this.Closed != null &&
                    this.Closed.Equals(other.Closed)
                ) && 
                (
                    this.ConfirmationCode == other.ConfirmationCode ||
                    this.ConfirmationCode != null &&
                    this.ConfirmationCode.Equals(other.ConfirmationCode)
                ) && 
                (
                    this.CustomerName == other.CustomerName ||
                    this.CustomerName != null &&
                    this.CustomerName.Equals(other.CustomerName)
                ) && 
                (
                    this.GroupSize == other.GroupSize ||
                    this.GroupSize != null &&
                    this.GroupSize.Equals(other.GroupSize)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.RegistrationMethod == other.RegistrationMethod ||
                    this.RegistrationMethod != null &&
                    this.RegistrationMethod.Equals(other.RegistrationMethod)
                ) && 
                (
                    this.DeviceType == other.DeviceType ||
                    this.DeviceType != null &&
                    this.DeviceType.Equals(other.DeviceType)
                ) && 
                (
                    this.NotificationUrl == other.NotificationUrl ||
                    this.NotificationUrl != null &&
                    this.NotificationUrl.Equals(other.NotificationUrl)
                ) && 
                (
                    this.Areas == other.Areas ||
                    this.Areas != null &&
                    this.Areas.Equals(other.Areas)
                ) && 
                (
                    this.ExpectedTime == other.ExpectedTime ||
                    this.ExpectedTime != null &&
                    this.ExpectedTime.Equals(other.ExpectedTime)
                ) && 
                (
                    this.Position == other.Position ||
                    this.Position != null &&
                    this.Position.Equals(other.Position)
                ) && 
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
                ) && 
                (
                    this.TableNumber == other.TableNumber ||
                    this.TableNumber != null &&
                    this.TableNumber.Equals(other.TableNumber)
                ) && 
                (
                    this.StatusTime == other.StatusTime ||
                    this.StatusTime != null &&
                    this.StatusTime.Equals(other.StatusTime)
                ) && 
                (
                    this.RestaurantId == other.RestaurantId ||
                    this.RestaurantId != null &&
                    this.RestaurantId.Equals(other.RestaurantId)
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
                ) && 
                (
                    this.OnHoldMode == other.OnHoldMode ||
                    this.OnHoldMode != null &&
                    this.OnHoldMode.Equals(other.OnHoldMode)
                ) && 
                (
                    this.OnHoldTime == other.OnHoldTime ||
                    this.OnHoldTime != null &&
                    this.OnHoldTime.Equals(other.OnHoldTime)
                ) && 
                (
                    this.OnHoldEndTime == other.OnHoldEndTime ||
                    this.OnHoldEndTime != null &&
                    this.OnHoldEndTime.Equals(other.OnHoldEndTime)
                ) && 
                (
                    this.Messages == other.Messages ||
                    this.Messages != null &&
                    this.Messages.SequenceEqual(other.Messages)
                ) && 
                (
                    this.Membership == other.Membership ||
                    this.Membership != null &&
                    this.Membership.Equals(other.Membership)
                ) && 
                (
                    this.Reservation == other.Reservation ||
                    this.Reservation != null &&
                    this.Reservation.Equals(other.Reservation)
                ) && 
                (
                    this.EstimatedTurnOverTime == other.EstimatedTurnOverTime ||
                    this.EstimatedTurnOverTime != null &&
                    this.EstimatedTurnOverTime.Equals(other.EstimatedTurnOverTime)
                ) && 
                (
                    this.UnreadMessageCount == other.UnreadMessageCount ||
                    this.UnreadMessageCount != null &&
                    this.UnreadMessageCount.Equals(other.UnreadMessageCount)
                ) && 
                (
                    this.Restaurant == other.Restaurant ||
                    this.Restaurant != null &&
                    this.Restaurant.Equals(other.Restaurant)
                ) && 
                (
                    this.CustomerProfile == other.CustomerProfile ||
                    this.CustomerProfile != null &&
                    this.CustomerProfile.Equals(other.CustomerProfile)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Closed != null)
                    hash = hash * 59 + this.Closed.GetHashCode();
                if (this.ConfirmationCode != null)
                    hash = hash * 59 + this.ConfirmationCode.GetHashCode();
                if (this.CustomerName != null)
                    hash = hash * 59 + this.CustomerName.GetHashCode();
                if (this.GroupSize != null)
                    hash = hash * 59 + this.GroupSize.GetHashCode();
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                if (this.RegistrationMethod != null)
                    hash = hash * 59 + this.RegistrationMethod.GetHashCode();
                if (this.DeviceType != null)
                    hash = hash * 59 + this.DeviceType.GetHashCode();
                if (this.NotificationUrl != null)
                    hash = hash * 59 + this.NotificationUrl.GetHashCode();
                if (this.Areas != null)
                    hash = hash * 59 + this.Areas.GetHashCode();
                if (this.ExpectedTime != null)
                    hash = hash * 59 + this.ExpectedTime.GetHashCode();
                if (this.Position != null)
                    hash = hash * 59 + this.Position.GetHashCode();
                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();
                if (this.TableNumber != null)
                    hash = hash * 59 + this.TableNumber.GetHashCode();
                if (this.StatusTime != null)
                    hash = hash * 59 + this.StatusTime.GetHashCode();
                if (this.RestaurantId != null)
                    hash = hash * 59 + this.RestaurantId.GetHashCode();
                if (this.HighChair != null)
                    hash = hash * 59 + this.HighChair.GetHashCode();
                if (this.Stroller != null)
                    hash = hash * 59 + this.Stroller.GetHashCode();
                if (this.OnHoldMode != null)
                    hash = hash * 59 + this.OnHoldMode.GetHashCode();
                if (this.OnHoldTime != null)
                    hash = hash * 59 + this.OnHoldTime.GetHashCode();
                if (this.OnHoldEndTime != null)
                    hash = hash * 59 + this.OnHoldEndTime.GetHashCode();
                if (this.Messages != null)
                    hash = hash * 59 + this.Messages.GetHashCode();
                if (this.Membership != null)
                    hash = hash * 59 + this.Membership.GetHashCode();
                if (this.Reservation != null)
                    hash = hash * 59 + this.Reservation.GetHashCode();
                if (this.EstimatedTurnOverTime != null)
                    hash = hash * 59 + this.EstimatedTurnOverTime.GetHashCode();
                if (this.UnreadMessageCount != null)
                    hash = hash * 59 + this.UnreadMessageCount.GetHashCode();
                if (this.Restaurant != null)
                    hash = hash * 59 + this.Restaurant.GetHashCode();
                if (this.CustomerProfile != null)
                    hash = hash * 59 + this.CustomerProfile.GetHashCode();
                if (this.Party != null)
                    hash = hash * 59 + this.Party.GetHashCode();
                return hash;
            }
        }

    }
}
