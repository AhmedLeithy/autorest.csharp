// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using System.Globalization;

namespace constants.Models
{
    /// <summary> The Enum8. </summary>
    public readonly partial struct Enum8 : IEquatable<Enum8>
    {
        private readonly bool _value;

        /// <summary> Initializes a new instance of <see cref="Enum8"/>. </summary>
        public Enum8(bool value)
        {
            _value = value;
        }

        private const bool TrueValue = true;

        /// <summary> true. </summary>
        public static Enum8 True { get; } = new Enum8(TrueValue);
        /// <summary> Determines if two <see cref="Enum8"/> values are the same. </summary>
        public static bool operator ==(Enum8 left, Enum8 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Enum8"/> values are not the same. </summary>
        public static bool operator !=(Enum8 left, Enum8 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Enum8"/>. </summary>
        public static implicit operator Enum8(bool value) => new Enum8(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Enum8 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Enum8 other) => Equals(_value, other._value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value.GetHashCode();
        /// <inheritdoc />
        public override string ToString() => _value.ToString(CultureInfo.InvariantCulture);
    }
}
