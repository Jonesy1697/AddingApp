Feature: ValidationTest
	Simple calculator for adding two numbers

@mytag
Scenario Outline: Validate services call (full method)
	Given the string value of <inputValue> input to class call

	Examples: 
	| inputValue | result  |
	| "6,2"      | "true"  |
	| "5,"       | "false" |
	| " 5,	5"   | "true"  |
	| " "        | "false" |
	| "duck"     | "false" |
	| " , 5"     | "false" |
	| "5,6,5,3"  | "false" | 

Scenario Outline: Validate string input comparison
	Given the string value of <inputValue>
	Then the valid result should be <result>

	Examples: 
	| inputValue | result  |
	| "6,2"      | "true"  |
	| "5,"       | "false" |
	| " 5,	5"   | "true"  |
	| " "        | "false" |
	| "duck"     | "false" |
	| " , 5"     | "false" |
	| "5,6,5,3"  | "false" |