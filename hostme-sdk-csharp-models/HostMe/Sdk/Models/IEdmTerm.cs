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
    public partial class IEdmTerm :  IEquatable<IEdmTerm>
    { 
    
        /// <summary>
        /// Gets or Sets TermKind
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TermKindEnum {
            
            [EnumMember(Value = "None")]
            None,
            
            [EnumMember(Value = "Type")]
            Type,
            
            [EnumMember(Value = "Value")]
            Value
        }

    
        /// <summary>
        /// Gets or Sets SchemaElementKind
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SchemaElementKindEnum {
            
            [EnumMember(Value = "None")]
            None,
            
            [EnumMember(Value = "TypeDefinition")]
            Typedefinition,
            
            [EnumMember(Value = "Function")]
            Function,
            
            [EnumMember(Value = "ValueTerm")]
            Valueterm,
            
            [EnumMember(Value = "EntityContainer")]
            Entitycontainer
        }

    
        /// <summary>
        /// Gets or Sets TermKind
        /// </summary>
        [DataMember(Name="termKind", EmitDefaultValue=true)]
        public TermKindEnum? TermKind { get; set; }
    
        /// <summary>
        /// Gets or Sets SchemaElementKind
        /// </summary>
        [DataMember(Name="schemaElementKind", EmitDefaultValue=true)]
        public SchemaElementKindEnum? SchemaElementKind { get; set; }
    
       
        
    
        /// <summary>
        /// Gets or Sets _Namespace
        /// </summary>
        [DataMember(Name="namespace", EmitDefaultValue=true)]
        public string _Namespace { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IEdmTerm {\n");
            sb.Append("  TermKind: ").Append(TermKind).Append("\n");
sb.Append("  SchemaElementKind: ").Append(SchemaElementKind).Append("\n");
sb.Append("  _Namespace: ").Append(_Namespace).Append("\n");
sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as IEdmTerm);
        }

        /// <summary>
        /// Returns true if IEdmTerm instances are equal
        /// </summary>
        /// <param name="other">Instance of IEdmTerm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IEdmTerm other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TermKind == other.TermKind ||
                    this.TermKind != null &&
                    this.TermKind.Equals(other.TermKind)
                ) && 
                (
                    this.SchemaElementKind == other.SchemaElementKind ||
                    this.SchemaElementKind != null &&
                    this.SchemaElementKind.Equals(other.SchemaElementKind)
                ) && 
                (
                    this._Namespace == other._Namespace ||
                    this._Namespace != null &&
                    this._Namespace.Equals(other._Namespace)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                if (this.TermKind != null)
                    hash = hash * 59 + this.TermKind.GetHashCode();
                if (this.SchemaElementKind != null)
                    hash = hash * 59 + this.SchemaElementKind.GetHashCode();
                if (this._Namespace != null)
                    hash = hash * 59 + this._Namespace.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                return hash;
            }
        }

    }
}
