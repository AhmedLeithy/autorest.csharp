// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Management.Storage;
using Azure.ResourceManager.Core;

namespace Azure.Management.Storage.Models
{
    /// <summary> Updates container properties as specified in request body. Properties not mentioned in the request will be unchanged. Update fails if the specified container doesn&apos;t already exist. </summary>
    public partial class BlobContainerUpdateOperation : Operation<BlobContainer>
    {
        private readonly OperationOrResponseInternals<BlobContainer> _operation;

        /// <summary> Initializes a new instance of BlobContainerUpdateOperation for mocking. </summary>
        protected BlobContainerUpdateOperation()
        {
        }

        internal BlobContainerUpdateOperation(ArmResource operationsBase, Response<BlobContainerData> response)
        {
            _operation = new OperationOrResponseInternals<BlobContainer>(Response.FromValue(new BlobContainer(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override BlobContainer Value => _operation.Value;

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
        public override ValueTask<Response<BlobContainer>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<BlobContainer>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
