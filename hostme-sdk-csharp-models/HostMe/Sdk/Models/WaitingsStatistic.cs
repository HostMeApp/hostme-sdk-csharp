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
    /// WaitingsStatistic
    /// </summary>
    [DataContract]
    public partial class WaitingsStatistic :  IEquatable<WaitingsStatistic>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WaitingsStatistic" /> class.
        /// </summary>
        /// <param name="InList">InList.</param>
        /// <param name="Called">Called.</param>
        /// <param name="TablesAvailable">TablesAvailable.</param>
        /// <param name="TotalCovers">TotalCovers.</param>
        /// <param name="CoversAvailable">CoversAvailable.</param>
        /// <param name="OneTwoGroup">OneTwoGroup.</param>
        /// <param name="ThreeFourGroup">ThreeFourGroup.</param>
        /// <param name="FiveSixGroup">FiveSixGroup.</param>
        /// <param name="WaitByGroup">WaitByGroup.</param>
        public WaitingsStatistic(int? InList = null, int? Called = null, int? TablesAvailable = null, int? TotalCovers = null, int? CoversAvailable = null, AverageWaitingTime OneTwoGroup = null, AverageWaitingTime ThreeFourGroup = null, AverageWaitingTime FiveSixGroup = null, List<WaitingStatLine> WaitByGroup = null)
        {
            this.InList = InList;
            this.Called = Called;
            this.TablesAvailable = TablesAvailable;
            this.TotalCovers = TotalCovers;
            this.CoversAvailable = CoversAvailable;
            this.OneTwoGroup = OneTwoGroup;
            this.ThreeFourGroup = ThreeFourGroup;
            this.FiveSixGroup = FiveSixGroup;
            this.WaitByGroup = WaitByGroup;
        }
        
        /// <summary>
        /// Gets or Sets InList
        /// </summary>
        [DataMember(Name="inList", EmitDefaultValue=true)]
        public int? InList { get; set; }
        /// <summary>
        /// Gets or Sets Called
        /// </summary>
        [DataMember(Name="called", EmitDefaultValue=true)]
        public int? Called { get; set; }
        /// <summary>
        /// Gets or Sets TablesAvailable
        /// </summary>
        [DataMember(Name="tablesAvailable", EmitDefaultValue=true)]
        public int? TablesAvailable { get; set; }
        /// <summary>
        /// Gets or Sets TotalCovers
        /// </summary>
        [DataMember(Name="totalCovers", EmitDefaultValue=true)]
        public int? TotalCovers { get; set; }
        /// <summary>
        /// Gets or Sets CoversAvailable
        /// </summary>
        [DataMember(Name="coversAvailable", EmitDefaultValue=true)]
        public int? CoversAvailable { get; set; }
        /// <summary>
        /// Gets or Sets OneTwoGroup
        /// </summary>
        [DataMember(Name="oneTwoGroup", EmitDefaultValue=true)]
        public AverageWaitingTime OneTwoGroup { get; set; }
        /// <summary>
        /// Gets or Sets ThreeFourGroup
        /// </summary>
        [DataMember(Name="threeFourGroup", EmitDefaultValue=true)]
        public AverageWaitingTime ThreeFourGroup { get; set; }
        /// <summary>
        /// Gets or Sets FiveSixGroup
        /// </summary>
        [DataMember(Name="fiveSixGroup", EmitDefaultValue=true)]
        public AverageWaitingTime FiveSixGroup { get; set; }
        /// <summary>
        /// Gets or Sets WaitByGroup
        /// </summary>
        [DataMember(Name="waitByGroup", EmitDefaultValue=true)]
        public List<WaitingStatLine> WaitByGroup { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WaitingsStatistic {\n");
            sb.Append("  InList: ").Append(InList).Append("\n");
            sb.Append("  Called: ").Append(Called).Append("\n");
            sb.Append("  TablesAvailable: ").Append(TablesAvailable).Append("\n");
            sb.Append("  TotalCovers: ").Append(TotalCovers).Append("\n");
            sb.Append("  CoversAvailable: ").Append(CoversAvailable).Append("\n");
            sb.Append("  OneTwoGroup: ").Append(OneTwoGroup).Append("\n");
            sb.Append("  ThreeFourGroup: ").Append(ThreeFourGroup).Append("\n");
            sb.Append("  FiveSixGroup: ").Append(FiveSixGroup).Append("\n");
            sb.Append("  WaitByGroup: ").Append(WaitByGroup).Append("\n");
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
            return this.Equals(obj as WaitingsStatistic);
        }

        /// <summary>
        /// Returns true if WaitingsStatistic instances are equal
        /// </summary>
        /// <param name="other">Instance of WaitingsStatistic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WaitingsStatistic other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.InList == other.InList ||
                    this.InList != null &&
                    this.InList.Equals(other.InList)
                ) && 
                (
                    this.Called == other.Called ||
                    this.Called != null &&
                    this.Called.Equals(other.Called)
                ) && 
                (
                    this.TablesAvailable == other.TablesAvailable ||
                    this.TablesAvailable != null &&
                    this.TablesAvailable.Equals(other.TablesAvailable)
                ) && 
                (
                    this.TotalCovers == other.TotalCovers ||
                    this.TotalCovers != null &&
                    this.TotalCovers.Equals(other.TotalCovers)
                ) && 
                (
                    this.CoversAvailable == other.CoversAvailable ||
                    this.CoversAvailable != null &&
                    this.CoversAvailable.Equals(other.CoversAvailable)
                ) && 
                (
                    this.OneTwoGroup == other.OneTwoGroup ||
                    this.OneTwoGroup != null &&
                    this.OneTwoGroup.Equals(other.OneTwoGroup)
                ) && 
                (
                    this.ThreeFourGroup == other.ThreeFourGroup ||
                    this.ThreeFourGroup != null &&
                    this.ThreeFourGroup.Equals(other.ThreeFourGroup)
                ) && 
                (
                    this.FiveSixGroup == other.FiveSixGroup ||
                    this.FiveSixGroup != null &&
                    this.FiveSixGroup.Equals(other.FiveSixGroup)
                ) && 
                (
                    this.WaitByGroup == other.WaitByGroup ||
                    this.WaitByGroup != null &&
                    this.WaitByGroup.SequenceEqual(other.WaitByGroup)
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
                if (this.InList != null)
                    hash = hash * 59 + this.InList.GetHashCode();
                if (this.Called != null)
                    hash = hash * 59 + this.Called.GetHashCode();
                if (this.TablesAvailable != null)
                    hash = hash * 59 + this.TablesAvailable.GetHashCode();
                if (this.TotalCovers != null)
                    hash = hash * 59 + this.TotalCovers.GetHashCode();
                if (this.CoversAvailable != null)
                    hash = hash * 59 + this.CoversAvailable.GetHashCode();
                if (this.OneTwoGroup != null)
                    hash = hash * 59 + this.OneTwoGroup.GetHashCode();
                if (this.ThreeFourGroup != null)
                    hash = hash * 59 + this.ThreeFourGroup.GetHashCode();
                if (this.FiveSixGroup != null)
                    hash = hash * 59 + this.FiveSixGroup.GetHashCode();
                if (this.WaitByGroup != null)
                    hash = hash * 59 + this.WaitByGroup.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}