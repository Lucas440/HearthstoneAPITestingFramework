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
        private IService _service;

        private TableParse _parse;

        [Given(@"I have initialized CardRaceService")]
        public void GivenIHaveInitializedCardRaceService()
        {
            CallManager manager = new CallManager(new HttpClient());
            IService _service = new CardRaceService(manager);
        }

        [When(@"I search for the Classes")]
        public void WhenISearchForTheClasses(Table table)
        {
            _parse = table.CreateInstance<TableParse>();
            _service.MakeRequestAsync(_parse.Classes);
        }

        [Then(@"A JSON of just Classes cards is returned")]
        public void ThenAJSONOfJustClassesCardsIsReturned()
        {
            throw new PendingStepException();
        }

        [Then(@"Header status should be (.*)")]
        public void ThenHeaderStatusShouldBe(int p0)
        {
            throw new PendingStepException();
        }

        [Then(@"Content type should be ""([^""]*)""")]
        public void ThenContentTypeShouldBe(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"Connection type should be ""([^""]*)""")]
        public void ThenConnectionTypeShouldBe(string p0)
        {
            throw new PendingStepException();
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
