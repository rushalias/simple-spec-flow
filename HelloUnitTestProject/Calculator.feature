Feature: Calculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario Outline: Add two numbers
	Given I have entered First Number <n1> into the calculator
	And I have entered Second Number <n2> into the calculator
	When I press add
	Then the result should be <total> on the screen 
	
	Examples: 
	| i | n1 | n2 | total |
	| 0 | 50 | 70 | 120   |
	| 1 | 5  | 7  | 12    |
	| 2 | 1  | 1  | 2     |
	| 3 | 10 | 10 | 20    | 
