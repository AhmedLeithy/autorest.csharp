// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> Api error. </summary>
    public partial class ApiError
    {
        /// <summary> Initializes a new instance of ApiError. </summary>
        internal ApiError()
        {
            Details = new ChangeTrackingList<ApiErrorBase>();
        }

        /// <summary> Initializes a new instance of ApiError. </summary>
        /// <param name="details"> The Api error details. </param>
        /// <param name="innererror"> The Api inner error. </param>
        /// <param name="code"> The error code. </param>
        /// <param name="target"> The target of the particular error. </param>
        /// <param name="message"> The error message. </param>
        internal ApiError(IReadOnlyList<ApiErrorBase> details, InnerError innererror, string code, string target, string message)
        {
            Details = details;
            Innererror = innererror;
            Code = code;
            Target = target;
            Message = message;
        }

        /// <summary> The Api error details. </summary>
        public IReadOnlyList<ApiErrorBase> Details { get; }
        /// <summary> The Api inner error. </summary>
        public InnerError Innererror { get; }
        /// <summary> The error code. </summary>
        public string Code { get; }
        /// <summary> The target of the particular error. </summary>
        public string Target { get; }
        /// <summary> The error message. </summary>
        public string Message { get; }
    }
}
