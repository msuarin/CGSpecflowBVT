using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using CGSpecFlowBVT.Page_Objects;
using CGSpecFlowBVT.Page_Object_Parts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using log4net;
using CGSpecFlowBVT.Utility;

namespace CGSpecFlowBVT.Step_Definitions
{
    [Binding]
    public class LoginSteps
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(LoginSteps)));

        [When(@"I log out from ChangeGear Web")]
        public void WhenILogOutFromChangeGearWeb()
        {
            UserSettings.ClickUserSettingsOption("Log Off");
        }

        [Given(@"I log out from ChangeGear Web")]
        public void GivenILogOutFromChangeGearWeb()
        {
            UserSettings.ClickUserSettingsOption("Log Off");
            Switches.AmIOnPageSwitch("Logged In");
        }

        //Navigate to login page from logged out page
        [Given(@"I navigate to the CGWeb login page")]
        public void GivenINavigateToTheCGWebLoginPage()
        {
            LoginPage.ClickLoginLink();
            Switches.AmIOnPageSwitch("Logged In");
        }

        [Then(@"I am on the logged in page")]
        public void ThenIAmOnTheLoggedInPage()
        {
            Switches.AmIOnPageSwitch("Logged In");
        }

        [When(@"I log in to ChangeGear Web using the credentials: (.*), (.*)")]
        public void WhenILogInToChangeGearWebUsingTheCredentials(string user, string pass)
        {
            LoginPage.InputLogInCredentials(user, pass);
            LoginPage.ClickLoginBtn();
        }

        [Then(@"I am logged in as (.*), (.*)")]
        public void ThenIAmLoggedInAs(string fname, string lname)
        {
            Assert.IsTrue(UserSettings.AmILoggedInAs(fname, lname));
        }
    }
}
