﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.2.1
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34014
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace CGSpecFlowBVT.FeatureFiles
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.2.1")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class IncidentFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Incident.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Incident", "In order to manage Incident tickets\r\nAs a CGWeb user\r\nI want to be able to create" +
                    ", delete and do various things with Incident tickets", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Incident")))
            {
                CGSpecFlowBVT.FeatureFiles.IncidentFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Create an Incident Ticket")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Incident")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mytag")]
        public virtual void CreateAnIncidentTicket()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create an Incident Ticket", new string[] {
                        "mytag"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I am logged in to ChangeGear Web", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.And("I am on the Incident module page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.When("I click on the new button in the action bar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1.AddRow(new string[] {
                        "Requester",
                        "Bob Johnson"});
            table1.AddRow(new string[] {
                        "Summary",
                        "This is my Summary"});
            table1.AddRow(new string[] {
                        "Type",
                        "Service Request:Password Reset:Password Change"});
            table1.AddRow(new string[] {
                        "Owner",
                        "Network Team"});
            table1.AddRow(new string[] {
                        "Assignee",
                        "Erin Lane"});
            table1.AddRow(new string[] {
                        "Impact",
                        "4 - Routine"});
            table1.AddRow(new string[] {
                        "Urgency",
                        "2 - High"});
            table1.AddRow(new string[] {
                        "Priority",
                        "1 - Critical"});
            table1.AddRow(new string[] {
                        "DueDate",
                        ""});
            table1.AddRow(new string[] {
                        "Origin",
                        "myOrigin"});
            table1.AddRow(new string[] {
                        "ImpactedBusinessServices",
                        "CHANGEGEAR ENTERPRISE:HERMES"});
#line 11
 testRunner.And("I enter the following Incident data into the new ticket form:", ((string)(null)), table1, "And ");
#line 24
 testRunner.And("I Submit the ticket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.And("I close the ticket window", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.And("I click on the All Incidents view", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.And("I open the newest ticket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table2.AddRow(new string[] {
                        "Requester",
                        "Bob Johnson"});
            table2.AddRow(new string[] {
                        "Summary",
                        "This is my Summary"});
            table2.AddRow(new string[] {
                        "Type",
                        "Service Request:Password Reset:Password Change"});
            table2.AddRow(new string[] {
                        "Owner",
                        "Network Team"});
            table2.AddRow(new string[] {
                        "Assignee",
                        "Erin Lane"});
            table2.AddRow(new string[] {
                        "Impact",
                        "4 - Routine"});
            table2.AddRow(new string[] {
                        "Urgency",
                        "2 - High"});
            table2.AddRow(new string[] {
                        "Priority",
                        "1 - Critical"});
            table2.AddRow(new string[] {
                        "DueDate",
                        ""});
            table2.AddRow(new string[] {
                        "Origin",
                        "myOrigin"});
            table2.AddRow(new string[] {
                        "ImpactedBusinessServices",
                        "CHANGEGEAR ENTERPRISE:HERMES"});
#line 28
 testRunner.Then("The ticket should display the correct Incident data", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion