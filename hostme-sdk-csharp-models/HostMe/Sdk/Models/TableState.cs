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
    public partial class TableState :  IEquatable<TableState>
    { 
    
       
        
    
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=true)]
        public string Title { get; set; }
    
        /// <summary>
        /// Gets or Sets Percents
        /// </summary>
        [DataMember(Name="percents", EmitDefaultValue=true)]
        public int? Percents { get; set; }
    
        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [DataMember(Name="color", EmitDefaultValue=true)]
        public string Color { get; set; }
    
        /// <summary>
        /// Gets or Sets IsCustom
        /// </summary>
        [DataMember(Name="isCustom", EmitDefaultValue=true)]
        public bool? IsCustom { get; set; }
    
        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="isActive", EmitDefaultValue=true)]
        public bool? IsActive { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TableState {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
sb.Append("  Percents: ").Append(Percents).Append("\n");
sb.Append("  Color: ").Append(Color).Append("\n");
sb.Append("  IsCustom: ").Append(IsCustom).Append("\n");
sb.Append("  IsActive: ").Append(IsActive).Append("\n");
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
            return this.Equals(obj as TableState);
        }

        /// <summary>
        /// Returns true if TableState instances are equal
        /// </summary>
        /// <param name="other">Instance of TableState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TableState other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.Percents == other.Percents ||
                    this.Percents != null &&
                    this.Percents.Equals(other.Percents)
                ) && 
                (
                    this.Color == other.Color ||
                    this.Color != null &&
                    this.Color.Equals(other.Color)
                ) && 
                (
                    this.IsCustom == other.IsCustom ||
                    this.IsCustom != null &&
                    this.IsCustom.Equals(other.IsCustom)
                ) && 
                (
                    this.IsActive == other.IsActive ||
                    this.IsActive != null &&
                    this.IsActive.Equals(other.IsActive)
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
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Percents != null)
                    hash = hash * 59 + this.Percents.GetHashCode();
                if (this.Color != null)
                    hash = hash * 59 + this.Color.GetHashCode();
                if (this.IsCustom != null)
                    hash = hash * 59 + this.IsCustom.GetHashCode();
                if (this.IsActive != null)
                    hash = hash * 59 + this.IsActive.GetHashCode();
                return hash;
            }
        }

    }
}
