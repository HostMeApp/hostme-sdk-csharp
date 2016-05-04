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
    public partial class WaitingsStatistic :  IEquatable<WaitingsStatistic>
    { 
    
       
        
    
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
            sb.Append("  OneTwoGroup: ").Append(OneTwoGroup).Append("\n");
            sb.Append("  ThreeFourGroup: ").Append(ThreeFourGroup).Append("\n");
            sb.Append("  FiveSixGroup: ").Append(FiveSixGroup).Append("\n");
            
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
                
                if (this.OneTwoGroup != null)
                    hash = hash * 59 + this.OneTwoGroup.GetHashCode();
                
                if (this.ThreeFourGroup != null)
                    hash = hash * 59 + this.ThreeFourGroup.GetHashCode();
                
                if (this.FiveSixGroup != null)
                    hash = hash * 59 + this.FiveSixGroup.GetHashCode();
                
                return hash;
            }
        }

    }


}
