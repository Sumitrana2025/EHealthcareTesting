Feature: EHealthcare

A short summary of the feature

@tag1
Scenario: Add products to the cart and doing payments
	Given I enter username
	Then I entered password
	When I clicked on Add to cart button
	Then I click on add to cart symbol button
	When I clicked on Checkout button
	When Shipping address page displays and click on next button
	Then Review order page displays and click on next button
	When I enter Card Name
	Then I enter Card number
	Then I enter expiry date
	Then I enter CVV
	When I click on place order button payment successful page displays
