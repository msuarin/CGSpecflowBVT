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
    public static class AnnouncementPage
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(AnnouncementPage)));
        public static AnnouncementIDs ID = new AnnouncementIDs();

        public static void AmIOnPage()
        {
            Assert.IsTrue(IsWindowTitleVisible());
        }
        //Ticket number is  not displayed for Announcements
        //public static void IsTicketNumberCorrect(string ticketNum)
        //{
        //    Assert.IsTrue(IsWindowTitleTicketNumberVisible(ticketNum));
        //    Assert.IsTrue(IsFormTicketNumberVisible(ticketNum));
        //}

        private static bool IsWindowTitleVisible()
        {
            log.Info("Window Title is: " + GeneralPage.GetWindowTitle());
            bool announcementFormTitleFound = GeneralPage.GetWindowTitle().Contains("Announcement");

            if (!(announcementFormTitleFound))
            {
                log.Info("Announcement form window title was not found.");
            }
            else
            {
                log.Info("Announcement form window title was found.");
            }
            return announcementFormTitleFound;
        }

        //private static bool IsWindowTitleTicketNumberVisible(string ticketNum)
        //{
        //    bool isTicketNumberVisible = GeneralPage.GetWindowTitle().Contains(ticketNum);

        //    if (!(isTicketNumberVisible))
        //    {
        //        log.Info("Incident form window title ticket number was not found.");
        //    }
        //    else
        //    {
        //        log.Info("Incident form window title ticket number was found.");
        //    }
        //    return isTicketNumberVisible;
        //}

        //private static bool IsFormTicketNumberVisible(string ticketNum)
        //{
        //    bool isTicketNumberVisible = GeneralPage.ExtractTextFromElement(ID.ticketInfo).Contains(ticketNum);
        //    isTicketNumberVisible &= GeneralPage.ExtractTextFromElement(ID.ticketInfo).Contains("IR");

        //    if (!(isTicketNumberVisible))
        //    {
        //        log.Info("Incident form ticket details ticket number was not found.");
        //    }
        //    else
        //    {
        //        log.Info("Incident form ticket details ticket number was found.");
        //    }
        //    return isTicketNumberVisible;
        //}
    }
}
