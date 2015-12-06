using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGSpecFlowBVT.PageIDs
{
    //ID classes are non static so they can only be called from the static object page. They have to be called at the object level like IncidentPage.
    //Accessing these IDs would look something like : "IncidentPage.ID.incidentPageTitle". Here, IncidentPage is the static object class, ID is the name of the
    //instance that you declare in the incident object page, and incidentPageTitle is the actual ID
    public class IncidentIDs : GeneralPageIDs
    {
        public string sidebarIncidentModuleSelectBtn = @"//form[contains(@id, 'form2')]/div[4]/ul/li[text()[contains(., 'Incident')]]";
        public string incidentPageTitle = @"//form[contains(@id, 'form2')]/div[2]/div/div[2][text()[contains(., 'Incident')]]";

        //Looks for 'All Incidents' view in the left sidebar
        public string allIncidentsView = @"//form[contains(@id, 'form2')]/div[3]/div/div/div//ul/li[text()[contains(., 'All Incidents')]]";

        //Incident form elements
        public string ticketInfo = @"//*[@id='ticketDescription']";

        //Incident Task elements
        public string taskInfo = @"//*[@id='ticketDescription']";

        //Incident form IDs

        //To extract value of type field, use this
        //public string incidentTypeValue = @"//table[contains(@id, 'IncidentRequestType')]" +
        //    @"/tbody/tr/td[1]/input[contains(@id, 'IncidentRequestType')]";
    }
}
