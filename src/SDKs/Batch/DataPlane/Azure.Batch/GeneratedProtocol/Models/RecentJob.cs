// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Information about the most recent job to run under the job schedule.
    /// </summary>
    public partial class RecentJob
    {
        /// <summary>
        /// Initializes a new instance of the RecentJob class.
        /// </summary>
        public RecentJob() { }

        /// <summary>
        /// Initializes a new instance of the RecentJob class.
        /// </summary>
        /// <param name="id">The ID of the job.</param>
        /// <param name="url">The URL of the job.</param>
        public RecentJob(string id = default(string), string url = default(string))
        {
            this.Id = id;
            this.Url = url;
        }

        /// <summary>
        /// Gets or sets the ID of the job.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the URL of the job.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

    }
}
