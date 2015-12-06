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
    public class ViewSteps
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(ViewSteps)));

        [When(@"I click on the (.*) view")]
        public void WhenIClickOnTheView(string view)
        {
            ViewsPanel.ClickOnView(view);
        }

        [Then(@"I see the (.*) view")]
        public void ThenISeeTheView(string name)
        {
            ViewsPanel.AmIOnView(name);
        }


    }
}
