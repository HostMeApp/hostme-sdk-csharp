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
    public partial class Zone :  IEquatable<Zone>
    { 
    
       
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public int? Id { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets TableNumbers
        /// </summary>
        [DataMember(Name="tableNumbers", EmitDefaultValue=true)]
        public List<string> TableNumbers { get; set; }
    
        /// <summary>
        /// Gets or Sets Days
        /// </summary>
        [DataMember(Name="days", EmitDefaultValue=true)]
        public List<int?> Days { get; set; }
    
        /// <summary>
        /// Gets or Sets Waiter
        /// </summary>
        [DataMember(Name="waiter", EmitDefaultValue=true)]
        public Waiter Waiter { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Zone {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
sb.Append("  Name: ").Append(Name).Append("\n");
sb.Append("  TableNumbers: ").Append(TableNumbers).Append("\n");
sb.Append("  Days: ").Append(Days).Append("\n");
sb.Append("  Waiter: ").Append(Waiter).Append("\n");
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
            return this.Equals(obj as Zone);
        }

        /// <summary>
        /// Returns true if Zone instances are equal
        /// </summary>
        /// <param name="other">Instance of Zone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Zone other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.TableNumbers == other.TableNumbers ||
                    this.TableNumbers != null &&
                    this.TableNumbers.SequenceEqual(other.TableNumbers)
                ) && 
                (
                    this.Days == other.Days ||
                    this.Days != null &&
                    this.Days.SequenceEqual(other.Days)
                ) && 
                (
                    this.Waiter == other.Waiter ||
                    this.Waiter != null &&
                    this.Waiter.Equals(other.Waiter)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.TableNumbers != null)
                    hash = hash * 59 + this.TableNumbers.GetHashCode();
                if (this.Days != null)
                    hash = hash * 59 + this.Days.GetHashCode();
                if (this.Waiter != null)
                    hash = hash * 59 + this.Waiter.GetHashCode();
                return hash;
            }
        }

    }
}
