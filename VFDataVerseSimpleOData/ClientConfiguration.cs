using System;
using System.Security;

namespace VFDataVerseSimpleOData.AuthenticationUtility
{
    public class ClientConfiguration : IClientConfiguration
    {
        public String RedirectUriString
        {
            get;
            set;
        }
        public String UriString
        {
            get;
            set;
        }
        public String ActiveDirectoryResource
        {
            get;
            set;
        }
        public String ActiveDirectoryTenant
        {
            get;
            set;
        }
        public String ActiveDirectoryClientAppId
        {
            get;
            set;
        }
        public String ActiveDirectoryClientAppSecret
        {
            get;
            set;
        }
        public String UserName
        {
            get;
            set;
        }
        public SecureString Password
        {
            get;
            set;
        }
        public String TLSVersion
        {
            get;
            set;
        }
        public String ODataEntityPath
        {
            get;
            set;
        }
    }
}
