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
    public partial class NewRestaurantBindingModel :  IEquatable<NewRestaurantBindingModel>
    { 
    
       
        
    
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
        /// Url of the restaurant&#39;s logo. The logo size should be 100x100
        /// </summary>
        /// <value>Url of the restaurant&#39;s logo. The logo size should be 100x100</value>
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewRestaurantBindingModel {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
sb.Append("  Address: ").Append(Address).Append("\n");
sb.Append("  Phone: ").Append(Phone).Append("\n");
sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
sb.Append("  FacebookId: ").Append(FacebookId).Append("\n");
sb.Append("  TwitterAccount: ").Append(TwitterAccount).Append("\n");
sb.Append("  WebsiteUrl: ").Append(WebsiteUrl).Append("\n");
sb.Append("  FoursquareId: ").Append(FoursquareId).Append("\n");
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
            return this.Equals(obj as NewRestaurantBindingModel);
        }

        /// <summary>
        /// Returns true if NewRestaurantBindingModel instances are equal
        /// </summary>
        /// <param name="other">Instance of NewRestaurantBindingModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewRestaurantBindingModel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                if (this.TimeZone != null)
                    hash = hash * 59 + this.TimeZone.GetHashCode();
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
                return hash;
            }
        }

    }
}
