Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator]($projectname$/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@TwoNumbersForAddition
Scenario: Add two numbers for addition
	Given the first addition number is 50
	And the second addition number is 70
	When the two additions numbers are added
	Then the addition result should be 120
	
	
@TwoNumbersForMultiplication
	Scenario: Add two numbers for multiplication
		Given the first multiplication number is 50
		And the second multiplication number is 70
		When the two multiplications numbers are added
		Then the multiplication result should be 3500
		
		
@TwoNumbersForDivision
Scenario: Add two numbers for division
	Given the first division number is 30
	And the second division number is 3
	When the two division numbers are added
	Then the division result should be 10

@TwoNumbersForDivisionByZero
Scenario: Add two numbers for division by zero
	Given the first division by zero number is 12
	And the second division by zero number is 0
	When the two numbers division by zero are added
	Then the error 'Division by zero impossible' should be raised
	

@anyNumbersForAddition
Scenario: Add any numbers for addition
