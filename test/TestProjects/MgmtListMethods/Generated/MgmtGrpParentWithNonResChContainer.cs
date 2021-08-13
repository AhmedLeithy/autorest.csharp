// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;
using MgmtListMethods.Models;

namespace MgmtListMethods
{
    /// <summary> A class representing collection of MgmtGrpParentWithNonResCh and their operations over a ManagementGroup. </summary>
    public partial class MgmtGrpParentWithNonResChContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly MgmtGrpParentWithNonResChesRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="MgmtGrpParentWithNonResChContainer"/> class for mocking. </summary>
        protected MgmtGrpParentWithNonResChContainer()
        {
        }

        /// <summary> Initializes a new instance of MgmtGrpParentWithNonResChContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal MgmtGrpParentWithNonResChContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new MgmtGrpParentWithNonResChesRestOperations(_clientDiagnostics, Pipeline, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ManagementGroup.ResourceType;

        // Container level operations.

        /// <summary> Create or update. </summary>
        /// <param name="mgmtGrpParentWithNonResChName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithNonResChName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<MgmtGrpParentWithNonResCh> CreateOrUpdate(string mgmtGrpParentWithNonResChName, MgmtGrpParentWithNonResChData parameters, CancellationToken cancellationToken = default)
        {
            if (mgmtGrpParentWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(mgmtGrpParentWithNonResChName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(mgmtGrpParentWithNonResChName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update. </summary>
        /// <param name="mgmtGrpParentWithNonResChName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithNonResChName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<MgmtGrpParentWithNonResCh>> CreateOrUpdateAsync(string mgmtGrpParentWithNonResChName, MgmtGrpParentWithNonResChData parameters, CancellationToken cancellationToken = default)
        {
            if (mgmtGrpParentWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(mgmtGrpParentWithNonResChName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(mgmtGrpParentWithNonResChName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update. </summary>
        /// <param name="mgmtGrpParentWithNonResChName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithNonResChName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual MgmtGrpParentWithNonResChCreateOrUpdateOperation StartCreateOrUpdate(string mgmtGrpParentWithNonResChName, MgmtGrpParentWithNonResChData parameters, CancellationToken cancellationToken = default)
        {
            if (mgmtGrpParentWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(mgmtGrpParentWithNonResChName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.Name, mgmtGrpParentWithNonResChName, parameters, cancellationToken);
                return new MgmtGrpParentWithNonResChCreateOrUpdateOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update. </summary>
        /// <param name="mgmtGrpParentWithNonResChName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithNonResChName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<MgmtGrpParentWithNonResChCreateOrUpdateOperation> StartCreateOrUpdateAsync(string mgmtGrpParentWithNonResChName, MgmtGrpParentWithNonResChData parameters, CancellationToken cancellationToken = default)
        {
            if (mgmtGrpParentWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(mgmtGrpParentWithNonResChName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.Name, mgmtGrpParentWithNonResChName, parameters, cancellationToken).ConfigureAwait(false);
                return new MgmtGrpParentWithNonResChCreateOrUpdateOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="mgmtGrpParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<MgmtGrpParentWithNonResCh> Get(string mgmtGrpParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChContainer.Get");
            scope.Start();
            try
            {
                if (mgmtGrpParentWithNonResChName == null)
                {
                    throw new ArgumentNullException(nameof(mgmtGrpParentWithNonResChName));
                }

                var response = _restClient.Get(Id.Name, mgmtGrpParentWithNonResChName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MgmtGrpParentWithNonResCh(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="mgmtGrpParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<MgmtGrpParentWithNonResCh>> GetAsync(string mgmtGrpParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChContainer.Get");
            scope.Start();
            try
            {
                if (mgmtGrpParentWithNonResChName == null)
                {
                    throw new ArgumentNullException(nameof(mgmtGrpParentWithNonResChName));
                }

                var response = await _restClient.GetAsync(Id.Name, mgmtGrpParentWithNonResChName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new MgmtGrpParentWithNonResCh(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="mgmtGrpParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<MgmtGrpParentWithNonResCh> GetIfExists(string mgmtGrpParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChContainer.GetIfExists");
            scope.Start();
            try
            {
                if (mgmtGrpParentWithNonResChName == null)
                {
                    throw new ArgumentNullException(nameof(mgmtGrpParentWithNonResChName));
                }

                var response = _restClient.Get(Id.Name, mgmtGrpParentWithNonResChName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<MgmtGrpParentWithNonResCh>(null, response.GetRawResponse())
                    : Response.FromValue(new MgmtGrpParentWithNonResCh(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="mgmtGrpParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<MgmtGrpParentWithNonResCh>> GetIfExistsAsync(string mgmtGrpParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChContainer.GetIfExists");
            scope.Start();
            try
            {
                if (mgmtGrpParentWithNonResChName == null)
                {
                    throw new ArgumentNullException(nameof(mgmtGrpParentWithNonResChName));
                }

                var response = await _restClient.GetAsync(Id.Name, mgmtGrpParentWithNonResChName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<MgmtGrpParentWithNonResCh>(null, response.GetRawResponse())
                    : Response.FromValue(new MgmtGrpParentWithNonResCh(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="mgmtGrpParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string mgmtGrpParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (mgmtGrpParentWithNonResChName == null)
                {
                    throw new ArgumentNullException(nameof(mgmtGrpParentWithNonResChName));
                }

                var response = GetIfExists(mgmtGrpParentWithNonResChName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="mgmtGrpParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string mgmtGrpParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (mgmtGrpParentWithNonResChName == null)
                {
                    throw new ArgumentNullException(nameof(mgmtGrpParentWithNonResChName));
                }

                var response = await GetIfExistsAsync(mgmtGrpParentWithNonResChName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MgmtGrpParentWithNonResCh" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<MgmtGrpParentWithNonResCh> GetAll(CancellationToken cancellationToken = default)
        {
            Page<MgmtGrpParentWithNonResCh> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MgmtGrpParentWithNonResCh(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<MgmtGrpParentWithNonResCh> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllNextPage(nextLink, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MgmtGrpParentWithNonResCh(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MgmtGrpParentWithNonResCh" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<MgmtGrpParentWithNonResCh> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<MgmtGrpParentWithNonResCh>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MgmtGrpParentWithNonResCh(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<MgmtGrpParentWithNonResCh>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllNextPageAsync(nextLink, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MgmtGrpParentWithNonResCh(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="MgmtGrpParentWithNonResCh" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(MgmtGrpParentWithNonResCh.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="MgmtGrpParentWithNonResCh" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(MgmtGrpParentWithNonResCh.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, MgmtGrpParentWithNonResCh, MgmtGrpParentWithNonResChData> Construct() { }
    }
}
