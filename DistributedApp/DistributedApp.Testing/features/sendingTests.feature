Feature: sendingTests
	Simple calculator for adding two numbers

@mytag
Scenario: Message correctly packed
	Given the input string of <inputString>
	When the sender is called
	Then the first value should be <value1>
	And the second value should be <value2>

	Examples: 
	| inputString | value1 | value2 |
	| 36,33       | 36     | 33     |
	| -35,15      | -35    | 15     |
	| 531, -516   | 531    | -516   |

Scenario: Exception on message
	Given the input string of <inputString>
	When the sender is called
	Then an exception should be raised

	Examples:
	| inputString |
	| agih        |
	| 2,          |
	| ,           |