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
    /// ZXY-EulerAngle local rotation in [deg]
    /// </summary>
    [DataContract]
        public partial class Orientation :  IEquatable<Orientation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Orientation" /> class.
        /// </summary>
        /// <param name="rotationAngle">Drehwinkel.</param>
        /// <param name="tiltAngle">Neigungswinkel.</param>
        /// <param name="panAngle">Schwenkwinkel.</param>
        public Orientation(double? rotationAngle = default(double?), double? tiltAngle = default(double?), double? panAngle = default(double?))
        {
            this.RotationAngle = rotationAngle;
            this.TiltAngle = tiltAngle;
            this.PanAngle = panAngle;
        }
        
        /// <summary>
        /// Drehwinkel
        /// </summary>
        /// <value>Drehwinkel</value>
        [DataMember(Name="rotationAngle", EmitDefaultValue=false)]
        public double? RotationAngle { get; set; }

        /// <summary>
        /// Neigungswinkel
        /// </summary>
        /// <value>Neigungswinkel</value>
        [DataMember(Name="tiltAngle", EmitDefaultValue=false)]
        public double? TiltAngle { get; set; }

        /// <summary>
        /// Schwenkwinkel
        /// </summary>
        /// <value>Schwenkwinkel</value>
        [DataMember(Name="panAngle", EmitDefaultValue=false)]
        public double? PanAngle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Orientation {\n");
            sb.Append("  RotationAngle: ").Append(RotationAngle).Append("\n");
            sb.Append("  TiltAngle: ").Append(TiltAngle).Append("\n");
            sb.Append("  PanAngle: ").Append(PanAngle).Append("\n");
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
            return this.Equals(input as Orientation);
        }

        /// <summary>
        /// Returns true if Orientation instances are equal
        /// </summary>
        /// <param name="input">Instance of Orientation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Orientation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RotationAngle == input.RotationAngle ||
                    (this.RotationAngle != null &&
                    this.RotationAngle.Equals(input.RotationAngle))
                ) && 
                (
                    this.TiltAngle == input.TiltAngle ||
                    (this.TiltAngle != null &&
                    this.TiltAngle.Equals(input.TiltAngle))
                ) && 
                (
                    this.PanAngle == input.PanAngle ||
                    (this.PanAngle != null &&
                    this.PanAngle.Equals(input.PanAngle))
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
                if (this.RotationAngle != null)
                    hashCode = hashCode * 59 + this.RotationAngle.GetHashCode();
                if (this.TiltAngle != null)
                    hashCode = hashCode * 59 + this.TiltAngle.GetHashCode();
                if (this.PanAngle != null)
                    hashCode = hashCode * 59 + this.PanAngle.GetHashCode();
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