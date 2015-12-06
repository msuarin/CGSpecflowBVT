using System;
using TechTalk.SpecFlow;
using CGSpecFlowBVT.Page_Objects;
using CGSpecFlowBVT.Page_Object_Parts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using log4net;
using CGSpecFlowBVT.Utility;


namespace CGSpecFlowBVT.Step_Definitions
{
    [Binding]
    public class NavigationSteps
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(NavigationSteps)));

        [Given(@"I am logged in to ChangeGear Web")]
        public void GivenIAmLoggedInToChangeGearWeb()
        {
            GeneralPage.NavigateToCGWebMain();
            //Test if it didn't log you in automatically with your windows credential.
            //This part logs you in if you didn't get logged in automatically
            if (!LoginPage.AmILoggedIn())
            {
                LoginPage.InputLogInCredentials(@"qalab\administrator", @"qatest04");
                LoginPage.ClickLoginBtn();
            }
        }

        [Given(@"I am on the (.*) module page")]
        public void GivenIAmOnThePage(string modulePage)
        {
            NavBar.Click(modulePage);
            Switches.AmIOnGridPageSwitch(modulePage);
            
        }

        //This is a method for when you navigate to a module using the navigation bar
        [When(@"I navigate to the (.*) module page")]
        public void WhenINavigateToTheModulePage(string moduleLink)
        {
            NavBar.Click(moduleLink);
        }

        [Then(@"I am on the (.*) module page")]
        public void ThenIAmOnTheModulePage(string pageTitle)
        {
            Switches.AmIOnGridPageSwitch(pageTitle);
        }

        
    }
}
