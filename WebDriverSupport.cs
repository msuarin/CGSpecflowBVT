using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using log4net;


namespace CGSpecFlowBVT
{
    //This class contains methods that you can use to manipulate web elements.
    public static class WebDriverSupport
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(WebDriverSupport)));
        private static IWebDriver driver;

        public static void SetDriver(IWebDriver myDriver)
        {
            driver = myDriver;
        }

        public static void ClickOnObject(string targetControl, int nbrTries = 4)
        {
            for (int tries = 0; ; tries++)
            {
                if (tries > nbrTries) Assert.Fail("Couldn't click on " + targetControl);
                try
                {
                    IWebElement element = driver.FindElement(By.XPath(targetControl));
                    element.Click();
                    break;
                }
                catch (Exception)
                {
                    Thread.Sleep(tries * 500);
                }

            }       
        }

        public static void NavigateToURL(string moduleURL)
        {
            log.Info("Navigating to " + moduleURL);
            driver.Navigate().GoToUrl(moduleURL);
            driver.Manage().Window.Maximize();
        }

        //This method is used to check if titles are visible ie. page title, view title etc.
        public static bool IsTitleVisible(string titleID)
        {
            bool isVisible = true;
            int timeoutSecs = 10;
            Thread.Sleep(4000);

            //Return true if the element was found. Otherwise return false.
            try
            {
                //Wait for 10 seconds or until the title is found
                if (timeoutSecs > 0)
                {
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutSecs));
                    wait.Until(drv => drv.FindElement(By.XPath(titleID)));
                }
                IWebElement element = driver.FindElement(By.XPath(titleID));
                if (element.Displayed)
                {
                    isVisible = true;
                }
                else
                    isVisible = false;
            }
            catch (WebDriverException)
            {
                isVisible = false;
            }

            return isVisible;
        }

    }
}
