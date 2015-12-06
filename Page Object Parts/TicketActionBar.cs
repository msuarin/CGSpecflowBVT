using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CGSpecFlowBVT.Page_Objects;
using CGSpecFlowBVT.PageIDs;

namespace CGSpecFlowBVT.Page_Object_Parts
{
    public static class TicketActionBar
    {
        public static TicketActionBarIDs ID = new TicketActionBarIDs();

        public static void ClickAction(string action)
        {
            GeneralPage.ClickOnObject(ID.GenerateTicketActionXPath(action));
        }
    }
}
