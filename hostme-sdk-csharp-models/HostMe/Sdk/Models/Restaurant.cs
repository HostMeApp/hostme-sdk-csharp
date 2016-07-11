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
    public partial class Restaurant :  IEquatable<Restaurant>
    { 
    
       
        
    
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
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=true)]
        public string Location { get; set; }
    
        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name="imageUrl", EmitDefaultValue=true)]
        public string ImageUrl { get; set; }
    
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
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name="settings", EmitDefaultValue=true)]
        public RestaurantSettings Settings { get; set; }
    
        /// <summary>
        /// Gets or Sets GooglePlaceId
        /// </summary>
        [DataMember(Name="googlePlaceId", EmitDefaultValue=true)]
        public string GooglePlaceId { get; set; }
    
        /// <summary>
        /// Gets or Sets YelpId
        /// </summary>
        [DataMember(Name="yelpId", EmitDefaultValue=true)]
        public string YelpId { get; set; }
    
        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=true)]
        public string City { get; set; }
    
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public string State { get; set; }
    
        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=true)]
        public string Country { get; set; }
    
        /// <summary>
        /// Gets or Sets IsPublished
        /// </summary>
        [DataMember(Name="isPublished", EmitDefaultValue=true)]
        public bool? IsPublished { get; set; }
    
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
            sb.Append("class Restaurant {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
sb.Append("  Name: ").Append(Name).Append("\n");
sb.Append("  Address: ").Append(Address).Append("\n");
sb.Append("  Location: ").Append(Location).Append("\n");
sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
sb.Append("  Lat: ").Append(Lat).Append("\n");
sb.Append("  Lon: ").Append(Lon).Append("\n");
sb.Append("  FacebookId: ").Append(FacebookId).Append("\n");
sb.Append("  TwitterAccount: ").Append(TwitterAccount).Append("\n");
sb.Append("  WebsiteUrl: ").Append(WebsiteUrl).Append("\n");
sb.Append("  FoursquareId: ").Append(FoursquareId).Append("\n");
sb.Append("  Phone: ").Append(Phone).Append("\n");
sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
sb.Append("  Settings: ").Append(Settings).Append("\n");
sb.Append("  GooglePlaceId: ").Append(GooglePlaceId).Append("\n");
sb.Append("  YelpId: ").Append(YelpId).Append("\n");
sb.Append("  City: ").Append(City).Append("\n");
sb.Append("  State: ").Append(State).Append("\n");
sb.Append("  Country: ").Append(Country).Append("\n");
sb.Append("  IsPublished: ").Append(IsPublished).Append("\n");
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
            return this.Equals(obj as Restaurant);
        }

        /// <summary>
        /// Returns true if Restaurant instances are equal
        /// </summary>
        /// <param name="other">Instance of Restaurant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Restaurant other)
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
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) && 
                (
                    this.ImageUrl == other.ImageUrl ||
                    this.ImageUrl != null &&
                    this.ImageUrl.Equals(other.ImageUrl)
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
                    this.Settings == other.Settings ||
                    this.Settings != null &&
                    this.Settings.Equals(other.Settings)
                ) && 
                (
                    this.GooglePlaceId == other.GooglePlaceId ||
                    this.GooglePlaceId != null &&
                    this.GooglePlaceId.Equals(other.GooglePlaceId)
                ) && 
                (
                    this.YelpId == other.YelpId ||
                    this.YelpId != null &&
                    this.YelpId.Equals(other.YelpId)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.IsPublished == other.IsPublished ||
                    this.IsPublished != null &&
                    this.IsPublished.Equals(other.IsPublished)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                if (this.ImageUrl != null)
                    hash = hash * 59 + this.ImageUrl.GetHashCode();
                if (this.Lat != null)
                    hash = hash * 59 + this.Lat.GetHashCode();
                if (this.Lon != null)
                    hash = hash * 59 + this.Lon.GetHashCode();
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
                if (this.Settings != null)
                    hash = hash * 59 + this.Settings.GetHashCode();
                if (this.GooglePlaceId != null)
                    hash = hash * 59 + this.GooglePlaceId.GetHashCode();
                if (this.YelpId != null)
                    hash = hash * 59 + this.YelpId.GetHashCode();
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.IsPublished != null)
                    hash = hash * 59 + this.IsPublished.GetHashCode();
                if (this.ReservationIncomeEmail != null)
                    hash = hash * 59 + this.ReservationIncomeEmail.GetHashCode();
                return hash;
            }
        }

    }
}
