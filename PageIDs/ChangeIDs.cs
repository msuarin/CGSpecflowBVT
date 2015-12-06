using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGSpecFlowBVT.PageIDs
{
    public class ChangeIDs : GeneralPageIDs
    {
        public string sidebarChangeModuleSelectBtn = @"//form[contains(@id, 'form2')]/div[4]/ul/li[text()[contains(., 'Change')]]";
        public string changePageTitle =
            @"//form[contains(@id, 'form2')]/div[2]/div/div[2][text()[contains(., 'Change')]]";
        public string allTicketsView =
            @"//form[contains(@id, 'form2')]/div[3]/div/div/div//ul/li[text()[contains(., 'All Tickets')]]";

        //Change form elements
        public string ticketInfo = @"//*[@id='ticketDescription']";

        //Change task form elements
        public string taskInfo = @"//*[@id='ticketDescription']";

    }
}
