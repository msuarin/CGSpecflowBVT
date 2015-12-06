using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGSpecFlowBVT.PageIDs
{
    public class ServiceRequestIDs : GeneralPageIDs
    {
        public string sidebarServiceRequestModuleSelectBtn =
            @"//form[contains(@id, 'form2')]/div[4]/ul/li[text()[contains(., 'Service Request')]]";
        public string serviceRequestPageTitle = 
            @"//form[contains(@id, 'form2')]/div[2]/div/div[2][text()[contains(., 'Service Request')]]";

        //Looks for 'All Requests' view in the left sidebar
        public string allRequestsView =
            @"//form[contains(@id, 'form2')]/div[3]/div/div/div//ul/li[text()[contains(., 'All Requests')]]";

        //Access Request System selection
        public string systemDropdown = @"//select[contains(@id, 'SystemUsed') and contains(@id, 'ddl')]";
        //System Value extraction
        public string systemValue = @"//select[contains(@id, 'SystemUsed') and contains(@id, 'ddl')]" +
            @"/option[contains(@selected, 'selected')]";

        //Access Request Access Level selection
        public string accessLevelDropdown = @"//select[contains(@id, 'AccessLevel') and contains(@id, 'ddl')]";
        //Access Level Value extraction
        public string accessLevelValue = @"//select[contains(@id, 'AccessLevel') and contains(@id, 'ddl')]" +
            @"/option[contains(@selected, 'selected')]";

        //Access Request Access Location selection
        public string accessLocationDropdown = @"//select[contains(@id, 'AccessLocation') and contains(@id, 'ddl')]";
        //Access Location Value extraction
        public string accessLocationValue = @"//select[contains(@id, 'AccessLocation') and contains(@id, 'ddl')]" +
            @"/option[contains(@selected, 'selected')]";

        //Hardware Request Hardware type selection
        public string hardwareTypeDropdown = @"//select[contains(@id, 'HardwareType') and contains(@id, 'ddl')]";
        //Hardware type value extraction
        public string hardwareTypeValue = @"//select[contains(@id, 'HardwareType') and contains(@id, 'ddl')]" +
            @"/option[contains(@selected, 'selected')]";

        //Hardware Request Operating System selection
        public string operatingSystemDropdown = @"//select[contains(@id, 'OS') and contains(@id, 'ddl')]";
        //Operating System value extraction
        public string operatingSystemValue = @"//select[contains(@id, 'OS') and contains(@id, 'ddl')]" +
            @"/option[contains(@selected, 'selected')]";

        //Software Request requested software selection
        public string requestedSoftwareDropdown = @"//select[contains(@id, 'Software') and contains(@id, 'ddl')]";
        //Requested software value extraction
        public string requestedSoftwareValue = @"//select[contains(@id, 'Software') and contains(@id, 'ddl')]" +
            @"/option[contains(@selected, 'selected')]";

        //Training Request course name selection and value extraction
        public string coursenameTextbox = @"//input[contains(@id, 'CourseName') and contains(@id, 'txtbx')]";

        //Training Request program type selection
        public string programTypeDropdown = @"//select[contains(@id, 'ProgramType') and contains(@id, 'ddl')]";
        //Training Request program type value
        public string programTypeValue = @"//select[contains(@id, 'ProgramType') and contains(@id, 'ddl')]" +
            @"/option[contains(@selected, 'selected')]";

        //Training Request training level selection
        public string trainingLevelDropdown = @"//select[contains(@id, 'TrainingLevel') and contains(@id, 'ddl')]";
        //Training Request training level value
        public string trainingLevelValue = @"//select[contains(@id, 'TrainingLevel') and contains(@id, 'ddl')]" +
            @"/option[contains(@selected, 'selected')]";

        //Training Request course cost selection and value extraction
        public string courseCostTextbox = @"//input[contains(@id, 'CourseCost') and contains(@id, 'txtbx')]";

        //Training Request Course Start Date
        public string courseStartDateButton =
            @"//img[contains(@id, 'CourseStartDate') and contains(@id, 'dtc') and contains(@id, '_Date_')]";
        //Course Start Date today
        public string courseStartTodayDate = @"//table[contains(@id, 'CourseStartDate')]" + 
            @"//td[contains(@class, 'CalendarDay_') and contains(@class, 'CalendarToday_')]";

        //Training Request Course End Date
        public string courseEndDateButton =
            @"//img[contains(@id, 'CourseEndDate') and contains(@id, 'dtc') and contains(@id, '_Date_')]";
        //Course End Date today
        public string courseEndTodayDate = @"//table[contains(@id, 'CourseEndDate')]" +
            @"//td[contains(@class, 'CalendarDay_') and contains(@class, 'CalendarToday_')]";

        //Move Request Employee Name selection and value extraction
        public string employeeName = @"//input[contains(@id, 'EmployeeName') and contains(@id, 'txtbx')]";

        //Move Request Employee Type selection and value extraction
        public string employeeType = @"//input[contains(@id, 'EmployeeType') and contains(@id, 'txtbx')]";

        //Move Request Position selection and value extraction
        public string position = @"//input[contains(@id, 'Position') and contains(@id, 'txtbx')]";

        //Move Request Current cube or office selection and value extraction
        public string currentCubeOffice = @"//input[contains(@id, 'CurrentCubeOffice') and contains(@id, 'txtbx')]";

        //Move Request New cube or office selection and value extraction
        public string newCubeOffice = @"//input[contains(@id, 'NewCubeOffice') and contains(@id, 'txtbx')]";

        //Move Request Current phone ext selection and value extraction
        public string currentPhoneExt = @"//input[contains(@id, 'CurrentPhoneExt') and contains(@id, 'txtbx')]";

        //Move Request New phone ext  selection and value extraction
        public string newPhoneExt = @"//input[contains(@id, 'NewPhoneExt') and contains(@id, 'txtbx')]";

        //Current Location Arrow
        public string currentLocationArrow = @"//td[contains(@id, 'DynamicLayoutControl') and contains(@id, 'CurrentLocation')" +
            @" and contains(@id, 'DropDownEdit')]";
        //To extract value of Current Location field, use this
        public string currentLocationValue = @"//table[contains(@id, 'CurrentLocation')]" +
            @"/tbody/tr/td[1]/input[contains(@id, 'CurrentLocation')]";
        //New Location Arrow
        public string newLocationArrow = @"//td[contains(@id, 'DynamicLayoutControl') and contains(@id, 'NewLocation')" +
            @" and contains(@id, 'DropDownEdit')]";
        //To extract value of New Location field, use this
        public string newLocationValue = @"//table[contains(@id, 'NewLocation')]" +
            @"/tbody/tr/td[1]/input[contains(@id, 'NewLocation')]";
    }
}
