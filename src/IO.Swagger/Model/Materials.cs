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
    /// Defines Materials
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum Materials
    {
        /// <summary>
        /// Enum Concrete for value: Concrete
        /// </summary>
        [EnumMember(Value = "Concrete")]
        Concrete = 1,
        /// <summary>
        /// Enum Stoneware for value: Stoneware
        /// </summary>
        [EnumMember(Value = "Stoneware")]
        Stoneware = 2,
        /// <summary>
        /// Enum Plastic for value: Plastic
        /// </summary>
        [EnumMember(Value = "Plastic")]
        Plastic = 3,
        /// <summary>
        /// Enum Other for value: Other
        /// </summary>
        [EnumMember(Value = "Other")]
        Other = 4    }
}
