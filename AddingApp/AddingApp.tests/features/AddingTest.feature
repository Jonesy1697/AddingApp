Feature: AddingTest
	Simple calculator for adding two numbers

@mytag
Scenario Outline: Add two numbers
	Given the first number is <value1>
	And the second number is <value2>
	When the two numbers are added
	Then the result should be <result>

	Examples: 
	| value1 | value2 | result |
	| 16     | 35     | 51     |
	| -6     | 7      | 1      |
	| -4     | -6     | -10    |
	| 27     | -33    | -6     |
