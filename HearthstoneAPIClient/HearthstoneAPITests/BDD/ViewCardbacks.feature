Feature: ViewCardbacks

AS a player
I WANT to view the card backs
SO THAT I know the card back details

Background: 
Given I have initialized CardRaceService

@CardbackRequest
Scenario: When searching for a cardback type, status code 200 should be in the response header
	When I search for the cardbacks
	| cardbacks |
	| Celeste   |
	| Firelord  |
	| N'Zoth    |
	Then A JSON of just cardbacks is returned
	And Header status should be 200

	@CardRaceRequest
Scenario: When searching for a valid cardback type, status returned object should be a json
	When I search for the cardbacks
	| cardbacks |
	| Celeste   |
	| Firelord  |
	| N'Zoth    |
	Then A JSON of just cardbacks is returned
	And Content type should be "application/json"

	@CardRaceRequest
Scenario: When searching for a valid cardback, connection should be keep alive
	When I search for the cardbacks
	| cardbacks |
	| Celeste   |
	| Firelord  |
	| N'Zoth    |
	Then A JSON of just cardbacks is returned
	And Connection type should be "keep-alive"
