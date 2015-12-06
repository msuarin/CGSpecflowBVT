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
    class ChangeModulePage
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(ChangeModulePage)));
        public static ChangeIDs ID = new ChangeIDs();

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
            if (!(GeneralPage.IsElementVisible(ID.changePageTitle)))
            {
                log.Info("Change page title was not found.");
            }
            else
            {
                log.Info("Change page title was found.");
            }

            return GeneralPage.IsElementVisible(ID.changePageTitle);
        }

        private static bool IsViewLinkVisible()
        {
            if (!(GeneralPage.IsElementVisible(ID.allTicketsView)))
            {
                log.Info("All Tickets view was not found.");
            }
            else
            {
                log.Info("All Tickets view was found.");
            }

            return GeneralPage.IsElementVisible(ID.allTicketsView);
        }
    }
}
