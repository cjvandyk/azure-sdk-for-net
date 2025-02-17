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
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing a collection of <see cref="MachineLearningFeaturestoreEntityVersionResource"/> and their operations.
    /// Each <see cref="MachineLearningFeaturestoreEntityVersionResource"/> in the collection will belong to the same instance of <see cref="MachineLearningFeatureStoreEntityContainerResource"/>.
    /// To get a <see cref="MachineLearningFeaturestoreEntityVersionCollection"/> instance call the GetMachineLearningFeaturestoreEntityVersions method from an instance of <see cref="MachineLearningFeatureStoreEntityContainerResource"/>.
    /// </summary>
    public partial class MachineLearningFeaturestoreEntityVersionCollection : ArmCollection, IEnumerable<MachineLearningFeaturestoreEntityVersionResource>, IAsyncEnumerable<MachineLearningFeaturestoreEntityVersionResource>
    {
        private readonly ClientDiagnostics _machineLearningFeaturestoreEntityVersionFeaturestoreEntityVersionsClientDiagnostics;
        private readonly FeaturestoreEntityVersionsRestOperations _machineLearningFeaturestoreEntityVersionFeaturestoreEntityVersionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MachineLearningFeaturestoreEntityVersionCollection"/> class for mocking. </summary>
        protected MachineLearningFeaturestoreEntityVersionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MachineLearningFeaturestoreEntityVersionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MachineLearningFeaturestoreEntityVersionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _machineLearningFeaturestoreEntityVersionFeaturestoreEntityVersionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", MachineLearningFeaturestoreEntityVersionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MachineLearningFeaturestoreEntityVersionResource.ResourceType, out string machineLearningFeaturestoreEntityVersionFeaturestoreEntityVersionsApiVersion);
            _machineLearningFeaturestoreEntityVersionFeaturestoreEntityVersionsRestClient = new FeaturestoreEntityVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, machineLearningFeaturestoreEntityVersionFeaturestoreEntityVersionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MachineLearningFeatureStoreEntityContainerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MachineLearningFeatureStoreEntityContainerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featurestoreEntities/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturestoreEntityVersions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningFeaturestoreEntityVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="data"> Version entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MachineLearningFeaturestoreEntityVersionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string version, MachineLearningFeaturestoreEntityVersionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningFeaturestoreEntityVersionFeaturestoreEntityVersionsClientDiagnostics.CreateScope("MachineLearningFeaturestoreEntityVersionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _machineLearningFeaturestoreEntityVersionFeaturestoreEntityVersionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<MachineLearningFeaturestoreEntityVersionResource>(new MachineLearningFeaturestoreEntityVersionOperationSource(Client), _machineLearningFeaturestoreEntityVersionFeaturestoreEntityVersionsClientDiagnostics, Pipeline, _machineLearningFeaturestoreEntityVersionFeaturestoreEntityVersionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Create or update version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featurestoreEntities/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturestoreEntityVersions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningFeaturestoreEntityVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="data"> Version entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MachineLearningFeaturestoreEntityVersionResource> CreateOrUpdate(WaitUntil waitUntil, string version, MachineLearningFeaturestoreEntityVersionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningFeaturestoreEntityVersionFeaturestoreEntityVersionsClientDiagnostics.CreateScope("MachineLearningFeaturestoreEntityVersionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _machineLearningFeaturestoreEntityVersionFeaturestoreEntityVersionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, data, cancellationToken);
                var operation = new MachineLearningArmOperation<MachineLearningFeaturestoreEntityVersionResource>(new MachineLearningFeaturestoreEntityVersionOperationSource(Client), _machineLearningFeaturestoreEntityVersionFeaturestoreEntityVersionsClientDiagnostics, Pipeline, _machineLearningFeaturestoreEntityVersionFeaturestoreEntityVersionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Get version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featurestoreEntities/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturestoreEntityVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningFeaturestoreEntityVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual async Task<Response<MachineLearningFeaturestoreEntityVersionResource>> GetAsync(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _machineLearningFeaturestoreEntityVersionFeaturestoreEntityVersionsClientDiagnostics.CreateScope("MachineLearningFeaturestoreEntityVersionCollection.Get");
            scope.Start();
            try
            {
                var response = await _machineLearningFeaturestoreEntityVersionFeaturestoreEntityVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningFeaturestoreEntityVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featurestoreEntities/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturestoreEntityVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningFeaturestoreEntityVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual Response<MachineLearningFeaturestoreEntityVersionResource> Get(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _machineLearningFeaturestoreEntityVersionFeaturestoreEntityVersionsClientDiagnostics.CreateScope("MachineLearningFeaturestoreEntityVersionCollection.Get");
            scope.Start();
            try
            {
                var response = _machineLearningFeaturestoreEntityVersionFeaturestoreEntityVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningFeaturestoreEntityVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List versions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featurestoreEntities/{name}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturestoreEntityVersions_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningFeaturestoreEntityVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MachineLearningFeaturestoreEntityVersionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MachineLearningFeaturestoreEntityVersionResource> GetAllAsync(MachineLearningFeaturestoreEntityVersionCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new MachineLearningFeaturestoreEntityVersionCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningFeaturestoreEntityVersionFeaturestoreEntityVersionsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, options.Skip, options.Tags, options.ListViewType, pageSizeHint, options.VersionName, options.Version, options.Description, options.CreatedBy, options.Stage);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningFeaturestoreEntityVersionFeaturestoreEntityVersionsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, options.Skip, options.Tags, options.ListViewType, pageSizeHint, options.VersionName, options.Version, options.Description, options.CreatedBy, options.Stage);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MachineLearningFeaturestoreEntityVersionResource(Client, MachineLearningFeaturestoreEntityVersionData.DeserializeMachineLearningFeaturestoreEntityVersionData(e)), _machineLearningFeaturestoreEntityVersionFeaturestoreEntityVersionsClientDiagnostics, Pipeline, "MachineLearningFeaturestoreEntityVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List versions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featurestoreEntities/{name}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturestoreEntityVersions_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningFeaturestoreEntityVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MachineLearningFeaturestoreEntityVersionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MachineLearningFeaturestoreEntityVersionResource> GetAll(MachineLearningFeaturestoreEntityVersionCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new MachineLearningFeaturestoreEntityVersionCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningFeaturestoreEntityVersionFeaturestoreEntityVersionsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, options.Skip, options.Tags, options.ListViewType, pageSizeHint, options.VersionName, options.Version, options.Description, options.CreatedBy, options.Stage);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningFeaturestoreEntityVersionFeaturestoreEntityVersionsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, options.Skip, options.Tags, options.ListViewType, pageSizeHint, options.VersionName, options.Version, options.Description, options.CreatedBy, options.Stage);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MachineLearningFeaturestoreEntityVersionResource(Client, MachineLearningFeaturestoreEntityVersionData.DeserializeMachineLearningFeaturestoreEntityVersionData(e)), _machineLearningFeaturestoreEntityVersionFeaturestoreEntityVersionsClientDiagnostics, Pipeline, "MachineLearningFeaturestoreEntityVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featurestoreEntities/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturestoreEntityVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningFeaturestoreEntityVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _machineLearningFeaturestoreEntityVersionFeaturestoreEntityVersionsClientDiagnostics.CreateScope("MachineLearningFeaturestoreEntityVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _machineLearningFeaturestoreEntityVersionFeaturestoreEntityVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featurestoreEntities/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturestoreEntityVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningFeaturestoreEntityVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual Response<bool> Exists(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _machineLearningFeaturestoreEntityVersionFeaturestoreEntityVersionsClientDiagnostics.CreateScope("MachineLearningFeaturestoreEntityVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = _machineLearningFeaturestoreEntityVersionFeaturestoreEntityVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featurestoreEntities/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturestoreEntityVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningFeaturestoreEntityVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual async Task<NullableResponse<MachineLearningFeaturestoreEntityVersionResource>> GetIfExistsAsync(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _machineLearningFeaturestoreEntityVersionFeaturestoreEntityVersionsClientDiagnostics.CreateScope("MachineLearningFeaturestoreEntityVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _machineLearningFeaturestoreEntityVersionFeaturestoreEntityVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearningFeaturestoreEntityVersionResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearningFeaturestoreEntityVersionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featurestoreEntities/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturestoreEntityVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningFeaturestoreEntityVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual NullableResponse<MachineLearningFeaturestoreEntityVersionResource> GetIfExists(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _machineLearningFeaturestoreEntityVersionFeaturestoreEntityVersionsClientDiagnostics.CreateScope("MachineLearningFeaturestoreEntityVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _machineLearningFeaturestoreEntityVersionFeaturestoreEntityVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearningFeaturestoreEntityVersionResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearningFeaturestoreEntityVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MachineLearningFeaturestoreEntityVersionResource> IEnumerable<MachineLearningFeaturestoreEntityVersionResource>.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IAsyncEnumerator<MachineLearningFeaturestoreEntityVersionResource> IAsyncEnumerable<MachineLearningFeaturestoreEntityVersionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(options: null, cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
