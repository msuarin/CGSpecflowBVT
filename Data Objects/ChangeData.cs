using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGSpecFlowBVT.Data_Objects
{
    class ChangeData : ModuleData
    {
        public string Description { get; set; }
        public string Notes { get; set; }
        public string ImpactedBusinessServices { get; set; }
        public string ImpactedGroups { get; set; }
        public string Origin { get; set; }
    }
}
