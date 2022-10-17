Feature: Addtocart

It will add the products to the cart and checkout

@tag1
Scenario: It will show add to cart and checkout navigation 
	Given I have navigated to EHealthcare website
	When I need to click on Catalog button
	Then It shows catalog 
	When I click on Add to cart button
	When I click on Cart symbol button
	Then It will navigate to checkout page
	When I click on Checkout button
	Then Checkout Page appears

