using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGSpecFlowBVT.Data_Objects
{
    public class ServiceRequestData : ModuleData
    {
        //Access Request
        public string System { get; set; }
        public string AccessLevel { get; set; }
        public string AccessLocation { get; set; }

        //Hardware Request and Software Request
        public string OperatingSystem { get; set; }

        //Hardware Request
        public string HardwareType { get; set; }

        //Software Request
        public string RequestedSoftware { get; set; }

        //Move Request
        public string EmployeeName { get; set; }
        public string EmployeeType { get; set; }
        public string Position { get; set; }
        public string CurrentLocation { get; set; }
        public string NewLocation { get; set; }
        public string CurrentCubeOrOffice { get; set; }
        public string NewCubeOrOffice { get; set; }
        public string CurrentPhoneExt { get; set; }
        public string NewPhoneExt { get; set; }

        //Training Request
        public string CourseName { get; set; }
        public string ProgramType { get; set; }
        public string TrainingLevel { get; set; }
        public string CourseCost { get; set; }
    }
}
