using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using log4net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using CGSpecFlowBVT.Page_Objects;
using CGSpecFlowBVT.Data_Objects;

namespace CGSpecFlowBVT
{
    [Binding]
    [TestClass]
    public class Hooks1
    {
       
        private static readonly ILog log = LogManager.GetLogger((typeof(Hooks1)));
        static IWebDriver driver;
        public static string webVirtDir;
        public static string webSrvr;
        public static string browserType;

        [BeforeScenario]
        public void BeforeScenario()
        {
            log.Info("Initializing tests");
            webVirtDir = Environment.GetEnvironmentVariable("UNIT_TEST_WEB_URL");
            log.Info("Web virtual directory is " + webVirtDir);
            webSrvr = Environment.GetEnvironmentVariable("UNIT_TEST_WEB_SRVR");
            log.Info("Web server is " + webSrvr);
            //For browser type set this to "ie", "firefox" or "chrome"
            browserType = "firefox";
            log.Info("==========Starting Scenario: " + ScenarioContext.Current.ScenarioInfo.Title + "==========");

            if (browserType == "firefox")
            {
                FirefoxProfile profile = new FirefoxProfile();

                // WYMAN - WE NEED TO FIX THIS TO POINT TO just eps. Websrv has the username and password already in it
                profile.SetPreference("network.automatic-ntlm-auth.trusted-uris", webSrvr);
                profile.SetPreference("network.negotiate-auth.delegation-uris", webSrvr);
                profile.SetPreference("network.negotiate-auth.trusted-uris", webSrvr);
                driver = new FirefoxDriver(profile);
            }
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(15));
            GeneralPage.SetDriver(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            
            log.Info("Ending scenario: " + ScenarioContext.Current.ScenarioInfo.Title);
            driver.Quit();
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            
        }

        //The testclass attribute was added to this class in order to use the Assemblycleanup attribute.
        //This is because the [aftertestrun] binding doesn't work
        [AssemblyCleanup()]
        public static void AfterTestRun()
        {
            log.Info("End of test run");
        }
    }
}
