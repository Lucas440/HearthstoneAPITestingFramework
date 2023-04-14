using HearthstoneAPIClient.Interfaces;
using HearthstoneAPIClient.Services;
using HearthstoneAPIClient.Services.DataHandling;
using HearthstoneAPITests.Utils;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace HearthstoneAPITests.BDD
{
    [Binding]
    public class CardClassFeatureStepDefinitions
    {
        private static IService _service;

        private static TableParse _parse;

        
        [Given(@"I have initialized CardRaceService")]
        public void GivenIHaveInitializedCardRaceService()
        {
            CallManager manager = new CallManager(new HttpClient());
            _service = new CardClassService(manager);
        }

        [When(@"I search for the Classes <Classes>")]
        public void WhenISearchForTheClassesClasses(Table table)
        {
            //_parse = table.CreateInstance<TableParse>();
        }


        [Then(@"A JSON of just Classes cards is returned")]
        public async void ThenAJSONOfJustClassesCardsIsReturned()
        {
            await _service.MakeRequestAsync("cards/classes/Rogue");
        }

        [Then(@"Header status should be (.*)")]
        public void ThenHeaderStatusShouldBe(int p0)
        {
            Assert.That(((CardClassService)_service).GetStatusCode(), Is.EqualTo(p0));
        }

        [Then(@"Content type should be ""([^""]*)""")]
        public void ThenContentTypeShouldBe(string p0)
        {
            Assert.That(((CardClassService)_service).GetContentType(), Is.EqualTo(p0));
        }

        [Then(@"Connection type should be ""([^""]*)""")]
        public void ThenConnectionTypeShouldBe(string p0)
        {
            Assert.That(((CardClassService)_service).GetConnectionType(), Is.EqualTo(p0));
        }

        [When(@"I search for the class ""([^""]*)""")]
        public void WhenISearchForTheClass(string shamon)
        {
            throw new PendingStepException();
        }

        [Then(@"JSON should contain a message ""([^""]*)""")]
        public void ThenJSONShouldContainAMessage(string p0)
        {
            throw new PendingStepException();
        }
    }
}
