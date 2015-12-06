using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGSpecFlowBVT.PageIDs
{
    public class ActionBarIDs
    {
        public string print = @"//*[@id='ActionBarControl1_PrintLinkButton']";
        public string email = @"//*[@id='ActionBarControl1_EmailHyperLink']";
        public string hyperlink = @"//*[@id='ActionBarControl1_LinkUrlButton']";

        public string newBtn = @"//*[@id='ActionBarControl1_New_Button']";
        public string templateDD = @"//*[@id='ActionBarControl1_TemplateDropDownImage']";
        public string edit = @"//*[@id='ActionBarControl1_Edit_Button']";
        public string duplicate = @"//*[@id='ActionBarControl1_Duplicate_Button']";
        public string delete = @"//*[@id='ActionBarControl1_Delete_Button']";
        public string refresh = @"//*[@id='ActionBarControl1_Refresh_Button']";
        public string search = @"//*[@id='ActionBarControl1_Search_Button']";

        //Method to generate XPath for ServiceRequest types from clicking new
        public string GenerateSRNewTypeXPath(string ticketType)
        {
            string xPath =
                @"//a[contains(@id, 'CreateTicketPopupControl') and contains(@id, 'Button') and contains(@id, '" +
                ticketType + "')]";

            return xPath;
        }

        //To access the action bar, switch to main grid frame
        public string mainGridFrame = @"//*[@id='mainGrid']";
    }
}
