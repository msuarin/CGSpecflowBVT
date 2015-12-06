using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CGSpecFlowBVT.Page_Objects;
using CGSpecFlowBVT.PageIDs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CGSpecFlowBVT.Page_Object_Parts
{
    public static class ModuleActionBar
    {
        public static ActionBarIDs ID = new ActionBarIDs();

        public static void ClickPrint()
        {
            GeneralPage.ClickOnObject(ID.print);
        }

        public static void ClickEmail()
        {
            GeneralPage.ClickOnObject(ID.email);
        }

        public static void ClickHyperlink()
        {
            GeneralPage.ClickOnObject(ID.hyperlink);
        }

        public static void ClickNew()
        {
            GeneralPage.ClickOnObject(ID.newBtn);
        }

        //Overload of ClickNew() for Service Request types
        public static void ClickNew(string ticketType)
        {
            string xPathType = "";
            
            switch (ticketType)
            {
                case "Access Request":
                    {
                        xPathType = "AccessRequest";
                        break;
                    }
                case "General Request":
                    {
                        xPathType = "GeneralRequest";
                        break;
                    }
                case "Hardware Request":
                    {
                        xPathType = "HardwareRequest";
                        break;
                    }
                case "Move Request":
                    {
                        xPathType = "MoveRequest";
                        break;
                    }
                case "Software Request":
                    {
                        xPathType = "SoftwareRequest";
                        break;
                    }
                case "Training Request":
                    {
                        xPathType = "TrainingRequest";
                        break;
                    }
                default:
                    {
                        Assert.Fail("Unknown Service request Type. Check the feature file for errors."); 
                        break;
                    }
            }
            GeneralPage.ClickOnObject(ID.newBtn);
            GeneralPage.ClickOnObject(ID.GenerateSRNewTypeXPath(xPathType));
        }

        public static void ClickTemplateDD(string template)
        {
            GeneralPage.ClickOnObject(ID.templateDD);
            //implement template
        }

        public static void ClickEdit()
        {
            GeneralPage.ClickOnObject(ID.edit);
        }

        public static void ClickDuplicate()
        {
            GeneralPage.ClickOnObject(ID.duplicate);
        }

        public static void ClickDelete()
        {
            GeneralPage.ClickOnObject(ID.delete);
        }

        public static void ClickRefresh()
        {
            GeneralPage.ClickOnObject(ID.refresh);
        }

        public static void ClickSearch()
        {
            GeneralPage.ClickOnObject(ID.search);
        }
    }
}
