using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGSpecFlowBVT.PageIDs
{
    public class TicketActionBarIDs
    {
        public string GenerateTicketActionXPath(string actionName)
        {
            string xPath = @"//td[contains(@id, 'ActionBarControl') and contains(@id, 'ButtonCell')]" +
                @"/a[contains(@id, '" + actionName + "')]";
            return xPath;
        }
    }
}
