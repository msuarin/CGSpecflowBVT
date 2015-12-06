Feature: Incident
	In order to manage Incident tickets
	As a CGWeb user
	I want to be able to create, delete and do various things with Incident tickets

@mytag
Scenario: Create an Incident Ticket
	Given I am logged in to ChangeGear Web
	And I am on the Incident module page
	When I click on the new button in the action bar
	And I enter the following Incident data into the new ticket form:
	| Field                    | Value                                          |
	| Requester                | Bob Johnson                                    |
	| Summary                  | This is my Summary                             |
	| Type                     | Service Request:Password Reset:Password Change |
	| Owner                    | Network Team                                   |
	| Assignee                 | Erin Lane                                      |
	| Impact                   | 4 - Routine                                    |
	| Urgency                  | 2 - High                                       |
	| Priority                 | 1 - Critical                                   |
	| DueDate                  |                                                |
	| Origin                   | myOrigin                                       |
	| ImpactedBusinessServices | CHANGEGEAR ENTERPRISE:HERMES                   |
	And I Submit the ticket
	And I close the ticket window
	And I click on the All Incidents view
	And I open the newest ticket
	Then The ticket should display the correct Incident data
	| Field                    | Value                                          |
	| Requester                | Bob Johnson                                    |
	| Summary                  | This is my Summary                             |
	| Type                     | Service Request:Password Reset:Password Change |
	| Owner                    | Network Team                                   |
	| Assignee                 | Erin Lane                                      |
	| Impact                   | 4 - Routine                                    |
	| Urgency                  | 2 - High                                       |
	| Priority                 | 1 - Critical                                   |
	| DueDate                  |                                                |
	| Origin                   | myOrigin                                       |
	| ImpactedBusinessServices | CHANGEGEAR ENTERPRISE:HERMES                   |