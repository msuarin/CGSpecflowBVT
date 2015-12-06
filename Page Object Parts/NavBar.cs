using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using log4net;
using CGSpecFlowBVT.PageIDs;
using CGSpecFlowBVT.Page_Objects;


namespace CGSpecFlowBVT.Page_Object_Parts
{
    public static class NavBar
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(NavBar)));

        private static bool IsNavBarExpanded()
        {
            bool isExpanded = true;
            //check if first and last buttons are visible
            isExpanded &= GeneralPage.IsElementVisible(IncidentModulePage.ID.sidebarIncidentModuleSelectBtn);
            isExpanded &= GeneralPage.IsElementVisible(ReportsModulePage.ID.sidebarReportsModuleSelectBtn);
            return isExpanded;
        }

        //No longer used. This was when we hovered to expand Nav bar
        private static void HoverToExpandNavBar()
        {
            if (!IsNavBarExpanded())
            {
                log.Info("Hovering to expand Navigation Bar...");
                GeneralPage.HoverOverElement(GeneralPage.ID.navbarHoverArea);
            }
            else
                log.Info("Tried to hover to expand module navigation bar but it was already open.");
        }
        
        private static void ClickToExpandNavBar()
        {
            if (!IsNavBarExpanded())
            {
                log.Info("Expanding Module Navigation Bar...");
                GeneralPage.ClickOnObject(GeneralPage.ID.navbarTriggerBtn);
            }
            else
                log.Info("Tried to expand the module navigation bar but it was already open.");
        }
        //No longer used
        private static void Collapse()
        {
            if (IsNavBarExpanded())
            {
                log.Info("Collapsing Module Navigation Bar...");
                GeneralPage.ClickOnObject(GeneralPage.ID.navbarTriggerBtn);
            }
            else
                log.Info("Tried to collapse the module navigation bar but it was already collapsed.");
        }

        public static void Click(string moduleBtnSel)
        {
            string moduleBtn = moduleBtnSel;
            ClickToExpandNavBar();
            if (moduleBtn.Contains("Flex"))
            {
                //Determine if Flex module is valid
                bool moduleValid = false;
                for (int i = 1; i < 10; i++)
                {
                    if (moduleBtn == ("Flex" + i))
                    {
                        moduleValid |= true;
                        break;
                    }
                }
                if (!moduleValid)
                {
                    log.Error("This module[" + moduleBtn + "] does not exist. Check the feature file for errors.");
                    Assert.Fail("This module[" + moduleBtn + "] does not exist. Check the feature file for errors.");
                    return;
                }

                GeneralPage.ClickOnObject(FlexModulePage.ID.GenerateFlexNavBarXPath(moduleBtn));
                log.Info("Clicked on " + moduleBtn + " module in the module navigation bar.");
                return;
            }
            switch (moduleBtn)
            {
                case "Incident":
                    {
                        GeneralPage.ClickOnObject(IncidentModulePage.ID.sidebarIncidentModuleSelectBtn);
                        log.Info("Clicked on Incident module in the module navigation bar.");
                        break;
                    }
                case "Problem":
                    {
                        GeneralPage.ClickOnObject(ProblemModulePage.ID.sidebarProblemModuleSelectBtn);
                        log.Info("Clicked on Problem module in the module navigation bar.");
                        break;
                    }
                case "Change":
                    {
                        GeneralPage.ClickOnObject(ChangeModulePage.ID.sidebarChangeModuleSelectBtn);
                        log.Info("Clicked on Change module in the module navigation bar.");
                        break;
                    }
                case "Service Catalog":
                    {
                        GeneralPage.ClickOnObject(ServiceCatalogPage.ID.sidebarServiceCatalogModuleSelectBtn);
                        log.Info("Clicked on Service Catalog module in the navigation bar.");
                        break;
                    }
                case "CMDB":
                    {
                        GeneralPage.ClickOnObject(CMDBModulePage.ID.sidebarCMDBModuleSelectBtn);
                        log.Info("Clicked on CMDB module in the navigation bar.");
                        break;
                    }
                case "Knowledge Base":
                    {
                        GeneralPage.ClickOnObject(KBModulePage.ID.sidebarKBModuleSelectBtn);
                        log.Info("Clicked on Knowledge Base module in the navigation bar.");
                        break;
                    }
                case "Survey":
                    {
                        GeneralPage.ClickOnObject(SurveyModulePage.ID.sidebarSurveyModuleSelectBtn);
                        log.Info("Clicked on Survey module in the navigation bar.");
                        break;
                    }
                case "Reports":
                    {
                        GeneralPage.ClickOnObject(ReportsModulePage.ID.sidebarReportsModuleSelectBtn);
                        log.Info("Clicked on Reports module in the navigation bar.");
                        break;
                    }
                case "Service Request":
                    {
                        GeneralPage.ClickOnObject(ServiceRequestPage.ID.sidebarServiceRequestModuleSelectBtn);
                        log.Info("Clicked on " + moduleBtn + " module in the navigation bar.");
                        break;
                    }
                default:
                    {
                        log.Error("This module[" + moduleBtn + "] does not exist. Check the feature file for errors.");
                        Assert.Fail("This module[" + moduleBtn + "] does not exist. Check the feature file for errors.");
                        break;
                    }
            }
        }

    }
}
