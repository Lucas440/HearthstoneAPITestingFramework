Feature: ViewCard

AS a player
I WANT to be able to view a card by name
SO THAT I can look at the cards details

Background:
Given I have initialized CardService

# Searched Card
@ViewCardRequest
@Happy
Scenario: When searching for a card to view, I should receive status code 200 in the header response
	When I search for the <card>
	| card                 |
	| Boulderfist Ogre     |
	| Sir Finley Mrrgglton |
	| Ysera                |
	Then A JSON of the searched card is returned


# Minion Mana Cost
@ViewCardRequest
@Happy
Scenario: When searching for a card, I want to view how much mana a minion costs
	When I search for the <card>
	| card                 |
	| Boulderfist Ogre     |
	| Sir Finley Mrrgglton |
	| Ysera                |
	Then A JSON of the mana cost of a minion should be returned


# Card Rarity
@ViewCardRequest
@Happy
Scenario: When searching for a card, I want to know the rarity of the card
	When I search for the <card>
	| card                 |
	| Boulderfist Ogre     |
	| Sir Finley Mrrgglton |
	| Ysera                |
	Then A JSON of the rarity of the card is returned
