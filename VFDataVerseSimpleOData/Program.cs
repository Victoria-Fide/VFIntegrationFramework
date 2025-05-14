using Microsoft.Identity.Client;  // Microsoft Authentication Library (MSAL)
using Simple.OData.Client;
using System;
using VFDataVerseSimpleOData.AuthenticationUtility;
using VictoriFide.ODataDataSources.Microsoft.Dynamics.CRM;
namespace VFDataVerseSimpleOData
{
    internal class Program
    {
        static OAuthHeaderDelegate headerDelegate;
        static async Task Main(string[] args)
        {
            Simple.OData.Client.V4Adapter.Reference();
            Program.headerDelegate = await OAuthHeaderDelegate.Create().ConfigureAwait(false);
            Console.WriteLine("Please wait while I list accounts.");
            await ListAccounts();
        }

        static async Task ListAccounts()
        {
            //// TODO Specify the Dataverse environment name to connect with.
            //// See https://learn.microsoft.com/power-apps/developer/data-platform/webapi/compose-http-requests-handle-errors#web-api-url-and-versions
            string resource = "https://orgab450c0a.api.crm.dynamics.com";

            //// Microsoft Entra ID app registration shared by all Power App samples.
            //var clientId = "51f81489-12ee-4a9e-aaae-a2591f45987d";
            //var redirectUri = "http://localhost"; // Loopback for the interactive login.

            //// For your custom apps, you will need to register them with Microsoft Entra ID yourself.
            //// See https://docs.microsoft.com/powerapps/developer/data-platform/walkthrough-register-app-azure-active-directory

            //#region Authentication

            //var authBuilder = PublicClientApplicationBuilder.Create(clientId)
            //               .WithAuthority(AadAuthorityAudience.AzureAdMultipleOrgs)
            //               .WithRedirectUri(redirectUri)
            //               .Build();
            //var scope = resource + "/user_impersonation";
            //string[] scopes = { scope };

            //AuthenticationResult token =
            //   await authBuilder.AcquireTokenInteractive(scopes).ExecuteAsync();
            //#endregion Authentication
            //OAuthHeaderDelegate headerDelegate = await OAuthHeaderDelegate.Create().ConfigureAwait(false);
            var uri = new Uri(resource + "/api/data/v9.2/");
            var clientSettings = new ODataClientSettings(uri)
            {
                IncludeAnnotationsInResults = true,
                BeforeRequestAsync = Program.BeforeRequestAsync,
                IgnoreUnmappedProperties = true

                // MetadataDocument = await CRMSimpleODataDataSource.GetXmlMetadataAsync(this.Configuration.AssemblyName, this.Configuration.MetadataResource).ConfigureAwait(false)
            };

            var client = new ODataClient(clientSettings);
            var accounts = await client
                .For<account>()
                .FindEntriesAsync();
            foreach (var account in accounts)
            {
                Console.WriteLine(account.name);
            }
        }
        private static async Task BeforeRequestAsync(HttpRequestMessage request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            await Program.headerDelegate.AddRequestAuthenticationHeaderAsync(request).ConfigureAwait(false);

            // Add preference for annotations
            if (request.Headers.TryGetValues("Prefer", out IEnumerable<String> headerValues) == true)
            {
                // If Simple.OData is asking for annoations (Prefer: return= representation)
                // then use the CRM odata.include-annotations method for getting annotations
                if ((headerValues.Contains("return=representation") == true)
                    && (headerValues.Contains("odata.include-annotations=\"*\"") == false))
                {
                    request.Headers.Add("Prefer", "odata.include-annotations=\"*\"");
                }
            }

            // Add Hack for non-support for quoted key values
            var path = System.Web.HttpUtility.UrlDecode(request.RequestUri.AbsolutePath)
                .Replace("('", "(")
                .Replace("')", ")");

            System.Collections.Specialized.NameValueCollection parsedQuery = System.Web.HttpUtility.ParseQueryString(request.RequestUri.Query);
            var uriBuilder = new UriBuilder(request.RequestUri)
            {
                Path = path,
                Query = parsedQuery.ToString()
            };

            request.RequestUri = uriBuilder.Uri;

            //if (null != request?.Content)
            //{
            //    this.RequestContent = await request.Content.ReadAsStringAsync().ConfigureAwait(false);
            //}

            //await this.DumpODataMessageRequestAsync(request, @"C:\Temp\Logs").ConfigureAwait(false);
        }

    }
}
