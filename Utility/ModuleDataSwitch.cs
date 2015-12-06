using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CGSpecFlowBVT.Data_Objects;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using log4net;

namespace CGSpecFlowBVT.Utility
{
    public static class ModuleDataSwitch
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(ModuleDataSwitch)));

        public static ModuleData CreateModuleDataObject(string module, Table table)
        {
            ModuleData data = null;
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
                    return data;
                }
                //Create the flex data object
                data = table.CreateInstance<FlexData>();
                return data;
            }

            switch (module)
            {
                case "Incident":
                    {
                        data = table.CreateInstance<IncidentData>();
                        break;
                    }
                case "Problem":
                    {
                        data = table.CreateInstance<ProblemData>();
                        break;
                    }
                case "Change":
                    {
                        data = table.CreateInstance<ChangeData>();
                        break;
                    }
                default:
                    {
                        log.Error("This module[" + module + "] does not exist. Check the feature file for errors.");
                        Assert.Fail("This module[" + module + "] does not exist. Check the feature file for errors.");
                        break;
                    }
            }
            return data;
        }

        public static ModuleData CreateSRModuleDataObject(string ticketType, Table table)
        {
            bool requiredFieldsComplete = true;
            ModuleData data = table.CreateInstance<ServiceRequestData>();

            //Verify if all the required fields are present
            requiredFieldsComplete &= (data.Requester != null);
            requiredFieldsComplete &= (data.Summary != null);

            if (ticketType == "Move Request")
            {
                requiredFieldsComplete &= (((ServiceRequestData)data).EmployeeName != null);
                requiredFieldsComplete &= (((ServiceRequestData)data).EmployeeType != null);
                requiredFieldsComplete &= (((ServiceRequestData)data).Position != null);
                requiredFieldsComplete &= (((ServiceRequestData)data).CurrentLocation != null);
                requiredFieldsComplete &= (((ServiceRequestData)data).NewLocation != null);
                requiredFieldsComplete &= (((ServiceRequestData)data).CurrentCubeOrOffice != null);
                requiredFieldsComplete &= (((ServiceRequestData)data).NewCubeOrOffice != null);
                requiredFieldsComplete &= (((ServiceRequestData)data).CurrentPhoneExt != null);
                requiredFieldsComplete &= (((ServiceRequestData)data).NewPhoneExt != null);

                if (!requiredFieldsComplete)
                {
                    Assert.Fail("One or more required fields for move request was not found. Check the feature file for errors");
                    log.Info("One or more required fields for move request was not found. Check the feature file for errors");
                    return (data = null);
                }
                return data;
            }
            else
            {
                requiredFieldsComplete &= (data.Urgency != null);
                requiredFieldsComplete &= (data.Impact != null);
                requiredFieldsComplete &= (data.Priority != null);

                switch (ticketType)
                {
                    case "Access Request":
                        {
                            requiredFieldsComplete &= (((ServiceRequestData)data).System != null);
                            requiredFieldsComplete &= (((ServiceRequestData)data).AccessLevel != null);
                            requiredFieldsComplete &= (((ServiceRequestData)data).AccessLocation != null);
                            break;
                        }
                    case "General Request":
                        {
                            break;
                        }
                    case "Hardware Request":
                        {
                            requiredFieldsComplete &= (((ServiceRequestData)data).HardwareType != null);
                            requiredFieldsComplete &= (((ServiceRequestData)data).OperatingSystem != null);
                            break;
                        }
                    case "Software Request":
                        {
                            requiredFieldsComplete &= (((ServiceRequestData)data).RequestedSoftware != null);
                            requiredFieldsComplete &= (((ServiceRequestData)data).OperatingSystem != null);
                            break;
                        }
                    case "Training Request":
                        {
                            requiredFieldsComplete &= (((ServiceRequestData)data).CourseName != null);
                            requiredFieldsComplete &= (((ServiceRequestData)data).ProgramType != null);
                            requiredFieldsComplete &= (((ServiceRequestData)data).TrainingLevel != null);
                            requiredFieldsComplete &= (((ServiceRequestData)data).CourseCost != null);
                            break;
                        }
                    default:
                        {
                            log.Info("Unrecognized Service request type. Check the feature file for errors.");
                            Assert.Fail("Unrecognized Service request type. Check the feature file for errors.");
                            break;
                        }
                }

                if (!requiredFieldsComplete)
                {
                    Assert.Fail("One or more required fields for " + ticketType + 
                        " was not found. Check the feature file for errors");
                    log.Info("One or more required fields for " + ticketType + 
                        " was not found. Check the feature file for errors");
                    return (data = null);
                }
                return data;
            }
        }
    }
}
