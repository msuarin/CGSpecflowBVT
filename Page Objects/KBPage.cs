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
    public static class KBPage
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(KBPage)));
        public static KBIDs ID = new KBIDs();

        public static void AmIOnPage(string ticketNum)
        {
            Assert.IsTrue(IsPageTicketNumberVisible(ticketNum));
        }

        private static bool IsPageTicketNumberVisible(string ticketNum)
        {
            GeneralPage.SwitchToFrame(ID.kbArticleFrame);
            bool isTicketNumberVisible = GeneralPage.ExtractTextFromElement(ID.ticketInfo).Contains(ticketNum);
            isTicketNumberVisible &= GeneralPage.ExtractTextFromElement(ID.ticketInfo).Contains("KB");

            if (!(isTicketNumberVisible))
            {
                log.Info("KB ticket details ticket number was not found.");
            }
            else
            {
                log.Info("KB ticket details ticket number was found.");
            }
            return isTicketNumberVisible;
        }
    }
}
