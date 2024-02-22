// <auto-generated/>
using Jellyfin.Sdk.Generated.Items.Item.Images.Item.Item.Item.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.Items.Item.Images.Item.Item.Item {
    /// <summary>
    /// Builds and executes requests for operations under \Items\{itemId}\Images\{imageType}\{imageIndex}\{tag}
    /// </summary>
    public class WithTagItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.Items.item.Images.item.item.item.item collection</summary>
        /// <param name="position">Determines the output format of the image - original,gif,jpg,png.</param>
        public WithFormatItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("format", position);
            return new WithFormatItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new WithTagItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTagItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Items/{itemId}/Images/{imageType}/{imageIndex}/{tag}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithTagItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTagItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Items/{itemId}/Images/{imageType}/{imageIndex}/{tag}", rawUrl) {
        }
    }
}