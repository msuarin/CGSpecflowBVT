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
    public static class ReportsPage
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(ReportsPage)));
        public static ReportIDs ID = new ReportIDs();

        public static void AmIOnPage()
        {
            Assert.IsTrue(IsGeneratedMessageVisible());
        }

        private static bool IsGeneratedMessageVisible()
        {
            GeneralPage.SwitchToFrame(ID.reportFrame);
            if (!(GeneralPage.IsElementVisible(ID.generatedMessage)))
            {
                log.Info("Reports generated message was not found.");
            }
            else
            {
                log.Info("Reports generated message was found.");
            }

            return GeneralPage.IsElementVisible(ID.generatedMessage);
        }
    }
}
