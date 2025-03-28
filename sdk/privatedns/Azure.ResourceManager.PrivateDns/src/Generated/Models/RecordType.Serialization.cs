// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.PrivateDns.Models
{
    internal static partial class RecordTypeExtensions
    {
        public static string ToSerialString(this RecordType value) => value switch
        {
            RecordType.A => "A",
            RecordType.Aaaa => "AAAA",
            RecordType.Cname => "CNAME",
            RecordType.MX => "MX",
            RecordType.PTR => "PTR",
            RecordType.SOA => "SOA",
            RecordType.SRV => "SRV",
            RecordType.TXT => "TXT",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RecordType value.")
        };

        public static RecordType ToRecordType(this string value)
        {
            if (string.Equals(value, "A", StringComparison.InvariantCultureIgnoreCase)) return RecordType.A;
            if (string.Equals(value, "AAAA", StringComparison.InvariantCultureIgnoreCase)) return RecordType.Aaaa;
            if (string.Equals(value, "CNAME", StringComparison.InvariantCultureIgnoreCase)) return RecordType.Cname;
            if (string.Equals(value, "MX", StringComparison.InvariantCultureIgnoreCase)) return RecordType.MX;
            if (string.Equals(value, "PTR", StringComparison.InvariantCultureIgnoreCase)) return RecordType.PTR;
            if (string.Equals(value, "SOA", StringComparison.InvariantCultureIgnoreCase)) return RecordType.SOA;
            if (string.Equals(value, "SRV", StringComparison.InvariantCultureIgnoreCase)) return RecordType.SRV;
            if (string.Equals(value, "TXT", StringComparison.InvariantCultureIgnoreCase)) return RecordType.TXT;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RecordType value.");
        }
    }
}
