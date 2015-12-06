using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGSpecFlowBVT.PageIDs
{
    public class TicketGridIDs
    {
        //To access the grid, switch to main grid frame
        public string mainGridFrame = @"//*[@id='mainGrid']";

        //Generates Xpath for a ticket on the main grid. Takes integers to determine which ticket xpath to return
        //1 returns top most ticket, 2 returns 2nd ticket, 3 returns 3rd ticket and so on
        public string GenerateTicketGridXPath(int ticketPosition)
        {
            string xPath = @"//table[contains(@id, 'GeneralGridControl') and contains(@id, 'MainTable')]" +
                @"/tbody/tr[" + (ticketPosition + 1) + @"]";
            return xPath;
        }
    }
}
