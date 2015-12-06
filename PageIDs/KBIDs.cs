using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGSpecFlowBVT.PageIDs
{
    public class KBIDs
    {
        //Module page
        public string sidebarKBModuleSelectBtn =
            @"//form[contains(@id, 'form2')]/div[4]/ul/li[text()[contains(., 'Knowledge Base')]]";
        public string KBPageTitle =
            @"//form[contains(@id, 'form2')]/div[2]/div/div[2][text()[contains(., 'Knowledge Base')]]";
        public string allArticlesView =
            @"//form[contains(@id, 'form2')]/div[3]/div/div/div//ul/li[text()[contains(., 'All Articles')]]";

        //Article page
        public string ticketInfo = @"//*[@id='ctl02_ItemID_txt']";
        public string kbArticleFrame = @"/html/frameset/frame[2]";
                             
    }
}
