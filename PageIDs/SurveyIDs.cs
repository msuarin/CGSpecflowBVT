using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGSpecFlowBVT.PageIDs
{
    public class SurveyIDs
    {
        public string sidebarSurveyModuleSelectBtn =
            @"//form[contains(@id, 'form2')]/div[4]/ul/li[text()[contains(., 'Survey')]]";
        public string surveyModulePageTitle =
            @"//form[contains(@id, 'form2')]/div[2]/div/div[2][text()[contains(., 'Survey')]]";
        public string allSurveysView =
            @"//form[contains(@id, 'form2')]/div[3]/div/div/div//ul/li[text()[contains(., 'All Surveys')]]";

        public string surveyPageTitle = @"//*[@id='SurveyTitle']";
    }
}
