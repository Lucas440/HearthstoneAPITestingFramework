using HearthstoneAPIClient.Services.DataHandling;
using HearthstoneAPIClient.Services;
using Moq;
using HearthstoneAPIClient.Interfaces;
using System.Net;

namespace HearthstoneAPITests.Moq
{
    public class CardClassMoqTests
    {
        Mock<ICallManager> _mockManager;

        IService _service;

        [SetUp]
        public void SetUp() 
        {
            _mockManager = new Mock<ICallManager>();
            _service = new CardClassService(_mockManager.Object);
        }

        [Test]
        public void ServiceIsAbleToBeConstructed()
        {
            Assert.That(_service, Is.InstanceOf<IService>());
        }

        [Category("Happy")]
        [TestCase("Rogue")]
        [TestCase("Paladin")]
        public async Task WhenARequestMethodIsCalled_CallManagerIsUsed_WithAValidClass(string cardClass)
        {
            _mockManager.Setup(m => m.MakeRequestAsync($"cards/classes/{cardClass}"));
            _mockManager.Setup(m => m.ResponseMessage).Returns(new HttpResponseMessage() {Content = new StringContent("[{}]") });
            _mockManager.Setup(m => m.Successful).Returns(true);


            await _service.MakeRequestAsync($"cards/classes/{cardClass}");

            _mockManager.Verify(m => m.MakeRequestAsync($"cards/classes/{cardClass}"), Times.Once());
        }

        [Category("Sad")]
        [TestCase("Rouge")]
        [TestCase("Paldin")]
        public async Task WhenARequestMethodIsCalled_CallManagerIsUsed_WithAInValidClass(string cardClass)
        {
            _mockManager.Setup(m => m.MakeRequestAsync($"cards/classes/{cardClass}"));
            _mockManager.Setup(m => m.ResponseMessage).Returns(new HttpResponseMessage() { Content = new StringContent("{}") });
            _mockManager.Setup(m => m.Successful).Returns(false);

            await _service.MakeRequestAsync($"cards/classes/{cardClass}");

            _mockManager.Verify(m => m.MakeRequestAsync($"cards/classes/{cardClass}"), Times.Once());
        }

        [Test]
        public void WhenGetStatusCodeIsCalled_CallManagerReturnsAValue() 
        {
            _mockManager.Setup(m => m.GetStatusCode()).Returns(It.IsAny<int>());
            ((IHelper)_service).GetStatusCode();

            _mockManager.Verify(m => m.GetStatusCode(), Times.Once());
        }
        [Test]
        public void WhenGetContentTypeIsCalled_CallManagerReturnsAValue()
        {
            _mockManager.Setup(m => m.GetContentType()).Returns(It.IsAny<string>());
            ((IHelper)_service).GetContentType();

            _mockManager.Verify(m => m.GetContentType(), Times.Once());
        }
        [Test]
        public void WhenGetConnectionTypeIsCalled_CallManagerReturnsAValue()
        {
            _mockManager.Setup(m => m.GetConnectionType()).Returns(It.IsAny<string>());
            ((IHelper)_service).GetConnectionType();

            _mockManager.Verify(m => m.GetConnectionType(), Times.Once());
        }
    }
}
