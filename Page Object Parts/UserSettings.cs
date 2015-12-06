using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using log4net;
using CGSpecFlowBVT.PageIDs;
using CGSpecFlowBVT.Page_Objects;

namespace CGSpecFlowBVT.Page_Object_Parts
{
    public static class UserSettings
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(UserSettings)));
        public static GeneralPageIDs ID = new GeneralPageIDs();

        private static bool IsUserConfigMenuExpanded()
        {
            bool isExpanded = true;
            //Check if the following links are available
            isExpanded &= GeneralPage.IsElementVisible(GeneralPage.ID.userPreferencesLink);
            isExpanded &= GeneralPage.IsElementVisible(GeneralPage.ID.helpLink);
            isExpanded &= GeneralPage.IsElementVisible(GeneralPage.ID.logOffLink);
            return isExpanded;
        }

        private static void Expand()
        {
            if (!IsUserConfigMenuExpanded())
            {
                log.Info("Expanding User Config Menu...");
                GeneralPage.ClickOnObject(GeneralPage.ID.userConfigCog);
            }
            else
                log.Info("Tried to expand the User Config Menu but it was already open.");
        }

        private static void Collapse()
        {
            if (IsUserConfigMenuExpanded())
            {
                log.Info("Collapsing User Config Menu...");
                GeneralPage.ClickOnObject(GeneralPage.ID.userConfigCog);
            }
            else
                log.Info("Tried to collapse the User Config Menu but it was already collapsed.");
        }

        public static void ClickUserSettingsOption(string BtnSel)
        {
            string option = BtnSel;
            Expand();

            switch (option)
            {
                case "Preferences":
                    {
                        GeneralPage.ClickOnObject(GeneralPage.ID.userPreferencesLink);
                        log.Info("Clicked on Preferences in the User Config menu.");
                        break;
                    }
                case "Help":
                    {
                        GeneralPage.ClickOnObject(GeneralPage.ID.helpLink);
                        log.Info("Clicked on Help in the User Config menu.");
                        break;
                    }
                case "Log Off":
                    {
                        GeneralPage.ClickOnObject(GeneralPage.ID.logOffLink);
                        log.Info("Clicked on Log Off in the User Config menu.");
                        break;
                    }
                default:
                    {
                        log.Error("This selection[" + option + "] does not exist. Check the feature file for errors.");
                        Assert.Fail("This selection[" + option + "] does not exist. Check the feature file for errors.");
                        break;
                    }
            }
        }

        public static bool AmILoggedInAs(string fname, string lname)
        {
            string userFirstLastName;
            bool userMatch = true;

            if (GeneralPage.IsElementVisible(LoginPage.ID.loggedInUserLink))
            {
                log.Info("Logged in user display name found on page.");
            }
            else
            {
                log.Error("Logged in user display name not found.");
                Assert.Fail("Logged in user display name not found.");
            }
            
            userFirstLastName =  GeneralPage.ExtractTextFromElement(LoginPage.ID.loggedInUserLink);
            userMatch &= userFirstLastName.Contains(fname);
            userMatch &= userFirstLastName.Contains(lname);

            if (userMatch)
            {
                log.Info("User display name " + fname + " " + lname + " matches with " + userFirstLastName);
                return userMatch;
            }
            else
            {
                log.Error("User display name " + fname + " " + lname + " does not match with " + userFirstLastName);
                return userMatch;
            }
        }

    }
}
