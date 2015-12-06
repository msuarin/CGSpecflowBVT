using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGSpecFlowBVT.PageIDs
{
    public class UserCenterIDs
    {
        public string userCenterTitle = @"//*[@id='UserCenterLable']";
        public string profileTab = @"//div[@id='QuickTicketCallbackPanel_ASPxPageControl1']/ul/li[2]/ul/li[2]/a/span[text()[contains(., 'Profile')]]";
        public string requestType = @"//span[@id='ModuleLabel'][text()[contains(., 'Request Type')]]";
    }
}
