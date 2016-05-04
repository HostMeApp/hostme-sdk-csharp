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
    public partial class SingleValueNode :  IEquatable<SingleValueNode>
    { 
    
        /// <summary>
        /// Gets or Sets Kind
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum KindEnum {
            
            [EnumMember(Value = "None")]
            None,
            
            [EnumMember(Value = "Constant")]
            Constant,
            
            [EnumMember(Value = "Convert")]
            Convert,
            
            [EnumMember(Value = "NonentityRangeVariableReference")]
            Nonentityrangevariablereference,
            
            [EnumMember(Value = "BinaryOperator")]
            Binaryoperator,
            
            [EnumMember(Value = "UnaryOperator")]
            Unaryoperator,
            
            [EnumMember(Value = "SingleValuePropertyAccess")]
            Singlevaluepropertyaccess,
            
            [EnumMember(Value = "CollectionPropertyAccess")]
            Collectionpropertyaccess,
            
            [EnumMember(Value = "SingleValueFunctionCall")]
            Singlevaluefunctioncall,
            
            [EnumMember(Value = "Any")]
            Any,
            
            [EnumMember(Value = "CollectionNavigationNode")]
            Collectionnavigationnode,
            
            [EnumMember(Value = "SingleNavigationNode")]
            Singlenavigationnode,
            
            [EnumMember(Value = "SingleValueOpenPropertyAccess")]
            Singlevalueopenpropertyaccess,
            
            [EnumMember(Value = "SingleEntityCast")]
            Singleentitycast,
            
            [EnumMember(Value = "All")]
            All,
            
            [EnumMember(Value = "EntityCollectionCast")]
            Entitycollectioncast,
            
            [EnumMember(Value = "EntityRangeVariableReference")]
            Entityrangevariablereference,
            
            [EnumMember(Value = "SingleEntityFunctionCall")]
            Singleentityfunctioncall,
            
            [EnumMember(Value = "CollectionFunctionCall")]
            Collectionfunctioncall,
            
            [EnumMember(Value = "EntityCollectionFunctionCall")]
            Entitycollectionfunctioncall,
            
            [EnumMember(Value = "NamedFunctionParameter")]
            Namedfunctionparameter
        }

    
        /// <summary>
        /// Gets or Sets Kind
        /// </summary>
        [DataMember(Name="kind", EmitDefaultValue=true)]
        public KindEnum? Kind { get; set; }
    
       
        
    
        /// <summary>
        /// Gets or Sets TypeReference
        /// </summary>
        [DataMember(Name="typeReference", EmitDefaultValue=true)]
        public IEdmTypeReference TypeReference { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SingleValueNode {\n");
            sb.Append("  TypeReference: ").Append(TypeReference).Append("\n");
sb.Append("  Kind: ").Append(Kind).Append("\n");
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
            return this.Equals(obj as SingleValueNode);
        }

        /// <summary>
        /// Returns true if SingleValueNode instances are equal
        /// </summary>
        /// <param name="other">Instance of SingleValueNode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SingleValueNode other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TypeReference == other.TypeReference ||
                    this.TypeReference != null &&
                    this.TypeReference.Equals(other.TypeReference)
                ) && 
                (
                    this.Kind == other.Kind ||
                    this.Kind != null &&
                    this.Kind.Equals(other.Kind)
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
                if (this.TypeReference != null)
                    hash = hash * 59 + this.TypeReference.GetHashCode();
                if (this.Kind != null)
                    hash = hash * 59 + this.Kind.GetHashCode();
                return hash;
            }
        }

    }
}
