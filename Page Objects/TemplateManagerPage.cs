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
    public static class TemplateManagerPage
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(TemplateManagerPage)));
        public static TemplateManagerIDs ID = new TemplateManagerIDs();

        public static void AmIOnPage(string page)
        {
            Assert.IsTrue(IsWindowTitleVisible());
            Assert.IsTrue(IsViewVisible(page));
        }

        private static bool IsWindowTitleVisible()
        {
            log.Info("Window Title is: " + GeneralPage.GetWindowTitle());
            bool templateManagerTitleFound = GeneralPage.GetWindowTitle().Contains("Templates");

            if (!(templateManagerTitleFound))
            {
                log.Error("Template Manager window title was not found.");
            }
            else
            {
                log.Info("Template Manager window title was found.");
            }
            return templateManagerTitleFound;
        }

        private static bool IsViewVisible(string page)
        {
            bool viewVisible = true;
            string view;
            switch (page)
            {
                case "Incident Template Manager":
                    {
                        view = ID.incidentView;
                        break;
                    }
                case "Problem Template Manager":
                    {
                        view = ID.problemView;
                        break;
                    }
                case "Change Template Manager":
                    {
                        view = ID.changeView;
                        break;
                    }
                case "Flex1 Template Manager":
                    {
                        view = ID.flex1View;
                        break;
                    }
                case "Flex2 Template Manager":
                    {
                        view = ID.flex2View;
                        break;
                    }
                default:
                    {
                        view = "Incorrect module: TemplateManagerPage.cs";
                        break;
                    }
            }

            viewVisible = GeneralPage.IsElementVisible(view);
            if (!(viewVisible))
            {
                log.Error(page + " View was not found.");
            }
            else
            {
                log.Info(page + " View was found.");
            }

            return viewVisible;
        }

    }
}
