using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using CGSpecFlowBVT.PageIDs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CGSpecFlowBVT.Page_Objects
{
    public static class ReportsModulePage
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(ReportsModulePage)));
        public static ReportIDs ID = new ReportIDs();

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
            if (!(GeneralPage.IsElementVisible(ID.ReportsPageTitle)))
            {
                log.Info("Reports page title was not found.");
            }
            else
            {
                log.Info("Reports page title was found.");
            }

            return GeneralPage.IsElementVisible(ID.ReportsPageTitle);
        }

        private static bool IsViewLinkVisible()
        {
            if (!(GeneralPage.IsElementVisible(ID.flex1DefaultReportsView)))
            {
                log.Info("Flex1 Default Reports view was not found.");
            }
            else
            {
                log.Info("Flex1 Default Reports view was found.");
            }

            return GeneralPage.IsElementVisible(ID.flex1DefaultReportsView);
        }
    }
}
