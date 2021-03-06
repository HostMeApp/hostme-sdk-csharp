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
    /// EmbedToken
    /// </summary>
    [DataContract]
    public partial class EmbedToken :  IEquatable<EmbedToken>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedToken" /> class.
        /// </summary>
        /// <param name="Token">Token.</param>
        /// <param name="TokenId">TokenId.</param>
        /// <param name="Expiration">Expiration.</param>
        public EmbedToken(string Token = null, string TokenId = null, DateTimeOffset? Expiration = null)
        {
            this.Token = Token;
            this.TokenId = TokenId;
            this.Expiration = Expiration;
        }
        
        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name="token", EmitDefaultValue=true)]
        public string Token { get; set; }
        /// <summary>
        /// Gets or Sets TokenId
        /// </summary>
        [DataMember(Name="tokenId", EmitDefaultValue=true)]
        public string TokenId { get; set; }
        /// <summary>
        /// Gets or Sets Expiration
        /// </summary>
        [DataMember(Name="expiration", EmitDefaultValue=true)]
        public DateTimeOffset? Expiration { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmbedToken {\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
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
            return this.Equals(obj as EmbedToken);
        }

        /// <summary>
        /// Returns true if EmbedToken instances are equal
        /// </summary>
        /// <param name="other">Instance of EmbedToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmbedToken other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
                ) && 
                (
                    this.TokenId == other.TokenId ||
                    this.TokenId != null &&
                    this.TokenId.Equals(other.TokenId)
                ) && 
                (
                    this.Expiration == other.Expiration ||
                    this.Expiration != null &&
                    this.Expiration.Equals(other.Expiration)
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
                if (this.Token != null)
                    hash = hash * 59 + this.Token.GetHashCode();
                if (this.TokenId != null)
                    hash = hash * 59 + this.TokenId.GetHashCode();
                if (this.Expiration != null)
                    hash = hash * 59 + this.Expiration.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}