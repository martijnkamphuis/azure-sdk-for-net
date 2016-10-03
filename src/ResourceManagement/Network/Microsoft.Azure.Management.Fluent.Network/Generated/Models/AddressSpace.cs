// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// AddressSpace contains an array of IP address ranges that can be used
    /// by subnets
    /// </summary>
    public partial class AddressSpace
    {
        /// <summary>
        /// Initializes a new instance of the AddressSpace class.
        /// </summary>
        public AddressSpace() { }

        /// <summary>
        /// Initializes a new instance of the AddressSpace class.
        /// </summary>
        /// <param name="addressPrefixes">Gets or sets list of address blocks
        /// reserved for this virtual network in CIDR notation</param>
        public AddressSpace(System.Collections.Generic.IList<string> addressPrefixes = default(System.Collections.Generic.IList<string>))
        {
            AddressPrefixes = addressPrefixes;
        }

        /// <summary>
        /// Gets or sets list of address blocks reserved for this virtual
        /// network in CIDR notation
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "addressPrefixes")]
        public System.Collections.Generic.IList<string> AddressPrefixes { get; set; }

    }
}