Feature: Views
	In order see different views
	As a CG User
	I want to be able to click on different views

@mytag
Scenario: Access Incident views
	Given I am logged in to ChangeGear Web
	And I am on the Incident module page
	When I click on the All Incidents view
	Then I see the All Incidents view
	When I click on the Active Incidents view
	Then I see the Active Incidents view

	Scenario: Access Problem views
	Given I am logged in to ChangeGear Web
	And I am on the Problem module page
	When I click on the All Problems view
	Then I see the All Problems view
	When I click on the Active Problems view
	Then I see the Active Problems view

	Scenario: Access Change views
	Given I am logged in to ChangeGear Web
	And I am on the Change module page
	When I click on the All Tickets view
	Then I see the All Tickets view
	When I click on the Active Requests view
	Then I see the Active Requests view

	Scenario: Access Flex1 views
	Given I am logged in to ChangeGear Web
	And I am on the Flex1 module page
	When I click on the All Tickets view
	Then I see the All Tickets view
	When I click on the Active Requests view
	Then I see the Active Requests view

	Scenario: Access Flex2 views
	Given I am logged in to ChangeGear Web
	And I am on the Flex2 module page
	When I click on the All Tickets view
	Then I see the All Tickets view
	When I click on the Active Requests view
	Then I see the Active Requests view

	Scenario: Access CMDB views
	Given I am logged in to ChangeGear Web
	And I am on the CMDB module page
	When I click on the All Resources view
	Then I see the All Resources view
	When I click on the All Managed Items view
	Then I see the My Managed Items view

	Scenario: Access KB views
	Given I am logged in to ChangeGear Web
	And I am on the Knowledge Base module page
	When I click on the All Articles view
	Then I see the All Articles view
	When I click on the Recent Articles view
	Then I see the Recent Articles view

	Scenario: Access Survey views
	Given I am logged in to ChangeGear Web
	And I am on the Survey module page
	When I click on the All Surveys view
	Then I see the All Surveys view
	When I click on the Draft view
	Then I see the Draft view




