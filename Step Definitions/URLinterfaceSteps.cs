using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using log4net;
using CGSpecFlowBVT.Page_Objects;
using CGSpecFlowBVT.PageIDs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CGSpecFlowBVT.Utility;

namespace CGSpecFlowBVT.Step_Definitions
{
    [Binding]
    public class URLinterfaceSteps
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(URLinterfaceSteps)));
        
        [When(@"I type the (.*) module URL in my browser")]
        public void WhenITypeTheModuleURLInMyBrowser(string module)
        {
            Switches.NavigateToURLSwitch(module);
        }

        [When(@"I type the (.*) module URL, with ticket number (.*), in my browser")]
        public void WhenITypeTheModuleURLWithTicketNumberInMyBrowser(string module, int ticketNum)
        {
            Switches.NavigateToTicketURLSwitch(module, ticketNum);
        }

        [Then(@"The (.*) ticket with ID (.*) is visible")]
        public void ThenTheTicketWithIDIsVisible(string module, string ticketNum)
        {
            Switches.AmIOnTicketPageSwitch(module, ticketNum);
        }

        [When(@"I type the (.*) page URL in my browser")]
        public void WhenITypeThePageURLInMyBrowser(string page)
        {
            Switches.NavigateToURLSwitch(page);
        }


        [Then(@"I am on the (.*) CGWeb page")]
        public void ThenIAmOnThePage(string page)
        {
            Switches.AmIOnPageSwitch(page);
        }


        

        

        
        

    }
}
