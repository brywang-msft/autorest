// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsBodyComplex.Models
{
    using Fixtures.AcceptanceTestsBodyComplex;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Basic
    {
        /// <summary>
        /// Initializes a new instance of the Basic class.
        /// </summary>
        public Basic() { }

        /// <summary>
        /// Initializes a new instance of the Basic class.
        /// </summary>
        /// <param name="id">Basic Id</param>
        /// <param name="name">Name property with a very long description that
        /// does not fit on a single line and a line break.</param>
        /// <param name="color">Possible values include: 'cyan', 'Magenta',
        /// 'YELLOW', 'blacK'</param>
        public Basic(int? id = default(int?), string name = default(string), string color = default(string))
        {
            Id = id;
            Name = name;
            Color = color;
        }

        /// <summary>
        /// Gets or sets basic Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets name property with a very long description that does
        /// not fit on a single line and a line break.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'cyan', 'Magenta', 'YELLOW',
        /// 'blacK'
        /// </summary>
        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

    }
}

