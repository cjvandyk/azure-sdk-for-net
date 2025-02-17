// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Request body structure for starting data flow debug session. </summary>
    public partial class StartDataFlowDebugSessionRequest
    {
        /// <summary> Initializes a new instance of <see cref="StartDataFlowDebugSessionRequest"/>. </summary>
        public StartDataFlowDebugSessionRequest()
        {
            DataFlows = new ChangeTrackingList<DataFlowResource>();
            Datasets = new ChangeTrackingList<DatasetResource>();
            LinkedServices = new ChangeTrackingList<LinkedServiceResource>();
        }

        /// <summary> Initializes a new instance of <see cref="StartDataFlowDebugSessionRequest"/>. </summary>
        /// <param name="sessionId"> The ID of data flow debug session. </param>
        /// <param name="dataFlow"> Data flow instance. </param>
        /// <param name="dataFlows"> List of Data flows. </param>
        /// <param name="datasets"> List of datasets. </param>
        /// <param name="linkedServices"> List of linked services. </param>
        /// <param name="staging"> Staging info for debug session. </param>
        /// <param name="debugSettings"> Data flow debug settings. </param>
        /// <param name="incrementalDebug"> The type of new Databricks cluster. </param>
        internal StartDataFlowDebugSessionRequest(string sessionId, DataFlowResource dataFlow, IList<DataFlowResource> dataFlows, IList<DatasetResource> datasets, IList<LinkedServiceResource> linkedServices, object staging, object debugSettings, bool? incrementalDebug)
        {
            SessionId = sessionId;
            DataFlow = dataFlow;
            DataFlows = dataFlows;
            Datasets = datasets;
            LinkedServices = linkedServices;
            Staging = staging;
            DebugSettings = debugSettings;
            IncrementalDebug = incrementalDebug;
        }

        /// <summary> The ID of data flow debug session. </summary>
        public string SessionId { get; set; }
        /// <summary> Data flow instance. </summary>
        public DataFlowResource DataFlow { get; set; }
        /// <summary> List of Data flows. </summary>
        public IList<DataFlowResource> DataFlows { get; }
        /// <summary> List of datasets. </summary>
        public IList<DatasetResource> Datasets { get; }
        /// <summary> List of linked services. </summary>
        public IList<LinkedServiceResource> LinkedServices { get; }
        /// <summary> Staging info for debug session. </summary>
        public object Staging { get; set; }
        /// <summary> Data flow debug settings. </summary>
        public object DebugSettings { get; set; }
        /// <summary> The type of new Databricks cluster. </summary>
        public bool? IncrementalDebug { get; set; }
    }
}
