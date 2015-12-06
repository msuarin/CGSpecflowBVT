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
    public static class IncidentPage
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(IncidentPage)));
        public static IncidentIDs ID = new IncidentIDs();

        public static void AmIOnPage()
        {
            Assert.IsTrue(IsWindowTitleVisible());
        }

        public static void IsTicketNumberCorrect(string ticketNum)
        {
            // Make sure window title has Incident and the ticket number
            Assert.IsTrue(IsWindowTitleVisible());
            Assert.IsTrue(IsWindowTitleTicketNumberVisible(ticketNum));

            // Also make sure the form has the ticket number field
            Assert.IsTrue(IsFormTicketNumberVisible(ticketNum));
        }

        //public static void FillInIncidentFields(string module, ModuleData data)
        //{
        //    log.Info("Selecting the requester: " + data.Requester);
        //    GeneralPage.ClickOnObject(ID.requester);
        //    GeneralPage.ClickOnObject(ID.GenerateRequesterXPath(data.Requester));

        //    log.Info("Sending summary text: " + data.Summary);
        //    GeneralPage.InputTextInTextbox(data.Summary, ID.summary);

        //    log.Info("Selecting Incident type: " + data.Type);
        //    GeneralPage.ClickOnObject(ID.incidentTypeArrow);
        //    SelectIncidentType(data.Type);

        //    log.Info("Selecting owner: " + data.Owner);
        //    GeneralPage.ClickOnObject(ID.owner);
        //    GeneralPage.ClickOnObject(ID.GenerateOwnerXPath(data.Owner));

        //    log.Info("Selecting assigne: " + data.Assignee);
        //    GeneralPage.ClickOnObject(ID.assignee);
        //    GeneralPage.ClickOnObject(ID.GenerateAssigneeXPath(data.Assignee));

        //    log.Info("Selecting Impact: " + data.Impact);
        //    GeneralPage.SelectOptionFromDropdown(ID.impactDropdown, data.Impact);

        //    log.Info("Selecting Urgency: " + data.Urgency);
        //    GeneralPage.SelectOptionFromDropdown(ID.urgencyDropdown, data.Urgency);

        //    log.Info("Selecting Priority: " + data.Priority);
        //    GeneralPage.SelectOptionFromDropdown(ID.priorityDropdown, data.Priority);

        //    log.Info("Selecting Today as Due Date");
        //    GeneralPage.ClickOnObject(ID.dueDateButton);
        //    GeneralPage.ClickOnObject(ID.calendarToday);

        //    if (data is IncidentData)
        //    {
        //        log.Info(((IncidentData)data).Origin);
        //        log.Info(((IncidentData)data).ImpactedBusinessServices);
        //    }
        //}

        public static void VerifyTicketFieldValues(ModuleData data)
        {
            log.Info("Verifying if values are correct...");
            bool valuesMatch = true;
            var dictionary = new Dictionary<string, bool>();
            dictionary.Add("Requester", (data.Requester == GeneralPage.ExtractValueFromElement(ID.requesterValue)));
            dictionary.Add("Summary", (data.Summary == GeneralPage.ExtractValueFromElement(ID.Summary)));
            //Verify if type is correct
            string[] typeHierarchyListExpected = (data.Type).Split(':');
            string[] typeHierarchyListActual = (GeneralPage.ExtractValueFromElement(ID.TicketTypeValue)).Split(':');
            bool numTypeLevelsMatch = (typeHierarchyListActual.Count() == typeHierarchyListExpected.Count());
            valuesMatch &= numTypeLevelsMatch;
            bool typeLevelMatch = true;
            if (numTypeLevelsMatch)
            {
                for (int i = 0; i < typeHierarchyListExpected.Count(); i++)
                {
                    typeLevelMatch &= typeHierarchyListActual[i].Contains(typeHierarchyListExpected[i]);
                }
            }
            else
                log.Info("Type levels do not match");

            dictionary.Add("Type", typeLevelMatch);
            dictionary.Add("Owner", (data.Owner == GeneralPage.ExtractValueFromElement(ID.ownerValue)));
            dictionary.Add("Assignee", (data.Assignee == GeneralPage.ExtractValueFromElement(ID.assigneeValue)));
            dictionary.Add("Impact", (data.Impact == GeneralPage.ExtractTextFromElement(ID.impactValue)));
            dictionary.Add("Urgency", (data.Urgency == GeneralPage.ExtractTextFromElement(ID.urgencyValue)));
            dictionary.Add("Priority", (data.Priority == GeneralPage.ExtractTextFromElement(ID.priorityValue)));

            foreach (KeyValuePair<string, bool> entry in dictionary)
            {
                log.Info(entry.Key + ": " + entry.Value);
                valuesMatch &= entry.Value;
            }

            if (!valuesMatch)
                log.Error("One or more field values do not match. Check the logs above to see which field is incorrect");

            Assert.IsTrue(valuesMatch);
        }

        //private static void SelectIncidentType(string type)
        //{
        //    int levels = type.Count(f => f == ':') + 1;
        //    string[] typeHierarchyList = type.Split(':');
        //    //foreach (string incidentType in typeHierarchyList)
        //    //{
        //    //    log.Info(incidentType);
        //    //}

        //    //Loop n many times where n is the number of levels
        //    for (int i = 1; i <= levels; i++)
        //    {
        //        //if you are in the deepest level, click on the actual item and not the + sign
        //        //if not in the deepest level, click on +
        //        if (i == levels)
        //        {
        //            //click on item
        //            log.Info("Clicking on item type: " + typeHierarchyList[i - 1]);
        //            //Scroll down to the item before clicking it
        //            GeneralPage.ScrollDownDropDownList(ID.GenerateTypeXPath(typeHierarchyList, i, levels));
        //            GeneralPage.ClickOnObject(ID.GenerateTypeXPath(typeHierarchyList, i, levels));
        //        }
        //        else
        //        {
        //            //Click on + sign
        //            log.Info("Clicking + sign for: " + typeHierarchyList[i-1]);
        //            GeneralPage.ClickOnObject(ID.GenerateTypeXPath(typeHierarchyList, i, levels));
        //        }
        //    }
        //}

        private static void SelectRequesterItems(string items)
        {
            int numberOfItems = items.Count(f => f == ':') + 1;
            string[] itemList = items.Split(':');
        }

        private static bool IsWindowTitleVisible()
        {
            log.Info("Window Title is: " + GeneralPage.GetWindowTitle());
            bool incidentFormTitleFound = GeneralPage.GetWindowTitle().Contains("Incident");

            if (!(incidentFormTitleFound))
            {
                log.Info("Incident form window title was not found.");
            }
            else
            {
                log.Info("Incident form window title was found.");
            }
            return incidentFormTitleFound;
        }

        private static bool IsWindowTitleTicketNumberVisible(string ticketNum)
        {
            bool isTicketNumberVisible = GeneralPage.GetWindowTitle().Contains(ticketNum);

            if (!(isTicketNumberVisible))
            {
                log.Info("Incident form window title ticket number was not found.");
            }
            else
            {
                log.Info("Incident form window title ticket number was found.");
            }
            return isTicketNumberVisible;
        }

        private static bool IsFormTicketNumberVisible(string ticketNum)
        {
            bool isTicketNumberVisible = GeneralPage.ExtractTextFromElement(ID.ticketInfo).Contains(ticketNum);
            isTicketNumberVisible &= GeneralPage.ExtractTextFromElement(ID.ticketInfo).Contains("IR");

            if (!(isTicketNumberVisible))
            {
                log.Info("Incident form ticket details ticket number was not found.");
            }
            else
            {
                log.Info("Incident form ticket details ticket number was found.");
            }
            return isTicketNumberVisible;
        }
    }
}
