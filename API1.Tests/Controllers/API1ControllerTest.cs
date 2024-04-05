
using FakeItEasy;
using API1.Interfaces;
using App1.Controllers;
using Xunit;
using FluentAssertions;

namespace API1.Tests.Controllers
{
    public class API1ControllerTest
    {
        private readonly IApi2Service _api2;
        private readonly IApi3Service _api3;
        public API1ControllerTest()
        {
            _api2 = A.Fake<IApi2Service>();
            _api3 = A.Fake<IApi3Service>();
        }

        [Fact]
        public async void APIController_Get_ReturnOK()
        {
            //Arrange
            var api2Result = "{\"x\":\"hello world\",\"y\":\"from app2\"}";
            var api3Result = "{\"x\":\"hello world\",\"y\":\"from app3\"}";

            A.CallTo(() => _api2.Api2Get(A<HttpClient>.Ignored)).Returns(Task.FromResult(api2Result));
            A.CallTo(() => _api3.Api3Get(A<HttpClient>.Ignored)).Returns(Task.FromResult(api3Result));

            var controller = new API1Controller(_api2, _api3);

            //Act
            var result = await controller.Get();

            //Assert
            result.Should().NotBeNull();
        }
    }
}
