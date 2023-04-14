﻿Feature: CardClassFeature

AS a player
I WANT to be able to search cards by Class
SO THAT I can see which cards I could play

Background:
	Given I have initialized CardRaceService

@CardClassRequest
@Happy
Scenario: When searching for a valid class type status code 200 should be in the response header
	When I search for the Classes <Classes>
	| key | Classes |
	| 1 | Rogue   |
	| 2 | Shaman  |
	| 3 | Warlock |
	Then A JSON of just Classes cards is returned
	And Header status should be 200

@CardClassRequest
@Happy
Scenario: When searching for a valid class type status returned object should be a json
	When I search for the Classes <Classes>
	| Classes |
	| Rogue   |
	| Shaman  |
	| Warlock |
	Then A JSON of just Classes cards is returned
	And Content type should be "application/json"


@CardClassRequest
@Happy
Scenario: When searching for a valid class type connection should be keep alive
	When I search for the Classes <Classes>
	| Classes |
	| Rogue   |
	| Shaman  |
	| Warlock |
	Then A JSON of just Classes cards is returned
	And Connection type should be "keep-alive"

@CardClassRequest
@Sad
Scenario: When searching for a invalid class type status code 404 should be in the response header
	When I search for the class "Shamon"
	Then Header status should be 404
	 

@CardClassRequest
@Sad
Scenario: When searching for a invalid class type an error message should show
	When I search for the class "Shamon"
	Then JSON should contain a message "Class not found." 