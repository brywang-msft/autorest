// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsAzureCompositeModelClient.Models
{
    using Fixtures.AcceptanceTestsAzureCompositeModelClient;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The product documentation.
    /// </summary>
    public partial class ProductInner
    {
        /// <summary>
        /// Initializes a new instance of the ProductInner class.
        /// </summary>
        public ProductInner() { }

        /// <summary>
        /// Initializes a new instance of the ProductInner class.
        /// </summary>
        /// <param name="productId">Unique identifier representing a specific
        /// product for a given latitude &amp; longitude. For example, uberX in
        /// San Francisco will have a different product_id than uberX in Los
        /// Angeles.</param>
        /// <param name="description">Description of product.</param>
        /// <param name="displayName">Display name of product.</param>
        /// <param name="capacity">Capacity of product. For example, 4
        /// people.</param>
        /// <param name="image">Image URL representing the product.</param>
        public ProductInner(string productId = default(string), string description = default(string), string displayName = default(string), string capacity = default(string), string image = default(string))
        {
            ProductId = productId;
            Description = description;
            DisplayName = displayName;
            Capacity = capacity;
            Image = image;
        }

        /// <summary>
        /// Gets or sets unique identifier representing a specific product for
        /// a given latitude &amp;amp; longitude. For example, uberX in San
        /// Francisco will have a different product_id than uberX in Los
        /// Angeles.
        /// </summary>
        [JsonProperty(PropertyName = "product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// Gets or sets description of product.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets display name of product.
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets capacity of product. For example, 4 people.
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public string Capacity { get; set; }

        /// <summary>
        /// Gets or sets image URL representing the product.
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }

    }
}

