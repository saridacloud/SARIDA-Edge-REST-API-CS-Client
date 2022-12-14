/* 
 * SaridaEdgeAPI
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// CameraState
    /// </summary>
    [DataContract]
        public partial class CameraState :  IEquatable<CameraState>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CameraState" /> class.
        /// </summary>
        /// <param name="frameTime">frameTime.</param>
        /// <param name="pathPosition">Weglaenge in [m].</param>
        /// <param name="cameraOrientation">cameraOrientation.</param>
        /// <param name="liftAngle">Hubwinkel.</param>
        public CameraState(FrameTime frameTime = default(FrameTime), double? pathPosition = default(double?), Orientation cameraOrientation = default(Orientation), double? liftAngle = default(double?))
        {
            this.FrameTime = frameTime;
            this.PathPosition = pathPosition;
            this.CameraOrientation = cameraOrientation;
            this.LiftAngle = liftAngle;
        }
        
        /// <summary>
        /// Gets or Sets FrameTime
        /// </summary>
        [DataMember(Name="frameTime", EmitDefaultValue=false)]
        public FrameTime FrameTime { get; set; }

        /// <summary>
        /// Weglaenge in [m]
        /// </summary>
        /// <value>Weglaenge in [m]</value>
        [DataMember(Name="pathPosition", EmitDefaultValue=false)]
        public double? PathPosition { get; set; }

        /// <summary>
        /// Gets or Sets CameraOrientation
        /// </summary>
        [DataMember(Name="cameraOrientation", EmitDefaultValue=false)]
        public Orientation CameraOrientation { get; set; }

        /// <summary>
        /// Hubwinkel
        /// </summary>
        /// <value>Hubwinkel</value>
        [DataMember(Name="liftAngle", EmitDefaultValue=false)]
        public double? LiftAngle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CameraState {\n");
            sb.Append("  FrameTime: ").Append(FrameTime).Append("\n");
            sb.Append("  PathPosition: ").Append(PathPosition).Append("\n");
            sb.Append("  CameraOrientation: ").Append(CameraOrientation).Append("\n");
            sb.Append("  LiftAngle: ").Append(LiftAngle).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CameraState);
        }

        /// <summary>
        /// Returns true if CameraState instances are equal
        /// </summary>
        /// <param name="input">Instance of CameraState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CameraState input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FrameTime == input.FrameTime ||
                    (this.FrameTime != null &&
                    this.FrameTime.Equals(input.FrameTime))
                ) && 
                (
                    this.PathPosition == input.PathPosition ||
                    (this.PathPosition != null &&
                    this.PathPosition.Equals(input.PathPosition))
                ) && 
                (
                    this.CameraOrientation == input.CameraOrientation ||
                    (this.CameraOrientation != null &&
                    this.CameraOrientation.Equals(input.CameraOrientation))
                ) && 
                (
                    this.LiftAngle == input.LiftAngle ||
                    (this.LiftAngle != null &&
                    this.LiftAngle.Equals(input.LiftAngle))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.FrameTime != null)
                    hashCode = hashCode * 59 + this.FrameTime.GetHashCode();
                if (this.PathPosition != null)
                    hashCode = hashCode * 59 + this.PathPosition.GetHashCode();
                if (this.CameraOrientation != null)
                    hashCode = hashCode * 59 + this.CameraOrientation.GetHashCode();
                if (this.LiftAngle != null)
                    hashCode = hashCode * 59 + this.LiftAngle.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
