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
    /// WaiterCreate
    /// </summary>
    [DataContract]
    public partial class WaiterCreate :  IEquatable<WaiterCreate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WaiterCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WaiterCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WaiterCreate" /> class.
        /// </summary>
        /// <param name="Color">Color (required).</param>
        /// <param name="FullName">FullName (required).</param>
        /// <param name="Base64DataUrl">Base64DataUrl.</param>
        /// <param name="Invitation">Invitation.</param>
        public WaiterCreate(string Color = null, string FullName = null, string Base64DataUrl = null, WaiterInvitation Invitation = null)
        {
            // to ensure "Color" is required (not null)
            if (Color == null)
            {
                throw new InvalidDataException("Color is a required property for WaiterCreate and cannot be null");
            }
            else
            {
                this.Color = Color;
            }
            // to ensure "FullName" is required (not null)
            if (FullName == null)
            {
                throw new InvalidDataException("FullName is a required property for WaiterCreate and cannot be null");
            }
            else
            {
                this.FullName = FullName;
            }
            this.Base64DataUrl = Base64DataUrl;
            this.Invitation = Invitation;
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
        /// Gets or Sets Invitation
        /// </summary>
        [DataMember(Name="invitation", EmitDefaultValue=true)]
        public WaiterInvitation Invitation { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WaiterCreate {\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  Base64DataUrl: ").Append(Base64DataUrl).Append("\n");
            sb.Append("  Invitation: ").Append(Invitation).Append("\n");
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
            return this.Equals(obj as WaiterCreate);
        }

        /// <summary>
        /// Returns true if WaiterCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of WaiterCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WaiterCreate other)
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
                    this.Invitation == other.Invitation ||
                    this.Invitation != null &&
                    this.Invitation.Equals(other.Invitation)
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
                if (this.Invitation != null)
                    hash = hash * 59 + this.Invitation.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}