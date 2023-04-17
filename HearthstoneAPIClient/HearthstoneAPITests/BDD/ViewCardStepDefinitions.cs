using HearthstoneAPIClient.Services.DataHandling;
using HearthstoneAPIClient.Services;
using System;
using TechTalk.SpecFlow;
using HearthstoneAPIClient.Interfaces;

namespace HearthstoneAPITests.BDD
{
    [Binding]
    public class ViewCardStepDefinitions
    {
        private static IService _service;

        private static string _cardName;

        [Given(@"I have initialized CardService")]
        public void GivenIHaveInitializedCardService()
        {
            CallManager manager = new CallManager(new HttpClient());
            _service = new CardClassService(manager);
        }

        [When(@"I search for the ""([^""]*)""")]
        public void WhenISearchForThe(string p0)
        {
            _cardName = p0;
        }

        [Then(@"A JSON of the searched card is returned")]
        public async void ThenAJSONOfTheSearchedCardIsReturned()
        {
            await _service.MakeRequestAsync($"cards/{_cardName}");
        }

        [Then(@"header status is (.*)")]
        public void ThenHeaderStatusIs(int p0)
        {
            Assert.That(((IHelper)_service).GetStatusCode(), Is.EqualTo(p0));
        }

        [Then(@"content type is ""([^""]*)""")]
        public void ThenContentTypeIs(string p0)
        {
            Assert.That(((IHelper)_service).GetContentType(), Is.EqualTo(p0));
        }

        [Then(@"connection type is ""([^""]*)""")]
        public void ThenConnectionTypeIs(string p0)
        {
            Assert.That(((IHelper)_service).GetConnectionType(), Is.EqualTo(p0));
        }

        [Then(@"A JSON containing the mana cost of (.*) minion should be returned")]
        public void ThenAJSONContainingTheManaCostOfMinionShouldBeReturned(int p0)
        {
            Assert.That((int)_service.SuccessfulResponseContent[0]["cost"], Is.EqualTo(p0));
        }

        [When(@"I search for the card id ""([^""]*)""")]
        public void WhenISearchForTheCardId(string p0)
        {
            _cardName = p0;
        }

        [Then(@"A JSON of the containing rarity of ""([^""]*)"" is returned")]
        public void ThenAJSONOfTheContainingRarityOfIsReturned(string legendary)
        {
            Assert.That(_service.SuccessfulResponseContent[0]["rarity"].ToString(), Is.EqualTo(legendary));
        }

        [Then(@"JSON should contain a message ""([^""]*)"" is Returned")]
        public void ThenJSONShouldContainAMessageIsReturned(string p0)
        {
            Assert.That(_service.UnSuccessfulResponseContent["message"].ToString(), Is.EqualTo(p0));
        }

    }
}
