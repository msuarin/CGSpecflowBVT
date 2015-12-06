using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CGSpecFlowBVT.Page_Objects;
using CGSpecFlowBVT.PageIDs;

namespace CGSpecFlowBVT.Page_Object_Parts
{
    public static class TicketGrid
    {
        public static TicketGridIDs ID = new TicketGridIDs();

        public static void DoubleClickTicketInGrid(int ticketPosition)
        {
            GeneralPage.DoubleClickObject(ID.GenerateTicketGridXPath(ticketPosition));
        }

        //This can be used to see if highlight works by single clicking a row in the grid. This particular test is not yet implemented.
        public static void ClickOnTicket(int ticketPosition)
        {
            GeneralPage.ClickOnObject(ID.GenerateTicketGridXPath(ticketPosition));
        }
    }
}
