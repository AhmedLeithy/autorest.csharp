// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Core;
using NoTypeReplacement;

namespace NoTypeReplacement.Models
{
    public partial class NoTypeReplacementModel1PutOperation : Operation<NoTypeReplacementModel1>
    {
        private readonly OperationOrResponseInternals<NoTypeReplacementModel1> _operation;

        /// <summary> Initializes a new instance of NoTypeReplacementModel1PutOperation for mocking. </summary>
        protected NoTypeReplacementModel1PutOperation()
        {
        }

        internal NoTypeReplacementModel1PutOperation(ArmResource operationsBase, Response<NoTypeReplacementModel1Data> response)
        {
            _operation = new OperationOrResponseInternals<NoTypeReplacementModel1>(Response.FromValue(new NoTypeReplacementModel1(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override NoTypeReplacementModel1 Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<NoTypeReplacementModel1>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<NoTypeReplacementModel1>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
