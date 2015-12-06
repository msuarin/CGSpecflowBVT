Feature: Flex
	In order to manage Flex tickets
	As a CGWeb user
	I want to be able to create, delete and do various things with Flex tickets

@mytag
Scenario: Create a Flex ticket
	Given I am logged in to ChangeGear Web
	And I am on the Flex5 module page
	When I click on the new button in the action bar
	And I enter the following Flex5 data into the new ticket form:
	| Field     | Value                   |
	| Requester | Fred Thomson            |
	| Summary   | This is my Flex summary |
	| Type      | Type1                   |
	| Owner     | Desktop Services Team   |
	| Assignee  | Jim Jamieson            |
	| Impact    | 1 - Major               |
	| Urgency   | 4 - Low                 |
	| Priority  | 1 - Critical            |
	| DueDate   |                         |
	And I Submit the ticket
	And I click OK on the comment popup window
	And I close the ticket window
	And I click on the All Tickets view
	And I open the newest ticket
	Then The ticket should display the correct Flex5 data
	| Field     | Value                   |
	| Requester | Fred Thomson            |
	| Summary   | This is my Flex summary |
	| Type      | Type1                   |
	| Owner     | Desktop Services Team   |
	| Assignee  | Jim Jamieson            |
	| Impact    | 1 - Major               |
	| Urgency   | 4 - Low                 |
	| Priority  | 1 - Critical            |
	| DueDate   |                         |