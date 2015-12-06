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
    public static class IncidentModulePage
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(IncidentModulePage)));
        public static IncidentIDs ID = new IncidentIDs();

        public static void NavigateToURL()
        {
            GeneralPage.NavigateToURL(moduleURLs.main);
        }

        public static void AmIOnPage()
        {
            Assert.IsTrue(IsPageTitleVisible());
            Assert.IsTrue(IsViewLinkVisible());
        }

        private static bool IsPageTitleVisible()
        {
            if (!(GeneralPage.IsElementVisible(ID.incidentPageTitle)))
            {
                log.Info("Incident page title was not found.");
            }
            else
            {
                log.Info("Incident page title was found.");
            }

            return GeneralPage.IsElementVisible(ID.incidentPageTitle);
        }

        private static bool IsViewLinkVisible()
        {
            if (!(GeneralPage.IsElementVisible(ID.allIncidentsView)))
            {
                log.Info("All Incidents view was not found.");
            }
            else
            {
                log.Info("All Incidents view was found.");
            }

            return GeneralPage.IsElementVisible(ID.allIncidentsView);
        }
    }
}
