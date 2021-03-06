/* 
 * Qa full api
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: all
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace HostMe.Sdk.Model
{
    /// <summary>
    /// CreateRestaurant
    /// </summary>
    [DataContract]
    public partial class CreateRestaurant :  IEquatable<CreateRestaurant>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRestaurant" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateRestaurant() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRestaurant" /> class.
        /// </summary>
        /// <param name="Name">Name (required).</param>
        /// <param name="Address">Address (required).</param>
        /// <param name="Phone">Phone.</param>
        /// <param name="Email">Email.</param>
        /// <param name="ImageUrl">ImageUrl.</param>
        /// <param name="FacebookId">FacebookId.</param>
        /// <param name="TwitterAccount">TwitterAccount.</param>
        /// <param name="WebsiteUrl">WebsiteUrl.</param>
        /// <param name="FoursquareId">FoursquareId.</param>
        /// <param name="Language">Language.</param>
        public CreateRestaurant(string Name = null, string Address = null, string Phone = null, string Email = null, string ImageUrl = null, string FacebookId = null, string TwitterAccount = null, string WebsiteUrl = null, string FoursquareId = null, string Language = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for CreateRestaurant and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Address" is required (not null)
            if (Address == null)
            {
                throw new InvalidDataException("Address is a required property for CreateRestaurant and cannot be null");
            }
            else
            {
                this.Address = Address;
            }
            this.Phone = Phone;
            this.Email = Email;
            this.ImageUrl = ImageUrl;
            this.FacebookId = FacebookId;
            this.TwitterAccount = TwitterAccount;
            this.WebsiteUrl = WebsiteUrl;
            this.FoursquareId = FoursquareId;
            this.Language = Language;
        }
        
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
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=true)]
        public string Email { get; set; }
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
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=true)]
        public string Language { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRestaurant {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  FacebookId: ").Append(FacebookId).Append("\n");
            sb.Append("  TwitterAccount: ").Append(TwitterAccount).Append("\n");
            sb.Append("  WebsiteUrl: ").Append(WebsiteUrl).Append("\n");
            sb.Append("  FoursquareId: ").Append(FoursquareId).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
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
            return this.Equals(obj as CreateRestaurant);
        }

        /// <summary>
        /// Returns true if CreateRestaurant instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateRestaurant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateRestaurant other)
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
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
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
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
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
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
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
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}