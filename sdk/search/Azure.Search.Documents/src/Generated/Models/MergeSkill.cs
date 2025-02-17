// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> A skill for merging two or more strings into a single unified string, with an optional user-defined delimiter separating each component part. </summary>
    public partial class MergeSkill : SearchIndexerSkill
    {
        /// <summary> Initializes a new instance of <see cref="MergeSkill"/>. </summary>
        /// <param name="inputs"> Inputs of the skills could be a column in the source data set, or the output of an upstream skill. </param>
        /// <param name="outputs"> The output of a skill is either a field in a search index, or a value that can be consumed as an input by another skill. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inputs"/> or <paramref name="outputs"/> is null. </exception>
        public MergeSkill(IEnumerable<InputFieldMappingEntry> inputs, IEnumerable<OutputFieldMappingEntry> outputs) : base(inputs, outputs)
        {
            Argument.AssertNotNull(inputs, nameof(inputs));
            Argument.AssertNotNull(outputs, nameof(outputs));

            ODataType = "#Microsoft.Skills.Text.MergeSkill";
        }

        /// <summary> Initializes a new instance of <see cref="MergeSkill"/>. </summary>
        /// <param name="oDataType"> A URI fragment specifying the type of skill. </param>
        /// <param name="name"> The name of the skill which uniquely identifies it within the skillset. A skill with no name defined will be given a default name of its 1-based index in the skills array, prefixed with the character '#'. </param>
        /// <param name="description"> The description of the skill which describes the inputs, outputs, and usage of the skill. </param>
        /// <param name="context"> Represents the level at which operations take place, such as the document root or document content (for example, /document or /document/content). The default is /document. </param>
        /// <param name="inputs"> Inputs of the skills could be a column in the source data set, or the output of an upstream skill. </param>
        /// <param name="outputs"> The output of a skill is either a field in a search index, or a value that can be consumed as an input by another skill. </param>
        /// <param name="insertPreTag"> The tag indicates the start of the merged text. By default, the tag is an empty space. </param>
        /// <param name="insertPostTag"> The tag indicates the end of the merged text. By default, the tag is an empty space. </param>
        internal MergeSkill(string oDataType, string name, string description, string context, IList<InputFieldMappingEntry> inputs, IList<OutputFieldMappingEntry> outputs, string insertPreTag, string insertPostTag) : base(oDataType, name, description, context, inputs, outputs)
        {
            InsertPreTag = insertPreTag;
            InsertPostTag = insertPostTag;
            ODataType = oDataType ?? "#Microsoft.Skills.Text.MergeSkill";
        }

        /// <summary> The tag indicates the start of the merged text. By default, the tag is an empty space. </summary>
        public string InsertPreTag { get; set; }
        /// <summary> The tag indicates the end of the merged text. By default, the tag is an empty space. </summary>
        public string InsertPostTag { get; set; }
    }
}
