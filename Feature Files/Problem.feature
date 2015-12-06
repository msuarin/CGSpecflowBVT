Feature: Problem
	In order to manage Problem tickets
	As a CGWeb user
	I want to be able to create, delete and do various things with Problem tickets

@mytag
Scenario: Create a Problem ticket
	Given I am logged in to ChangeGear Web
	And I am on the Problem module page
	When I click on the new button in the action bar
	And I enter the following Problem data into the new ticket form:
	| Field                    | Value                        |
	| Requester                | Rose Stephens                |
	| Summary                  | This is my problem summary   |
	| Type                     | Service:Email Services       |
	| Owner                    | SAP Team                     |
	| Assignee                 | Anthony Miller               |
	| Impact                   | 1 - Major                    |
	| Urgency                  | 3 - Medium                   |
	| Priority                 | 4 - Low                      |
	| DueDate                  |                              |
	And I Submit the ticket
	And I close the ticket window
	And I click on the All Problems view
	And I open the newest ticket
	Then The ticket should display the correct Problem data
	| Field                    | Value                        |
	| Requester                | Rose Stephens                |
	| Summary                  | This is my problem summary   |
	| Type                     | Service:Email Services       |
	| Owner                    | SAP Team                     |
	| Assignee                 | Anthony Miller               |
	| Impact                   | 1 - Major                    |
	| Urgency                  | 3 - Medium                   |
	| Priority                 | 4 - Low                      |
	| DueDate                  |                              |