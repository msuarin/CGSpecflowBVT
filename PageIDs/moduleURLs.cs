using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGSpecFlowBVT.PageIDs
{
    public static class moduleURLs
    {
        //Modules
        public static string main = "Main.aspx";
        public static string incident = "?ModuleName=Incident";
        public static string incidentTask = "?ModuleName=Incident Tasks";
        public static string problem = "?ModuleName=Problem";
        public static string change = "?ModuleName=Change";
        public static string changeTask = "?ModuleName=Tasks";
        public static string flex1 = "?ModuleName=Flex1";
        public static string flex2 = "?ModuleName=Flex2";
        public static string iCenter = "?ModuleName=iCenter";
        public static string KB = "?ModuleName=Knowledge Base";
        public static string announcement = "?ModuleName=Announcements";
        public static string survey = "?ModuleName=Survey";
        public static string reports = "?ModuleName=Reports";
        public static string cmdb = "?ModuleName=CMDB";
        public static string serviceCatalog = "?ModuleName=ServiceCatalog";

        //Announcement portal
        public static string announcementPortal = @"Announce/ViewAnnounce.aspx";

        //SSP URL
        public static string ssp = "CGClient/SSP/Index.aspx";

        //Announcement Manager
        public static string announcementManager =
            @"/MainUI/Common/Modules/BaseModule.aspx?view=All%20Announcements&moduleName=Announcements&EntityManager=true";

        //Template Managers
        public static string incidentTemplateManager =
            @"/MainUI/Templates/TemplateModule.aspx?view=Incident%20Templates&moduleName=Templates&EntityManager=true&text=Incident%20Templates&OpenMode=popup";
        public static string problemTemplateManager =
            @"/MainUI/Templates/TemplateModule.aspx?view=Problem%20Templates&moduleName=Templates&EntityManager=true&text=Problem%20Templates&OpenMode=popup";
        public static string changeTemplateManager =
            @"/MainUI/Templates/TemplateModule.aspx?view=Change%20Templates&moduleName=Templates&EntityManager=true&text=Change%20Templates&OpenMode=popup";
        public static string flex1TemplateManager =
            @"/MainUI/Templates/TemplateModule.aspx?view=Flex1%20Templates&moduleName=Templates&EntityManager=true&text=Flex1%20Templates&OpenMode=popup";
        public static string flex2TemplateManager =
            @"/MainUI/Templates/TemplateModule.aspx?view=Flex2%20Templates&moduleName=Templates&EntityManager=true&text=Flex2%20Templates&OpenMode=popup";

        //Task Managers
        public static string incidentTaskManager =
            @"/MainUI/Common/Modules/BaseModule.aspx?view=My%20Incident%20Tasks&moduleName=Incident%20Tasks&EntityManager=true&text=My%20Incident%20Tasks&OpenMode=popup";
        public static string changeTaskManager =
            @"/MainUI/Common/Modules/BaseModule.aspx?view=My%20Tasks&moduleName=Tasks&EntityManager=true&text=My%20Tasks&OpenMode=popup";

        //User Center
        public static string userCenter =
            @"/MainUI/Common/UserCenter.aspx?boundtable=IPerson&moduleName=User%20Center&text=User%20Center";

        //KB ticket URL
        public static string kbTicketURL =
            @"/CGWeb/MainUI/Print/PrintFrame.aspx?boundtable=IKBArticle&column=ID&columnValue=";

        //Survey ticket URL
        public static string surveyTicketURL =
            @"/Survey/SurveyCompletionEditPanel.aspx?boundTable=ISurvey";

        //Report URL
        public static string reportURL =
            @"/Reports/ViewReport.aspx?boundtable=IReportEntity&DateRange=All&Width=1363&Height=660&IsStandAlone=false";
        //CI URL
        public static string ciURL =
            @"/CMDB/ResourceDetails.aspx?boundtable=IManagedResource&HideStaticActions=Print,Save,New,Duplicate&CloseOnPerformAction=false&windowWidth=730&openTime=1396982269279";
    }
}
