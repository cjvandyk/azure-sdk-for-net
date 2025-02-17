// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Repository branch configuration for PR Annotations. </summary>
    public partial class TargetBranchConfiguration
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TargetBranchConfiguration"/>. </summary>
        public TargetBranchConfiguration()
        {
            BranchNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="TargetBranchConfiguration"/>. </summary>
        /// <param name="branchNames"> Gets or sets branches that should have annotations. </param>
        /// <param name="annotateDefaultBranch">
        /// Configuration of PR Annotations on default branch.
        ///
        /// Enabled - PR Annotations are enabled on the resource's default branch.
        /// Disabled - PR Annotations are disabled on the resource's default branch.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TargetBranchConfiguration(IList<string> branchNames, AnnotateDefaultBranchState? annotateDefaultBranch, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            BranchNames = branchNames;
            AnnotateDefaultBranch = annotateDefaultBranch;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets branches that should have annotations. </summary>
        public IList<string> BranchNames { get; }
        /// <summary>
        /// Configuration of PR Annotations on default branch.
        ///
        /// Enabled - PR Annotations are enabled on the resource's default branch.
        /// Disabled - PR Annotations are disabled on the resource's default branch.
        /// </summary>
        public AnnotateDefaultBranchState? AnnotateDefaultBranch { get; set; }
    }
}
