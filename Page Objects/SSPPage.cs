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
    public static class SSPPage
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(IncidentPage)));
        public static SSPIDs ID = new SSPIDs();

        public static void AmIOnPage()
        {
            bool sspButtonsVisible = true;

            // Check to see if the My Request button exists
            sspButtonsVisible &= GeneralPage.IsElementVisible(ID.requestHelpBtn);

            if (sspButtonsVisible)
            {
                log.Info("SSP buttons were found.");
            }
            else
            {
                log.Error("One or more SSP buttons were not found.");
                Assert.Fail("One or more SSP buttons were not found.");
            }
        }
    }
}
