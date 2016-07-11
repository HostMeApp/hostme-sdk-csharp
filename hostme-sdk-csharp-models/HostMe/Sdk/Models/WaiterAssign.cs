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
    public partial class WaiterAssign :  IEquatable<WaiterAssign>
    { 
    
       
        
    
        /// <summary>
        /// Gets or Sets WaiterId
        /// </summary>
        [DataMember(Name="waiterId", EmitDefaultValue=true)]
        public int? WaiterId { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WaiterAssign {\n");
            sb.Append("  WaiterId: ").Append(WaiterId).Append("\n");
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
            return this.Equals(obj as WaiterAssign);
        }

        /// <summary>
        /// Returns true if WaiterAssign instances are equal
        /// </summary>
        /// <param name="other">Instance of WaiterAssign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WaiterAssign other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.WaiterId == other.WaiterId ||
                    this.WaiterId != null &&
                    this.WaiterId.Equals(other.WaiterId)
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
                if (this.WaiterId != null)
                    hash = hash * 59 + this.WaiterId.GetHashCode();
                return hash;
            }
        }

    }
}
