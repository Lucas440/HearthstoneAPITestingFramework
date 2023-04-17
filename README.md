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

#### Call Manager

- Dependancy Injection

#### Features

- Initialise the service

- Assert that return status, type are correct

- Checking the response of requests are correct

### Class Diagram

![Hearthstone drawio](https://user-images.githubusercontent.com/91668478/232553778-31ad4215-e54e-486b-bb48-cc33d327bf02.png)

### How To Extend

When loading the program each item is organized in its respected file

#### Adding a Service
  - Create a new Service class in the services folder
  - Ensure the service implements the IHelper and IService interface
  - Ensure the Service's constructor has a parameter of CallManager

#### Adding new Tests
- Create a new Specflow feature file to the BDD folder
- Create gherkin scripts for the test cases 
- Define the steps and Develop the steps from the scripts


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

#### Living Docs

###### How to upgrade / create new LivingDoc File

1. Confirm CLI is installed by entering the following command in CMD: dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI

2. Navigate to folder containing the tests in CMD(\HearthstoneAPITestingFramework\HearthstoneAPIClient\HearthstoneAPITests)

3. Execute the following command: livingdoc feature-folder .\ -t.\bin\debug\net7.0\TestExecution.json --output .\MyReport.html

4. Access the livingdoc file in the tests folder (Step 2.)

### 📝 Project Board

Our up-to-date GitHub project board [can be found here](https://github.com/users/gleniw/projects/1)

### Retrospective

Our Metro Retro Board [can be found here](https://metroretro.io/board/LB05S0ZQXV3Z)

### 💭 Definitions of Done and Ready

Our definition of Done [can be found here](https://github.com/gleniw/HearthstoneAPITestingFramework/issues/10)

Our definition of Ready [can be found here](https://github.com/gleniw/HearthstoneAPITestingFramework/issues/19)


