Feature: SpecFlowFeature2
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: Login
	Given I go to home page
	And I enter <username> and <password>
	Then I see user account
	And Close Browser
Examples: 
| username | password |
|Ksenvov|Qwerty12345|