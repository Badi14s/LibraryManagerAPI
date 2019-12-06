Feature: GetBooksFromLibrary
As a User I want to get details for books So that I can choose which books to add in my reading list.

@Scenario_1.1
Scenario: Search for book without description by Id
	Given I add to my reading list the following book
		| Id | Author     | Title     | Description |
		| 6  | TestAuthor | TestTitle |             | 
	When I search for book with Id "6"
	Then the result should should retun the following book
		| Id | Author     | Title     | Description |
		| 6  | TestAuthor | TestTitle |             |

@Scenario_1.2
Scenario: Search for book with description by Id
	Given I add to my reading list the following book
		| Id | Author     | Title     | Description     |
		| 6  | TestAuthor | TestTitle | TestDescription |
	When I search for book with Id "6"
	Then the result should should retun the following book
		| Id | Author     | Title     | Description     |
		| 6  | TestAuthor | TestTitle | TestDescription |  

@Scenario_1.3
Scenario: Search for book with 100 character title by Id
	Given I add to my reading list the following book
		| Id | Author     | Title                                                                                                | Description     |
		| 6  | TestAuthor | eT7d5HNl9bAmcovlc1X7 eT7d5HNl9bAmcovlc1X eT7d5HNl9bAmcovlc1X eT7d5HNl9bAmcovlc1X eT7d5HNl9bAmcovlc10 | TestDescription | 
	When I search for book with Id "6"
	Then the result should should retun the following book
		| Id | Author     | Title                                                                                                | Description     |
		| 6  | TestAuthor | eT7d5HNl9bAmcovlc1X7 eT7d5HNl9bAmcovlc1X eT7d5HNl9bAmcovlc1X eT7d5HNl9bAmcovlc1X eT7d5HNl9bAmcovlc10 | TestDescription |  

@Scenario_1.4
Scenario: Search for book with 30 character author by Id
	Given I add to my reading list the following book
		| Id | Author                         | Title     | Description     |
		| 6  | eT7d5HNl9bAmcovlc1X7 asGd3H459 | TestTitle | TestDescription |
	When I search for book with Id "6"
	Then the result should should retun the following book
		| Id | Author                         | Title     | Description     |
		| 6  | eT7d5HNl9bAmcovlc1X7 asGd3H459 | TestTitle | TestDescription |
