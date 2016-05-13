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
    public partial class IEdmModel :  IEquatable<IEdmModel>
    { 
    
       
        
    
        /// <summary>
        /// Gets or Sets SchemaElements
        /// </summary>
        [DataMember(Name="schemaElements", EmitDefaultValue=true)]
        public List<IEdmSchemaElement> SchemaElements { get; set; }
    
        /// <summary>
        /// Gets or Sets VocabularyAnnotations
        /// </summary>
        [DataMember(Name="vocabularyAnnotations", EmitDefaultValue=true)]
        public List<IEdmVocabularyAnnotation> VocabularyAnnotations { get; set; }
    
        /// <summary>
        /// Gets or Sets ReferencedModels
        /// </summary>
        [DataMember(Name="referencedModels", EmitDefaultValue=true)]
        public List<IEdmModel> ReferencedModels { get; set; }
    
        /// <summary>
        /// Gets or Sets DirectValueAnnotationsManager
        /// </summary>
        [DataMember(Name="directValueAnnotationsManager", EmitDefaultValue=true)]
        public IEdmDirectValueAnnotationsManager DirectValueAnnotationsManager { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IEdmModel {\n");
            sb.Append("  SchemaElements: ").Append(SchemaElements).Append("\n");
sb.Append("  VocabularyAnnotations: ").Append(VocabularyAnnotations).Append("\n");
sb.Append("  ReferencedModels: ").Append(ReferencedModels).Append("\n");
sb.Append("  DirectValueAnnotationsManager: ").Append(DirectValueAnnotationsManager).Append("\n");
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
            return this.Equals(obj as IEdmModel);
        }

        /// <summary>
        /// Returns true if IEdmModel instances are equal
        /// </summary>
        /// <param name="other">Instance of IEdmModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IEdmModel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SchemaElements == other.SchemaElements ||
                    this.SchemaElements != null &&
                    this.SchemaElements.SequenceEqual(other.SchemaElements)
                ) && 
                (
                    this.VocabularyAnnotations == other.VocabularyAnnotations ||
                    this.VocabularyAnnotations != null &&
                    this.VocabularyAnnotations.SequenceEqual(other.VocabularyAnnotations)
                ) && 
                (
                    this.ReferencedModels == other.ReferencedModels ||
                    this.ReferencedModels != null &&
                    this.ReferencedModels.SequenceEqual(other.ReferencedModels)
                ) && 
                (
                    this.DirectValueAnnotationsManager == other.DirectValueAnnotationsManager ||
                    this.DirectValueAnnotationsManager != null &&
                    this.DirectValueAnnotationsManager.Equals(other.DirectValueAnnotationsManager)
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
                if (this.SchemaElements != null)
                    hash = hash * 59 + this.SchemaElements.GetHashCode();
                if (this.VocabularyAnnotations != null)
                    hash = hash * 59 + this.VocabularyAnnotations.GetHashCode();
                if (this.ReferencedModels != null)
                    hash = hash * 59 + this.ReferencedModels.GetHashCode();
                if (this.DirectValueAnnotationsManager != null)
                    hash = hash * 59 + this.DirectValueAnnotationsManager.GetHashCode();
                return hash;
            }
        }

    }
}
