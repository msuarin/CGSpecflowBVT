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
    public static class AnnouncementManagerPage
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(AnnouncementManagerPage)));
        public static AnnouncementIDs ID = new AnnouncementIDs();

        public static void AmIOnPage()
        {
            Assert.IsTrue(IsWindowTitleVisible());
        }

        private static bool IsWindowTitleVisible()
        {
            log.Info("Window Title is: " + GeneralPage.GetWindowTitle());
            bool announcementManagerTitleFound = GeneralPage.GetWindowTitle().Contains("Announcement");

            if (!(announcementManagerTitleFound))
            {
                log.Info("Announcement Manager window title was not found.");
            }
            else
            {
                log.Info("Announcement Manager window title was found.");
            }
            return announcementManagerTitleFound;
        }
    }
}
