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
    public partial class SelectExpandClause :  IEquatable<SelectExpandClause>
    { 
    
       
        
    
        /// <summary>
        /// Gets or Sets SelectedItems
        /// </summary>
        [DataMember(Name="selectedItems", EmitDefaultValue=true)]
        public List<SelectItem> SelectedItems { get; set; }
    
        /// <summary>
        /// Gets or Sets AllSelected
        /// </summary>
        [DataMember(Name="allSelected", EmitDefaultValue=true)]
        public bool? AllSelected { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SelectExpandClause {\n");
            sb.Append("  SelectedItems: ").Append(SelectedItems).Append("\n");
sb.Append("  AllSelected: ").Append(AllSelected).Append("\n");
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
            return this.Equals(obj as SelectExpandClause);
        }

        /// <summary>
        /// Returns true if SelectExpandClause instances are equal
        /// </summary>
        /// <param name="other">Instance of SelectExpandClause to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SelectExpandClause other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SelectedItems == other.SelectedItems ||
                    this.SelectedItems != null &&
                    this.SelectedItems.SequenceEqual(other.SelectedItems)
                ) && 
                (
                    this.AllSelected == other.AllSelected ||
                    this.AllSelected != null &&
                    this.AllSelected.Equals(other.AllSelected)
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
                if (this.SelectedItems != null)
                    hash = hash * 59 + this.SelectedItems.GetHashCode();
                if (this.AllSelected != null)
                    hash = hash * 59 + this.AllSelected.GetHashCode();
                return hash;
            }
        }

    }
}
