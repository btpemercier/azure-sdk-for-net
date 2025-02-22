// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Batch.Models
{
    internal static partial class BatchCertificateVisibilityExtensions
    {
        public static string ToSerialString(this BatchCertificateVisibility value) => value switch
        {
            BatchCertificateVisibility.StartTask => "StartTask",
            BatchCertificateVisibility.Task => "Task",
            BatchCertificateVisibility.RemoteUser => "RemoteUser",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BatchCertificateVisibility value.")
        };

        public static BatchCertificateVisibility ToBatchCertificateVisibility(this string value)
        {
            if (string.Equals(value, "StartTask", StringComparison.InvariantCultureIgnoreCase)) return BatchCertificateVisibility.StartTask;
            if (string.Equals(value, "Task", StringComparison.InvariantCultureIgnoreCase)) return BatchCertificateVisibility.Task;
            if (string.Equals(value, "RemoteUser", StringComparison.InvariantCultureIgnoreCase)) return BatchCertificateVisibility.RemoteUser;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BatchCertificateVisibility value.");
        }
    }
}
