Feature: receivingTests
	Simple calculator for adding two numbers

@mytag
Scenario: Add two numbers
	Given input first input value of <valueOne> and <valueTwo>
	Then the sum should be <sum>

	Examples:
	| valueOne | valueTwo | sum |
	| 3        | 5        | 8   |
	| -5       | 12       | 7   |
	| 3        | -5       | -2  |
	| -4       | -5       | -9  |
	| 363      | 584      | 947 |