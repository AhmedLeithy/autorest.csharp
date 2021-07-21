// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Inheritance.Models
{
    /// <summary> The SomeProperties. </summary>
    public partial class SomeProperties
    {
        /// <summary> Initializes a new instance of SomeProperties. </summary>
        public SomeProperties()
        {
        }

        /// <summary> Initializes a new instance of SomeProperties. </summary>
        /// <param name="someProperty"></param>
        /// <param name="someOtherProperty"></param>
        internal SomeProperties(string someProperty, string someOtherProperty)
        {
            SomeProperty = someProperty;
            SomeOtherProperty = someOtherProperty;
        }

        public string SomeProperty { get; set; }
        public string SomeOtherProperty { get; set; }
    }
}
