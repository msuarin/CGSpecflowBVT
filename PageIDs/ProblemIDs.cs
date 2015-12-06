using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGSpecFlowBVT.PageIDs
{
    public class ProblemIDs : GeneralPageIDs
    {
        //The nav bar Problem module selection button
        public string sidebarProblemModuleSelectBtn = @"//form[contains(@id, 'form2')]/div[4]/ul/li[text()[contains(., 'Problem')]]";
        //The module title on upper left hand side of the page
        public string problemPageTitle = @"//form[contains(@id, 'form2')]/div[2]/div/div[2][text()[contains(., 'Problem')]]";
        
        //The All Problems view link on the left hand side view panel
        public string allProblemsView = @"//form[contains(@id, 'form2')]/div[3]/div/div/div//ul/li[text()[contains(., 'All Problems')]]";

        //Problem form elements
        public string ticketInfo = @"//*[@id='ticketDescription']";

        //public string GenerateTypeXPath(string[] typeNames, int currentLevel, int maxLevel)
        //{
        //    string xPath = @"//div[contains(@id, 'Type') and contains(@id, 'DropDownEdit')" +
        //        @" and contains(@id, 'DropDownTreeView')]";
        //    for (int i = 1; i <= currentLevel; i++)
        //    {
        //        xPath += @"/ul/li";
        //        if (currentLevel == maxLevel && i == currentLevel)
        //        {
        //            xPath += @"/div/span[text()[contains(., '" + typeNames[i - 1] + @"')]]";
        //        }
        //        else if (currentLevel < maxLevel && i == currentLevel)
        //        {
        //            xPath += @"/div/span[text()[contains(., '" + typeNames[i - 1] + @"')]]/preceding-sibling::span[1]";
        //        }
        //    }

        //    return xPath;
        //}
    }
}
