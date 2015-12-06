using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGSpecFlowBVT.PageIDs
{
    public class CMDBIDs
    {
        public string sidebarCMDBModuleSelectBtn =
            @"//form[contains(@id, 'form2')]/div[4]/ul/li[text()[contains(., 'CMDB')]]";
        public string CMDBPageTitle =
            @"//form[contains(@id, 'form2')]/div[2]/div/div[2][text()[contains(., 'CMDB')]]";
        public string allResourcesView =
            @"//form[contains(@id, 'form2')]/div[3]/div/div/div//ul/li[text()[contains(., 'All Resources')]]";

        //CI page
        public string ciField = @"//label[text()[contains(., 'CI')]]";
        public string configurationTab = @"//span[text()[contains(., 'Configuration')]]";
        public string relationshipsTab = @"//span[text()[contains(., 'Relationships')]]";
        public string ticketInfo = @"//*[@id='ticketDescription']";

    }
}
