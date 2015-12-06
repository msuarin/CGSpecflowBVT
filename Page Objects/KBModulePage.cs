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
    public static class KBModulePage
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(KBModulePage)));
        public static KBIDs ID = new KBIDs();

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
            if (!(GeneralPage.IsElementVisible(ID.KBPageTitle)))
            {
                log.Info("KB page title was not found.");
            }
            else
            {
                log.Info("KB page title was found.");
            }

            return GeneralPage.IsElementVisible(ID.KBPageTitle);
        }

        private static bool IsViewLinkVisible()
        {
            if (!(GeneralPage.IsElementVisible(ID.allArticlesView)))
            {
                log.Info("All Articles view was not found.");
            }
            else
            {
                log.Info("All Articles view was found.");
            }

            return GeneralPage.IsElementVisible(ID.allArticlesView);
        }
    }
}
