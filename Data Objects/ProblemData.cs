using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGSpecFlowBVT.Data_Objects
{
    class ProblemData : ModuleData
    {
        public string ImpactedUsers { get; set; }
        public string StartedDate { get; set; }
        public string CompletedDate { get; set; }
        public string Description { get; set; }
        public string Resolution { get; set; }
    }
}
