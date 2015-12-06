using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using CGSpecFlowBVT.Data_Objects;
using CGSpecFlowBVT.Page_Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CGSpecFlowBVT.Utility
{
    public static class CreateTicketSwitch
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(CreateTicketSwitch)));

        public static void CreateTicket(string module, ModuleData data)
        {
            switch (module)
            {
                case "Incident":
                    {
                        TicketPage.FillInTicketFields(module, data);
                        break;
                    }
                case "Problem":
                    {
                        break;
                    }
                default:
                    {
                        log.Error("This module[" + module + "] does not exist. Check the feature file for errors.");
                        Assert.Fail("This module[" + module + "] does not exist. Check the feature file for errors.");
                        break;
                    }
            }
        }
    }
}
