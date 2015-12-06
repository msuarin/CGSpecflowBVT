Feature: ServiceRequest
	In order to manage Service Request tickets
	As a CGWeb user
	I want to be able to create, delete and do various things with Service Request tickets

@mytag
Scenario: Create a Service Request ticket of type Access Request
	Given I am logged in to ChangeGear Web
	And I am on the Service Request module page
	#Options for SR types are(Make sure to follow the exact letter case and spacing): 
	#Access Request, General Request, Hardware Request, Move Request, Software Request, Training Request
	When I click on the new button in the action bar and select Access Request
	And I enter the following Service Request data into the new Access Request form:
	| Field          | Value                            |
	| Requester      | Bob Johnson                      |
	| Summary        | This is my Access Request ticket |
	| Urgency        | 2 - High                         |
	| Impact         | 3 - Minor                        |
	| Priority       | 4 - Low                          |
	| System         | CRM                              |
	| AccessLevel    | Super User                       |
	| AccessLocation | Home Office                      |
	And I Submit the ticket
	And I click OK on the comment popup window
	And I close the ticket window
	And I click on the All Open Requests view
	And I open the newest ticket
	Then The ticket should display the correct Service Request data of type Access Request
	| Field          | Value                            |
	| Requester      | Bob Johnson                      |
	| Summary        | This is my Access Request ticket |
	| Urgency        | 2 - High                         |
	| Impact         | 3 - Minor                        |
	| Priority       | 4 - Low                          |
	| System         | CRM                              |
	| AccessLevel    | Super User                       |
	| AccessLocation | Home Office                      |

Scenario: Create a Service Request ticket of type General Request
	Given I am logged in to ChangeGear Web
	And I am on the Service Request module page
	#Options for SR types are(Make sure to follow the exact letter case and spacing): 
	#Access Request, General Request, Hardware Request, Move Request, Software Request, Training Request
	When I click on the new button in the action bar and select General Request
	And I enter the following Service Request data into the new General Request form:
	| Field     | Value                             |
	| Requester | Bob Johnson                       |
	| Summary   | This is my General Request ticket |
	| Urgency   | 2 - High                          |
	| Impact    | 3 - Minor                         |
	| Priority  | 4 - Low                           |
	And I Submit the ticket
	And I click OK on the comment popup window
	And I close the ticket window
	And I click on the All Open Requests view
	And I open the newest ticket
	Then The ticket should display the correct Service Request data of type General Request
	| Field     | Value                             |
	| Requester | Bob Johnson                       |
	| Summary   | This is my General Request ticket |
	| Urgency   | 2 - High                          |
	| Impact    | 3 - Minor                         |
	| Priority  | 4 - Low                           |
	
Scenario: Create a Service Request ticket of type Hardware Request
	Given I am logged in to ChangeGear Web
	And I am on the Service Request module page
	#Options for SR types are(Make sure to follow the exact letter case and spacing): 
	#Access Request, General Request, Hardware Request, Move Request, Software Request, Training Request
	When I click on the new button in the action bar and select Hardware Request
	And I enter the following Service Request data into the new Hardware Request form:
	| Field           | Value                              |
	| Requester       | Bob Johnson                        |
	| Summary         | This is my Hardware Request ticket |
	| Urgency         | 2 - High                           |
	| Impact          | 3 - Minor                          |
	| Priority        | 4 - Low                            |
	| HardwareType    | Laptop Computer                    |
	| OperatingSystem | MAC OS                             |
	And I Submit the ticket
	And I click OK on the comment popup window
	And I close the ticket window
	And I click on the All Open Requests view
	And I open the newest ticket
	Then The ticket should display the correct Service Request data of type Hardware Request
	| Field           | Value                              |
	| Requester       | Bob Johnson                        |
	| Summary         | This is my Hardware Request ticket |
	| Urgency         | 2 - High                           |
	| Impact          | 3 - Minor                          |
	| Priority        | 4 - Low                            |
	| HardwareType    | Laptop Computer                    |
	| OperatingSystem | MAC OS                             |

Scenario: Create a Service Request ticket of type Move Request
	Given I am logged in to ChangeGear Web
	And I am on the Service Request module page
	#Options for SR types are(Make sure to follow the exact letter case and spacing): 
	#Access Request, General Request, Hardware Request, Move Request, Software Request, Training Request
	When I click on the new button in the action bar and select Move Request
	And I enter the following Service Request data into the new Move Request form:
	| Field               | Value                          |
	| Requester           | Bob Johnson                    |
	| Summary             | This is my Move Request ticket |
	| EmployeeName        | Mr. Employee                   |
	| EmployeeType        | Regular                        |
	| Position            | Software Developer             |
	| CurrentCubeOrOffice | 46B                            |
	| NewCubeOrOffice     | 25C                            |
	| CurrentPhoneExt     | 546                            |
	| NewPhoneExt         | 436                            |
	| CurrentLocation     | Europe:United Kingdom:London   |
	| NewLocation         | Australia:Sydney               |
	And I Submit the ticket
	And I click OK on the comment popup window
	And I close the ticket window
	And I click on the All Open Requests view
	And I open the newest ticket
	Then The ticket should display the correct Service Request data of type Move Request
	| Field               | Value                          |
	| Requester           | Bob Johnson                    |
	| Summary             | This is my Move Request ticket |
	| EmployeeName        | Mr. Employee                   |
	| EmployeeType        | Regular                        |
	| Position            | Software Developer             |
	| CurrentCubeOrOffice | 46B                            |
	| NewCubeOrOffice     | 25C                            |
	| CurrentPhoneExt     | 546                            |
	| NewPhoneExt         | 436                            |
	| CurrentLocation     | Europe:United Kingdom:London   |
	| NewLocation         | Australia:Sydney               |

Scenario: Create a Service Request ticket of type Software Request
	Given I am logged in to ChangeGear Web
	And I am on the Service Request module page
	#Options for SR types are(Make sure to follow the exact letter case and spacing): 
	#Access Request, General Request, Hardware Request, Move Request, Software Request, Training Request
	When I click on the new button in the action bar and select Software Request
	And I enter the following Service Request data into the new Software Request form:
	| Field             | Value                              |
	| Requester         | Bob Johnson                        |
	| Summary           | This is my Software Request ticket |
	| Urgency           | 2 - High                           |
	| Impact            | 3 - Minor                          |
	| Priority          | 4 - Low                            |
	| RequestedSoftware | Microsoft Office                   |
	| OperatingSystem   | Windows 7                          |
	And I Submit the ticket
	And I click OK on the comment popup window
	And I close the ticket window
	And I click on the All Open Requests view
	And I open the newest ticket
	Then The ticket should display the correct Service Request data of type Software Request
	| Field             | Value                              |
	| Requester         | Bob Johnson                        |
	| Summary           | This is my Software Request ticket |
	| Urgency           | 2 - High                           |
	| Impact            | 3 - Minor                          |
	| Priority          | 4 - Low                            |
	| RequestedSoftware | Microsoft Office                   |
	| OperatingSystem   | Windows 7                          |

Scenario: Create a Service Request ticket of type Training Request
	Given I am logged in to ChangeGear Web
	And I am on the Service Request module page
	#Options for SR types are(Make sure to follow the exact letter case and spacing): 
	#Access Request, General Request, Hardware Request, Move Request, Software Request, Training Request
	When I click on the new button in the action bar and select Training Request
	And I enter the following Service Request data into the new Training Request form:
	| Field         | Value                              |
	| Requester     | Bob Johnson                        |
	| Summary       | This is my Training Request ticket |
	| Urgency       | 2 - High                           |
	| Impact        | 3 - Minor                          |
	| Priority      | 4 - Low                            |
	| CourseName    | Javascript for Beginners           |
	| ProgramType   | Employee Development               |
	| TrainingLevel | Basic                              |
	| CourseCost    | $100.00                            |
	And I Submit the ticket
	And I click OK on the comment popup window
	And I close the ticket window
	And I click on the All Open Requests view
	And I open the newest ticket
	Then The ticket should display the correct Service Request data of type Training Request
	| Field         | Value                              |
	| Requester     | Bob Johnson                        |
	| Summary       | This is my Training Request ticket |
	| Urgency       | 2 - High                           |
	| Impact        | 3 - Minor                          |
	| Priority      | 4 - Low                            |
	| CourseName    | Javascript for Beginners           |
	| ProgramType   | Employee Development               |
	| TrainingLevel | Basic                              |
	| CourseCost    | $100.00                            |