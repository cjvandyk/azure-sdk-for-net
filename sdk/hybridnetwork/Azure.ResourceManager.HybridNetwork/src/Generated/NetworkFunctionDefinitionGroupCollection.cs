// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.HybridNetwork
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkFunctionDefinitionGroupResource"/> and their operations.
    /// Each <see cref="NetworkFunctionDefinitionGroupResource"/> in the collection will belong to the same instance of <see cref="PublisherResource"/>.
    /// To get a <see cref="NetworkFunctionDefinitionGroupCollection"/> instance call the GetNetworkFunctionDefinitionGroups method from an instance of <see cref="PublisherResource"/>.
    /// </summary>
    public partial class NetworkFunctionDefinitionGroupCollection : ArmCollection, IEnumerable<NetworkFunctionDefinitionGroupResource>, IAsyncEnumerable<NetworkFunctionDefinitionGroupResource>
    {
        private readonly ClientDiagnostics _networkFunctionDefinitionGroupClientDiagnostics;
        private readonly NetworkFunctionDefinitionGroupsRestOperations _networkFunctionDefinitionGroupRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkFunctionDefinitionGroupCollection"/> class for mocking. </summary>
        protected NetworkFunctionDefinitionGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkFunctionDefinitionGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkFunctionDefinitionGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkFunctionDefinitionGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HybridNetwork", NetworkFunctionDefinitionGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkFunctionDefinitionGroupResource.ResourceType, out string networkFunctionDefinitionGroupApiVersion);
            _networkFunctionDefinitionGroupRestClient = new NetworkFunctionDefinitionGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkFunctionDefinitionGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PublisherResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PublisherResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a network function definition group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/networkFunctionDefinitionGroups/{networkFunctionDefinitionGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFunctionDefinitionGroups_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFunctionDefinitionGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkFunctionDefinitionGroupName"> The name of the network function definition group. </param>
        /// <param name="data"> Parameters supplied to the create or update publisher network function definition group operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFunctionDefinitionGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFunctionDefinitionGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkFunctionDefinitionGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string networkFunctionDefinitionGroupName, NetworkFunctionDefinitionGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFunctionDefinitionGroupName, nameof(networkFunctionDefinitionGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkFunctionDefinitionGroupClientDiagnostics.CreateScope("NetworkFunctionDefinitionGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkFunctionDefinitionGroupRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkFunctionDefinitionGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HybridNetworkArmOperation<NetworkFunctionDefinitionGroupResource>(new NetworkFunctionDefinitionGroupOperationSource(Client), _networkFunctionDefinitionGroupClientDiagnostics, Pipeline, _networkFunctionDefinitionGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkFunctionDefinitionGroupName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a network function definition group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/networkFunctionDefinitionGroups/{networkFunctionDefinitionGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFunctionDefinitionGroups_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFunctionDefinitionGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkFunctionDefinitionGroupName"> The name of the network function definition group. </param>
        /// <param name="data"> Parameters supplied to the create or update publisher network function definition group operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFunctionDefinitionGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFunctionDefinitionGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkFunctionDefinitionGroupResource> CreateOrUpdate(WaitUntil waitUntil, string networkFunctionDefinitionGroupName, NetworkFunctionDefinitionGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFunctionDefinitionGroupName, nameof(networkFunctionDefinitionGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkFunctionDefinitionGroupClientDiagnostics.CreateScope("NetworkFunctionDefinitionGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkFunctionDefinitionGroupRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkFunctionDefinitionGroupName, data, cancellationToken);
                var operation = new HybridNetworkArmOperation<NetworkFunctionDefinitionGroupResource>(new NetworkFunctionDefinitionGroupOperationSource(Client), _networkFunctionDefinitionGroupClientDiagnostics, Pipeline, _networkFunctionDefinitionGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkFunctionDefinitionGroupName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified networkFunctionDefinition group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/networkFunctionDefinitionGroups/{networkFunctionDefinitionGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFunctionDefinitionGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFunctionDefinitionGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFunctionDefinitionGroupName"> The name of the network function definition group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFunctionDefinitionGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFunctionDefinitionGroupName"/> is null. </exception>
        public virtual async Task<Response<NetworkFunctionDefinitionGroupResource>> GetAsync(string networkFunctionDefinitionGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFunctionDefinitionGroupName, nameof(networkFunctionDefinitionGroupName));

            using var scope = _networkFunctionDefinitionGroupClientDiagnostics.CreateScope("NetworkFunctionDefinitionGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkFunctionDefinitionGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkFunctionDefinitionGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFunctionDefinitionGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified networkFunctionDefinition group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/networkFunctionDefinitionGroups/{networkFunctionDefinitionGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFunctionDefinitionGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFunctionDefinitionGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFunctionDefinitionGroupName"> The name of the network function definition group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFunctionDefinitionGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFunctionDefinitionGroupName"/> is null. </exception>
        public virtual Response<NetworkFunctionDefinitionGroupResource> Get(string networkFunctionDefinitionGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFunctionDefinitionGroupName, nameof(networkFunctionDefinitionGroupName));

            using var scope = _networkFunctionDefinitionGroupClientDiagnostics.CreateScope("NetworkFunctionDefinitionGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _networkFunctionDefinitionGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkFunctionDefinitionGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFunctionDefinitionGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information of the network function definition groups under a publisher.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/networkFunctionDefinitionGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFunctionDefinitionGroups_ListByPublisher</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFunctionDefinitionGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkFunctionDefinitionGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkFunctionDefinitionGroupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkFunctionDefinitionGroupRestClient.CreateListByPublisherRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkFunctionDefinitionGroupRestClient.CreateListByPublisherNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkFunctionDefinitionGroupResource(Client, NetworkFunctionDefinitionGroupData.DeserializeNetworkFunctionDefinitionGroupData(e)), _networkFunctionDefinitionGroupClientDiagnostics, Pipeline, "NetworkFunctionDefinitionGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets information of the network function definition groups under a publisher.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/networkFunctionDefinitionGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFunctionDefinitionGroups_ListByPublisher</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFunctionDefinitionGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkFunctionDefinitionGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkFunctionDefinitionGroupResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkFunctionDefinitionGroupRestClient.CreateListByPublisherRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkFunctionDefinitionGroupRestClient.CreateListByPublisherNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkFunctionDefinitionGroupResource(Client, NetworkFunctionDefinitionGroupData.DeserializeNetworkFunctionDefinitionGroupData(e)), _networkFunctionDefinitionGroupClientDiagnostics, Pipeline, "NetworkFunctionDefinitionGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/networkFunctionDefinitionGroups/{networkFunctionDefinitionGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFunctionDefinitionGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFunctionDefinitionGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFunctionDefinitionGroupName"> The name of the network function definition group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFunctionDefinitionGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFunctionDefinitionGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string networkFunctionDefinitionGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFunctionDefinitionGroupName, nameof(networkFunctionDefinitionGroupName));

            using var scope = _networkFunctionDefinitionGroupClientDiagnostics.CreateScope("NetworkFunctionDefinitionGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkFunctionDefinitionGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkFunctionDefinitionGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/networkFunctionDefinitionGroups/{networkFunctionDefinitionGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFunctionDefinitionGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFunctionDefinitionGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFunctionDefinitionGroupName"> The name of the network function definition group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFunctionDefinitionGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFunctionDefinitionGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string networkFunctionDefinitionGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFunctionDefinitionGroupName, nameof(networkFunctionDefinitionGroupName));

            using var scope = _networkFunctionDefinitionGroupClientDiagnostics.CreateScope("NetworkFunctionDefinitionGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkFunctionDefinitionGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkFunctionDefinitionGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/networkFunctionDefinitionGroups/{networkFunctionDefinitionGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFunctionDefinitionGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFunctionDefinitionGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFunctionDefinitionGroupName"> The name of the network function definition group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFunctionDefinitionGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFunctionDefinitionGroupName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetworkFunctionDefinitionGroupResource>> GetIfExistsAsync(string networkFunctionDefinitionGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFunctionDefinitionGroupName, nameof(networkFunctionDefinitionGroupName));

            using var scope = _networkFunctionDefinitionGroupClientDiagnostics.CreateScope("NetworkFunctionDefinitionGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkFunctionDefinitionGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkFunctionDefinitionGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetworkFunctionDefinitionGroupResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkFunctionDefinitionGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/networkFunctionDefinitionGroups/{networkFunctionDefinitionGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFunctionDefinitionGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFunctionDefinitionGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFunctionDefinitionGroupName"> The name of the network function definition group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFunctionDefinitionGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFunctionDefinitionGroupName"/> is null. </exception>
        public virtual NullableResponse<NetworkFunctionDefinitionGroupResource> GetIfExists(string networkFunctionDefinitionGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFunctionDefinitionGroupName, nameof(networkFunctionDefinitionGroupName));

            using var scope = _networkFunctionDefinitionGroupClientDiagnostics.CreateScope("NetworkFunctionDefinitionGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkFunctionDefinitionGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkFunctionDefinitionGroupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetworkFunctionDefinitionGroupResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkFunctionDefinitionGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkFunctionDefinitionGroupResource> IEnumerable<NetworkFunctionDefinitionGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkFunctionDefinitionGroupResource> IAsyncEnumerable<NetworkFunctionDefinitionGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
