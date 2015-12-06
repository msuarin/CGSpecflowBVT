using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGSpecFlowBVT.PageIDs
{
    public class FlexIDs : GeneralPageIDs
    {
        //Generates the XPath to select any of the 9 Flex modules in the Navigation bar
        public string GenerateFlexNavBarXPath(string flexModule)
        {
            string xPath = @"//form[contains(@id, 'form2')]/div[4]/ul/li[text()[contains(., '" +
                flexModule + @"')]]";
            return xPath;
        }

        //Generates the XPath for the Flex Page title
        public string GenerateFlexPageTitleXPath(string flexModule)
        {
            string xPath = @"//form[contains(@id, 'form2')]/div[2]/div/div[2][text()[contains(., '" + 
                flexModule + @"')]]";
            return xPath;
        }

        //Looks for "All Tickets" view in the whole left side panel
        public string allTicketsView = @"//form[contains(@id, 'form2')]/div[3]/div/div/div//ul/li[text()[contains(., 'All Tickets')]]";

        //Flex form elements
        public string ticketInfo = @"//*[@id='ticketDescription']";

    }
}
