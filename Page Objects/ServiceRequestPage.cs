using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using CGSpecFlowBVT.PageIDs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CGSpecFlowBVT.Data_Objects;
using System.Collections;

namespace CGSpecFlowBVT.Page_Objects
{
    public static class ServiceRequestPage
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(ServiceRequestPage)));
        public static ServiceRequestIDs ID = new ServiceRequestIDs();

        public static void VerifyTicketFieldValues(string ticketType, ServiceRequestData data)
        {
            log.Info("Verifying if " + ticketType + " values are correct...");
            bool valuesMatch = true;
            var dictionary = new Dictionary<string, bool>();
            dictionary.Add("Requester", (data.Requester == GeneralPage.ExtractValueFromElement(ID.requesterValue)));
            dictionary.Add("Summary", (data.Summary == GeneralPage.ExtractValueFromElement(ID.Summary)));

            //string[] typeHierarchyListExpected = (data.Type).Split(':');
            //string[] typeHierarchyListActual = (GeneralPage.ExtractValueFromElement(ID.TicketTypeValue)).Split(':');
            //bool numTypeLevelsMatch = (typeHierarchyListActual.Count() == typeHierarchyListExpected.Count());
            //valuesMatch &= numTypeLevelsMatch;
            //bool typeLevelMatch = true;
            //if (numTypeLevelsMatch)
            //{
            //    for (int i = 0; i < typeHierarchyListExpected.Count(); i++)
            //    {
            //        typeLevelMatch &= typeHierarchyListActual[i].Contains(typeHierarchyListExpected[i]);
            //    }
            //}
            //else
            //    log.Info("Type levels do not match");

            //dictionary.Add("Type", typeLevelMatch);
            if (ticketType == "Move Request")
            {

                dictionary.Add("Employee Name", (data.EmployeeName == GeneralPage.ExtractValueFromElement(ID.employeeName)));
                dictionary.Add("Employee Type", (((ServiceRequestData)data).EmployeeType == GeneralPage.ExtractValueFromElement(ID.employeeType)));
                dictionary.Add("Position", (((ServiceRequestData)data).Position == GeneralPage.ExtractValueFromElement(ID.position)));
                dictionary.Add("Current Cube or Office", (((ServiceRequestData)data).CurrentCubeOrOffice == GeneralPage.ExtractValueFromElement(ID.currentCubeOffice)));
                dictionary.Add("New Cube or Office", (((ServiceRequestData)data).NewCubeOrOffice == GeneralPage.ExtractValueFromElement(ID.newCubeOffice)));
                dictionary.Add("Current Phone Ext", (((ServiceRequestData)data).CurrentPhoneExt == GeneralPage.ExtractValueFromElement(ID.currentPhoneExt)));
                dictionary.Add("New Phone Ext", (((ServiceRequestData)data).NewPhoneExt == GeneralPage.ExtractValueFromElement(ID.newPhoneExt)));
                dictionary.Add("Current Location", VerifyHierarchyField(data, "CurrentLocation"));
                dictionary.Add("New Location", VerifyHierarchyField(data, "NewLocation"));
            }
            else
            {
                switch (ticketType)
                {
                    case "Access Request":
                        {
                            dictionary.Add("System", ((ServiceRequestData)data).System == GeneralPage.ExtractTextFromElement(ID.systemValue));
                            dictionary.Add("Access Level", ((ServiceRequestData)data).AccessLevel == GeneralPage.ExtractTextFromElement(ID.accessLevelValue));
                            dictionary.Add("Access Location", ((ServiceRequestData)data).AccessLocation == GeneralPage.ExtractTextFromElement(ID.accessLocationValue));
                            break;
                        }
                    case "General Request":
                        {
                            break;
                        }
                    case "Hardware Request":
                        {
                            dictionary.Add("Hardware Type", ((ServiceRequestData)data).HardwareType == GeneralPage.ExtractTextFromElement(ID.hardwareTypeValue));
                            dictionary.Add("Operating System", ((ServiceRequestData)data).OperatingSystem == GeneralPage.ExtractTextFromElement(ID.operatingSystemValue));
                            break;
                        }
                    case "Software Request":
                        {
                            dictionary.Add("Requested Software", ((ServiceRequestData)data).RequestedSoftware == GeneralPage.ExtractTextFromElement(ID.requestedSoftwareValue));
                            dictionary.Add("Operating System", ((ServiceRequestData)data).OperatingSystem == GeneralPage.ExtractTextFromElement(ID.operatingSystemValue));
                            break;
                        }
                    case "Training Request":
                        {
                            dictionary.Add("Course Name", data.CourseName == GeneralPage.ExtractValueFromElement(ID.coursenameTextbox));
                            dictionary.Add("Program Type", data.ProgramType == GeneralPage.ExtractTextFromElement(ID.programTypeValue));
                            dictionary.Add("Training Level", data.TrainingLevel == GeneralPage.ExtractTextFromElement(ID.trainingLevelValue));
                            dictionary.Add("Course Cost", data.CourseCost == GeneralPage.ExtractValueFromElement(ID.courseCostTextbox));
                            break;
                        }
                    default:
                        {
                            log.Info("Unrecognized Service request type. Check the feature file for errors.");
                            Assert.Fail("Unrecognized Service request type. Check the feature file for errors.");
                            break;
                        }
                }
                dictionary.Add("Impact", (data.Impact == GeneralPage.ExtractTextFromElement(ID.impactValue)));
                dictionary.Add("Urgency", (data.Urgency == GeneralPage.ExtractTextFromElement(ID.urgencyValue)));
                dictionary.Add("Priority", (data.Priority == GeneralPage.ExtractTextFromElement(ID.priorityValue)));
            }

            foreach (KeyValuePair<string, bool> entry in dictionary)
            {
                log.Info(entry.Key + ": " + entry.Value);
                valuesMatch &= entry.Value;
            }

            if (!valuesMatch)
                log.Error("One or more field values do not match. Check the logs above to see which field is incorrect");

            Assert.IsTrue(valuesMatch);
        }

        private static bool VerifyHierarchyField(ServiceRequestData data, string fieldID)
        {
            string location = "";
            string locationXPath = "";
            if(fieldID == "CurrentLocation")
            {
                location = data.CurrentLocation;
                locationXPath = ID.currentLocationValue;
            }
            else if (fieldID == "NewLocation")
            {
                location = data.NewLocation;
                locationXPath = ID.newLocationValue;
            }
            else
            {
                log.Info("From the VerifyHierarchyField method of the ServiceRequestPage.cs file. Incorrect parameter passed: " + 
                    fieldID);
                Assert.Fail("From the VerifyHierarchyField method of the ServiceRequestPage.cs file. Incorrect parameter passed: " +
                    fieldID);
                return false;
            }

            //Verify if  is correct
            string[] typeHierarchyListExpected = location.Split(':');
            string[] typeHierarchyListActual = (GeneralPage.ExtractValueFromElement(locationXPath)).Split(':');
            bool numTypeLevelsMatch = (typeHierarchyListActual.Count() == typeHierarchyListExpected.Count());

            bool typeLevelMatch = true;
            if (numTypeLevelsMatch)
            {
                for (int i = 0; i < typeHierarchyListExpected.Count(); i++)
                {
                    typeLevelMatch &= typeHierarchyListActual[i].Contains(typeHierarchyListExpected[i]);
                }
            }
            else
            {
                typeLevelMatch &= numTypeLevelsMatch;
                log.Error("Type levels do not match. Check the Service request feature file for errors");
            }

            return typeLevelMatch;
        }
    }
}
