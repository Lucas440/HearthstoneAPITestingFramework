# Hearthstone API Testing Framework

## API Testing Project on [Hearthstone® API for Developers | RapidAP]((https://rapidapi.com/omgvamp/api/hearthstone)) that utilises HTTPS and Specflow

[![SpecFlow Tests](https://github.com/gleniw/HearthstoneAPITestingFramework/actions/workflows/dotnet.yml/badge.svg)](https://github.com/gleniw/HearthstoneAPITestingFramework/actions/workflows/dotnet.yml)

### Product Goal

* [ ]  Have an automated Test Framework for the Hearthstone API  

### Sprint Goals
* [ ]  To use project board for Planning, Review and Retrospective
* [ ]  Ensure artifacts are up to date and consistent with Product Goal
* [ ]  To have high quality user stories and test cases
* [ ]  To have very clear Gherkin scenarios derived from user stories to represent the user journeys
* [ ]  To have a fully functional API test framework
* [ ]  GitHub Action Workflows


### 🎉️ Epics

Epic 1.0 View Card - Epic 2.0 View Card Backs - Epic 3.0 View Race - Epic 4. View Classes

### 🏷 Class Diagrams and Test Framework

#### Services

IService
IHelper

Single Responsibility
Interface Seperation

Helper methods

#### Call Manager

If sucessful into JArray and unsucessful JObject

Dependancy Injection

Call Manager is not called on the page


#### Features

Step Definitions

Initialise the service

Assert that return information is correct

Checking the repsponse



### 📝 Project Board

Our up-to-date GitHub project board [can be found here](https://github.com/users/gleniw/projects/1)

### 💭 Definitions of Done and Ready

### How To Add

When loading the program each item is organized in its respected file

#### Adding a Service
  - Create a new Service class in the services folder
  - Ensure the service implements the IHelper and IService interface
  - Ensure the Service's constructor has a parameter of CallManager

#### Adding new Tests
- Create a new Specflow feature file to the BDD folder
- Create gherkin scripts for the test cases 
- Define the steps and Develop the steps from the scripts

### 🤺 Contributors

Lucas Brennan,  Glen Smith, Suheyb Adam, Kevin Conceicao
