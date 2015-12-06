using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGSpecFlowBVT.PageIDs
{
    public class ViewsPanelIDs
    {
        //To access the mainGrid elements switch to the mainGrid frame
        public string mainGridFrame = @"//*[@id='mainGrid']";

        public string viewChooser = @"//*[@id='ViewChooser1_ViewDropDownList']";

        public string GenerateViewXpath(string name)
        {
            //This xpath will take a direct path to the div where the views are. From there, any <li> element within that div
            //that has the given view name will be selected but filters out every element except for the first one
            string xPath =
                @"(//form[contains(@id, 'form2')]/div[3]/div/div/div//li[text()[contains(., '" +
                name + @"')]])[1]";

            return xPath;
        }

        public string GenerateViewDropdownXpath(string name)
        {
            string xPath =
                @"//*[@id='ViewChooser1_ViewDropDownList']/option[text()[contains(., '" + name + @"')]][@selected='selected']";

            return xPath;
        }
    }
}
