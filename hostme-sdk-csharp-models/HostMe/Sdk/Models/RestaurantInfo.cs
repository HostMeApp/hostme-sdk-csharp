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
    public partial class RestaurantInfo :  IEquatable<RestaurantInfo>
    { 
    
       
        
    
        /// <summary>
        /// Gets or Sets HoursInterval
        /// </summary>
        [DataMember(Name="hoursInterval", EmitDefaultValue=true)]
        public int? HoursInterval { get; set; }
    
        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=true)]
        public string City { get; set; }
    
        /// <summary>
        /// Gets or Sets MaxPartySize
        /// </summary>
        [DataMember(Name="maxPartySize", EmitDefaultValue=true)]
        public int? MaxPartySize { get; set; }
    
        /// <summary>
        /// Gets or Sets MinPartySize
        /// </summary>
        [DataMember(Name="minPartySize", EmitDefaultValue=true)]
        public int? MinPartySize { get; set; }
    
        /// <summary>
        /// Gets or Sets OpeningHours
        /// </summary>
        [DataMember(Name="openingHours", EmitDefaultValue=true)]
        public BusinessHours OpeningHours { get; set; }
    
        /// <summary>
        /// Gets or Sets ReservationHours
        /// </summary>
        [DataMember(Name="reservationHours", EmitDefaultValue=true)]
        public BusinessHours ReservationHours { get; set; }
    
        /// <summary>
        /// Gets or Sets SeatingZones
        /// </summary>
        [DataMember(Name="seatingZones", EmitDefaultValue=true)]
        public List<string> SeatingZones { get; set; }
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public int? Id { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=true)]
        public string Address { get; set; }
    
        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name="imageUrl", EmitDefaultValue=true)]
        public string ImageUrl { get; set; }
    
        /// <summary>
        /// Gets or Sets FacebookId
        /// </summary>
        [DataMember(Name="facebookId", EmitDefaultValue=true)]
        public string FacebookId { get; set; }
    
        /// <summary>
        /// Gets or Sets TwitterAccount
        /// </summary>
        [DataMember(Name="twitterAccount", EmitDefaultValue=true)]
        public string TwitterAccount { get; set; }
    
        /// <summary>
        /// Gets or Sets WebsiteUrl
        /// </summary>
        [DataMember(Name="websiteUrl", EmitDefaultValue=true)]
        public string WebsiteUrl { get; set; }
    
        /// <summary>
        /// Gets or Sets FoursquareId
        /// </summary>
        [DataMember(Name="foursquareId", EmitDefaultValue=true)]
        public string FoursquareId { get; set; }
    
        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=true)]
        public string Phone { get; set; }
    
        /// <summary>
        /// Gets or Sets TimeZone
        /// </summary>
        [DataMember(Name="timeZone", EmitDefaultValue=true)]
        public string TimeZone { get; set; }
    
        /// <summary>
        /// Gets or Sets Lat
        /// </summary>
        [DataMember(Name="lat", EmitDefaultValue=true)]
        public double? Lat { get; set; }
    
        /// <summary>
        /// Gets or Sets Lon
        /// </summary>
        [DataMember(Name="lon", EmitDefaultValue=true)]
        public double? Lon { get; set; }
    
        /// <summary>
        /// Gets or Sets HasHostmeSystem
        /// </summary>
        [DataMember(Name="hasHostmeSystem", EmitDefaultValue=true)]
        public bool? HasHostmeSystem { get; set; }
    
        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [DataMember(Name="distance", EmitDefaultValue=true)]
        public double? Distance { get; set; }
    
        /// <summary>
        /// Gets or Sets HasLoyaltyProgram
        /// </summary>
        [DataMember(Name="hasLoyaltyProgram", EmitDefaultValue=true)]
        public bool? HasLoyaltyProgram { get; set; }
    
        /// <summary>
        /// Gets or Sets AcceptRemouteLine
        /// </summary>
        [DataMember(Name="acceptRemouteLine", EmitDefaultValue=true)]
        public bool? AcceptRemouteLine { get; set; }
    
        /// <summary>
        /// Gets or Sets AcceptReservation
        /// </summary>
        [DataMember(Name="acceptReservation", EmitDefaultValue=true)]
        public bool? AcceptReservation { get; set; }
    
        /// <summary>
        /// Gets or Sets AllowManualHold
        /// </summary>
        [DataMember(Name="allowManualHold", EmitDefaultValue=true)]
        public bool? AllowManualHold { get; set; }
    
        /// <summary>
        /// Gets or Sets CurrentLineStats
        /// </summary>
        [DataMember(Name="currentLineStats", EmitDefaultValue=true)]
        public WaitingStats CurrentLineStats { get; set; }
    
        /// <summary>
        /// Gets or Sets ReservationIncomeEmail
        /// </summary>
        [DataMember(Name="reservationIncomeEmail", EmitDefaultValue=true)]
        public string ReservationIncomeEmail { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestaurantInfo {\n");
            sb.Append("  HoursInterval: ").Append(HoursInterval).Append("\n");
sb.Append("  City: ").Append(City).Append("\n");
sb.Append("  MaxPartySize: ").Append(MaxPartySize).Append("\n");
sb.Append("  MinPartySize: ").Append(MinPartySize).Append("\n");
sb.Append("  OpeningHours: ").Append(OpeningHours).Append("\n");
sb.Append("  ReservationHours: ").Append(ReservationHours).Append("\n");
sb.Append("  SeatingZones: ").Append(SeatingZones).Append("\n");
sb.Append("  Id: ").Append(Id).Append("\n");
sb.Append("  Name: ").Append(Name).Append("\n");
sb.Append("  Address: ").Append(Address).Append("\n");
sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
sb.Append("  FacebookId: ").Append(FacebookId).Append("\n");
sb.Append("  TwitterAccount: ").Append(TwitterAccount).Append("\n");
sb.Append("  WebsiteUrl: ").Append(WebsiteUrl).Append("\n");
sb.Append("  FoursquareId: ").Append(FoursquareId).Append("\n");
sb.Append("  Phone: ").Append(Phone).Append("\n");
sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
sb.Append("  Lat: ").Append(Lat).Append("\n");
sb.Append("  Lon: ").Append(Lon).Append("\n");
sb.Append("  HasHostmeSystem: ").Append(HasHostmeSystem).Append("\n");
sb.Append("  Distance: ").Append(Distance).Append("\n");
sb.Append("  HasLoyaltyProgram: ").Append(HasLoyaltyProgram).Append("\n");
sb.Append("  AcceptRemouteLine: ").Append(AcceptRemouteLine).Append("\n");
sb.Append("  AcceptReservation: ").Append(AcceptReservation).Append("\n");
sb.Append("  AllowManualHold: ").Append(AllowManualHold).Append("\n");
sb.Append("  CurrentLineStats: ").Append(CurrentLineStats).Append("\n");
sb.Append("  ReservationIncomeEmail: ").Append(ReservationIncomeEmail).Append("\n");
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
            return this.Equals(obj as RestaurantInfo);
        }

        /// <summary>
        /// Returns true if RestaurantInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of RestaurantInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestaurantInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.HoursInterval == other.HoursInterval ||
                    this.HoursInterval != null &&
                    this.HoursInterval.Equals(other.HoursInterval)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.MaxPartySize == other.MaxPartySize ||
                    this.MaxPartySize != null &&
                    this.MaxPartySize.Equals(other.MaxPartySize)
                ) && 
                (
                    this.MinPartySize == other.MinPartySize ||
                    this.MinPartySize != null &&
                    this.MinPartySize.Equals(other.MinPartySize)
                ) && 
                (
                    this.OpeningHours == other.OpeningHours ||
                    this.OpeningHours != null &&
                    this.OpeningHours.Equals(other.OpeningHours)
                ) && 
                (
                    this.ReservationHours == other.ReservationHours ||
                    this.ReservationHours != null &&
                    this.ReservationHours.Equals(other.ReservationHours)
                ) && 
                (
                    this.SeatingZones == other.SeatingZones ||
                    this.SeatingZones != null &&
                    this.SeatingZones.SequenceEqual(other.SeatingZones)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) && 
                (
                    this.ImageUrl == other.ImageUrl ||
                    this.ImageUrl != null &&
                    this.ImageUrl.Equals(other.ImageUrl)
                ) && 
                (
                    this.FacebookId == other.FacebookId ||
                    this.FacebookId != null &&
                    this.FacebookId.Equals(other.FacebookId)
                ) && 
                (
                    this.TwitterAccount == other.TwitterAccount ||
                    this.TwitterAccount != null &&
                    this.TwitterAccount.Equals(other.TwitterAccount)
                ) && 
                (
                    this.WebsiteUrl == other.WebsiteUrl ||
                    this.WebsiteUrl != null &&
                    this.WebsiteUrl.Equals(other.WebsiteUrl)
                ) && 
                (
                    this.FoursquareId == other.FoursquareId ||
                    this.FoursquareId != null &&
                    this.FoursquareId.Equals(other.FoursquareId)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
                ) && 
                (
                    this.Lat == other.Lat ||
                    this.Lat != null &&
                    this.Lat.Equals(other.Lat)
                ) && 
                (
                    this.Lon == other.Lon ||
                    this.Lon != null &&
                    this.Lon.Equals(other.Lon)
                ) && 
                (
                    this.HasHostmeSystem == other.HasHostmeSystem ||
                    this.HasHostmeSystem != null &&
                    this.HasHostmeSystem.Equals(other.HasHostmeSystem)
                ) && 
                (
                    this.Distance == other.Distance ||
                    this.Distance != null &&
                    this.Distance.Equals(other.Distance)
                ) && 
                (
                    this.HasLoyaltyProgram == other.HasLoyaltyProgram ||
                    this.HasLoyaltyProgram != null &&
                    this.HasLoyaltyProgram.Equals(other.HasLoyaltyProgram)
                ) && 
                (
                    this.AcceptRemouteLine == other.AcceptRemouteLine ||
                    this.AcceptRemouteLine != null &&
                    this.AcceptRemouteLine.Equals(other.AcceptRemouteLine)
                ) && 
                (
                    this.AcceptReservation == other.AcceptReservation ||
                    this.AcceptReservation != null &&
                    this.AcceptReservation.Equals(other.AcceptReservation)
                ) && 
                (
                    this.AllowManualHold == other.AllowManualHold ||
                    this.AllowManualHold != null &&
                    this.AllowManualHold.Equals(other.AllowManualHold)
                ) && 
                (
                    this.CurrentLineStats == other.CurrentLineStats ||
                    this.CurrentLineStats != null &&
                    this.CurrentLineStats.Equals(other.CurrentLineStats)
                ) && 
                (
                    this.ReservationIncomeEmail == other.ReservationIncomeEmail ||
                    this.ReservationIncomeEmail != null &&
                    this.ReservationIncomeEmail.Equals(other.ReservationIncomeEmail)
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
                if (this.HoursInterval != null)
                    hash = hash * 59 + this.HoursInterval.GetHashCode();
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                if (this.MaxPartySize != null)
                    hash = hash * 59 + this.MaxPartySize.GetHashCode();
                if (this.MinPartySize != null)
                    hash = hash * 59 + this.MinPartySize.GetHashCode();
                if (this.OpeningHours != null)
                    hash = hash * 59 + this.OpeningHours.GetHashCode();
                if (this.ReservationHours != null)
                    hash = hash * 59 + this.ReservationHours.GetHashCode();
                if (this.SeatingZones != null)
                    hash = hash * 59 + this.SeatingZones.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                if (this.ImageUrl != null)
                    hash = hash * 59 + this.ImageUrl.GetHashCode();
                if (this.FacebookId != null)
                    hash = hash * 59 + this.FacebookId.GetHashCode();
                if (this.TwitterAccount != null)
                    hash = hash * 59 + this.TwitterAccount.GetHashCode();
                if (this.WebsiteUrl != null)
                    hash = hash * 59 + this.WebsiteUrl.GetHashCode();
                if (this.FoursquareId != null)
                    hash = hash * 59 + this.FoursquareId.GetHashCode();
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                if (this.TimeZone != null)
                    hash = hash * 59 + this.TimeZone.GetHashCode();
                if (this.Lat != null)
                    hash = hash * 59 + this.Lat.GetHashCode();
                if (this.Lon != null)
                    hash = hash * 59 + this.Lon.GetHashCode();
                if (this.HasHostmeSystem != null)
                    hash = hash * 59 + this.HasHostmeSystem.GetHashCode();
                if (this.Distance != null)
                    hash = hash * 59 + this.Distance.GetHashCode();
                if (this.HasLoyaltyProgram != null)
                    hash = hash * 59 + this.HasLoyaltyProgram.GetHashCode();
                if (this.AcceptRemouteLine != null)
                    hash = hash * 59 + this.AcceptRemouteLine.GetHashCode();
                if (this.AcceptReservation != null)
                    hash = hash * 59 + this.AcceptReservation.GetHashCode();
                if (this.AllowManualHold != null)
                    hash = hash * 59 + this.AllowManualHold.GetHashCode();
                if (this.CurrentLineStats != null)
                    hash = hash * 59 + this.CurrentLineStats.GetHashCode();
                if (this.ReservationIncomeEmail != null)
                    hash = hash * 59 + this.ReservationIncomeEmail.GetHashCode();
                return hash;
            }
        }

    }
}
