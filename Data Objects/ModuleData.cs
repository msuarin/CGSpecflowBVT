using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGSpecFlowBVT.Data_Objects
{
    public abstract class ModuleData
    {
        public string Requester { get; set; }
        public string Summary { get; set; }
        public string Type { get; set; }
        public string Owner { get; set; }
        public string Assignee { get; set; }
        public string Impact { get; set; }
        public string Urgency { get; set; }
        public string Priority { get; set; }
        public string DueDate { get; set; }
        public string ImpactedResources { get; set; }

    }
}
