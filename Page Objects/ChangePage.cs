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
    public static class ChangePage
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(ChangePage)));
        public static ChangeIDs ID = new ChangeIDs();

        public static void AmIOnPage()
        {
            Assert.IsTrue(IsWindowTitleVisible());
        }

        public static void IsTicketNumberCorrect(string ticketNum)
        {
            Assert.IsTrue(IsWindowTitleTicketNumberVisible(ticketNum));
            Assert.IsTrue(IsFormTicketNumberVisible(ticketNum));
        }

        private static bool IsWindowTitleVisible()
        {
            log.Info("Window Title is: " + GeneralPage.GetWindowTitle());
            bool changeFormTitleFound = GeneralPage.GetWindowTitle().Contains("RFC");

            if (!(changeFormTitleFound))
            {
                log.Info("Change form window title was not found.");
            }
            else
            {
                log.Info("Change form window title was found.");
            }
            return changeFormTitleFound;
        }

        private static bool IsWindowTitleTicketNumberVisible(string ticketNum)
        {
            bool isTicketNumberVisible = GeneralPage.GetWindowTitle().Contains(ticketNum);

            if (!(isTicketNumberVisible))
            {
                log.Info("Change form window title ticket number was not found.");
            }
            else
            {
                log.Info("Change form window title ticket number was found.");
            }
            return isTicketNumberVisible;
        }

        private static bool IsFormTicketNumberVisible(string ticketNum)
        {
            bool isTicketNumberVisible = GeneralPage.ExtractTextFromElement(ID.ticketInfo).Contains(ticketNum);
            isTicketNumberVisible &= GeneralPage.ExtractTextFromElement(ID.ticketInfo).Contains("RFC");

            if (!(isTicketNumberVisible))
            {
                log.Info("Change form ticket details ticket number was not found.");
            }
            else
            {
                log.Info("Change form ticket details ticket number was found.");
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
