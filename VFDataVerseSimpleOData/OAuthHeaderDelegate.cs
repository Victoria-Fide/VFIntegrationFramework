using Microsoft.Identity.Client;
using System.Net.Http.Headers;

namespace VFDataVerseSimpleOData.AuthenticationUtility
{
    /// <summary>
    /// This delegate class provides instance data that can be used to handle any events
    /// that require a bearer token authentication header.
    /// </summary>
    /// <remarks>
    /// This class is used to hold the authentication heaader value as instance data 
    /// so we only have to retrieve it once and can use it multiple times.
    /// </remarks>
    public class OAuthHeaderDelegate
    {
        private AuthenticationHeaderValue authHeader;
        private DateTimeOffset tokenExpiration;
        private String serviceUrl;
        private String tenant;
        private String resource;

        /// <summary>
        /// Default constructor
        /// </summary>
        private OAuthHeaderDelegate()
        {
        }

        /// <summary>
        /// Construct a delegate using a ClientConfiguration
        /// </summary>
        /// <param name="configuration">configuration containing the URL, client credentials and tenant</param>
        /// <remarks>
        /// <seealso cref="configuration"/> must contain the following configuration items:
        /// <list type="bullet">
        /// <item><term>ActiveDirectoryResource</term>
        /// <description>The URL from which to get the token</description></item>
        /// <item><term>ActiveDirectoryClientAppId</term>
        /// <description>The client ID to use in the credentials</description></item>
        /// <item><term>ActiveDirectoryClientAppSecret</term>
        /// <description>The client app secret to use in the credentials</description></item>
        /// <item><term>ActiveDirectoryTenant</term>
        /// <description>The tenant that will issue the token</description></item>
        /// </list>
        /// </remarks>
        public static async Task<OAuthHeaderDelegate> Create()
        {
            var headerDelegate = new OAuthHeaderDelegate();
            await headerDelegate.InitializeClass().ConfigureAwait(false);

            return headerDelegate;
        }

        /// <summary>
        /// Initialize the delegate values and obtain the token
        /// </summary>
        /// <param name="serviceUrl"></param>
        /// <param name="assertion"></param>
        /// <param name="tenant"></param>
        private async Task InitializeClass()
        {

            await this.GetBearerTokenAsync().ConfigureAwait(false);
        }

        private async Task GetBearerTokenAsync()
        {
            try
            {
                //var authContext = new AuthenticationContext(this.tenant, false);
                //var authResult = await authContext.AcquireTokenAsync(this.serviceUrl, this.assertion).ConfigureAwait(false);

                //this.authHeader = new AuthenticationHeaderValue("Bearer", authResult.AccessToken);

                ////Note that an Azure AD access token has finite lifetime, default expiration is 60 minutes.
                //this.tokenExpiration = authResult.ExpiresOn;

                string resource = "https://orgab450c0a.api.crm.dynamics.com";

                // Microsoft Entra ID app registration shared by all Power App samples.
                var clientId = "51f81489-12ee-4a9e-aaae-a2591f45987d";
                var redirectUri = "http://localhost"; // Loopback for the interactive login.

                // For your custom apps, you will need to register them with Microsoft Entra ID yourself.
                // See https://docs.microsoft.com/powerapps/developer/data-platform/walkthrough-register-app-azure-active-directory

                #region Authentication

                var authBuilder = PublicClientApplicationBuilder.Create(clientId)
                               .WithAuthority(AadAuthorityAudience.AzureAdMultipleOrgs)
                               .WithRedirectUri(redirectUri)
                               .Build();
                var scope = resource + "/user_impersonation";
                string[] scopes = { scope };

                AuthenticationResult token =
                   await authBuilder.AcquireTokenInteractive(scopes).ExecuteAsync();
                this.authHeader = new AuthenticationHeaderValue("Bearer", token.AccessToken);
                var claimsPrincipal = token.ClaimsPrincipal;
                this.tokenExpiration = token.ExpiresOn;

                #endregion Authentication

            }
            catch (Exception ex)
            {
                throw new AuthenticationFailedException("Failed to authenticate.", ex);
            }
        }

        /// <summary>
        /// Used to add Authorization header to an HttpRequestMessage
        /// </summary>
        /// <param name="request"></param>
        /// <remarks>
        /// To use on Simple.OData.Client, call this from the BeforeRequest action on the 
        /// ODataClientSettings
        /// see https://github.com/object/Simple.OData.Client/wiki/Request-authentication-and-interception
        /// for more information
        /// </remarks>
        public async Task AddRequestAuthenticationHeaderAsync(HttpRequestMessage request)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            // Check for expired token
            if (this.tokenExpiration < DateTimeOffset.UtcNow)
            {
                await this.GetBearerTokenAsync().ConfigureAwait(false);
            }

            request.Headers.Authorization = this.authHeader;
        }
    }
}
