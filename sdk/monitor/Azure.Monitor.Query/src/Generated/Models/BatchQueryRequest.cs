// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    /// <summary> An single request in a batch. </summary>
    internal partial class BatchQueryRequest
    {
        /// <summary> Initializes a new instance of BatchQueryRequest. </summary>
        /// <param name="id"> The error details. </param>
        /// <param name="body"> The Analytics query. Learn more about the [Analytics query syntax](https://azure.microsoft.com/documentation/articles/app-insights-analytics-reference/). </param>
        /// <param name="workspace"> Workspace Id to be included in the query. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="body"/> or <paramref name="workspace"/> is null. </exception>
        public BatchQueryRequest(string id, QueryBody body, string workspace)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(body, nameof(body));
            Argument.AssertNotNull(workspace, nameof(workspace));

            Id = id;
            Headers = new ChangeTrackingDictionary<string, string>();
            Body = body;
            Path = "/query";
            Method = "POST";
            Workspace = workspace;
        }

        /// <summary> The error details. </summary>
        public string Id { get; }
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IDictionary<string, string> Headers { get; }
        /// <summary> The Analytics query. Learn more about the [Analytics query syntax](https://azure.microsoft.com/documentation/articles/app-insights-analytics-reference/). </summary>
        public QueryBody Body { get; }
        /// <summary> Gets or sets the path. </summary>
        public string Path { get; set; }
        /// <summary> Gets or sets the method. </summary>
        public string Method { get; set; }
        /// <summary> Workspace Id to be included in the query. </summary>
        public string Workspace { get; }
    }
}
