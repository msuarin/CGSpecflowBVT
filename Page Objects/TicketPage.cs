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
    public static class TicketPage
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(TicketPage)));

        public static void FillInTicketFields(string module, ModuleData data)
        {
            dynamic ID = null;
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
                        ID = new IncidentIDs();
                        break;
                    }
                case "Problem":
                    {
                        ID = new ProblemIDs();
                        break;
                    }
                case "Change":
                    {
                        ID = new ChangeIDs();
                        break;
                    }
                case "Flex":
                    {
                        ID = new FlexIDs();
                        break;
                    }
                default:
                    {
                        Assert.Fail("Unknown module. Check the feature file for errors.");
                        break;
                    }
            }

            log.Info("Selecting the requester: " + data.Requester);
            GeneralPage.ClickOnObject(ID.requester);
            GeneralPage.ClickOnObject(ID.GenerateRequesterXPath(data.Requester));

            log.Info("Sending summary text: " + data.Summary);
            GeneralPage.InputTextInTextbox(data.Summary, ID.Summary);

            log.Info("Selecting Ticket type: " + data.Type);
            GeneralPage.ClickOnObject(ID.typeArrow);
            SelectHierarchyField(data.Type, ID);

            log.Info("Selecting owner: " + data.Owner);
            GeneralPage.ClickOnObject(ID.owner);
            GeneralPage.ClickOnObject(ID.GenerateOwnerXPath(data.Owner));

            log.Info("Selecting assignee: " + data.Assignee);
            GeneralPage.ClickOnObject(ID.assignee);
            GeneralPage.ClickOnObject(ID.GenerateAssigneeXPath(data.Assignee));

            log.Info("Selecting Impact: " + data.Impact);
            GeneralPage.SelectOptionFromDropdown(ID.impactDropdown, data.Impact);

            log.Info("Selecting Urgency: " + data.Urgency);
            GeneralPage.SelectOptionFromDropdown(ID.urgencyDropdown, data.Urgency);

            log.Info("Selecting Priority: " + data.Priority);
            GeneralPage.SelectOptionFromDropdown(ID.priorityDropdown, data.Priority);

            log.Info("Selecting Today as Due Date");
            GeneralPage.ClickOnObject(ID.dueDateButton);
            GeneralPage.ClickOnObject(ID.calendarToday);

            if (data is IncidentData)
            {
                log.Info(((IncidentData)data).Origin);
                log.Info(((IncidentData)data).ImpactedBusinessServices);
            }
            
        }

        public static void FillInSRTicketFields(string srType, ModuleData data)
        {
            ServiceRequestIDs ID = new ServiceRequestIDs();

            log.Info("Selecting the requester: " + data.Requester);
            GeneralPage.ClickOnObject(ID.requester);
            GeneralPage.ClickOnObject(ID.GenerateRequesterXPath(data.Requester));

            log.Info("Sending summary text: " + data.Summary);
            GeneralPage.InputTextInTextbox(data.Summary, ID.Summary);

            log.Info("Selecting Today as Due Date");
            GeneralPage.ClickOnObject(ID.dueDateButton);
            GeneralPage.ClickOnObject(ID.todayDate);

            if (srType == "Move Request")
            {
                log.Info("Sending Employee Name: " + ((ServiceRequestData)data).EmployeeName);
                GeneralPage.InputTextInTextbox(((ServiceRequestData)data).EmployeeName , ID.employeeName);

                log.Info("Sending Employee Type: " + ((ServiceRequestData)data).EmployeeType);
                GeneralPage.InputTextInTextbox(((ServiceRequestData)data).EmployeeType, ID.employeeType);

                log.Info("Sending Position: " + ((ServiceRequestData)data).Position);
                GeneralPage.InputTextInTextbox(((ServiceRequestData)data).Position, ID.position);

                log.Info("Sending Current Phone Ext : " + ((ServiceRequestData)data).CurrentPhoneExt);
                GeneralPage.InputTextInTextbox(((ServiceRequestData)data).CurrentPhoneExt, ID.currentPhoneExt);

                log.Info("Sending New Phone Ext : " + ((ServiceRequestData)data).NewPhoneExt);
                GeneralPage.InputTextInTextbox(((ServiceRequestData)data).NewPhoneExt, ID.newPhoneExt);

                log.Info("Sending Current Cube or Office: " + ((ServiceRequestData)data).CurrentCubeOrOffice);
                GeneralPage.InputTextInTextbox(((ServiceRequestData)data).CurrentCubeOrOffice, ID.currentCubeOffice);

                log.Info("Sending New Cube or Office: " + ((ServiceRequestData)data).NewCubeOrOffice);
                GeneralPage.InputTextInTextbox(((ServiceRequestData)data).NewCubeOrOffice, ID.newCubeOffice);

                log.Info("Selecting Current Location: " + ((ServiceRequestData)data).CurrentLocation);
                GeneralPage.ClickOnObject(ID.currentLocationArrow);
                SelectHierarchyLocationField(((ServiceRequestData)data).CurrentLocation, ID, "CurrentLocation");

                log.Info("Selecting New Location: " + ((ServiceRequestData)data).NewLocation);
                GeneralPage.ClickOnObject(ID.newLocationArrow);
                SelectHierarchyLocationField(((ServiceRequestData)data).NewLocation, ID, "NewLocation");

            }
            else
            {
                switch (srType)
                {
                    case "Access Request":
                        log.Info("Selecting System: " + ((ServiceRequestData)data).System);
                        GeneralPage.SelectOptionFromDropdown(ID.systemDropdown, ((ServiceRequestData)data).System);

                        log.Info("Selecting Access Level: " + ((ServiceRequestData)data).AccessLevel);
                        GeneralPage.SelectOptionFromDropdown(ID.accessLevelDropdown, ((ServiceRequestData)data).AccessLevel);

                        log.Info("Selecting Access Location: " + ((ServiceRequestData)data).AccessLocation);
                        GeneralPage.SelectOptionFromDropdown(ID.accessLocationDropdown, ((ServiceRequestData)data).AccessLocation);
                        break;
                    case "General Request":
                        break;
                    case "Hardware Request":
                        log.Info("Selecting Hardware Type: " + ((ServiceRequestData)data).HardwareType);
                        GeneralPage.SelectOptionFromDropdown(ID.hardwareTypeDropdown, ((ServiceRequestData)data).HardwareType);

                        log.Info("Selecting Operating System: " + ((ServiceRequestData)data).OperatingSystem);
                        GeneralPage.SelectOptionFromDropdown(ID.operatingSystemDropdown, ((ServiceRequestData)data).OperatingSystem);
                        break;
                    case "Software Request":
                        log.Info("Selecting Requested Software: " + ((ServiceRequestData)data).RequestedSoftware);
                        GeneralPage.SelectOptionFromDropdown(ID.requestedSoftwareDropdown, ((ServiceRequestData)data).RequestedSoftware);

                        log.Info("Selecting Operating System: " + ((ServiceRequestData)data).OperatingSystem);
                        GeneralPage.SelectOptionFromDropdown(ID.operatingSystemDropdown, ((ServiceRequestData)data).OperatingSystem);
                        break;
                    case "Training Request":
                        log.Info("Sending Course Name: " + ((ServiceRequestData)data).CourseName);
                        GeneralPage.InputTextInTextbox(((ServiceRequestData)data).CourseName, ID.coursenameTextbox);

                        log.Info("Sending Course Cost: " + ((ServiceRequestData)data).CourseCost);
                        GeneralPage.ClearTextbox(ID.courseCostTextbox);
                        GeneralPage.InputTextInTextbox(((ServiceRequestData)data).CourseCost, ID.courseCostTextbox);

                        log.Info("Selecting Program Type: " + ((ServiceRequestData)data).ProgramType);
                        GeneralPage.SelectOptionFromDropdown(ID.programTypeDropdown, ((ServiceRequestData)data).ProgramType);

                        log.Info("Selecting Training Level: " + ((ServiceRequestData)data).TrainingLevel);
                        GeneralPage.SelectOptionFromDropdown(ID.trainingLevelDropdown, ((ServiceRequestData)data).TrainingLevel);

                        log.Info("Selecting Today as Course Start Date");
                        GeneralPage.ClickOnObject(ID.courseStartDateButton);
                        GeneralPage.ClickOnObject(ID.courseStartTodayDate);

                        log.Info("Selecting Today as Course End Date");
                        GeneralPage.ClickOnObject(ID.courseEndDateButton);
                        GeneralPage.ClickOnObject(ID.courseEndTodayDate);
                        break;
                    default:
                        log.Info("Incorrect Service Request Type: " + srType +
                            ". See the feature file for errors");
                        Assert.Fail("Incorrect Service Request Type: " + srType +
                            ". See the feature file for errors");
                        break;
                }

                log.Info("Selecting Impact: " + data.Impact);
                GeneralPage.SelectOptionFromDropdown(ID.impactDropdown, data.Impact);

                log.Info("Selecting Urgency: " + data.Urgency);
                GeneralPage.SelectOptionFromDropdown(ID.urgencyDropdown, data.Urgency);

                log.Info("Selecting Priority: " + data.Priority);
                GeneralPage.SelectOptionFromDropdown(ID.priorityDropdown, data.Priority);
            }
        }

        private static void SelectHierarchyField(string type, dynamic ID)
        {
            int levels = type.Count(f => f == ':') + 1;
            string[] hierarchyList = type.Split(':');
            //foreach (string incidentType in typeHierarchyList)
            //{
            //    log.Info(incidentType);
            //}

            //Loop n many times where n is the number of levels
            for (int i = 1; i <= levels; i++)
            {
                //if you are in the deepest level, click on the actual item and not the + sign
                //if not in the deepest level, click on +
                if (i == levels)
                {
                    //click on item
                    log.Info("Clicking on item type: " + hierarchyList[i - 1]);
                    //Scroll down to the item before clicking it
                    GeneralPage.ScrollDownDropDownList(ID.GenerateHierarchyXPath(hierarchyList, i, levels));
                    GeneralPage.ClickOnObject(ID.GenerateHierarchyXPath(hierarchyList, i, levels));
                }
                else
                {
                    //Click on + sign
                    log.Info("Clicking + sign for: " + hierarchyList[i - 1]);
                    GeneralPage.ClickOnObject(ID.GenerateHierarchyXPath(hierarchyList, i, levels));
                }
            }
        }

        private static void SelectHierarchyLocationField(string type, dynamic ID, string fieldID)
        {
            int levels = type.Count(f => f == ':') + 1;
            string[] hierarchyList = type.Split(':');
            //foreach (string incidentType in typeHierarchyList)
            //{
            //    log.Info(incidentType);
            //}

            //Loop n many times where n is the number of levels
            for (int i = 1; i <= levels; i++)
            {
                //if you are in the deepest level, click on the actual item and not the + sign
                //if not in the deepest level, click on +
                if (i == levels)
                {
                    //click on item
                    log.Info("Clicking on item type: " + hierarchyList[i - 1]);
                    //Scroll down to the item before clicking it
                    GeneralPage.ScrollDownDropDownList(ID.GenerateHierarchyLocationXPath(hierarchyList, i, levels, fieldID));
                    GeneralPage.ClickOnObject(ID.GenerateHierarchyLocationXPath(hierarchyList, i, levels, fieldID));
                }
                else
                {
                    //Click on + sign
                    log.Info("Clicking + sign for: " + hierarchyList[i - 1]);
                    GeneralPage.ClickOnObject(ID.GenerateHierarchyLocationXPath(hierarchyList, i, levels, fieldID));
                }
            }
        }

        public static void ClickOkOnCommentPopup()
        {
            GeneralPageIDs ID = new GeneralPageIDs();
            GeneralPage.ClickOnObject(ID.okCommentPopup);
        }
    }
}
