Feature: AmazonTest

A short summary of the feature

	Scenario Outline: Validate search bar functionality is working for multiple products
	Given User Navigate to amazon.in 
    When User Amazon Home Page 
	And user search the product "<Item>" filter folder
	Then user validate the searched word from Result Info bar "<Item>"
	Examples:
	| Item	        | 
	| Toy           |
	| Phone         |

	Scenario: Valdiate image logo
	Given User Navigate to amazon.in 
	When Select the Hamburger Menu button from the main navigation bar 
	And User select option 'Mobiles, Computers'
	And Select option 'Software
	Then User validate the log is present under 'Top categories' section

	Scenario: Validate item is added to the cart
	Given User Navigate to amazon.in 
    When User Amazon Home Page 
	And user search the product 'Toy'
	And User select the first produc
	And User Click on Add Cart
	Then select shopping cart and validate if added item is present in the shopping cart