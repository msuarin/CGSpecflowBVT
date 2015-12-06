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
    public static class SurveyModulePage
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(SurveyModulePage)));
        public static SurveyIDs ID = new SurveyIDs();

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
            if (!(GeneralPage.IsElementVisible(ID.surveyModulePageTitle)))
            {
                log.Info("Survey page title was not found.");
            }
            else
            {
                log.Info("Survey page title was found.");
            }

            return GeneralPage.IsElementVisible(ID.surveyModulePageTitle);
        }

        private static bool IsViewLinkVisible()
        {
            if (!(GeneralPage.IsElementVisible(ID.allSurveysView)))
            {
                log.Info("All Surveys view was not found.");
            }
            else
            {
                log.Info("All Surveys view was found.");
            }

            return GeneralPage.IsElementVisible(ID.allSurveysView);
        }
    }
}
