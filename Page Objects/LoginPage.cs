using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using CGSpecFlowBVT.PageIDs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CGSpecFlowBVT.Page_Objects
{
    public static class LoginPage
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(IncidentPage)));
        public static LoginIDs ID = new LoginIDs();

        public static void AmIOnLoggedOutPage()
        {
            if (!GeneralPage.IsElementVisible(ID.loggedOutMessage))
            {
                log.Error("Logged out page was not found.");
            }
            else
            {
                log.Info("Logged out page was found.");
            }
            Assert.IsTrue(GeneralPage.IsElementVisible(ID.loggedOutMessage));
        }

        public static void AmIOnPage()
        {
            bool loginTextBoxesVisible = true;
            loginTextBoxesVisible &= GeneralPage.IsElementVisible(ID.userInputBox);
            loginTextBoxesVisible &= GeneralPage.IsElementVisible(ID.passwordInputBox);

            if (loginTextBoxesVisible)
            {
                log.Info("Log in form textboxes were found.");
            }
            else
            {
                log.Error("One or more required textboxes were not found.");
                Assert.Fail("One or more required textboxes were not found.");
            }
        }

        public static bool AmILoggedIn()
        {
            bool loginTextBoxesVisible = true;
            loginTextBoxesVisible &= GeneralPage.IsElementVisible(ID.userInputBox);
            loginTextBoxesVisible &= GeneralPage.IsElementVisible(ID.passwordInputBox);

            return (!loginTextBoxesVisible);
        }

        public static void ClickLoginLink()
        {
            log.Info("Clicking on login link");
            GeneralPage.ClickOnObject(ID.loginLink);
        }

        public static void InputLogInCredentials(string user, string pass)
        {
            log.Info("Entering user name...");
            GeneralPage.InputTextInTextbox(user, LoginPage.ID.userInputBox);
            log.Info("Entering password...");
            GeneralPage.InputTextInTextbox(pass, LoginPage.ID.passwordInputBox);
        }

        public static void ClickLoginBtn()
        {
            GeneralPage.ClickOnObject(ID.logInBtn);
        }

    }
}
