// <auto-generated>
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//
// </auto-generated>

namespace Microsoft.DotNet.Helix.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class QueueInfo
    {
        /// <summary>
        /// Initializes a new instance of the QueueInfo class.
        /// </summary>
        public QueueInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QueueInfo class.
        /// </summary>
        public QueueInfo(string description = default(string), bool? isAvailable = default(bool?), bool? isInternalOnly = default(bool?), bool? isOnPremises = default(bool?), string operatingSystemGroup = default(string), string queueId = default(string), long? queueDepth = default(long?), string userList = default(string), string workspacePath = default(string))
        {
            Description = description;
            IsAvailable = isAvailable;
            IsInternalOnly = isInternalOnly;
            IsOnPremises = isOnPremises;
            OperatingSystemGroup = operatingSystemGroup;
            QueueId = queueId;
            QueueDepth = queueDepth;
            UserList = userList;
            WorkspacePath = workspacePath;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsAvailable")]
        public bool? IsAvailable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsInternalOnly")]
        public bool? IsInternalOnly { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsOnPremises")]
        public bool? IsOnPremises { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OperatingSystemGroup")]
        public string OperatingSystemGroup { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QueueId")]
        public string QueueId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QueueDepth")]
        public long? QueueDepth { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserList")]
        public string UserList { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "WorkspacePath")]
        public string WorkspacePath { get; set; }

    }
}