using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGSpecFlowBVT.PageIDs
{
    public class GeneralPageIDs
    {
        public string navbarTriggerBtn = @"//form[contains(@id, 'form2')]/div[2]/div/div/img";
        public string navbarHoverArea = @"/html/body/form/div[4]/div/div";

        //User Config Cog and options
        public string userConfigCog = @"//*[@id='userConfig']";
        //Have to separate Log and Out since Firebug is showing a lot of spaces in between
        public string logOffLink =
            @"//form[contains(@id, 'form2')]/div[2]/div/ul/li[2]/ul/li[3]/a[text()[contains(., 'Log') and contains(., 'Out')]]";
        public string userPreferencesLink =
            @"//form[contains(@id, 'form2')]/div[2]/div/ul/li[2]/ul/li/a[text()[contains(., 'Preferences')]]";
        public string helpLink =
            @"//form[contains(@id, 'form2')]/div[2]/div/ul/li[2]/ul/li[2]/a[text()[contains(., 'Help')]]";

        //Common module IDs. The module ID classes inherit from this class
        //Requester dropdown arrow
        public virtual string requester
        {
            get { return @"//img[contains(@id, 'Requester_PersonChooser')]"; }
            set { }
        }

        //Method to generate the xpath for requesters
        public string GenerateRequesterXPath(string requesterName)
        {
            string xPath =
                @"//table[contains(@id, 'Requester') and contains(@id, 'PersonChooser') and contains(@id, 'MainTable')]" +
                @"/tbody/tr[contains(@id, 'DataRow')]/td[text()[contains(., '" + requesterName + @"')]]";

            return xPath;
        }
        //To extract value of the requester field, use this.
        public string requesterValue = @"//input[contains(@id, 'Requester') and contains(@id, 'PersonChooser') and contains(@id, 'GridLookupPC')]";

        //Summary Textbox
        public virtual string Summary 
        {
            get
            {
                //return @"//div[contains(@id, 'DynamicLayoutControl') and contains(@id, 'Root')]" +
                    //@"/div/div/input[contains(@id, 'DynamicLayoutControl') and contains(@id, 'Summary')]";

                return @"//input[contains(@id, 'DynamicLayoutControl') and contains(@id, 'Summary')]";
            }
        }
        //public string summary = @"//div[contains(@id, 'DynamicLayoutControl') and contains(@id, 'Root')]" +
            //@"/div/div/input[contains(@id, 'DynamicLayoutControl') and contains(@id, 'Summary')]";

        //Incident Type dropdown arrow
        public string typeArrow = @"//td[contains(@id, 'DynamicLayoutControl') and contains(@id, 'Type')" +
            @" and contains(@id, 'DropDownEdit')]";
       //Method to generate xpath for ticket Type
        public string GenerateHierarchyXPath(string[] typeNames, int currentLevel, int maxLevel)
        {
            string xPath = @"//div[contains(@id, 'Type') and contains(@id, 'DropDownEdit')" +
                @" and contains(@id, 'DropDownTreeView')]";
            for (int i = 1; i <= currentLevel; i++)
            {
                xPath += @"/ul/li";
                if (currentLevel == maxLevel && i == currentLevel)
                {
                    xPath += @"/div/span[text()[contains(., '" + typeNames[i - 1] + @"')]]";
                }
                else if (currentLevel < maxLevel && i == currentLevel)
                {
                    xPath += @"/div/span[text()[contains(., '" + typeNames[i - 1] + @"')]]/preceding-sibling::span[1]";
                }
            }

            return xPath;
        }
        //To extract value of type field, use this
        public string TicketTypeValue = @"//table[contains(@id, 'Type')]" +
            @"/tbody/tr/td[1]/input[contains(@id, 'Type')]";
        //Method to generate xpath for ticket Type
        public string GenerateHierarchyLocationXPath(string[] typeNames, int currentLevel, int maxLevel, string fieldID)
        {
            string xPath = @"//div[contains(@id, '" + fieldID + @"') and contains(@id, 'DropDownEdit')" +
                @" and contains(@id, 'DropDownTreeView')]";
            for (int i = 1; i <= currentLevel; i++)
            {
                xPath += @"/ul/li";
                if (currentLevel == maxLevel && i == currentLevel)
                {
                    xPath += @"/div/span[text()[contains(., '" + typeNames[i - 1] + @"')]]";
                }
                else if (currentLevel < maxLevel && i == currentLevel)
                {
                    xPath += @"/div/span[text()[contains(., '" + typeNames[i - 1] + @"')]]/preceding-sibling::span[1]";
                }
            }

            return xPath;
        }
        
        //Owner dropdown arrow
        public string owner = @"//img[contains(@id, 'ItemOwner_PersonChooser')]";
        //Method to generate Xpath for Owner
        public string GenerateOwnerXPath(string ownerName)
        {
            string xPath =
                @"//table[contains(@id, 'ItemOwner') and contains(@id, 'PersonChooser') and contains(@id, 'MainTable')]" +
                @"/tbody/tr[contains(@id, 'DataRow')]/td[text()[contains(., '" + ownerName + @"')]]";

            return xPath;
        }
        //To extract value of the owner field, use this.
        public string ownerValue = @"//input[contains(@id, 'ItemOwner') and contains(@id, 'PersonChooser') and contains(@id, 'GridLookupPC')]";

        //Assignee dropdown arow
        public string assignee = @"//img[contains(@id, 'AssignedTo_PersonChooser')]";
        public string GenerateAssigneeXPath(string assigneeName)
        {
            string xPath =
                @"//table[contains(@id, 'AssignedTo') and contains(@id, 'PersonChooser') and contains(@id, 'MainTable')]" +
                @"/tbody/tr[contains(@id, 'DataRow')]/td[text()[contains(., '" + assigneeName + @"')]]";

            return xPath;
        }
        //To extract value of the requester field, use this.
        public string assigneeValue = @"//input[contains(@id, 'AssignedTo') and contains(@id, 'PersonChooser') and contains(@id, 'GridLookupPC')]";

        //Impact selection
        public string impactDropdown = @"//select[contains(@id, 'Impact') and contains(@id, 'ddl')]";
        //Impact value extraction
        public string impactValue = @"//select[contains(@id, 'Impact') and contains(@id, 'ddl')]" +
            @"/option[contains(@selected, 'selected')]";

        //Urgency selection
        public string urgencyDropdown = @"//select[contains(@id, 'Urgency') and contains(@id, 'ddl')]";
        //Urgency value extraction
        public string urgencyValue = @"//select[contains(@id, 'Urgency') and contains(@id, 'ddl')]" +
            @"/option[contains(@selected, 'selected')]";

        //Priority selection
        public string priorityDropdown = @"//select[contains(@id, 'Priority') and contains(@id, 'ddl')]";
        //Priority value extraction
        public string priorityValue = @"//select[contains(@id, 'Priority') and contains(@id, 'ddl')]" +
            @"/option[contains(@selected, 'selected')]";

        //Due Date selection
        public string dueDateButton = @"//img[contains(@id, 'DueDate') and contains(@id, 'dtc') and contains(@id, '_Date_')]";
        //Today selection
        public string calendarToday =
            @"//table[contains(@id, 'DueDate') and contains(@id, 'dtc') and contains(@id, '_Date_') and contains(@id, 'DDD')]" +
            @"/tbody//tr//td[contains(@class, 'CalendarDay_') and contains(@class, 'CalendarToday_')]";

        public string todayDate =
            @"//td[contains(@class, 'CalendarDay_') and contains(@class, 'CalendarToday_')]";

        //First visible ticket
        public string firstVisibleTicket = @"//table[contains(@id, 'ASPxGrid') and contains(@id, 'MainTable')]" +
            @"/tbody/tr[contains(@id, 'ASPxGrid') and contains(@id, 'DataRow0')]";

        //OK Button for comment popup
        //public string okCommentPopup = @"//div[contains(@id, 'CommentPopup') and contains(@id, 'OkCommentButton')]" +
        //    @"/span[text()[contains(., 'OK')]]";

        public string okCommentPopup = @"//div[contains(@class, 'popup-btn-group')]" +
            @"/div[contains(@id, 'Commentpopup') and contains(@id, 'OKCommentButton')]";

    }
}
