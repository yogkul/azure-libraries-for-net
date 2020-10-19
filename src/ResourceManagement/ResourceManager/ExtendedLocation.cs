// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Azure.Management.ResourceManager.Fluent
{
    using Newtonsoft.Json;

    /// <summary>
    /// Extended location property
    /// </summary>
    public partial class ExtendedLocation
    {
        /// <summary>
        /// Initializes a new instance of the ExtendedLocation class.
        /// </summary>
        public ExtendedLocation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExtendedLocation class.
        /// </summary>
        /// <param name="addressPrefixes">A list of address blocks reserved for
        /// this virtual network in CIDR notation.</param>
        public ExtendedLocation(string name = default(string), string type = default(string))
        {
            Name = name;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Type of extended location
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Name of extended location
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
