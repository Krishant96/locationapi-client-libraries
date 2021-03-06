/* 
 * Location API
 *
 * Geolocation, Geocoding and Maps
 *
 * OpenAPI spec version: 2.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = unwired.Client.OpenAPIDateConverter;

namespace unwired.Model
{
    /// <summary>
    /// Enable IP address fallback. Specify IP address of the device in the “ip” field if it’s different from the device making the API call.
    /// </summary>
    /// <value>Enable IP address fallback. Specify IP address of the device in the “ip” field if it’s different from the device making the API call.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum IpfSchema
    {
        /// <summary>
        /// Enum NUMBER_0 for value: 0
        /// </summary>
        [EnumMember(Value = "0")]
        NUMBER_0 = 1,

        /// <summary>
        /// Enum NUMBER_1 for value: 1
        /// </summary>
        [EnumMember(Value = "1")]
        NUMBER_1 = 2

    }

}
