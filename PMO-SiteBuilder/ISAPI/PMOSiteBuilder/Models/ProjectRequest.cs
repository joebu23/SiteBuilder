using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMO_SiteBuilder.ISAPI.PMOSiteBuilder.Models
{
    public class ProjectRequest
    {
        public string ProjectName { get; set; }
        public string StartDate { get; set; }

        public string ClientList { get; set; }
        public string CdhList { get; set; }


        //public List<CdhPerson> Cdh { get; set; }
        //public List<ClientPerson> Client { get; set; }

        //public class CdhPerson : Person
        //{
        //    public string ConnectWiseUsername { get; set; }
        //}

        //public class ClientPerson : Person
        //{
        //    public string Username { get; set; }
        //    public string PlainTextPassword { get; set; }
        //}

        //public class Person
        //{
        //    public string Name { get; set; }
        //    public string Email { get; set; }
        //}
    }
}
