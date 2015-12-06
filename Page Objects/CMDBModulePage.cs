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
    public static class CMDBModulePage
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(CMDBModulePage)));
        public static CMDBIDs ID = new CMDBIDs();

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
            if (!(GeneralPage.IsElementVisible(ID.CMDBPageTitle)))
            {
                log.Info("CMDB page title was not found.");
            }
            else
            {
                log.Info("CMDB page title was found.");
            }

            return GeneralPage.IsElementVisible(ID.CMDBPageTitle);
        }

        private static bool IsViewLinkVisible()
        {
            if (!(GeneralPage.IsElementVisible(ID.allResourcesView)))
            {
                log.Info("All Resources view was not found.");
            }
            else
            {
                log.Info("All Resources view was found.");
            }

            return GeneralPage.IsElementVisible(ID.allResourcesView);
        }
    }
}
