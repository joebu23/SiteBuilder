using System.Web;
using Microsoft.Online.SharePoint.TenantAdministration;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;

namespace PMO_SiteBuilder.ISAPI.PMOSiteBuilder.Services
{
    public class SharePointService : ISharePointService
    {
        public bool CreateSharePointSite(Models.ProjectRequest projectRequest)
        {
            HttpContext.Current.Items["FormDigestValidated"] = true;

            SPWebApplication site = new SPSite("http://dev.test2013").WebApplication;

            //site.AllowUnsafeUpdates = true;

            SPSiteCollection siteCollection = site.Sites;

            SPSite newSiteCollection = siteCollection.Add("/sites/" + projectRequest.ProjectName, "testTitle", "testDescription", 1033, "STS#0", "test", "test", "test@test.com");
           




            return true;
        }
    }
}
