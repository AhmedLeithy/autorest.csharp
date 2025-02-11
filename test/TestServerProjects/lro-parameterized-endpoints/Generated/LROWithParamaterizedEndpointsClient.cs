// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core.Pipeline;

namespace lro_parameterized_endpoints
{
    /// <summary> The LROWithParamaterizedEndpoints service client. </summary>
    public partial class LROWithParamaterizedEndpointsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal LROWithParamaterizedEndpointsRestClient RestClient { get; }

        /// <summary> Initializes a new instance of LROWithParamaterizedEndpointsClient for mocking. </summary>
        protected LROWithParamaterizedEndpointsClient()
        {
        }

        /// <summary> Initializes a new instance of LROWithParamaterizedEndpointsClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="host"> A string value that is used as a global part of the parameterized host. Pass in &apos;host:3000&apos; to pass test. </param>
        internal LROWithParamaterizedEndpointsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "host")
        {
            RestClient = new LROWithParamaterizedEndpointsRestClient(clientDiagnostics, pipeline, host);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Poll with method and client level parameters in endpoint. </summary>
        /// <param name="accountName"> Account Name. Pass in &apos;local&apos; to pass test. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual async Task<LROWithParamaterizedEndpointsPollWithParameterizedEndpointsOperation> StartPollWithParameterizedEndpointsAsync(string accountName, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            using var scope = _clientDiagnostics.CreateScope("LROWithParamaterizedEndpointsClient.StartPollWithParameterizedEndpoints");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.PollWithParameterizedEndpointsAsync(accountName, cancellationToken).ConfigureAwait(false);
                return new LROWithParamaterizedEndpointsPollWithParameterizedEndpointsOperation(_clientDiagnostics, _pipeline, RestClient.CreatePollWithParameterizedEndpointsRequest(accountName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Poll with method and client level parameters in endpoint. </summary>
        /// <param name="accountName"> Account Name. Pass in &apos;local&apos; to pass test. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual LROWithParamaterizedEndpointsPollWithParameterizedEndpointsOperation StartPollWithParameterizedEndpoints(string accountName, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            using var scope = _clientDiagnostics.CreateScope("LROWithParamaterizedEndpointsClient.StartPollWithParameterizedEndpoints");
            scope.Start();
            try
            {
                var originalResponse = RestClient.PollWithParameterizedEndpoints(accountName, cancellationToken);
                return new LROWithParamaterizedEndpointsPollWithParameterizedEndpointsOperation(_clientDiagnostics, _pipeline, RestClient.CreatePollWithParameterizedEndpointsRequest(accountName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Poll with method and client level parameters in endpoint, with a constant value. </summary>
        /// <param name="accountName"> Account Name. Pass in &apos;local&apos; to pass test. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual async Task<LROWithParamaterizedEndpointsPollWithConstantParameterizedEndpointsOperation> StartPollWithConstantParameterizedEndpointsAsync(string accountName, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            using var scope = _clientDiagnostics.CreateScope("LROWithParamaterizedEndpointsClient.StartPollWithConstantParameterizedEndpoints");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.PollWithConstantParameterizedEndpointsAsync(accountName, cancellationToken).ConfigureAwait(false);
                return new LROWithParamaterizedEndpointsPollWithConstantParameterizedEndpointsOperation(_clientDiagnostics, _pipeline, RestClient.CreatePollWithConstantParameterizedEndpointsRequest(accountName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Poll with method and client level parameters in endpoint, with a constant value. </summary>
        /// <param name="accountName"> Account Name. Pass in &apos;local&apos; to pass test. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual LROWithParamaterizedEndpointsPollWithConstantParameterizedEndpointsOperation StartPollWithConstantParameterizedEndpoints(string accountName, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            using var scope = _clientDiagnostics.CreateScope("LROWithParamaterizedEndpointsClient.StartPollWithConstantParameterizedEndpoints");
            scope.Start();
            try
            {
                var originalResponse = RestClient.PollWithConstantParameterizedEndpoints(accountName, cancellationToken);
                return new LROWithParamaterizedEndpointsPollWithConstantParameterizedEndpointsOperation(_clientDiagnostics, _pipeline, RestClient.CreatePollWithConstantParameterizedEndpointsRequest(accountName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
