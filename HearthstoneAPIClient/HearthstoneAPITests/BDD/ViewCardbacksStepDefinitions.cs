using HearthstoneAPIClient.Services.DataHandling;
using HearthstoneAPIClient.Services;
using System;
using TechTalk.SpecFlow;
using HearthstoneAPIClient.Interfaces;

namespace HearthstoneAPITests.BDD
{
    [Binding]
    public class ViewCardbacksStepDefinitions
    {

        private static IService _service;

        [Given(@"I have initialized CardBackService")]
        public void GivenIHaveInitializedCardBackService()
        {
            CallManager manager = new CallManager(new HttpClient());
            _service = new CardClassService(manager);
        }

        [When(@"I search for the cardbacks")]
        public async void WhenISearchForTheCardbacks()
        {
            await _service.MakeRequestAsync("cardbacks");
        }


        [Then(@"the Header status should be (.*)")]
        public void ThenTheHeaderStatusShouldBe(int p0)
        {
            Assert.That(((IHelper)_service).GetStatusCode(), Is.EqualTo(p0));
        }

        [Then(@"The Content type should be ""([^""]*)""")]
        public void ThenTheContentTypeShouldBe(string p0)
        {
            Assert.That(((IHelper)_service).GetContentType(), Is.EqualTo(p0));
        }

        [Then(@"The Connection type should be ""([^""]*)""")]
        public void ThenTheConnectionTypeShouldBe(string p0)
        {
            Assert.That(((IHelper)_service).GetConnectionType(), Is.EqualTo(p0));
        }

        [When(@"I search for an inccorect spelling ""([^""]*)""")]
        public async void WhenISearchForAnInccorectSpelling(string cardback)
        {
            await _service.MakeRequestAsync(cardback);
        }
        [Then(@"JSON Response should contain a message ""([^""]*)""")]
        public void ThenJSONResponseShouldContainAMessage(string p0)
        {
            Assert.That(_service.UnSuccessfulResponseContent["message"].ToString(), Is.EqualTo(p0));
        }
    }
}
