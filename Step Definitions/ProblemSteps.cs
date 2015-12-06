using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CGSpecFlowBVT.Data_Objects;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using CGSpecFlowBVT.Page_Objects;
using CGSpecFlowBVT.Page_Object_Parts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using log4net;
using CGSpecFlowBVT.Utility;

namespace CGSpecFlowBVT.Step_Definitions
{
    class ProblemSteps
    {
        private static readonly ILog log = LogManager.GetLogger((typeof(ProblemSteps)));
        private static ProblemData data = new ProblemData();
    }
}
