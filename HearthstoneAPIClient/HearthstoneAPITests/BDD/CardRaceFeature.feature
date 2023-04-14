Feature: CardRaceFeature

AS a Player
I WANT to be able to search cards by Race 
SO THAT I can see which Cards are affected my Abilities

Background:
	Given I have initialized CardRaceService

@CardRaceRequest
@Happy
Scenario: When searching for a valid race type status code 200 should be in the response header
	When I search for the races
	| races  |
	| Murloc |
	| Demon |
	| Dragon |
	Then A JSON of just races cards is returned
	And Header status should be 200

@CardRaceRequest
@Happy
Scenario: When searching for a valid race type status returned object should be a json
	When I search for the races
	| races  |
	| Murloc |
	| Demon |
	| Dragon |
	Then A JSON of just races cards is returned
	And Content type should be "application/json"


@CardRaceRequest
@Happy
Scenario: When searching for a valid race type connection should be keep alive
	When I search for the races
	| races  |
	| Murloc |
	| Demon |
	| Dragon |
	Then A JSON of just races cards is returned
	And Connection type should be "keep-alive"

@CardRaceRequest
@Sad
Scenario: When searching for a invalid race type status code 404 should be in the response header
	When I search for the race "Daemon"
	Then Header status should be 404
	 

@CardRaceRequest
@Sad
Scenario: When searching for a invalid race type an error message should show
	When I search for the race "Daemon"
	Then JSON should contain a message "Endpoint '/races/Daemon' does not exist"