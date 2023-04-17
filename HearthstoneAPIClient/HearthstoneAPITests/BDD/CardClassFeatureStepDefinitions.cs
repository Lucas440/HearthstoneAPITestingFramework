using HearthstoneAPIClient.Interfaces;
using HearthstoneAPIClient.Services;
using HearthstoneAPIClient.Services.DataHandling;
using HearthstoneAPITests.Utils;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Moq;

namespace HearthstoneAPITests.BDD
{
    [Binding]
    public class CardClassFeatureStepDefinitions
    {
        private static IService _service;

        private static string _cardClass;

        
        [Given(@"I have initialized CardClassService")]
        public void GivenIHaveInitializedCardRaceService()
        {
            CallManager manager = new CallManager(new HttpClient());
            _service = new CardClassService(manager);
        }

        [When(@"I search for the Classes ""([^""]*)""")]
        public void WhenISearchForTheClassesClasses(string classType)
        {
            _cardClass = classType;
        }


        [Then(@"A JSON of just Classes cards is returned")]
        public async void ThenAJSONOfJustClassesCardsIsReturned()
        {
            await _service.MakeRequestAsync($"cards/classes/{_cardClass}");
        }

        [Then(@"Header status should be (.*)")]
        public void ThenHeaderStatusShouldBe(int p0)
        {
            Assert.That(((IHelper)_service).GetStatusCode(), Is.EqualTo(p0));
        }

        [Then(@"Content type should be ""([^""]*)""")]
        public void ThenContentTypeShouldBe(string p0)
        {
            Assert.That(((IHelper)_service).GetContentType(), Is.EqualTo(p0));
        }

        [Then(@"Connection type should be ""([^""]*)""")]
        public void ThenConnectionTypeShouldBe(string p0)
        {
            Assert.That(((IHelper)_service).GetConnectionType(), Is.EqualTo(p0));
        }

        [Then(@"JSON should contain a message ""([^""]*)""")]
        public void ThenJSONShouldContainAMessage(string p0)
        {
            Assert.That(_service.UnSuccessfulResponseContent["message"].ToString(), Is.EqualTo(p0));
        }
    }
}
