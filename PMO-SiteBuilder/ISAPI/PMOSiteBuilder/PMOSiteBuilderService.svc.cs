using Microsoft.SharePoint.Client.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Activation;
using PMOSiteBuilder.ISAPI.PMOSiteBuilder;
using PMOSiteBuilder.ISAPI.PMOSiteBuilder.Interfaces;
using PMO_SiteBuilder.ISAPI.PMOSiteBuilder.Models;
using PMO_SiteBuilder.ISAPI.PMOSiteBuilder.Services;

namespace PMOSiteBuilder.ISAPI.PMOSiteBuilder
{
    [BasicHttpBindingServiceMetadataExchangeEndpointAttribute]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class PMOSiteBuilderService : IPMOSiteBuilderService
    {

        public string GetTest()
        {
            return "got this from the server";
        }


        public bool GenerateProject(ProjectRequest projectDetails)
        {
            var spService = new SharePointService();

            spService.CreateSharePointSite(projectDetails);

            return true;
        }
    }
}