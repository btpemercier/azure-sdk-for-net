// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies information about the gallery sharing profile update. </summary>
    public partial class SharingUpdate
    {
        /// <summary> Initializes a new instance of SharingUpdate. </summary>
        /// <param name="operationType"> This property allows you to specify the operation type of gallery sharing update. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **Add** &lt;br&gt;&lt;br&gt; **Remove** &lt;br&gt;&lt;br&gt; **Reset**. </param>
        public SharingUpdate(SharingUpdateOperationType operationType)
        {
            OperationType = operationType;
            Groups = new ChangeTrackingList<SharingProfileGroup>();
        }

        /// <summary> Initializes a new instance of SharingUpdate. </summary>
        /// <param name="operationType"> This property allows you to specify the operation type of gallery sharing update. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **Add** &lt;br&gt;&lt;br&gt; **Remove** &lt;br&gt;&lt;br&gt; **Reset**. </param>
        /// <param name="groups"> A list of sharing profile groups. </param>
        internal SharingUpdate(SharingUpdateOperationType operationType, IList<SharingProfileGroup> groups)
        {
            OperationType = operationType;
            Groups = groups;
        }

        /// <summary> This property allows you to specify the operation type of gallery sharing update. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **Add** &lt;br&gt;&lt;br&gt; **Remove** &lt;br&gt;&lt;br&gt; **Reset**. </summary>
        public SharingUpdateOperationType OperationType { get; set; }
        /// <summary> A list of sharing profile groups. </summary>
        public IList<SharingProfileGroup> Groups { get; }
    }
}
