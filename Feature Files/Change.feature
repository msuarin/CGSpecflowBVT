Feature: Change
	In order to manage Change tickets
	As a CGWeb user
	I want to be able to create, delete and do various things with Change tickets

@mytag
Scenario: Create a Change ticket
	Given I am logged in to ChangeGear Web
	And I am on the Change module page
	When I click on the new button in the action bar
	And I enter the following Change data into the new ticket form:
	| Field     | Value                     |
	| Requester | James Simpson             |
	| Summary   | This is my Change summary |
	| Type      | Hardware:Install:Memory   |
	| Owner     | HR Team                   |
	| Assignee  | Dave Ramond               |
	| Impact    | 2 - Significant           |
	| Urgency   | 2 - High                  |
	| Priority  | 1 - Emergency             |
	| DueDate   |                           |
	And I Submit the ticket
	And I click OK on the comment popup window
	And I close the ticket window
	And I click on the All Tickets view
	And I open the newest ticket
	Then The ticket should display the correct Change data
	| Field     | Value                     |
	| Requester | James Simpson             |
	| Summary   | This is my Change summary |
	| Type      | Hardware:Install:Memory   |
	| Owner     | HR Team                   |
	| Assignee  | Dave Ramond               |
	| Impact    | 2 - Significant           |
	| Urgency   | 2 - High                  |
	| Priority  | 1 - Emergency             |
	| DueDate   |                           |
