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
    public static class ViewsPanel
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(ViewsPanel)));
        public static ViewsPanelIDs ID = new ViewsPanelIDs();

        public static void ClickOnView(string viewName)
        {
            log.Info("Clicking on view: " + viewName);
            GeneralPage.ClickOnObject(ID.GenerateViewXpath(viewName));
        }
        public static void AmIOnView(string name)
        {
            Assert.IsTrue(IsDropDownViewActive(name));
        }

        private static bool IsDropDownViewActive(string viewName)
        {
            GeneralPage.SwitchToFrame(ID.mainGridFrame);
            //Commenting this because you dont have to click dropdown in order to se the DD list
            //GeneralPage.ClickOnObject(ID.viewChooser);
            bool visible = GeneralPage.IsElementVisible(ID.GenerateViewDropdownXpath(viewName));
            if (!visible)
            {
                log.Error(viewName + " dropdown option was not found.");
            }
            else
            {
                log.Info("View dropdown option was found.");
            }
            GeneralPage.SwitchToDefaultFrame();
            return visible;
        }
         
    }
}
