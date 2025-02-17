// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> Bounding polygon on a specific page of the input. </summary>
    public partial class BoundingRegion
    {
        /// <summary> Initializes a new instance of <see cref="BoundingRegion"/>. </summary>
        /// <param name="pageNumber"> 1-based page number of page containing the bounding region. </param>
        /// <param name="polygon">
        /// Bounding polygon on the page, or the entire page if not specified.
        /// Coordinates specified relative to the top-left of the page. The numbers
        /// represent the x, y values of the polygon vertices, clockwise from the left
        /// (-180 degrees inclusive) relative to the element orientation.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="polygon"/> is null. </exception>
        internal BoundingRegion(int pageNumber, IEnumerable<float> polygon)
        {
            Argument.AssertNotNull(polygon, nameof(polygon));

            PageNumber = pageNumber;
            Polygon = polygon.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="BoundingRegion"/>. </summary>
        /// <param name="pageNumber"> 1-based page number of page containing the bounding region. </param>
        /// <param name="polygon">
        /// Bounding polygon on the page, or the entire page if not specified.
        /// Coordinates specified relative to the top-left of the page. The numbers
        /// represent the x, y values of the polygon vertices, clockwise from the left
        /// (-180 degrees inclusive) relative to the element orientation.
        /// </param>
        internal BoundingRegion(int pageNumber, IReadOnlyList<float> polygon)
        {
            PageNumber = pageNumber;
            Polygon = polygon;
        }

        /// <summary> 1-based page number of page containing the bounding region. </summary>
        public int PageNumber { get; }
        /// <summary>
        /// Bounding polygon on the page, or the entire page if not specified.
        /// Coordinates specified relative to the top-left of the page. The numbers
        /// represent the x, y values of the polygon vertices, clockwise from the left
        /// (-180 degrees inclusive) relative to the element orientation.
        /// </summary>
        public IReadOnlyList<float> Polygon { get; }
    }
}
