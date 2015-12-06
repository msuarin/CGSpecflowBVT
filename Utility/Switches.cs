using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using CGSpecFlowBVT.Page_Objects;
using CGSpecFlowBVT.PageIDs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CGSpecFlowBVT.Data_Objects;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace CGSpecFlowBVT.Utility
{
    public static class Switches
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(Switches)));

        public static void NavigateToURLSwitch(string module)
        {
            switch (module)
            {
                case "Incident":
                    {
                        GeneralPage.NavigateToModuleURL(moduleURLs.incident);
                        break;
                    }
                case "Problem":
                    {
                        GeneralPage.NavigateToModuleURL(moduleURLs.problem);
                        break;
                    }
                case "Change":
                    {
                        GeneralPage.NavigateToModuleURL(moduleURLs.change);
                        break;
                    }
                case "Flex1":
                    {
                        GeneralPage.NavigateToModuleURL(moduleURLs.flex1);
                        break;
                    }
                case "Flex2":
                    {
                        GeneralPage.NavigateToModuleURL(moduleURLs.flex2);
                        break;
                    }
                case "Knowledge Base":
                    {
                        GeneralPage.NavigateToModuleURL(moduleURLs.KB);
                        break;
                    }
                case "Survey":
                    {
                        GeneralPage.NavigateToModuleURL(moduleURLs.survey);
                        break;
                    }
                case "Reports":
                    {
                        GeneralPage.NavigateToModuleURL(moduleURLs.reports);
                        break;
                    }
                case "CMDB":
                    {
                        GeneralPage.NavigateToModuleURL(moduleURLs.cmdb);
                        break;
                    }
                case "Service Catalog":
                    {
                        GeneralPage.NavigateToModuleURL(moduleURLs.serviceCatalog);
                        break;
                    }
                case "Announcement Portal":
                    {
                        GeneralPage.NavigateToCGWebFeaturesURL(moduleURLs.announcementPortal);
                        break;
                    }
                case "SSP":
                    {
                        GeneralPage.NavigateToCGWebFeaturesURL(moduleURLs.ssp);
                        break;
                    }
                case "Announcement Manager":
                    {
                        GeneralPage.NavigateToCGWebFeaturesURL(moduleURLs.announcementManager);
                        break;
                    }
                case "Incident Template Manager":
                    {
                        GeneralPage.NavigateToCGWebFeaturesURL(moduleURLs.incidentTemplateManager);
                        break;
                    }
                case "Problem Template Manager":
                    {
                        GeneralPage.NavigateToCGWebFeaturesURL(moduleURLs.problemTemplateManager);
                        break;
                    }
                case "Change Template Manager":
                    {
                        GeneralPage.NavigateToCGWebFeaturesURL(moduleURLs.changeTemplateManager);
                        break;
                    }
                case "Flex1 Template Manager":
                    {
                        GeneralPage.NavigateToCGWebFeaturesURL(moduleURLs.flex1TemplateManager);
                        break;
                    }
                case "Flex2 Template Manager":
                    {
                        GeneralPage.NavigateToCGWebFeaturesURL(moduleURLs.flex2TemplateManager);
                        break;
                    }
                case "Incident Task Manager":
                    {
                        GeneralPage.NavigateToCGWebFeaturesURL(moduleURLs.incidentTaskManager);
                        break;
                    }
                case "Change Task Manager":
                    {
                        GeneralPage.NavigateToCGWebFeaturesURL(moduleURLs.changeTaskManager);
                        break;
                    }
                case "User Center":
                    {
                        GeneralPage.NavigateToCGWebFeaturesURL(moduleURLs.userCenter);
                        break;
                    }
                default:
                    {
                        log.Error("That module[" + module + "] doesn't exist. Check the feature file for errors");
                        Assert.Fail("That module[" + module + "] doesn't exist. Check the feature file for errors");
                        break;
                    }
            }
        }

        public static void NavigateToTicketURLSwitch(string module, int ticketNum)
        {
            switch (module)
            {
                case "Incident":
                    {
                        GeneralPage.NavigateToTicketURL(moduleURLs.incident, ticketNum);
                        break;
                    }
                case "Incident task":
                    {
                        GeneralPage.NavigateToTicketURL(moduleURLs.incidentTask, ticketNum);
                        break;
                    }
                case "Problem":
                    {
                        GeneralPage.NavigateToTicketURL(moduleURLs.problem, ticketNum);
                        break;
                    }
                case "Change":
                    {
                        GeneralPage.NavigateToTicketURL(moduleURLs.change, ticketNum);
                        break;
                    }
                case "Change task":
                    {
                        GeneralPage.NavigateToTicketURL(moduleURLs.changeTask, ticketNum);
                        break;
                    }
                case "Flex1":
                    {
                        GeneralPage.NavigateToTicketURL(moduleURLs.flex1, ticketNum);
                        break;
                    }
                case "Flex2":
                    {
                        GeneralPage.NavigateToTicketURL(moduleURLs.flex2, ticketNum);
                        break;
                    }
                case "Announcement":
                    {
                        GeneralPage.NavigateToTicketURL(moduleURLs.announcement, ticketNum);
                        break;
                    }
                case "Knowledge Base":
                    {
                        GeneralPage.NavigateToKBTicketURL(ticketNum);
                        break;
                    }
                case "Survey":
                    {
                        GeneralPage.NavigateToOtherTicketEntitiesURL(moduleURLs.surveyTicketURL, ticketNum);
                        break;
                    }
                case "Report":
                    {
                        GeneralPage.NavigateToOtherTicketEntitiesURL(moduleURLs.reportURL, ticketNum);
                        break;
                    }
                case "CMDB":
                    {
                        GeneralPage.NavigateToOtherTicketEntitiesURL(moduleURLs.ciURL, ticketNum);
                        break;
                    }
                default:
                    {
                        log.Error("This module[" + module + "] does not exist. Check the feature file for errors.");
                        Assert.Fail("This module[" + module + "] does not exist. Check the feature file for errors.");
                        break;
                    }
            }
        }

        public static void AmIOnTicketPageSwitch(string module, string ticketNum)
        {
            switch (module)
            {
                case "Incident":
                    {
                        IncidentPage.AmIOnPage();
                        IncidentPage.IsTicketNumberCorrect(ticketNum);
                        break;
                    }
                case "Incident task":
                    {
                        IncidentTaskPage.AmIOnPage();
                        IncidentTaskPage.IsTicketNumberCorrect(ticketNum);
                        break;
                    }
                case "Problem":
                    {
                        ProblemPage.AmIOnPage();
                        ProblemPage.IsTicketNumberCorrect(ticketNum);
                        break;
                    }
                case "Change":
                    {
                        ChangePage.AmIOnPage();
                        ChangePage.IsTicketNumberCorrect(ticketNum);
                        break;
                    }
                case "Change task":
                    {
                        ChangeTaskPage.AmIOnPage();
                        ChangeTaskPage.IsTicketNumberCorrect(ticketNum);
                        break;
                    }
                case "Flex1":
                    {
                        FlexPage.AmIOnPage(module);
                        FlexPage.IsTicketNumberCorrect(module, ticketNum);
                        break;
                    }
                case "Flex2":
                    {
                        FlexPage.AmIOnPage(module);
                        FlexPage.IsTicketNumberCorrect(module, ticketNum);
                        break;
                    }
                case "Announcement":
                    {
                        AnnouncementPage.AmIOnPage();
                        break;
                    }
                case "Knowledge Base":
                    {
                        KBPage.AmIOnPage(ticketNum);
                        break;
                    }
                case "Survey":
                    {
                        SurveyPage.AmIOnPage();
                        break;
                    }
                case "Report":
                    {
                        ReportsPage.AmIOnPage();
                        break;
                    }
                case "CI":
                    {
                        CIPage.AmIOnPage(ticketNum);
                        break;
                    }
                default:
                    {
                        log.Error("This module[" + module + "] does not exist. Check the feature file for errors.");
                        Assert.Fail("This module[" + module + "] does not exist. Check the feature file for errors.");
                        break;
                    }
            }
        }

        public static void AmIOnPageSwitch(string page)
        {

            switch (page)
            {
                case "Logged Out":
                    {
                        LoginPage.AmIOnLoggedOutPage();
                        break;
                    }
                case "Logged In":
                    {
                        LoginPage.AmIOnPage();
                        break;
                    }
                case "Announcement Portal":
                    {
                        AnnouncementPortalPage.AmIOnPage();
                        break;
                    }
                case "SSP":
                    {
                        SSPPage.AmIOnPage();
                        break;
                    }
                case "Announcement Manager":
                    {
                        AnnouncementManagerPage.AmIOnPage();
                        break;
                    }
                case "Incident Template Manager":
                    {
                        TemplateManagerPage.AmIOnPage(page);
                        break;
                    }
                case "Problem Template Manager":
                    {
                        TemplateManagerPage.AmIOnPage(page);
                        break;
                    }
                case "Change Template Manager":
                    {
                        TemplateManagerPage.AmIOnPage(page);
                        break;
                    }
                case "Flex1 Template Manager":
                    {
                        TemplateManagerPage.AmIOnPage(page);
                        break;
                    }
                case "Flex2 Template Manager":
                    {
                        TemplateManagerPage.AmIOnPage(page);
                        break;
                    }
                case "Incident Task Manager":
                    {
                        TaskManagerPage.AmIOnPage(page);
                        break;
                    }
                case "Change Task Manager":
                    {
                        TaskManagerPage.AmIOnPage(page);
                        break;
                    }
                case "User Center":
                    {
                        UserCenterPage.AmIOnPage();
                        break;
                    }
                default:
                    {
                        log.Error("This page[" + page + "] does not exist. Check the feature file for errors.");
                        Assert.Fail("This page[" + page + "] does not exist. Check the feature file for errors.");
                        break;
                    }
            }
        }

        public static void AmIOnGridPageSwitch(string modulePage)
        {
            if (modulePage.Contains("Flex"))
            {
                //Determine if Flex module is valid
                bool moduleValid = false;
                for (int i = 1; i < 10; i++)
                {
                    if (modulePage == ("Flex" + i))
                    {
                        moduleValid |= true;
                        break;
                    }
                }
                if (!moduleValid)
                {
                    log.Error("This module[" + modulePage + "] does not exist. Check the feature file for errors.");
                    Assert.Fail("This module[" + modulePage + "] does not exist. Check the feature file for errors.");
                    return;
                }
                //Verify if i'm on the correct Flex page
                FlexModulePage.AmIOnPage(modulePage);
                return;
            }
            switch (modulePage)
            {
                case "Incident":
                    {
                        IncidentModulePage.AmIOnPage();
                        break;
                    }
                case "Problem":
                    {
                        ProblemModulePage.AmIOnPage();
                        break;
                    }
                case "Change":
                    {
                        ChangeModulePage.AmIOnPage();
                        break;
                    }
                case "Service Catalog":
                    {
                        ServiceCatalogPage.AmIOnPage();
                        break;
                    }
                case "CMDB":
                    {
                        CMDBModulePage.AmIOnPage();
                        break;
                    }
                case "Knowledge Base":
                    {
                        KBModulePage.AmIOnPage();
                        break;
                    }
                case "Survey":
                    {
                        SurveyModulePage.AmIOnPage();
                        break;
                    }
                case "Reports":
                    {
                        ReportsModulePage.AmIOnPage();
                        break;
                    }
                case "Service Request":
                    {
                        ServiceRequestModulePage.AmIOnPage();
                        break;
                    }
                default:
                    {
                        log.Error("This module[" + modulePage + "] does not exist. Check the feature file for errors.");
                        Assert.Fail("This module[" + modulePage + "] does not exist. Check the feature file for errors.");
                        break;
                    }
            }
        }
    }
}
