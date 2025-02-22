// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Determines how N-Cross validations value is determined.
    /// Serialized Name: NCrossValidationsMode
    /// </summary>
    internal readonly partial struct NCrossValidationsMode : IEquatable<NCrossValidationsMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NCrossValidationsMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NCrossValidationsMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AutoValue = "Auto";
        private const string CustomValue = "Custom";

        /// <summary>
        /// Determine N-Cross validations value automatically. Supported only for &apos;Forecasting&apos; AutoML task.
        /// Serialized Name: NCrossValidationsMode.Auto
        /// </summary>
        public static NCrossValidationsMode Auto { get; } = new NCrossValidationsMode(AutoValue);
        /// <summary>
        /// Use custom N-Cross validations value.
        /// Serialized Name: NCrossValidationsMode.Custom
        /// </summary>
        public static NCrossValidationsMode Custom { get; } = new NCrossValidationsMode(CustomValue);
        /// <summary> Determines if two <see cref="NCrossValidationsMode"/> values are the same. </summary>
        public static bool operator ==(NCrossValidationsMode left, NCrossValidationsMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NCrossValidationsMode"/> values are not the same. </summary>
        public static bool operator !=(NCrossValidationsMode left, NCrossValidationsMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NCrossValidationsMode"/>. </summary>
        public static implicit operator NCrossValidationsMode(string value) => new NCrossValidationsMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NCrossValidationsMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NCrossValidationsMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
