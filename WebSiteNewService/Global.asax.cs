using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Reflection;
using Funq;

namespace WebSiteNewService
{
    public class Global : System.Web.HttpApplication
    {

        public class WebsiteAppHost : AppHostBase
        {
            public WebsiteAppHost()
                : base("WebSite", typeof(SubmissionService).Assembly)
            {
            }

            public override void Configure(Container container)
            {
               // throw new NotImplementedException();
            }
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            new WebsiteAppHost().Init();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}