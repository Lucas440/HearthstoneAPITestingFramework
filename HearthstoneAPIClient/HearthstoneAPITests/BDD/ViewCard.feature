Feature: ViewCard

AS a player
I WANT to be able to view a card by name
SO THAT I can look at the cards details

Background:
Given I have initialized CardService

@ViewCardRequest
@Happy
Scenario: When searching for a valid race type status code 200 should be in the response header
	When I search for the "Boulderfist Ogre"
	Then A JSON of the searched card is returned
	And header status is 200

@ViewCardRequest
@Happy
Scenario: When searching for a valid race type status returned object should be a json
	When I search for the "Boulderfist Ogre"
	Then A JSON of the searched card is returned
	And content type is "application/json"


@ViewCardRequest
@Happy
Scenario: When searching for a valid race type connection should be keep alive
	When I search for the "Boulderfist Ogre"
	Then A JSON of the searched card is returned
	And connection type is "keep-alive"


# Searched Card
@ViewCardRequest
@Happy
Scenario: When searching for a card to view, I should receive status code 200 in the header response
	When I search for the "Boulderfist Ogre"
	Then A JSON of the searched card is returned


# Minion Mana Cost
@ViewCardRequest
@Happy
Scenario: When searching for a card, I want to view how much mana a minion costs
	When I search for the "LOE_076"
	Then A JSON of the searched card is returned
	And A JSON containing the mana cost of 1 minion should be returned


# Card Rarity
@ViewCardRequest
@Happy
Scenario: When searching for a card, I want to know the rarity of the card
	When I search for the card id "VAN_EX1_572"
	Then A JSON of the searched card is returned
	And A JSON of the containing rarity of "Legendary" is returned

@ViewCardRequest 
@Sad 
Scenario: When searching for a invalid card type status code 404 should be in the response header 
	When I search for the "Ysero" 
	Then A JSON of the searched card is returned
	And header status is 404 

@ViewCardRequest 
@Sad 
Scenario: When searching for a invalid card type an error message should show 
	When I search for the "steve" 
	Then A JSON of the searched card is returned
	And JSON should contain a message "Card not found." is Returned
