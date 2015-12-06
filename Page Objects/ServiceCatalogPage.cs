using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using CGSpecFlowBVT.PageIDs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CGSpecFlowBVT.Page_Objects
{
    public static class ServiceCatalogPage
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(ServiceCatalogPage)));
        public static ServiceCatalogIDs ID = new ServiceCatalogIDs();

        public static void NavigateToURL()
        {
            GeneralPage.NavigateToURL(moduleURLs.main);
        }

        public static void AmIOnPage()
        {
            Assert.IsTrue(IsPageTitleVisible());
            Assert.IsTrue(IsViewDropDownOptionVisible());
            //Sample code on how to access the original parent frame after switching to an inner frame
            //Note that the method IsCustomizeLinkVisible() switches the driver's frame to access the "Show Catalog" link
            //In the code below, Clicking on the Navigation Bar Trigger button will not work unless SwitchToDefaultFrame() is called. 
            //GeneralPage.SwitchToDefaultFrame();
            //GeneralPage.ClickOnObject(GeneralPage.ID.navbarTriggerBtn);
            //NavBar.Click("Incident");
        }

        private static bool IsPageTitleVisible()
        {
            if (!(GeneralPage.IsElementVisible(ID.serviceCatalogPageTitle)))
            {
                log.Error("Service Catalog page title was not found.");
            }
            else
            {
                log.Info("Service Catalog page title was found.");
            }

            return GeneralPage.IsElementVisible(ID.serviceCatalogPageTitle);
        }

        private static bool IsViewDropDownOptionVisible()
        {
            GeneralPage.SwitchToFrame(ID.mainGridFrame);
            GeneralPage.ClickOnObject(ID.viewChooser);
            if (!(GeneralPage.IsElementVisible(ID.allServicesViewDropdownOption)))
            {
                log.Error("All Services view dropdown option was not found.");
            }
            else
            {
                log.Info("All Services view dropdown option was found.");
            }

            return GeneralPage.IsElementVisible(ID.allServicesViewDropdownOption);
        }
    }
}
