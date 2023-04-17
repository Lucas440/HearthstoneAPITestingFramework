Feature: CardRaceFeature

AS a Player
I WANT to be able to search cards by Race 
SO THAT I can see which Cards are affected my Abilities

Background:
	Given i have initialized CardRaceService

@CardRaceRequest
@Happy
Scenario: When searching for a valid race type status code 200 should be in the response header
	When I search for the race "Mech"
	Then A JSON of just races cards is returned
	And header status should be 200

@CardRaceRequest
@Happy
Scenario: When searching for a valid race type status returned object should be a json
	When I search for the race "Demon"
	Then A JSON of just races cards is returned
	And content type should be "application/json"


@CardRaceRequest
@Happy
Scenario: When searching for a valid race type connection should be keep alive
	When I search for the race "Dragon"
	Then A JSON of just races cards is returned
	And connection type should be "keep-alive"

@CardRaceRequest
@Sad
Scenario: When searching for a invalid race type status code 404 should be in the response header
	When I search for the race "Daemon"
	Then A JSON of just races cards is returned
	And header status should be 404
	 

@CardRaceRequest
@Sad
Scenario: When searching for a invalid race type an error message should show
	When I search for the race "Daemon"
	Then A JSON of just races cards is returned
	And json should contain a message "Race not found."