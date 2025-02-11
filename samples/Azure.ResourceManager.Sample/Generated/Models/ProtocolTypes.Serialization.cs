// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sample.Models
{
    internal static partial class ProtocolTypesExtensions
    {
        public static string ToSerialString(this ProtocolTypes value) => value switch
        {
            ProtocolTypes.Http => "Http",
            ProtocolTypes.Https => "Https",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ProtocolTypes value.")
        };

        public static ProtocolTypes ToProtocolTypes(this string value)
        {
            if (string.Equals(value, "Http", StringComparison.InvariantCultureIgnoreCase)) return ProtocolTypes.Http;
            if (string.Equals(value, "Https", StringComparison.InvariantCultureIgnoreCase)) return ProtocolTypes.Https;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ProtocolTypes value.");
        }
    }
}
