// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Storage.Models
{
    /// <summary> The authentication protocol that is used for the file share. Can only be specified when creating a share. </summary>
    public readonly partial struct EnabledProtocols : IEquatable<EnabledProtocols>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EnabledProtocols"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EnabledProtocols(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SMBValue = "SMB";
        private const string NFSValue = "NFS";

        /// <summary> SMB. </summary>
        public static EnabledProtocols SMB { get; } = new EnabledProtocols(SMBValue);
        /// <summary> NFS. </summary>
        public static EnabledProtocols NFS { get; } = new EnabledProtocols(NFSValue);
        /// <summary> Determines if two <see cref="EnabledProtocols"/> values are the same. </summary>
        public static bool operator ==(EnabledProtocols left, EnabledProtocols right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EnabledProtocols"/> values are not the same. </summary>
        public static bool operator !=(EnabledProtocols left, EnabledProtocols right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EnabledProtocols"/>. </summary>
        public static implicit operator EnabledProtocols(string value) => new EnabledProtocols(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EnabledProtocols other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EnabledProtocols other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
