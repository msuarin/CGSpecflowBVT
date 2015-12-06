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
    public static class TaskManagerPage
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(TaskManagerPage)));
        public static TaskManagerIDs ID = new TaskManagerIDs();

        public static void AmIOnPage(string page)
        {
            Assert.IsTrue(IsWindowTitleVisible(page));
            Assert.IsTrue(IsViewVisible(page));
        }

        private static bool IsWindowTitleVisible(string page)
        {
            log.Info("Window Title is: " + GeneralPage.GetWindowTitle());
            string title = "";
            switch (page)
            {
                case "Incident Task Manager":
                    {
                        title = "Incident Tasks";
                        break;
                    }
                case "Change Task Manager":
                    {
                        title = "Change Tasks";
                        break;
                    }
                default:
                    {
                        log.Error("Task Manager Page: Task module not found");
                        break;
                    }
            }
            bool taskManagerTitleFound = GeneralPage.GetWindowTitle().Contains(title);

            if (!(taskManagerTitleFound))
            {
                log.Error(page + " window title was not found.");
            }
            else
            {
                log.Info(page + " window title was found.");
            }
            return taskManagerTitleFound;
        }

        private static bool IsViewVisible(string page)
        {
            bool viewVisible = true;
            string view;
            switch (page)
            {
                case "Incident Task Manager":
                    {
                        view = ID.incidentView;
                        break;
                    }
                case "Change Task Manager":
                    {
                        view = ID.changeView;
                        break;
                    }
                default:
                    {
                        view = "Incorrect module: TemplateManagerPage.cs";
                        log.Error("Incorrect module: TemplateManagerPage.cs");
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
