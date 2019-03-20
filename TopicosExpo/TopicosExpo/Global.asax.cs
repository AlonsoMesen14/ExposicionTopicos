using GdPicture14.WEB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace TopicosExpo
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            DocuViewareManager.SetupConfiguration(true, DocuViewareSessionStateMode.InProc, HttpRuntime.AppDomainAppPath + "\\Cache");
            DocuViewareLicensing.RegisterKEY("0435375251735586356441524");
        }
    }
}