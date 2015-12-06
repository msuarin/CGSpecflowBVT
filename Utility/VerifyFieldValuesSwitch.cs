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
    public static class VerifyFieldValuesSwitch
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(VerifyFieldValuesSwitch)));

        public static void VerifyFieldValues(string module, ModuleData data)
        {
            string moduleSelected = module;
            if (module.Contains("Flex"))
            {
                //Determine if Flex module is valid
                bool moduleValid = false;
                for (int i = 1; i < 10; i++)
                {
                    if (module == ("Flex" + i))
                    {
                        moduleValid |= true;
                        break;
                    }
                }
                if (!moduleValid)
                {
                    log.Error("This module[" + module + "] does not exist. Check the feature file for errors.");
                    Assert.Fail("This module[" + module + "] does not exist. Check the feature file for errors.");
                    return;
                }
                //Set module name to Flex
                moduleSelected = "Flex";
            }

            switch (moduleSelected)
            {
                case "Incident":
                    {
                        IncidentPage.VerifyTicketFieldValues(data);
                        break;
                    }
                case "Problem":
                    {
                        ProblemPage.VerifyTicketFieldValues(data);
                        break;
                    }
                case "Change":
                    {
                        ChangePage.VerifyTicketFieldValues(data);
                        break;
                    }
                case "Flex":
                    {
                        FlexPage.VerifyTicketFieldValues(data);
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

        public static void VerifySRFieldValues(string ticketType, ServiceRequestData data)
        {
            ServiceRequestPage.VerifyTicketFieldValues(ticketType, data);
        }
    }
}
