Feature: URLinterface
	In order to access different pages using the URL
	As a CGWeb user
	I want to be able to use the URL interface

@mytag
Scenario: Navigate to the Incident module using its URL
	Given I am logged in to ChangeGear Web
	When I type the Incident module URL in my browser
	Then I am on the Incident module page

Scenario: Navigate to the Problem module using its URL
	Given I am logged in to ChangeGear Web
	When I type the Problem module URL in my browser
	Then I am on the Problem module page

Scenario: Navigate to the Change module using its URL
	Given I am logged in to ChangeGear Web
	When I type the Change module URL in my browser
	Then I am on the Change module page

Scenario: Navigate to the Flex1 module using its URL
	Given I am logged in to ChangeGear Web
	When I type the Flex1 module URL in my browser
	Then I am on the Flex1 module page

Scenario: Navigate to the Flex2 module using its URL
	Given I am logged in to ChangeGear Web
	When I type the Flex2 module URL in my browser
	Then I am on the Flex2 module page

Scenario: Navigate to the KB Module URL
	Given I am logged in to ChangeGear Web
	When I type the Knowledge Base module URL in my browser
	Then I am on the Knowledge Base module page

Scenario: Navigate to the Survey Module URL
	Given I am logged in to ChangeGear Web
	When I type the Survey module URL in my browser
	Then I am on the Survey module page

Scenario: Navigate to the Reports Module URL
	Given I am logged in to ChangeGear Web
	When I type the Reports module URL in my browser
	Then I am on the Reports module page

Scenario: Navigate to the CMDB Module URL
	Given I am logged in to ChangeGear Web
	When I type the CMDB module URL in my browser
	Then I am on the CMDB module page

Scenario: Navigate to the Service Catalog Module URL
	Given I am logged in to ChangeGear Web
	When I type the Service Catalog module URL in my browser
	Then I am on the Service Catalog module page

Scenario: Navigate to the Self-Service Portal URL
	Given I am logged in to ChangeGear Web
	When I type the SSP page URL in my browser
	Then I am on the SSP CGWeb page

Scenario: Navigate to the Announcement Portal URL
	Given I am logged in to ChangeGear Web
	When I type the Announcement Portal page URL in my browser
	Then I am on the Announcement Portal CGWeb page

Scenario: Navigate to the Announcement Manager URL
	Given I am logged in to ChangeGear Web
	When I type the Announcement Manager page URL in my browser
	Then I am on the Announcement Manager CGWeb page

Scenario: Navigate to the Incident Template Manager URL
	Given I am logged in to ChangeGear Web
	When I type the Incident Template Manager page URL in my browser
	Then I am on the Incident Template Manager CGWeb page

Scenario: Navigate to the Problem Template Manager URL
	Given I am logged in to ChangeGear Web
	When I type the Problem Template Manager page URL in my browser
	Then I am on the Problem Template Manager CGWeb page

Scenario: Navigate to the Change Template Manager URL
	Given I am logged in to ChangeGear Web
	When I type the Change Template Manager page URL in my browser
	Then I am on the Change Template Manager CGWeb page

Scenario: Navigate to the Flex1 Template Manager URL
	Given I am logged in to ChangeGear Web
	When I type the Flex1 Template Manager page URL in my browser
	Then I am on the Flex1 Template Manager CGWeb page

Scenario: Navigate to the Flex2 Template Manager URL
	Given I am logged in to ChangeGear Web
	When I type the Flex2 Template Manager page URL in my browser
	Then I am on the Flex2 Template Manager CGWeb page

Scenario: Navigate to the Incident Task Manager URL
	Given I am logged in to ChangeGear Web
	When I type the Incident Task Manager page URL in my browser
	Then I am on the Incident Task Manager CGWeb page

Scenario: Navigate to the Change Task Manager URL
	Given I am logged in to ChangeGear Web
	When I type the Change Task Manager page URL in my browser
	Then I am on the Change Task Manager CGWeb page

Scenario: Navigate to the User Center URL
	Given I am logged in to ChangeGear Web
	When I type the User Center page URL in my browser
	Then I am on the User Center CGWeb page

Scenario: Open an Incident ticket using its URL
	Given I am logged in to ChangeGear Web
	When I type the Incident module URL, with ticket number 9, in my browser
	Then The Incident ticket with ID 9 is visible

Scenario: Open a Problem ticket using its URL
	Given I am logged in to ChangeGear Web
	When I type the Problem module URL, with ticket number 1, in my browser
	Then The Problem ticket with ID 1 is visible

Scenario: Open a Change ticket using its URL
	Given I am logged in to ChangeGear Web
	When I type the Change module URL, with ticket number 1, in my browser
	Then The Change ticket with ID 1 is visible

Scenario: Open a Flex1 ticket using its URL
	Given I am logged in to ChangeGear Web
	When I type the Flex1 module URL, with ticket number 1, in my browser
	Then The Flex1 ticket with ID 1 is visible

Scenario: Open a Flex2 ticket using its URL
	Given I am logged in to ChangeGear Web
	When I type the Flex2 module URL, with ticket number 1, in my browser
	Then The Flex2 ticket with ID 1 is visible

Scenario: Open an Incident task using its URL
	Given I am logged in to ChangeGear Web
	When I type the Incident task module URL, with ticket number 1, in my browser
	Then The Incident task ticket with ID 1 is visible

Scenario: Open a Change task using its URL
	Given I am logged in to ChangeGear Web
	When I type the Change task module URL, with ticket number 1, in my browser
	Then The Change task ticket with ID 1 is visible

Scenario: Open an announcement using its URL
	Given I am logged in to ChangeGear Web
	When I type the Announcement module URL, with ticket number 1, in my browser
	Then The Announcement ticket with ID 1 is visible

Scenario: Open a KB using its URL
	Given I am logged in to ChangeGear Web
	When I type the Knowledge Base module URL, with ticket number 1, in my browser
	Then The Knowledge Base ticket with ID 1 is visible

Scenario: Open a Survey using its URL
	Given I am logged in to ChangeGear Web
	When I type the Survey module URL, with ticket number 1, in my browser
	Then The Survey ticket with ID 1 is visible

Scenario: Open a Report using its URL
	Given I am logged in to ChangeGear Web
	When I type the Report module URL, with ticket number 68, in my browser
	Then The Report ticket with ID 68 is visible

Scenario: Open a CI using its URL
	Given I am logged in to ChangeGear Web
	When I type the CMDB module URL, with ticket number 1, in my browser
	Then The CI ticket with ID 1 is visible