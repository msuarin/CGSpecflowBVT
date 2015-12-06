using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGSpecFlowBVT.PageIDs
{
    public class TaskManagerIDs
    {
        public string incidentView =
            @"//*[@id='ViewChooser1_ViewDropDownList']/option[contains(@selected, 'selected')][text()[contains(., 'My Incident Tasks')]]";
        public string changeView =
             @"//*[@id='ViewChooser1_ViewDropDownList']/option[contains(@selected, 'selected')][text()[contains(., 'My Tasks')]]";
    }
}