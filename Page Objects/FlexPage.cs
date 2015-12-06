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
    public static class FlexPage
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(FlexPage)));
        public static FlexIDs ID = new FlexIDs();

        public static void AmIOnPage(string flexType)
        {
            Assert.IsTrue(IsWindowTitleVisible(flexType));
        }

        public static void IsTicketNumberCorrect(string flexType, string ticketNum)
        {
            Assert.IsTrue(IsWindowTitleTicketNumberVisible(flexType, ticketNum));
            Assert.IsTrue(IsFormTicketNumberVisible(flexType, ticketNum));
        }

        private static bool IsWindowTitleVisible(string flexType)
        {
            log.Info("Window Title is: " + GeneralPage.GetWindowTitle());
            bool flexFormTitleFound = GeneralPage.GetWindowTitle().Contains(flexType);

            if (!(flexFormTitleFound))
            {
                log.Info(flexType + " form window title was not found.");
            }
            else
            {
                log.Info(flexType + " form window title was found.");
            }
            return flexFormTitleFound;
        }

        private static bool IsWindowTitleTicketNumberVisible(string flexType, string ticketNum)
        {
            bool isTicketNumberVisible = GeneralPage.GetWindowTitle().Contains(ticketNum);

            if (!(isTicketNumberVisible))
            {
                log.Info(flexType + " form window title ticket number was not found.");
            }
            else
            {
                log.Info(flexType + " form window title ticket number was found.");
            }
            return isTicketNumberVisible;
        }

        private static bool IsFormTicketNumberVisible(string flexType, string ticketNum)
        {
            string pfix;

            if (flexType == "Flex1")
            {
                pfix = "FM1";
            }
            else
            {
                pfix = "FM2";
            }
            bool isTicketNumberVisible = GeneralPage.ExtractTextFromElement(ID.ticketInfo).Contains(ticketNum);
            isTicketNumberVisible &= GeneralPage.ExtractTextFromElement(ID.ticketInfo).Contains(pfix);

            if (!(isTicketNumberVisible))
            {
                log.Info(flexType + " form ticket details ticket number was not found.");
            }
            else
            {
                log.Info(flexType + " form ticket details ticket number was found.");
            }
            return isTicketNumberVisible;
        }

        public static void VerifyTicketFieldValues(ModuleData data)
        {
            log.Info("Verifying if values are correct...");
            bool valuesMatch = true;
            var dictionary = new Dictionary<string, bool>();
            dictionary.Add("Requester", (data.Requester == GeneralPage.ExtractValueFromElement(ID.requesterValue)));
            dictionary.Add("Summary", (data.Summary == GeneralPage.ExtractValueFromElement(ID.Summary)));
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
    }
}
