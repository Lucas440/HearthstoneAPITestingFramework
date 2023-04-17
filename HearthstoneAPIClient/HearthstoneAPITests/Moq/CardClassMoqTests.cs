using HearthstoneAPIClient.Services.DataHandling;
using HearthstoneAPIClient.Services;
using Moq;
using HearthstoneAPIClient.Interfaces;
using System.Net;

namespace HearthstoneAPITests.Moq
{
    public class CardClassMoqTests
    {
        Mock<CallManager> _mockManager;

        IService _service;

        [SetUp]
        public void SetUp() 
        {
            _mockManager = new Mock<CallManager>();
            _service = new CardClassService(_mockManager.Object);
        }

        [TestCase("Rogue")]
        [TestCase("Paladin")]
        public async Task WhenARequestMethodIsCalled_CallManagerIsUsed(string cardClass)
        {
            _mockManager.Setup(m => m.MakeRequestAsync($"cards/classes/{cardClass}"));
            //So that it doesnt crash since its not actually getting an api response
            try
            {
                await _service.MakeRequestAsync($"cards/classes/{cardClass}");
            }
            catch (Exception) { }
            _mockManager.Verify(m => m.MakeRequestAsync($"cards/classes/{cardClass}"), Times.Once());
        }
        [Test]
        public void WhenAHelperMethodIsCalled_CallManagerIsUsed() 
        {
            _mockManager.Setup(m => m.GetStatusCode());
            try
            {
                ((IHelper)_service).GetStatusCode();
            }
            catch (Exception) { }
            _mockManager.Verify(m => m.GetStatusCode(), Times.Once());
        }
    }
}
