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
    /// Heigh and width of pipe in [mm]
    /// </summary>
    [DataContract]
        public partial class PipeDiameter :  IEquatable<PipeDiameter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PipeDiameter" /> class.
        /// </summary>
        /// <param name="width">Pipe width in [mm] (required).</param>
        /// <param name="height">Pipe height in [mm] (required).</param>
        public PipeDiameter(int? width = default(int?), int? height = default(int?))
        {
            // to ensure "width" is required (not null)
            if (width == null)
            {
                throw new InvalidDataException("width is a required property for PipeDiameter and cannot be null");
            }
            else
            {
                this.Width = width;
            }
            // to ensure "height" is required (not null)
            if (height == null)
            {
                throw new InvalidDataException("height is a required property for PipeDiameter and cannot be null");
            }
            else
            {
                this.Height = height;
            }
        }
        
        /// <summary>
        /// Pipe width in [mm]
        /// </summary>
        /// <value>Pipe width in [mm]</value>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public int? Width { get; set; }

        /// <summary>
        /// Pipe height in [mm]
        /// </summary>
        /// <value>Pipe height in [mm]</value>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public int? Height { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PipeDiameter {\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
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
            return this.Equals(input as PipeDiameter);
        }

        /// <summary>
        /// Returns true if PipeDiameter instances are equal
        /// </summary>
        /// <param name="input">Instance of PipeDiameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PipeDiameter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
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
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
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
