// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using MgmtListMethods.Models;

namespace MgmtListMethods
{
    /// <summary> A class representing collection of FakeParentWithAncestorWithNonResCh and their operations over its parent. </summary>
    public partial class FakeParentWithAncestorWithNonResChCollection : ArmCollection, IEnumerable<FakeParentWithAncestorWithNonResCh>, IAsyncEnumerable<FakeParentWithAncestorWithNonResCh>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly FakeParentWithAncestorWithNonResChesRestOperations _fakeParentWithAncestorWithNonResChesRestClient;

        /// <summary> Initializes a new instance of the <see cref="FakeParentWithAncestorWithNonResChCollection"/> class for mocking. </summary>
        protected FakeParentWithAncestorWithNonResChCollection()
        {
        }

        /// <summary> Initializes a new instance of FakeParentWithAncestorWithNonResChCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal FakeParentWithAncestorWithNonResChCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _fakeParentWithAncestorWithNonResChesRestClient = new FakeParentWithAncestorWithNonResChesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => Fake.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChes/{fakeParentWithAncestorWithNonResChName}
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}
        /// OperationId: FakeParentWithAncestorWithNonResChes_CreateOrUpdate
        /// <summary> Create or update. </summary>
        /// <param name="fakeParentWithAncestorWithNonResChName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithAncestorWithNonResChName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual FakeParentWithAncestorWithNonResChCreateOrUpdateOperation CreateOrUpdate(string fakeParentWithAncestorWithNonResChName, FakeParentWithAncestorWithNonResChData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (fakeParentWithAncestorWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(fakeParentWithAncestorWithNonResChName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _fakeParentWithAncestorWithNonResChesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.Name, fakeParentWithAncestorWithNonResChName, parameters, cancellationToken);
                var operation = new FakeParentWithAncestorWithNonResChCreateOrUpdateOperation(Parent, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChes/{fakeParentWithAncestorWithNonResChName}
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}
        /// OperationId: FakeParentWithAncestorWithNonResChes_CreateOrUpdate
        /// <summary> Create or update. </summary>
        /// <param name="fakeParentWithAncestorWithNonResChName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithAncestorWithNonResChName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<FakeParentWithAncestorWithNonResChCreateOrUpdateOperation> CreateOrUpdateAsync(string fakeParentWithAncestorWithNonResChName, FakeParentWithAncestorWithNonResChData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (fakeParentWithAncestorWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(fakeParentWithAncestorWithNonResChName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _fakeParentWithAncestorWithNonResChesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.Name, fakeParentWithAncestorWithNonResChName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new FakeParentWithAncestorWithNonResChCreateOrUpdateOperation(Parent, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChes/{fakeParentWithAncestorWithNonResChName}
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}
        /// OperationId: FakeParentWithAncestorWithNonResChes_Get
        /// <summary> Retrieves information. </summary>
        /// <param name="fakeParentWithAncestorWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithAncestorWithNonResChName"/> is null. </exception>
        public virtual Response<FakeParentWithAncestorWithNonResCh> Get(string fakeParentWithAncestorWithNonResChName, CancellationToken cancellationToken = default)
        {
            if (fakeParentWithAncestorWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(fakeParentWithAncestorWithNonResChName));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChCollection.Get");
            scope.Start();
            try
            {
                var response = _fakeParentWithAncestorWithNonResChesRestClient.Get(Id.SubscriptionId, Id.Name, fakeParentWithAncestorWithNonResChName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FakeParentWithAncestorWithNonResCh(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChes/{fakeParentWithAncestorWithNonResChName}
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}
        /// OperationId: FakeParentWithAncestorWithNonResChes_Get
        /// <summary> Retrieves information. </summary>
        /// <param name="fakeParentWithAncestorWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithAncestorWithNonResChName"/> is null. </exception>
        public async virtual Task<Response<FakeParentWithAncestorWithNonResCh>> GetAsync(string fakeParentWithAncestorWithNonResChName, CancellationToken cancellationToken = default)
        {
            if (fakeParentWithAncestorWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(fakeParentWithAncestorWithNonResChName));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChCollection.Get");
            scope.Start();
            try
            {
                var response = await _fakeParentWithAncestorWithNonResChesRestClient.GetAsync(Id.SubscriptionId, Id.Name, fakeParentWithAncestorWithNonResChName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new FakeParentWithAncestorWithNonResCh(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="fakeParentWithAncestorWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithAncestorWithNonResChName"/> is null. </exception>
        public virtual Response<FakeParentWithAncestorWithNonResCh> GetIfExists(string fakeParentWithAncestorWithNonResChName, CancellationToken cancellationToken = default)
        {
            if (fakeParentWithAncestorWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(fakeParentWithAncestorWithNonResChName));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _fakeParentWithAncestorWithNonResChesRestClient.Get(Id.SubscriptionId, Id.Name, fakeParentWithAncestorWithNonResChName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<FakeParentWithAncestorWithNonResCh>(null, response.GetRawResponse())
                    : Response.FromValue(new FakeParentWithAncestorWithNonResCh(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="fakeParentWithAncestorWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithAncestorWithNonResChName"/> is null. </exception>
        public async virtual Task<Response<FakeParentWithAncestorWithNonResCh>> GetIfExistsAsync(string fakeParentWithAncestorWithNonResChName, CancellationToken cancellationToken = default)
        {
            if (fakeParentWithAncestorWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(fakeParentWithAncestorWithNonResChName));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _fakeParentWithAncestorWithNonResChesRestClient.GetAsync(Id.SubscriptionId, Id.Name, fakeParentWithAncestorWithNonResChName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<FakeParentWithAncestorWithNonResCh>(null, response.GetRawResponse())
                    : Response.FromValue(new FakeParentWithAncestorWithNonResCh(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="fakeParentWithAncestorWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithAncestorWithNonResChName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string fakeParentWithAncestorWithNonResChName, CancellationToken cancellationToken = default)
        {
            if (fakeParentWithAncestorWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(fakeParentWithAncestorWithNonResChName));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(fakeParentWithAncestorWithNonResChName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="fakeParentWithAncestorWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithAncestorWithNonResChName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string fakeParentWithAncestorWithNonResChName, CancellationToken cancellationToken = default)
        {
            if (fakeParentWithAncestorWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(fakeParentWithAncestorWithNonResChName));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(fakeParentWithAncestorWithNonResChName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChes
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}
        /// OperationId: FakeParentWithAncestorWithNonResChes_ListTest
        /// <summary> Lists all in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FakeParentWithAncestorWithNonResCh" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FakeParentWithAncestorWithNonResCh> GetAll(CancellationToken cancellationToken = default)
        {
            Page<FakeParentWithAncestorWithNonResCh> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _fakeParentWithAncestorWithNonResChesRestClient.ListTest(Id.SubscriptionId, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FakeParentWithAncestorWithNonResCh(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<FakeParentWithAncestorWithNonResCh> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _fakeParentWithAncestorWithNonResChesRestClient.ListTestNextPage(nextLink, Id.SubscriptionId, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FakeParentWithAncestorWithNonResCh(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChes
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}
        /// OperationId: FakeParentWithAncestorWithNonResChes_ListTest
        /// <summary> Lists all in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FakeParentWithAncestorWithNonResCh" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FakeParentWithAncestorWithNonResCh> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<FakeParentWithAncestorWithNonResCh>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _fakeParentWithAncestorWithNonResChesRestClient.ListTestAsync(Id.SubscriptionId, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FakeParentWithAncestorWithNonResCh(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<FakeParentWithAncestorWithNonResCh>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _fakeParentWithAncestorWithNonResChesRestClient.ListTestNextPageAsync(nextLink, Id.SubscriptionId, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FakeParentWithAncestorWithNonResCh(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<FakeParentWithAncestorWithNonResCh> IEnumerable<FakeParentWithAncestorWithNonResCh>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FakeParentWithAncestorWithNonResCh> IAsyncEnumerable<FakeParentWithAncestorWithNonResCh>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, FakeParentWithAncestorWithNonResCh, FakeParentWithAncestorWithNonResChData> Construct() { }
    }
}
