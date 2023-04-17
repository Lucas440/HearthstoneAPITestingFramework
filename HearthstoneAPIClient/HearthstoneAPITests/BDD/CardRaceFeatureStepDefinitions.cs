using HearthstoneAPIClient.Interfaces;
using HearthstoneAPIClient.Services.DataHandling;
using HearthstoneAPIClient.Services;
using System;
using TechTalk.SpecFlow;

namespace HearthstoneAPITests.BDD
{
    [Binding]
    public class CardRaceFeatureStepDefinitions
    {
        private static IService _service;

        private static string _cardClass;

        [Given(@"i have initialized CardRaceService")]
        public void GivenIHaveInitializedCardRaceService()
        {
            CallManager manager = new CallManager(new HttpClient());
            _service = new CardRaceService(manager);
        }

        [When(@"I search for the race ""([^""]*)""")]
        public void WhenISearchForTheRace(string p0)
        {
            _cardClass = p0;
        }

        [Then(@"A JSON of just races cards is returned")]
        public async void ThenAJSONOfJustRacesCardsIsReturned()
        {
            await _service.MakeRequestAsync($"cards/races/{_cardClass}");
        }

        [Then(@"header status should be (.*)")]
        public void ThenHeaderStatusShouldBe(int p0)
        {
            Assert.That(((IHelper)_service).GetStatusCode(), Is.EqualTo(p0));
        }

        [Then(@"content type should be ""([^""]*)""")]
        public void ThenContentTypeShouldBe(string p0)
        {
            Assert.That(((IHelper)_service).GetContentType(), Is.EqualTo(p0));
        }

        [Then(@"connection type should be ""([^""]*)""")]
        public void ThenConnectionTypeShouldBe(string p0)
        {
            Assert.That(((IHelper)_service).GetConnectionType(), Is.EqualTo(p0));
        }

        [Then(@"json should contain a message ""([^""]*)""")]
        public void ThenJsonShouldContainAMessage(string p0)
        {
            Assert.That(_service.UnSuccessfulResponseContent["message"].ToString(), Is.EqualTo(p0));
        }
    }
}
