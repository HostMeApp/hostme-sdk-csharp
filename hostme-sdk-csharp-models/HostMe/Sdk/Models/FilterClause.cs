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
    /// FilterClause
    /// </summary>
    [DataContract]
    public partial class FilterClause :  IEquatable<FilterClause>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterClause" /> class.
        /// </summary>
        /// <param name="Expression">Expression.</param>
        /// <param name="RangeVariable">RangeVariable.</param>
        /// <param name="ItemType">ItemType.</param>
        public FilterClause(SingleValueNode Expression = null, RangeVariable RangeVariable = null, IEdmTypeReference ItemType = null)
        {
            this.Expression = Expression;
            this.RangeVariable = RangeVariable;
            this.ItemType = ItemType;
        }
        
        /// <summary>
        /// Gets or Sets Expression
        /// </summary>
        [DataMember(Name="expression", EmitDefaultValue=true)]
        public SingleValueNode Expression { get; set; }
        /// <summary>
        /// Gets or Sets RangeVariable
        /// </summary>
        [DataMember(Name="rangeVariable", EmitDefaultValue=true)]
        public RangeVariable RangeVariable { get; set; }
        /// <summary>
        /// Gets or Sets ItemType
        /// </summary>
        [DataMember(Name="itemType", EmitDefaultValue=true)]
        public IEdmTypeReference ItemType { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FilterClause {\n");
            sb.Append("  Expression: ").Append(Expression).Append("\n");
            sb.Append("  RangeVariable: ").Append(RangeVariable).Append("\n");
            sb.Append("  ItemType: ").Append(ItemType).Append("\n");
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
            return this.Equals(obj as FilterClause);
        }

        /// <summary>
        /// Returns true if FilterClause instances are equal
        /// </summary>
        /// <param name="other">Instance of FilterClause to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilterClause other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Expression == other.Expression ||
                    this.Expression != null &&
                    this.Expression.Equals(other.Expression)
                ) && 
                (
                    this.RangeVariable == other.RangeVariable ||
                    this.RangeVariable != null &&
                    this.RangeVariable.Equals(other.RangeVariable)
                ) && 
                (
                    this.ItemType == other.ItemType ||
                    this.ItemType != null &&
                    this.ItemType.Equals(other.ItemType)
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
                if (this.Expression != null)
                    hash = hash * 59 + this.Expression.GetHashCode();
                if (this.RangeVariable != null)
                    hash = hash * 59 + this.RangeVariable.GetHashCode();
                if (this.ItemType != null)
                    hash = hash * 59 + this.ItemType.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}