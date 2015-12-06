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
    public static class IncidentTaskPage
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(IncidentTaskPage)));
        public static IncidentIDs ID = new IncidentIDs();

        public static void AmIOnPage()
        {
            Assert.IsTrue(IsWindowTitleVisible());
        }

        public static void IsTicketNumberCorrect(string ticketNum)
        {
            Assert.IsTrue(IsWindowTitleTicketNumberVisible(ticketNum));
            Assert.IsTrue(IsFormTicketNumberVisible(ticketNum));
        }

        private static bool IsWindowTitleVisible()
        {
            log.Info("Window Title is: " + GeneralPage.GetWindowTitle());
            bool incidentTaskFormTitleFound = GeneralPage.GetWindowTitle().Contains("Incident Task");

            if (!(incidentTaskFormTitleFound))
            {
                log.Info("Incident task form window title was not found.");
            }
            else
            {
                log.Info("Incident task form window title was found.");
            }
            return incidentTaskFormTitleFound;
        }

        private static bool IsWindowTitleTicketNumberVisible(string ticketNum)
        {
            bool isTicketNumberVisible = GeneralPage.GetWindowTitle().Contains(ticketNum);

            if (!(isTicketNumberVisible))
            {
                log.Info("Incident task form window title ticket number was not found.");
            }
            else
            {
                log.Info("Incident task form window title ticket number was found.");
            }
            return isTicketNumberVisible;
        }

        private static bool IsFormTicketNumberVisible(string ticketNum)
        {
            bool isTicketNumberVisible = GeneralPage.ExtractTextFromElement(ID.ticketInfo).Contains(ticketNum);
            isTicketNumberVisible &= GeneralPage.ExtractTextFromElement(ID.ticketInfo).Contains("TSK");

            if (!(isTicketNumberVisible))
            {
                log.Info("Incident task form ticket details ticket number was not found.");
            }
            else
            {
                log.Info("Incident task form ticket details ticket number was found.");
            }
            return isTicketNumberVisible;
        }
    }
}
