Feature: GridOverview

Background:
	Given I am on Grid Overview Page

Scenario: Search product
	When I entered <searchValue> into searchbox
	Then Searched value is displayed
Examples:
	| searchValue |
	| Tofu        |
	| Ikura       |

Scenario: Check if table contain all column
	Then Table contains all column
	| columnName   |
	| Product name |
	| Price        |
	| In Stock     |
	| Category     |
	| Rating       |
	| Country      |
	| Units        |
	| Total Sales  |
	| Target Sales |
