// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.OneDrive.Sdk
{
    using Microsoft.Graph;

    /// <summary>
    /// The type OneDriveClient.
    /// </summary>
    public partial class OneDriveClient : BaseClient, IOneDriveClient
    {
        /// <summary>
        /// Instantiates a new OneDriveClient.
        /// </summary>
        /// <param name="authenticationProvider">The <see cref="IAuthenticationProvider"/> for authenticating request messages.</param>
        /// <param name="httpProvider">The <see cref="IHttpProvider"/> for sending requests.</param>
        public OneDriveClient(
            IAuthenticationProvider authenticationProvider,
            IHttpProvider httpProvider = null)
            : this("https://api.onedrive.com/v1.0", authenticationProvider, httpProvider)
        {
        }

        /// <summary>
        /// Instantiates a new OneDriveClient.
        /// </summary>
        /// <param name="baseUrl">The base service URL. For example, "https://api.onedrive.com/v1.0."</param>
        /// <param name="authenticationProvider">The <see cref="IAuthenticationProvider"/> for authenticating request messages.</param>
        /// <param name="httpProvider">The <see cref="IHttpProvider"/> for sending requests.</param>
        public OneDriveClient(
            string baseUrl,
            IAuthenticationProvider authenticationProvider,
            IHttpProvider httpProvider = null)
            : base(baseUrl, authenticationProvider, httpProvider)
        {
        }

        /// <summary>
        /// Gets the OneDriveDrives request builder.
        /// </summary>
        public IOneDriveDrivesCollectionRequestBuilder Drives
        {
            get
            {
                return new OneDriveDrivesCollectionRequestBuilder(this.BaseUrl + "/drives", this);
            }
        }

        /// <summary>
        /// Gets the OneDriveShares request builder.
        /// </summary>
        public IOneDriveSharesCollectionRequestBuilder Shares
        {
            get
            {
                return new OneDriveSharesCollectionRequestBuilder(this.BaseUrl + "/shares", this);
            }
        }
    }
}
