using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using CGSpecFlowBVT.PageIDs;
using CGSpecFlowBVT.Page_Object_Parts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CGSpecFlowBVT.Page_Objects
{
    public static class ServiceRequestModulePage
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(ServiceRequestModulePage)));
        public static ServiceRequestIDs ID = new ServiceRequestIDs();

        public static void AmIOnPage()
        {
            Assert.IsTrue(IsPageTitleVisible());
            Assert.IsTrue(IsViewLinkVisible());
        }

        private static bool IsPageTitleVisible()
        {
            if (!(GeneralPage.IsElementVisible(ID.serviceRequestPageTitle)))
            {
                log.Info("Service Request page title was not found.");
            }
            else
            {
                log.Info("Service Request page title was found.");
            }

            return GeneralPage.IsElementVisible(ID.serviceRequestPageTitle);
        }

        private static bool IsViewLinkVisible()
        {
            if (!(GeneralPage.IsElementVisible(ID.allRequestsView)))
            {
                log.Info("All Requests view was not found.");
            }
            else
            {
                log.Info("All Requests view was found.");
            }

            return GeneralPage.IsElementVisible(ID.allRequestsView);
        }
    }
}
