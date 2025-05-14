using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DV_webapi_quickstart
{
    /// <summary>
    /// WhoAmIResponse class definition 
    /// </summary>
    /// <remarks>To be used for JSON deserialization.</remarks>
    /// <see cref="https://learn.microsoft.com/power-apps/developer/data-platform/webapi/reference/whoamiresponse"/>
    public class WhoAmIResponse
    {
        public Guid BusinessUnitId { get; set; }
        public Guid UserId { get; set; }
        public Guid OrganizationId { get; set; }
    }
}
