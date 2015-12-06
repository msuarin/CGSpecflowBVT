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
    public static class CIPage
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(CIPage)));
        public static CMDBIDs ID = new CMDBIDs();

        public static void AmIOnPage(string ciNum)
        {
            Assert.IsTrue(AreCIFormElementsVisible(ciNum));
        }

        private static bool AreCIFormElementsVisible(string ciNum)
        {
            bool areElementsVisible = GeneralPage.IsElementVisible(ID.ciField);
            areElementsVisible &= GeneralPage.IsElementVisible(ID.configurationTab);
            areElementsVisible &= GeneralPage.IsElementVisible(ID.relationshipsTab);
            areElementsVisible &= GeneralPage.ExtractTextFromElement(ID.ticketInfo).Contains(ciNum);

            if (!(areElementsVisible))
            {
                log.Error("One or more CI form elements were not found.");
            }
            else
            {
                log.Info("All CI form elements were found.");
            }

            return areElementsVisible;
        }
    }
}
