using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using CGSpecFlowBVT.Page_Objects;
using CGSpecFlowBVT.Page_Object_Parts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using log4net;
using CGSpecFlowBVT.Utility;
using CGSpecFlowBVT.Data_Objects;

namespace CGSpecFlowBVT.Step_Definitions
{
    [Binding]
    public class ModuleSteps
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(ModuleSteps)));
        private static ModuleData data;

        [When(@"I click on the (.*) button in the action bar")]
        public void WhenIClickOnTheButtonInTheActionBar(string action)
        {
            GeneralPage.SwitchToFrame(ModuleActionBar.ID.mainGridFrame);
            string old = GeneralPage.GetCurrentWindow();
            //Hard coded to click on "New" action. Need to change this to accomodate other actions.
            ModuleActionBar.ClickNew();
            log.Info("New button clicked");
            GeneralPage.SwitchToNewWindow(old);
            log.Info("Switched to new window");
        }

        [When(@"I click on the (.*) button in the action bar and select (.*)")]
        public void WhenIClickOnTheButtonInTheActionBarAndSelect(string action, string srType)
        {
            GeneralPage.SwitchToFrame(ModuleActionBar.ID.mainGridFrame);
            string old = GeneralPage.GetCurrentWindow();
            ModuleActionBar.ClickNew(srType);
            log.Info("New button clicked and type selectd.");
            GeneralPage.SwitchToNewWindow(old);
            log.Info("Switched to new window.");
        }


        [When(@"I enter the following (.*) data into the new ticket form:")]
        public void WhenIEnterTheFollowingDataIntoTheNewTicketForm(string module, Table table)
        {
            data = ModuleDataSwitch.CreateModuleDataObject(module, table);
            if (data == null)
            {
                Assert.Fail("Data was not found");
                log.Error("Data was not found");
            }
            TicketPage.FillInTicketFields(module, data);
        }

        [When(@"I enter the following Service Request data into the new (.*) form:")]
        public void WhenIEnterTheFollowingServiceRequestDataIntoTheNewForm(string srType, Table table)
        {
            data = ModuleDataSwitch.CreateSRModuleDataObject(srType, table);
            if (data == null)
            {
                Assert.Fail("Data wa snot found");
                log.Error("data was not found");
            }
            TicketPage.FillInSRTicketFields(srType, data);
        }



        [When(@"I (.*) the ticket")]
        public void WhenIPerformTheTicketAction(string action)
        {
            TicketActionBar.ClickAction(action);
            log.Info(action + " action was performed");
        }

        [When(@"I open the newest ticket")]
        public void WhenIOpenTheNewestTicket()
        {
            GeneralPage.SwitchToFrame(TicketGrid.ID.mainGridFrame);
            string old = GeneralPage.GetCurrentWindow();
            TicketGrid.DoubleClickTicketInGrid(1);
            log.Info("Double clicked the top most ticket");
            GeneralPage.SwitchToNewWindow(old);
            log.Info("Switched to ticket window.");
        }

        [Then(@"The ticket should display the correct (.*) data")]
        public void ThenTheTicketShouldDisplayTheCorrectData(string module, Table table)
        {
            data = ModuleDataSwitch.CreateModuleDataObject(module, table);
            
            if (data == null)
            {
                Assert.Fail("Data was not found");
                log.Error("Data was not found");
            }
            VerifyFieldValuesSwitch.VerifyFieldValues(module, data);
        }

        [Then(@"The ticket should display the correct Service Request data of type (.*)")]
        public void ThenTheTicketShouldDisplayTheCorrectServiceRequestDataOfType(string ticketType, Table table)
        {
            ServiceRequestData srData = (ServiceRequestData)ModuleDataSwitch.CreateSRModuleDataObject(ticketType, table);

            if (data == null)
            {
                Assert.Fail("Data was not found");
                log.Error("data was not found");
            }
            VerifyFieldValuesSwitch.VerifySRFieldValues(ticketType, srData);
        }


        [When(@"I close the ticket window")]
        public void WhenICloseTheTicketWindow()
        {
            log.Info("Closing the current ticket window...");
            GeneralPage.CloseCurrentWindow();
        }

        [When(@"I click OK on the comment popup window")]
        public void WhenIClickOKOnTheCommentPopupWindow()
        {
            log.Info("Clicking OK on the comment popup window");
            TicketPage.ClickOkOnCommentPopup();
        }


    }
}
