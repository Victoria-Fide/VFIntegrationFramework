using System;

namespace VFDataVerseSimpleOData.AuthenticationUtility
{
    public interface IClientConfiguration
    {
        String ActiveDirectoryClientAppId
        {
            get;
        }

        String ActiveDirectoryClientAppSecret
        {
            get;
        }

        String ActiveDirectoryResource
        {
            get;
        }

        String ActiveDirectoryTenant
        {
            get;
        }

        String TLSVersion
        {
            get;
        }

        String UriString
        {
            get;
        }

        String ODataEntityPath
        {
            get;
        }
    }
}
