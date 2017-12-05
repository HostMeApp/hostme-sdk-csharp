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
    /// RestaurantState
    /// </summary>
    [DataContract]
    public partial class RestaurantState :  IEquatable<RestaurantState>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestaurantState" /> class.
        /// </summary>
        /// <param name="Monitors">Monitors.</param>
        /// <param name="ServersRotation">ServersRotation.</param>
        public RestaurantState(List<TableMonitor> Monitors = null, List<Waiter> ServersRotation = null)
        {
            this.Monitors = Monitors;
            this.ServersRotation = ServersRotation;
        }
        
        /// <summary>
        /// Gets or Sets Monitors
        /// </summary>
        [DataMember(Name="monitors", EmitDefaultValue=true)]
        public List<TableMonitor> Monitors { get; set; }
        /// <summary>
        /// Gets or Sets ServersRotation
        /// </summary>
        [DataMember(Name="serversRotation", EmitDefaultValue=true)]
        public List<Waiter> ServersRotation { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestaurantState {\n");
            sb.Append("  Monitors: ").Append(Monitors).Append("\n");
            sb.Append("  ServersRotation: ").Append(ServersRotation).Append("\n");
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
            return this.Equals(obj as RestaurantState);
        }

        /// <summary>
        /// Returns true if RestaurantState instances are equal
        /// </summary>
        /// <param name="other">Instance of RestaurantState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestaurantState other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Monitors == other.Monitors ||
                    this.Monitors != null &&
                    this.Monitors.SequenceEqual(other.Monitors)
                ) && 
                (
                    this.ServersRotation == other.ServersRotation ||
                    this.ServersRotation != null &&
                    this.ServersRotation.SequenceEqual(other.ServersRotation)
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
                if (this.Monitors != null)
                    hash = hash * 59 + this.Monitors.GetHashCode();
                if (this.ServersRotation != null)
                    hash = hash * 59 + this.ServersRotation.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}