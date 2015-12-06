using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGSpecFlowBVT.PageIDs
{
    public class ServiceCatalogIDs
    {
        public string sidebarServiceCatalogModuleSelectBtn =
            @"//form[contains(@id, 'form2')]/div[4]/ul/li[text()[contains(., 'Service Catalog')]]";
        public string serviceCatalogPageTitle =
            @"//form[contains(@id, 'form2')]/div[2]/div/div[2][text()[contains(., 'Service Catalog')]]";

        //To access the mainGrid elements switch to the mainGrid frame
        public string mainGridFrame = @"//*[@id='mainGrid']";
        public string viewChooser = @"//*[@id='ViewChooser1_ViewDropDownList']";
        public string allServicesViewDropdownOption = @"//*[@id='ViewChooser1_ViewDropDownList']/option[text()[contains(., 'All Services')]]";                         
        
    }
}
