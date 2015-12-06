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
    public static class ProblemModulePage
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(ProblemModulePage)));
        public static ProblemIDs ID = new ProblemIDs();

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
            if (!(GeneralPage.IsElementVisible(ID.problemPageTitle)))
            {
                log.Info("Problem page title was not found.");
            }
            else
            {
                log.Info("Problem page title was found.");
            }

            return GeneralPage.IsElementVisible(ID.problemPageTitle);
        }

        private static bool IsViewLinkVisible()
        {
            if (!(GeneralPage.IsElementVisible(ID.allProblemsView)))
            {
                log.Info("All Problems view was not found.");
            }
            else
            {
                log.Info("All Problems view was found.");
            }

            return GeneralPage.IsElementVisible(ID.allProblemsView);
        }
    }
}
