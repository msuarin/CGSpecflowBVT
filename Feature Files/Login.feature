Feature: Login
	In order to access CGWeb
	As a CG user
	I want to be be able to log in and log out

@mytag
Scenario: Log in to ChangeGear Web
	Given I am logged in to ChangeGear Web
	And I log out from ChangeGear Web
	When I log in to ChangeGear Web using the credentials: qalab\administrator, qatest04
	Then I am logged in as Admin, QALAB\administrator

Scenario: Log out from ChangeGear Web
	Given I am logged in to ChangeGear Web
	When I log out from ChangeGear Web
	Then I am on the logged in page
