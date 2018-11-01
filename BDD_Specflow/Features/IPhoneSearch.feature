Feature: IPhoneSearch
	In order to use all options of Rozetka site
	As a customer
	I would like to search and get information about IPhone 7 and Iphone 7 Plus


Scenario Outline: Searching for IPhone7
	Given As an user, I open Mobile Phone tab on Rozetka
	When I select a phone as 'Apple' and phone version '<PhoneVersion>'
	#Then I see information regarding to my search

Examples:
	| TestId | PhoneVersion  |
	| 1      | iPhone 7      |
	| 2      | iPhone 7 Plus |
	
