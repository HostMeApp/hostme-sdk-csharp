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
    public partial class Profile :  IEquatable<Profile>
    { 
    
       
        
    
        /// <summary>
        /// Gets or Sets Allergy
        /// </summary>
        [DataMember(Name="allergy", EmitDefaultValue=true)]
        public List<string> Allergy { get; set; }
    
        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue=true)]
        public string Note { get; set; }
    
        /// <summary>
        /// Gets or Sets Vegetarian
        /// </summary>
        [DataMember(Name="vegetarian", EmitDefaultValue=true)]
        public bool? Vegetarian { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Profile {\n");
            sb.Append("  Allergy: ").Append(Allergy).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  Vegetarian: ").Append(Vegetarian).Append("\n");
            
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
            return this.Equals(obj as Profile);
        }

        /// <summary>
        /// Returns true if Profile instances are equal
        /// </summary>
        /// <param name="other">Instance of Profile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Profile other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Allergy == other.Allergy ||
                    this.Allergy != null &&
                    this.Allergy.SequenceEqual(other.Allergy)
                ) && 
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
                ) && 
                (
                    this.Vegetarian == other.Vegetarian ||
                    this.Vegetarian != null &&
                    this.Vegetarian.Equals(other.Vegetarian)
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
                
                if (this.Allergy != null)
                    hash = hash * 59 + this.Allergy.GetHashCode();
                
                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();
                
                if (this.Vegetarian != null)
                    hash = hash * 59 + this.Vegetarian.GetHashCode();
                
                return hash;
            }
        }

    }


}
