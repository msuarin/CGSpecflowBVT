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
    public static class AnnouncementPortalPage
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(AnnouncementPortalPage)));
        public static AnnouncementIDs ID = new AnnouncementIDs();

        public static void AmIOnPage()
        {
            //Might need to check more elements. This is only checking the title on top of the page
            Assert.IsTrue(IsPageTitleVisible());
        }

        private static bool IsPageTitleVisible()
        {

            if (!(GeneralPage.IsElementVisible(ID.AnnouncementPortalPageTitle)))
            {
                log.Info("Announcement Portal page title was not found.");
            }
            else
            {
                log.Info("Announcement Portal page title was found.");
            }

            return GeneralPage.IsElementVisible(ID.AnnouncementPortalPageTitle);
        }
    }
}
