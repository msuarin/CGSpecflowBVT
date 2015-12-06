Feature: Navigation
	In order to see different pages
	As a CG user
	I want to be able to navigate to different pages

@mytag
Scenario: Navigate to the Incident module
	Given I am logged in to ChangeGear Web
	And I am on the Problem module page
	When I navigate to the Incident module page
	Then I am on the Incident module page

Scenario: Navigate to the Problem module
	Given I am logged in to ChangeGear Web
	And I am on the Incident module page
	When I navigate to the Problem module page
	Then I am on the Problem module page

Scenario:  Navigate to the Change module
	Given I am logged in to ChangeGear Web
	And I am on the Incident module page
	When I navigate to the Change module page
	Then I am on the Change module page

Scenario: Navigate to the Flex1 module
	Given I am logged in to ChangeGear Web
	And I am on the Change module page
	When I navigate to the Flex1 module page
	Then I am on the Flex1 module page

Scenario: Navigate to the Flex2 module
	Given I am logged in to ChangeGear Web
	And I am on the Change module page
	When I navigate to the Flex2 module page
	Then I am on the Flex2 module page

Scenario: Navigate to the Service Catalog module
	Given I am logged in to ChangeGear Web
	And I am on the Incident module page
	When I navigate to the Service Catalog module page
	Then I am on the Service Catalog module page

Scenario: Navigate to the CMDB module
	Given I am logged in to ChangeGear Web
	And I am on the Incident module page
	When I navigate to the CMDB module page
	Then I am on the CMDB module page

Scenario: Navigate to the Knowledge Base module
	Given I am logged in to ChangeGear Web
	And I am on the Incident module page
	When I navigate to the Knowledge Base module page
	Then I am on the Knowledge Base module page

Scenario: Navigate to the Reports module
	Given I am logged in to ChangeGear Web
	And I am on the Incident module page
	When I navigate to the Reports module page
	Then I am on the Reports module page

Scenario: Navigate to the Survey module
	Given I am logged in to ChangeGear Web
	And I am on the Incident module page
	When I navigate to the Survey module page
	Then I am on the Survey module page