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
    class FlexModulePage
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(FlexModulePage)));
        public static FlexIDs ID = new FlexIDs();

        public static void NavigateToURL(string flexNumber)
        {
            string flexType = flexNumber;
            if (flexType == "Flex1")
            {
                GeneralPage.NavigateToURL(moduleURLs.main);
            }
            else
            {
                GeneralPage.NavigateToURL(moduleURLs.main);
            }
        }

        public static void AmIOnPage(string flexNumber)
        {
            Assert.IsTrue(IsPageTitleVisible(flexNumber));
            Assert.IsTrue(IsViewLinkVisible());
        }

        private static bool IsPageTitleVisible(string flexNumber)
        {
            string flexType = flexNumber;
            if (flexType == "Flex1")
            {
                if (!(GeneralPage.IsElementVisible(ID.GenerateFlexPageTitleXPath(flexType))))
                {
                    log.Error(flexType + " page title was not found.");
                }
                else
                {
                    log.Info(flexType + " page title was found.");
                }

                return GeneralPage.IsElementVisible(ID.GenerateFlexPageTitleXPath(flexType));
            }
            else
            {
                if (!(GeneralPage.IsElementVisible(ID.GenerateFlexPageTitleXPath(flexType))))
                {
                    log.Error(flexType + " page title was not found.");
                }
                else
                {
                    log.Info(flexType + " page title was found.");
                }

                return GeneralPage.IsElementVisible(ID.GenerateFlexPageTitleXPath(flexType));
            }
        }

        private static bool IsViewLinkVisible()
        {
            if (!(GeneralPage.IsElementVisible(ID.allTicketsView)))
            {
                log.Info("All Tickets view was not found.");
            }
            else
            {
                log.Info("All Tickets view was found.");
            }

            return GeneralPage.IsElementVisible(ID.allTicketsView);
        }
    }
}
