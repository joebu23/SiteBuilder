using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint.BusinessData.Administration;
using PMO_SiteBuilder.ISAPI.PMOSiteBuilder.Models;

namespace PMOSiteBuilder.ISAPI.PMOSiteBuilder.Interfaces
{
    [ServiceContract]
    public interface IPMOSiteBuilderService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/GetTest", ResponseFormat = WebMessageFormat.Json)]
        string GetTest();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/GenerateProject", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        bool GenerateProject(ProjectRequest projectDetails);

        //BodyStyle = WebMessageBodyStyle.WrappedRequest,

    }
}
