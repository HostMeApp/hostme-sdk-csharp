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
    /// WaiterUpdate
    /// </summary>
    [DataContract]
    public partial class WaiterUpdate :  IEquatable<WaiterUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WaiterUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WaiterUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WaiterUpdate" /> class.
        /// </summary>
        /// <param name="Color">Color (required).</param>
        /// <param name="FullName">FullName (required).</param>
        /// <param name="Base64DataUrl">Base64DataUrl.</param>
        /// <param name="Email">Email.</param>
        /// <param name="Code">Code.</param>
        /// <param name="ImageUrl">ImageUrl.</param>
        /// <param name="RestaurantId">RestaurantId.</param>
        public WaiterUpdate(string Color = null, string FullName = null, string Base64DataUrl = null, string Email = null, string Code = null, string ImageUrl = null, int? RestaurantId = null)
        {
            // to ensure "Color" is required (not null)
            if (Color == null)
            {
                throw new InvalidDataException("Color is a required property for WaiterUpdate and cannot be null");
            }
            else
            {
                this.Color = Color;
            }
            // to ensure "FullName" is required (not null)
            if (FullName == null)
            {
                throw new InvalidDataException("FullName is a required property for WaiterUpdate and cannot be null");
            }
            else
            {
                this.FullName = FullName;
            }
            this.Base64DataUrl = Base64DataUrl;
            this.Email = Email;
            this.Code = Code;
            this.ImageUrl = ImageUrl;
            this.RestaurantId = RestaurantId;
        }
        
        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [DataMember(Name="color", EmitDefaultValue=true)]
        public string Color { get; set; }
        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name="fullName", EmitDefaultValue=true)]
        public string FullName { get; set; }
        /// <summary>
        /// Gets or Sets Base64DataUrl
        /// </summary>
        [DataMember(Name="base64DataUrl", EmitDefaultValue=true)]
        public string Base64DataUrl { get; set; }
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=true)]
        public string Email { get; set; }
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=true)]
        public string Code { get; set; }
        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name="imageUrl", EmitDefaultValue=true)]
        public string ImageUrl { get; set; }
        /// <summary>
        /// Gets or Sets RestaurantId
        /// </summary>
        [DataMember(Name="restaurantId", EmitDefaultValue=true)]
        public int? RestaurantId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WaiterUpdate {\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  Base64DataUrl: ").Append(Base64DataUrl).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  RestaurantId: ").Append(RestaurantId).Append("\n");
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
            return this.Equals(obj as WaiterUpdate);
        }

        /// <summary>
        /// Returns true if WaiterUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of WaiterUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WaiterUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Color == other.Color ||
                    this.Color != null &&
                    this.Color.Equals(other.Color)
                ) && 
                (
                    this.FullName == other.FullName ||
                    this.FullName != null &&
                    this.FullName.Equals(other.FullName)
                ) && 
                (
                    this.Base64DataUrl == other.Base64DataUrl ||
                    this.Base64DataUrl != null &&
                    this.Base64DataUrl.Equals(other.Base64DataUrl)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.ImageUrl == other.ImageUrl ||
                    this.ImageUrl != null &&
                    this.ImageUrl.Equals(other.ImageUrl)
                ) && 
                (
                    this.RestaurantId == other.RestaurantId ||
                    this.RestaurantId != null &&
                    this.RestaurantId.Equals(other.RestaurantId)
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
                if (this.Color != null)
                    hash = hash * 59 + this.Color.GetHashCode();
                if (this.FullName != null)
                    hash = hash * 59 + this.FullName.GetHashCode();
                if (this.Base64DataUrl != null)
                    hash = hash * 59 + this.Base64DataUrl.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.ImageUrl != null)
                    hash = hash * 59 + this.ImageUrl.GetHashCode();
                if (this.RestaurantId != null)
                    hash = hash * 59 + this.RestaurantId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}