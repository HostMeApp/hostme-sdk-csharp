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
    public partial class IEdmType :  IEquatable<IEdmType>
    { 
    
        /// <summary>
        /// Gets or Sets TypeKind
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeKindEnum {
            
            [EnumMember(Value = "None")]
            None,
            
            [EnumMember(Value = "Primitive")]
            Primitive,
            
            [EnumMember(Value = "Entity")]
            Entity,
            
            [EnumMember(Value = "Complex")]
            Complex,
            
            [EnumMember(Value = "Row")]
            Row,
            
            [EnumMember(Value = "Collection")]
            Collection,
            
            [EnumMember(Value = "EntityReference")]
            Entityreference,
            
            [EnumMember(Value = "Enum")]
            Enum
        }

    
        /// <summary>
        /// Gets or Sets TypeKind
        /// </summary>
        [DataMember(Name="typeKind", EmitDefaultValue=true)]
        public TypeKindEnum? TypeKind { get; set; }
    
       
        
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IEdmType {\n");
            sb.Append("  TypeKind: ").Append(TypeKind).Append("\n");
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
            return this.Equals(obj as IEdmType);
        }

        /// <summary>
        /// Returns true if IEdmType instances are equal
        /// </summary>
        /// <param name="other">Instance of IEdmType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IEdmType other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TypeKind == other.TypeKind ||
                    this.TypeKind != null &&
                    this.TypeKind.Equals(other.TypeKind)
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
                if (this.TypeKind != null)
                    hash = hash * 59 + this.TypeKind.GetHashCode();
                return hash;
            }
        }

    }
}
