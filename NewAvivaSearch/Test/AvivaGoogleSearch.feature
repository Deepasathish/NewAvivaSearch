Feature: Aviva Google Search
	check for Google search Functionality


@mytag
Scenario: search result for Aviva in Google
	Given I am on the google page
	And I Enter 'Aviva' in Google search bar
	Then the result page with '11' links should be returned in the search page
	And print the fifth link text

	
Scenario: search result for empty in Google
	Given I am on the google page
	And I Enter '' in Google search bar
	Then the result page with '0' links should be returned in the search page
	And print the fifth link text