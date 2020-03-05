Feature: Amazon search
  Scenario: Perform an Amazon Search
    Given User navigates to Amazon page
    When The user performs a search for Samsung Galaxy S9
    Then The user Validates the price and adds product to cart
	Then The user Creates an Account
	Then Close browser