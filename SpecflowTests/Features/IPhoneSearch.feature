Feature: IPhoneSearch
	In order to use all options of Rozetka site
	As a customer
	I would like to search and get information about IPhone 7 and Iphone 7 Plus


Scenario: Compare characteristics 
	Given As an user, I open Mobile Phone tab on Rozetka
	And I select a phone as 'Apple' 
	When I open characteristics for 'iPhone 7, iPhone 7 Plus' phone versions
	Then I compare characteristics for 'iPhone 7' and 'iPhone 7 Plus' phone versions
	And I save common phone details to a file

	
