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
    public static class SurveyPage
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(SurveyPage)));
        public static SurveyIDs ID = new SurveyIDs();

        public static void AmIOnPage()
        {
            Assert.IsTrue(IsSurveyTitleVisible());
        }

        private static bool IsSurveyTitleVisible()
        {

            bool isTitleVisible = GeneralPage.IsElementVisible(ID.surveyPageTitle);

            if (!(isTitleVisible))
            {
                log.Info("Survey page title was not found.");
            }
            else
            {
                log.Info("Survey page title was found.");
            }
            return isTitleVisible;
        }
    }
}
