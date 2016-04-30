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
    public partial class WaitingsStatReportItem :  IEquatable<WaitingsStatReportItem>
    { 
    
       
        
    
        /// <summary>
        /// Gets or Sets Dimensions
        /// </summary>
        [DataMember(Name="dimensions", EmitDefaultValue=true)]
        public WaitingsStatDimensions Dimensions { get; set; }
    
        /// <summary>
        /// Gets or Sets TotalPartyCount
        /// </summary>
        [DataMember(Name="totalPartyCount", EmitDefaultValue=true)]
        public double? TotalPartyCount { get; set; }
    
        /// <summary>
        /// Gets or Sets TotalSeatedCount
        /// </summary>
        [DataMember(Name="totalSeatedCount", EmitDefaultValue=true)]
        public double? TotalSeatedCount { get; set; }
    
        /// <summary>
        /// Gets or Sets TotalCanceledCount
        /// </summary>
        [DataMember(Name="totalCanceledCount", EmitDefaultValue=true)]
        public double? TotalCanceledCount { get; set; }
    
        /// <summary>
        /// Gets or Sets MinTimeToCall
        /// </summary>
        [DataMember(Name="minTimeToCall", EmitDefaultValue=true)]
        public double? MinTimeToCall { get; set; }
    
        /// <summary>
        /// Gets or Sets AvgTimeToCall
        /// </summary>
        [DataMember(Name="avgTimeToCall", EmitDefaultValue=true)]
        public double? AvgTimeToCall { get; set; }
    
        /// <summary>
        /// Gets or Sets MaxTimeToCall
        /// </summary>
        [DataMember(Name="maxTimeToCall", EmitDefaultValue=true)]
        public double? MaxTimeToCall { get; set; }
    
        /// <summary>
        /// Gets or Sets MinTimeToSeat
        /// </summary>
        [DataMember(Name="minTimeToSeat", EmitDefaultValue=true)]
        public double? MinTimeToSeat { get; set; }
    
        /// <summary>
        /// Gets or Sets AvgTimeToSeat
        /// </summary>
        [DataMember(Name="avgTimeToSeat", EmitDefaultValue=true)]
        public double? AvgTimeToSeat { get; set; }
    
        /// <summary>
        /// Gets or Sets MaxTimeToSeat
        /// </summary>
        [DataMember(Name="maxTimeToSeat", EmitDefaultValue=true)]
        public double? MaxTimeToSeat { get; set; }
    
        /// <summary>
        /// Gets or Sets MinTimeToCancel
        /// </summary>
        [DataMember(Name="minTimeToCancel", EmitDefaultValue=true)]
        public double? MinTimeToCancel { get; set; }
    
        /// <summary>
        /// Gets or Sets AvgTimeToCancel
        /// </summary>
        [DataMember(Name="avgTimeToCancel", EmitDefaultValue=true)]
        public double? AvgTimeToCancel { get; set; }
    
        /// <summary>
        /// Gets or Sets MaxTimeToCancel
        /// </summary>
        [DataMember(Name="maxTimeToCancel", EmitDefaultValue=true)]
        public double? MaxTimeToCancel { get; set; }
    
        /// <summary>
        /// Gets or Sets MaxLine
        /// </summary>
        [DataMember(Name="maxLine", EmitDefaultValue=true)]
        public int? MaxLine { get; set; }
    
        /// <summary>
        /// Gets or Sets AvgLine
        /// </summary>
        [DataMember(Name="avgLine", EmitDefaultValue=true)]
        public double? AvgLine { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WaitingsStatReportItem {\n");
            sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
sb.Append("  TotalPartyCount: ").Append(TotalPartyCount).Append("\n");
sb.Append("  TotalSeatedCount: ").Append(TotalSeatedCount).Append("\n");
sb.Append("  TotalCanceledCount: ").Append(TotalCanceledCount).Append("\n");
sb.Append("  MinTimeToCall: ").Append(MinTimeToCall).Append("\n");
sb.Append("  AvgTimeToCall: ").Append(AvgTimeToCall).Append("\n");
sb.Append("  MaxTimeToCall: ").Append(MaxTimeToCall).Append("\n");
sb.Append("  MinTimeToSeat: ").Append(MinTimeToSeat).Append("\n");
sb.Append("  AvgTimeToSeat: ").Append(AvgTimeToSeat).Append("\n");
sb.Append("  MaxTimeToSeat: ").Append(MaxTimeToSeat).Append("\n");
sb.Append("  MinTimeToCancel: ").Append(MinTimeToCancel).Append("\n");
sb.Append("  AvgTimeToCancel: ").Append(AvgTimeToCancel).Append("\n");
sb.Append("  MaxTimeToCancel: ").Append(MaxTimeToCancel).Append("\n");
sb.Append("  MaxLine: ").Append(MaxLine).Append("\n");
sb.Append("  AvgLine: ").Append(AvgLine).Append("\n");
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
            return this.Equals(obj as WaitingsStatReportItem);
        }

        /// <summary>
        /// Returns true if WaitingsStatReportItem instances are equal
        /// </summary>
        /// <param name="other">Instance of WaitingsStatReportItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WaitingsStatReportItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Dimensions == other.Dimensions ||
                    this.Dimensions != null &&
                    this.Dimensions.Equals(other.Dimensions)
                ) && 
                (
                    this.TotalPartyCount == other.TotalPartyCount ||
                    this.TotalPartyCount != null &&
                    this.TotalPartyCount.Equals(other.TotalPartyCount)
                ) && 
                (
                    this.TotalSeatedCount == other.TotalSeatedCount ||
                    this.TotalSeatedCount != null &&
                    this.TotalSeatedCount.Equals(other.TotalSeatedCount)
                ) && 
                (
                    this.TotalCanceledCount == other.TotalCanceledCount ||
                    this.TotalCanceledCount != null &&
                    this.TotalCanceledCount.Equals(other.TotalCanceledCount)
                ) && 
                (
                    this.MinTimeToCall == other.MinTimeToCall ||
                    this.MinTimeToCall != null &&
                    this.MinTimeToCall.Equals(other.MinTimeToCall)
                ) && 
                (
                    this.AvgTimeToCall == other.AvgTimeToCall ||
                    this.AvgTimeToCall != null &&
                    this.AvgTimeToCall.Equals(other.AvgTimeToCall)
                ) && 
                (
                    this.MaxTimeToCall == other.MaxTimeToCall ||
                    this.MaxTimeToCall != null &&
                    this.MaxTimeToCall.Equals(other.MaxTimeToCall)
                ) && 
                (
                    this.MinTimeToSeat == other.MinTimeToSeat ||
                    this.MinTimeToSeat != null &&
                    this.MinTimeToSeat.Equals(other.MinTimeToSeat)
                ) && 
                (
                    this.AvgTimeToSeat == other.AvgTimeToSeat ||
                    this.AvgTimeToSeat != null &&
                    this.AvgTimeToSeat.Equals(other.AvgTimeToSeat)
                ) && 
                (
                    this.MaxTimeToSeat == other.MaxTimeToSeat ||
                    this.MaxTimeToSeat != null &&
                    this.MaxTimeToSeat.Equals(other.MaxTimeToSeat)
                ) && 
                (
                    this.MinTimeToCancel == other.MinTimeToCancel ||
                    this.MinTimeToCancel != null &&
                    this.MinTimeToCancel.Equals(other.MinTimeToCancel)
                ) && 
                (
                    this.AvgTimeToCancel == other.AvgTimeToCancel ||
                    this.AvgTimeToCancel != null &&
                    this.AvgTimeToCancel.Equals(other.AvgTimeToCancel)
                ) && 
                (
                    this.MaxTimeToCancel == other.MaxTimeToCancel ||
                    this.MaxTimeToCancel != null &&
                    this.MaxTimeToCancel.Equals(other.MaxTimeToCancel)
                ) && 
                (
                    this.MaxLine == other.MaxLine ||
                    this.MaxLine != null &&
                    this.MaxLine.Equals(other.MaxLine)
                ) && 
                (
                    this.AvgLine == other.AvgLine ||
                    this.AvgLine != null &&
                    this.AvgLine.Equals(other.AvgLine)
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
                if (this.Dimensions != null)
                    hash = hash * 59 + this.Dimensions.GetHashCode();
                if (this.TotalPartyCount != null)
                    hash = hash * 59 + this.TotalPartyCount.GetHashCode();
                if (this.TotalSeatedCount != null)
                    hash = hash * 59 + this.TotalSeatedCount.GetHashCode();
                if (this.TotalCanceledCount != null)
                    hash = hash * 59 + this.TotalCanceledCount.GetHashCode();
                if (this.MinTimeToCall != null)
                    hash = hash * 59 + this.MinTimeToCall.GetHashCode();
                if (this.AvgTimeToCall != null)
                    hash = hash * 59 + this.AvgTimeToCall.GetHashCode();
                if (this.MaxTimeToCall != null)
                    hash = hash * 59 + this.MaxTimeToCall.GetHashCode();
                if (this.MinTimeToSeat != null)
                    hash = hash * 59 + this.MinTimeToSeat.GetHashCode();
                if (this.AvgTimeToSeat != null)
                    hash = hash * 59 + this.AvgTimeToSeat.GetHashCode();
                if (this.MaxTimeToSeat != null)
                    hash = hash * 59 + this.MaxTimeToSeat.GetHashCode();
                if (this.MinTimeToCancel != null)
                    hash = hash * 59 + this.MinTimeToCancel.GetHashCode();
                if (this.AvgTimeToCancel != null)
                    hash = hash * 59 + this.AvgTimeToCancel.GetHashCode();
                if (this.MaxTimeToCancel != null)
                    hash = hash * 59 + this.MaxTimeToCancel.GetHashCode();
                if (this.MaxLine != null)
                    hash = hash * 59 + this.MaxLine.GetHashCode();
                if (this.AvgLine != null)
                    hash = hash * 59 + this.AvgLine.GetHashCode();
                return hash;
            }
        }

    }
}
