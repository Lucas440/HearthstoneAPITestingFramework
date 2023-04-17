Feature: ViewCardbacks

AS a player
I WANT to view the card backs
SO THAT I know the card back details

Background: 
Given I have initialized CardBackService

@CardbackRequest
Scenario: When searching for a cardback type, status code 200 should be in the response header
	When I search for the cardbacks
	#Then A JSON of just cardback is returned
	Then the Header status should be 200

	@CardbackRequest
Scenario: When searching for a valid cardback type, status returned object should be a json
	When I search for the cardbacks
	#Then A JSON of just cardback is returned
	Then The Content type should be "application/json"

	@CardbackRequest
Scenario: When searching for a valid cardback, connection should be keep alive
	When I search for the cardbacks
	#Then A JSON of just cardback is returned
	Then The Connection type should be "keep-alive"

@CardbackRequest 
@Sad 
Scenario: When searching for cardbacks incorrectly an error message should show 
When I search for an inccorect spelling "cardback" 
Then JSON Response should contain a message "Endpoint '/cardback' does not exist"
