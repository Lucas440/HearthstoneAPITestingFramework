using HearthstoneAPIClient.Services.DataHandling;
using HearthstoneAPIClient.Services;
using Moq;
using HearthstoneAPIClient.Interfaces;
using System.Net;
using System.Net.Http.Headers;

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

        [TestCase(200)]
        [TestCase(400)]
        public void WhenGetStatusCodeIsCalled_CallManagerReturnsAValue(int expected) 
        {
            _mockManager.Setup(m => (m.ResponseMessage)).Returns(new HttpResponseMessage { StatusCode = (HttpStatusCode)expected });
            int result = ((IHelper)_service).GetStatusCode();

            Assert.That(result, Is.EqualTo(expected));

            _mockManager.Verify(m => m.ResponseMessage, Times.Once);
        }           
        [TestCase("text/plain")]
        [TestCase("application/json")]
        public void WhenGetContentTypeIsCalled_CallManagerReturnsAValue(string expected)
        {
            var response = new HttpResponseMessage();
            response.Content.Headers.ContentType = new MediaTypeHeaderValue(expected);
            _mockManager.Setup(m => (m.ResponseMessage)).Returns(response);
            string result = ((IHelper)_service).GetContentType();

            Assert.That(result, Is.EqualTo(expected));

            _mockManager.Verify(m => m.ResponseMessage, Times.Once());
        }
        [TestCase("keep-alive")]
        public void WhenGetConnectionTypeIsCalled_CallManagerReturnsAValue(string expected)
        {
            var response = new HttpResponseMessage();
            response.Headers.Connection.Add(expected);
            _mockManager.Setup(m => (m.ResponseMessage)).Returns(response);
            string result = ((IHelper)_service).GetConnectionType();

            Assert.That(result, Is.EqualTo(expected));

            _mockManager.Verify(m => m.ResponseMessage, Times.Once());
        }
    }
}
