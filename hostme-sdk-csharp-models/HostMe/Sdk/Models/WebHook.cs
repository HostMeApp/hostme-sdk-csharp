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

namespace HostMe.Sdk.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class WebHook :  IEquatable<WebHook>
    { 
    
       
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or Sets WebHookUri
        /// </summary>
        [DataMember(Name="webHookUri", EmitDefaultValue=true)]
        public string WebHookUri { get; set; }
    
        /// <summary>
        /// Gets or Sets Secret
        /// </summary>
        [DataMember(Name="secret", EmitDefaultValue=true)]
        public string Secret { get; set; }
    
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or Sets IsPaused
        /// </summary>
        [DataMember(Name="isPaused", EmitDefaultValue=true)]
        public bool? IsPaused { get; set; }
    
        /// <summary>
        /// Gets or Sets Filters
        /// </summary>
        [DataMember(Name="filters", EmitDefaultValue=true)]
        public List<string> Filters { get; set; }
    
        /// <summary>
        /// Gets or Sets Headers
        /// </summary>
        [DataMember(Name="headers", EmitDefaultValue=true)]
        public Dictionary<string, string> Headers { get; set; }
    
        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="properties", EmitDefaultValue=true)]
        public Dictionary<string, Object> Properties { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebHook {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
sb.Append("  WebHookUri: ").Append(WebHookUri).Append("\n");
sb.Append("  Secret: ").Append(Secret).Append("\n");
sb.Append("  Description: ").Append(Description).Append("\n");
sb.Append("  IsPaused: ").Append(IsPaused).Append("\n");
sb.Append("  Filters: ").Append(Filters).Append("\n");
sb.Append("  Headers: ").Append(Headers).Append("\n");
sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return this.Equals(obj as WebHook);
        }

        /// <summary>
        /// Returns true if WebHook instances are equal
        /// </summary>
        /// <param name="other">Instance of WebHook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebHook other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.WebHookUri == other.WebHookUri ||
                    this.WebHookUri != null &&
                    this.WebHookUri.Equals(other.WebHookUri)
                ) && 
                (
                    this.Secret == other.Secret ||
                    this.Secret != null &&
                    this.Secret.Equals(other.Secret)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.IsPaused == other.IsPaused ||
                    this.IsPaused != null &&
                    this.IsPaused.Equals(other.IsPaused)
                ) && 
                (
                    this.Filters == other.Filters ||
                    this.Filters != null &&
                    this.Filters.SequenceEqual(other.Filters)
                ) && 
                (
                    this.Headers == other.Headers ||
                    this.Headers != null &&
                    this.Headers.SequenceEqual(other.Headers)
                ) && 
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.SequenceEqual(other.Properties)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.WebHookUri != null)
                    hash = hash * 59 + this.WebHookUri.GetHashCode();
                if (this.Secret != null)
                    hash = hash * 59 + this.Secret.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.IsPaused != null)
                    hash = hash * 59 + this.IsPaused.GetHashCode();
                if (this.Filters != null)
                    hash = hash * 59 + this.Filters.GetHashCode();
                if (this.Headers != null)
                    hash = hash * 59 + this.Headers.GetHashCode();
                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();
                return hash;
            }
        }

    }
}
