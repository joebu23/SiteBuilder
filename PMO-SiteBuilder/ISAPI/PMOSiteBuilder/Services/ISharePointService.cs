using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMO_SiteBuilder.ISAPI.PMOSiteBuilder.Models;

namespace PMO_SiteBuilder.ISAPI.PMOSiteBuilder.Services
{
    public interface ISharePointService
    {
        bool CreateSharePointSite(ProjectRequest projectRequest);
    }
}
