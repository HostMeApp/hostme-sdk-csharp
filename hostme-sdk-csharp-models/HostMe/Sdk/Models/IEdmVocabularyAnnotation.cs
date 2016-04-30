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
    public partial class IEdmVocabularyAnnotation :  IEquatable<IEdmVocabularyAnnotation>
    { 
    
       
        
    
        /// <summary>
        /// Gets or Sets Qualifier
        /// </summary>
        [DataMember(Name="qualifier", EmitDefaultValue=true)]
        public string Qualifier { get; set; }
    
        /// <summary>
        /// Gets or Sets Term
        /// </summary>
        [DataMember(Name="term", EmitDefaultValue=true)]
        public IEdmTerm Term { get; set; }
    
        /// <summary>
        /// Gets or Sets Target
        /// </summary>
        [DataMember(Name="target", EmitDefaultValue=true)]
        public IEdmVocabularyAnnotatable Target { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IEdmVocabularyAnnotation {\n");
            sb.Append("  Qualifier: ").Append(Qualifier).Append("\n");
sb.Append("  Term: ").Append(Term).Append("\n");
sb.Append("  Target: ").Append(Target).Append("\n");
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
            return this.Equals(obj as IEdmVocabularyAnnotation);
        }

        /// <summary>
        /// Returns true if IEdmVocabularyAnnotation instances are equal
        /// </summary>
        /// <param name="other">Instance of IEdmVocabularyAnnotation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IEdmVocabularyAnnotation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Qualifier == other.Qualifier ||
                    this.Qualifier != null &&
                    this.Qualifier.Equals(other.Qualifier)
                ) && 
                (
                    this.Term == other.Term ||
                    this.Term != null &&
                    this.Term.Equals(other.Term)
                ) && 
                (
                    this.Target == other.Target ||
                    this.Target != null &&
                    this.Target.Equals(other.Target)
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
                if (this.Qualifier != null)
                    hash = hash * 59 + this.Qualifier.GetHashCode();
                if (this.Term != null)
                    hash = hash * 59 + this.Term.GetHashCode();
                if (this.Target != null)
                    hash = hash * 59 + this.Target.GetHashCode();
                return hash;
            }
        }

    }
}
