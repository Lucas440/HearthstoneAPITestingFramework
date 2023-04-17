# Hearthstone API Testing Framework

## API Testing Project on [Hearthstone® API for Developers | RapidAP]((https://rapidapi.com/omgvamp/api/hearthstone)) that utilises HTTPS and Specflow.

### 🤺 Contributors

Lucas Brennan,  Glen Smith, Suheyb Adam, Kevin Conceicao

### Current Test Status

[![SpecFlow Tests](https://github.com/gleniw/HearthstoneAPITestingFramework/actions/workflows/dotnet.yml/badge.svg)](https://github.com/gleniw/HearthstoneAPITestingFramework/actions/workflows/dotnet.yml)

### Concepts Included

#### Services

- IService
- IHelper
- Single Responsibility
- Interface Seperation

#### Call Manager

- If sucessful into JArray and unsucessful JObject

- Dependancy Injection

#### Features

- Initialise the service

- Assert that return status, type are correct

- Checking the response of requests are correct

### Class Diagram

![Class Diagram]()

### Tools
- HTTPS 
- Specflow
- Moq
- Living Docs
- GitHub Actions

### Reporting

- To run Specflow Report

## Project Design & Management

### Product Goal

* [ ]  Have an automated Test Framework for the Hearthstone API  

### Sprint Goals
* [ ]  To use project board for Planning, Review and Retrospective
* [ ]  Ensure artifacts are up to date and consistent with Product Goal
* [ ]  To have high quality user stories and test cases
* [ ]  To have very clear Gherkin scenarios derived from user stories to represent the user journeys
* [ ]  To have a fully functional API test framework
* [ ]  GitHub Action Workflows

### User Stories

#### Epic 1.0 View Card
Endpoint
/cards/{name}

#### Epic 2.0 View Card Backs
**Endpoint**
/cardbacks
**Description**
Returns a list of all the card backs.

#### Epic 3.0 View Race
**Endpoint**
/card/{race}
**Description**
Returns all the cards of a certain race. Example values: Mech, Murloc.

#### Epic 4.0 View Classes
**Endpoint**
/cards/classes/{class}
**Description**
Returns all the cards of a class. Example values: Mage, Paladin.

### 📝 Project Board

Our up-to-date GitHub project board [can be found here](https://github.com/users/gleniw/projects/1)

### Retrospective

Our Metro Retro Board [can be found here](https://metroretro.io/board/LB05S0ZQXV3Z)

### 💭 Definitions of Done and Ready

Our definition of Done [can be found here](https://github.com/gleniw/HearthstoneAPITestingFramework/issues/10)

Our definition of Ready [can be found here](https://github.com/gleniw/HearthstoneAPITestingFramework/issues/19)


