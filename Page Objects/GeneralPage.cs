using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using log4net;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using CGSpecFlowBVT.PageIDs;
using CGSpecFlowBVT.Page_Object_Parts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace CGSpecFlowBVT.Page_Objects
{
    //This page object contains all the methods that are selenium related
    public static class GeneralPage
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(ProblemPage)));
        public static GeneralPageIDs ID = new GeneralPageIDs();
        private static IWebDriver driver;

        public static void NavigateToCGWebMain()
        {
            NavigateToURL("http://" + Hooks1.webSrvr + "/" + Hooks1.webVirtDir);
        }

        public static void NavigateToModuleURL(string urlParam)
        {
            NavigateToURL("http://" + Hooks1.webSrvr + "/" + Hooks1.webVirtDir + "/" + "Main.aspx" + urlParam);
        }

        public static void NavigateToCGWebFeaturesURL(string path)
        {
            NavigateToURL("http://" + Hooks1.webSrvr + "/CGWeb/" + path);
        }

        public static void NavigateToTicketURL(string moduleURL, int ticketNum)
        {
            string old = GeneralPage.GetCurrentWindow();
            NavigateToURL("http://" + Hooks1.webSrvr + "/CGWeb/MainUI/MainFrame.aspx" + moduleURL + "&ID=" + ticketNum);
            //NavigateToURL("http://" + Hooks1.webSrvr + "/" + Hooks1.webVirtDir + moduleURL + "&ID=" + ticketNum);

            //Switch to new window passing the old window as parameter
            GeneralPage.SwitchToNewWindow(old);
        }

        public static void NavigateToOtherTicketEntitiesURL(string moduleURL, int ticketNum)
        {
            NavigateToURL("http://" + Hooks1.webSrvr + "/CGWeb/MainUI" + moduleURL + "&ID=" + ticketNum);
        }

        public static void NavigateToKBTicketURL(int ticketNum)
        {
            NavigateToURL("http://" + Hooks1.webSrvr + moduleURLs.kbTicketURL + ticketNum);
        }

        public static void SetDriver(IWebDriver myDriver)
        {
            driver = myDriver;
        }

        public static void ClickOnObject(string targetControl)
        {
            bool visible = IsElementVisible(targetControl);
            if (!visible)
            {
                log.Error("Couldn't find " + targetControl);
                Assert.Fail("Couldn't find " + targetControl);
            }
                
            try
            {
                IWebElement element = driver.FindElement(By.XPath(targetControl));
                element.Click();
            }
            catch (Exception)
            {
                log.Error("Couldn't click on " + targetControl);
                Assert.Fail("Couldn't click on " + targetControl);
            }
            Thread.Sleep(5000);
        }

        public static void NavigateToURL(string moduleURL)
        {
            log.Info("Navigating to " + moduleURL);
            driver.Navigate().GoToUrl(moduleURL);
            Thread.Sleep(5000);
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
        }

        //This method is used to check if titles are visible ie. page title, view title etc.
        public static bool IsElementVisible(string titleID)
        {
            bool isVisible = true;
            int timeoutSecs = 10;

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

        public static void SwitchToFrame(string xPathToFrame)
        {
            driver.SwitchTo().Frame(driver.FindElement(By.XPath(xPathToFrame)));
        }

        public static void SwitchToDefaultFrame()
        {
            driver.SwitchTo().DefaultContent();
        }

        public static void InputTextInTextbox(string inputTxt, string targetControl, int nbrTries = 4)
        {
            for (int tries = 0; ; tries++)
            {
                if (tries > nbrTries)
                {
                    log.Error("Couldn't send text to " + targetControl);
                    Assert.Fail("Couldn't insert text " + inputTxt);
                }
                try
                {
                    IWebElement element = driver.FindElement(By.XPath(targetControl));
                    element.SendKeys(inputTxt);
                    Thread.Sleep(3000);
                    break;
                }
                catch (Exception)
                {
                    Thread.Sleep(tries * 500);
                }
            }
        }

        public static void ClearTextbox(string targetControl, int nbrTries = 4)
        {
            for (int tries = 0; ; tries++)
            {
                if (tries > nbrTries)
                {
                    log.Error("Couldn't clear text for Textbox: " + targetControl);
                    Assert.Fail("Couldn't clear text");
                }
                try
                {
                    IWebElement element = driver.FindElement(By.XPath(targetControl));
                    element.Clear();
                    Thread.Sleep(3000);
                    break;
                }
                catch (Exception)
                {
                    Thread.Sleep(tries * 500);
                }
            }
        }

        public static string ExtractTextFromElement(string xPath)
        {
            string s;
            s = driver.FindElement(By.XPath(xPath)).Text;
            return s;
        }

        public static string ExtractValueFromElement(string xPath)
        {
            string s;
            s = driver.FindElement(By.XPath(xPath)).GetAttribute("value");
            return s;
        }

        public static string GetCurrentWindow()
        {
            return driver.CurrentWindowHandle;
        }

        public static void SwitchToNewWindow(string oldWindow)
        {
            ReadOnlyCollection<string> windows = driver.WindowHandles;
            foreach (string handle in windows)
            {
                if (handle != oldWindow)
                {
                    driver.SwitchTo().Window(handle);
                    break;
                }
            }
        }

        public static void CloseCurrentWindow()
        {
            driver.Close();
            ReadOnlyCollection<string> windows = driver.WindowHandles;
            foreach (string handle in windows)
            {
                    driver.SwitchTo().Window(handle);
                    Thread.Sleep(2000);
                    break;
            }
        }

        public static string GetWindowTitle()
        {
            return driver.Title;
        }

        public static void HoverOverElement(string xPath)
        {
            IWebElement element = driver.FindElement(By.XPath(xPath));
            Actions builder = new Actions(driver);
            Actions hoverOver = builder.MoveToElement(element);
            hoverOver.Perform();
            Thread.Sleep(2000);
        }

        //This method is used to scroll to the item in the dropdown list for dropdown boxes that don't use the <select> tag
        public static void ScrollDownDropDownList(string itemToScrollTo)
        {
            FirefoxWebElement element = (FirefoxWebElement)driver.FindElement(By.XPath(itemToScrollTo));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            Thread.Sleep(1000);
        }

        //This method only usable for dropdown boxes that have the <select> tag
        public static void SelectOptionFromDropdown(string dropdownID, string text)
        {
            IWebElement dropdownListBox = driver.FindElement(By.XPath(dropdownID));
            SelectElement clickThis = new SelectElement(dropdownListBox);
            clickThis.SelectByText(text);
            Thread.Sleep(1000);
        }

        public static void DoubleClickObject(string targetControl)
        {
            bool visible = IsElementVisible(targetControl);
            if (!visible)
            {
                log.Error("Couldn't find " + targetControl);
                Assert.Fail("Couldn't find " + targetControl);
            }

            try
            {
                IWebElement element = driver.FindElement(By.XPath(targetControl));
                //This code double clicks a ticket. We are using javascript script since selenium 
                //doesnt have an implementation of a double click yet.
                ((IJavaScriptExecutor)driver).ExecuteScript("var evt = document.createEvent('MouseEvents');" +
        "evt.initMouseEvent('dblclick',true, true, window, 0, 0, 0, 0, 0, false, false, false, false, 0,null);" +
        "arguments[0].dispatchEvent(evt);", element);
            }
            catch (Exception)
            {
                log.Error("Couldn't click on " + targetControl);
                Assert.Fail("Couldn't click on " + targetControl);
            }
            Thread.Sleep(5000);
        }

    }
}
