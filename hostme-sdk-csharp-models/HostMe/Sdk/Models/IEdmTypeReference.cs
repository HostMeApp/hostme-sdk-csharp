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
    public partial class IEdmTypeReference :  IEquatable<IEdmTypeReference>
    { 
    
       
        
    
        /// <summary>
        /// Gets or Sets IsNullable
        /// </summary>
        [DataMember(Name="isNullable", EmitDefaultValue=true)]
        public bool? IsNullable { get; set; }
    
        /// <summary>
        /// Gets or Sets Definition
        /// </summary>
        [DataMember(Name="definition", EmitDefaultValue=true)]
        public IEdmType Definition { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IEdmTypeReference {\n");
            sb.Append("  IsNullable: ").Append(IsNullable).Append("\n");
sb.Append("  Definition: ").Append(Definition).Append("\n");
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
            return this.Equals(obj as IEdmTypeReference);
        }

        /// <summary>
        /// Returns true if IEdmTypeReference instances are equal
        /// </summary>
        /// <param name="other">Instance of IEdmTypeReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IEdmTypeReference other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IsNullable == other.IsNullable ||
                    this.IsNullable != null &&
                    this.IsNullable.Equals(other.IsNullable)
                ) && 
                (
                    this.Definition == other.Definition ||
                    this.Definition != null &&
                    this.Definition.Equals(other.Definition)
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
                if (this.IsNullable != null)
                    hash = hash * 59 + this.IsNullable.GetHashCode();
                if (this.Definition != null)
                    hash = hash * 59 + this.Definition.GetHashCode();
                return hash;
            }
        }

    }
}
