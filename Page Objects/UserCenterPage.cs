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
    public static class UserCenterPage
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(UserCenterPage)));
        public static UserCenterIDs ID = new UserCenterIDs();

        public static void AmIOnPage()
        {
            // Assert.IsTrue(IsWindowTitleVisible());
           //  Assert.IsTrue(IsPageTitleVisible());
            Assert.IsTrue(IsProfileTabVisible());
            Assert.IsTrue(IsRequestTypeVisible());
        }

        private static bool IsWindowTitleVisible()
        {
            log.Info("Window Title is: " + GeneralPage.GetWindowTitle());
            bool userCenterWindowTitleFound = GeneralPage.GetWindowTitle().Contains("User Center");

            if (!(userCenterWindowTitleFound))
            {
                log.Info("User Center window title was not found.");
            }
            else
            {
                log.Info("User Center window title was found.");
            }
            return userCenterWindowTitleFound;
        }

        private static bool IsPageTitleVisible()
        {
            bool userCenterPageTitleFound = GeneralPage.ExtractTextFromElement(ID.userCenterTitle).Contains("User Center");
            if (!(userCenterPageTitleFound))
            {
                log.Info("User Center Page title was not found.");
            }
            else
            {
                log.Info("User Center Page title was found.");
            }
            return userCenterPageTitleFound;
        }

        private static bool IsProfileTabVisible()
        {
            bool profileTabFound = GeneralPage.IsElementVisible(ID.profileTab);
            if (!(profileTabFound))
            {
                log.Info("User Center Profile tab was not found.");
            }
            else
            {
                log.Info("User Center Profile tab was found.");
            }
            return profileTabFound;
        }

        private static bool IsRequestTypeVisible()
        {
            bool requestTypeFound = GeneralPage.IsElementVisible(ID.requestType);
            if (!(requestTypeFound))
            {
                log.Info("User Center Request Type was not found.");
            }
            else
            {
                log.Info("User Center Request Type was found.");
            }
            return requestTypeFound;
        }
    }
}
