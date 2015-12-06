using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGSpecFlowBVT.PageIDs
{
    public class TemplateManagerIDs
    {
        public string incidentView =
            @"//*[@id='ViewChooser1_ViewDropDownList']/option[contains(@selected, 'selected')][text()[contains(., 'Incident Templates')]]";
        public string problemView =
            @"//*[@id='ViewChooser1_ViewDropDownList']/option[contains(@selected, 'selected')][text()[contains(., 'Problem Templates')]]";
        public string changeView =
            @"//*[@id='ViewChooser1_ViewDropDownList']/option[contains(@selected, 'selected')][text()[contains(., 'Change Templates')]]";
        public string flex1View =
            @"//*[@id='ViewChooser1_ViewDropDownList']/option[contains(@selected, 'selected')][text()[contains(., 'Flex1 Templates')]]";
        public string flex2View =
            @"//*[@id='ViewChooser1_ViewDropDownList']/option[contains(@selected, 'selected')][text()[contains(., 'Flex2 Templates')]]";
    }
}
