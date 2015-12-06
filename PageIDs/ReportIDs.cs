using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGSpecFlowBVT.PageIDs
{
    public class ReportIDs
    {
        //Module page
        public string sidebarReportsModuleSelectBtn =
            @"//form[contains(@id, 'form2')]/div[4]/ul/li[text()[contains(., 'Reports')]]";
        
        public string ReportsPageTitle =
            @"//form[contains(@id, 'form2')]/div[2]/div/div[2][text()[contains(., 'Reports')]]";
        public string flex1DefaultReportsView =
            @"//form[contains(@id, 'form2')]/div[3]/div/div/div//ul/li[text()[contains(., 'Flex1 Default Reports')]]";

        //Report page
        public string reportFrame = @"//*[contains(@id, 'ctl05_ReportViewer1_ContentFrame')]";
        public string reportDiv = @"//*[@id='report_div']";
        public string generatedMessage = @"//nobr[text()[contains(., 'Report')]]";
    }
}
