// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.Vision.ImageAnalysis
{
    /// <summary> Represents the outcome of an Image Analysis operation. </summary>
    public partial class ImageAnalysisResult
    {
        /// <summary> Initializes a new instance of <see cref="ImageAnalysisResult"/>. </summary>
        /// <param name="metadata"> Metadata associated with the analyzed image. </param>
        /// <param name="modelVersion"> The cloud AI model used for the analysis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="metadata"/> or <paramref name="modelVersion"/> is null. </exception>
        internal ImageAnalysisResult(ImageMetadata metadata, string modelVersion)
        {
            Argument.AssertNotNull(metadata, nameof(metadata));
            Argument.AssertNotNull(modelVersion, nameof(modelVersion));

            Metadata = metadata;
            ModelVersion = modelVersion;
        }

        /// <summary> Initializes a new instance of <see cref="ImageAnalysisResult"/>. </summary>
        /// <param name="caption"> The generated phrase that describes the content of the analyzed image. </param>
        /// <param name="denseCaptions">
        /// The up to 10 generated phrases, the first describing the content of the whole image,
        /// and the others describing the content of different regions of the image.
        /// </param>
        /// <param name="metadata"> Metadata associated with the analyzed image. </param>
        /// <param name="modelVersion"> The cloud AI model used for the analysis. </param>
        /// <param name="objects"> A list of detected physical objects in the analyzed image, and their location. </param>
        /// <param name="people"> A list of detected people in the analyzed image, and their location. </param>
        /// <param name="read"> The extracted printed and hand-written text in the analyze image. Also knows as OCR. </param>
        /// <param name="smartCrops">
        /// A list of crop regions at the desired as aspect ratios (if provided) that can be used as image thumbnails.
        /// These regions preserve as much content as possible from the analyzed image, with priority given to detected faces.
        /// </param>
        /// <param name="tags"> A list of content tags in the analyzed image. </param>
        internal ImageAnalysisResult(CaptionResult caption, DenseCaptionsResult denseCaptions, ImageMetadata metadata, string modelVersion, ObjectsResult objects, PeopleResult people, ReadResult read, SmartCropsResult smartCrops, TagsResult tags)
        {
            Caption = caption;
            DenseCaptions = denseCaptions;
            Metadata = metadata;
            ModelVersion = modelVersion;
            Objects = objects;
            People = people;
            Read = read;
            SmartCrops = smartCrops;
            Tags = tags;
        }

        /// <summary> The generated phrase that describes the content of the analyzed image. </summary>
        public CaptionResult Caption { get; }
        /// <summary>
        /// The up to 10 generated phrases, the first describing the content of the whole image,
        /// and the others describing the content of different regions of the image.
        /// </summary>
        public DenseCaptionsResult DenseCaptions { get; }
        /// <summary> Metadata associated with the analyzed image. </summary>
        public ImageMetadata Metadata { get; }
        /// <summary> The cloud AI model used for the analysis. </summary>
        public string ModelVersion { get; }
        /// <summary> A list of detected physical objects in the analyzed image, and their location. </summary>
        public ObjectsResult Objects { get; }
        /// <summary> A list of detected people in the analyzed image, and their location. </summary>
        public PeopleResult People { get; }
        /// <summary> The extracted printed and hand-written text in the analyze image. Also knows as OCR. </summary>
        public ReadResult Read { get; }
        /// <summary>
        /// A list of crop regions at the desired as aspect ratios (if provided) that can be used as image thumbnails.
        /// These regions preserve as much content as possible from the analyzed image, with priority given to detected faces.
        /// </summary>
        public SmartCropsResult SmartCrops { get; }
        /// <summary> A list of content tags in the analyzed image. </summary>
        public TagsResult Tags { get; }
    }
}
