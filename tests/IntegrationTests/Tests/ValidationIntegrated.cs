using System.Net;
using tech_qa_integrationTests.Fixtures;
using Xunit;

namespace tech_qa_integrationTests.Tests
{
    [Collection(nameof(ApiTestFixtureCollection))]
    public class ValidationIntegrated
    {
        private readonly ApiTestFixture<Program> _fixture;
        HttpResponseMessage? httpResponse;

        public ValidationIntegrated()
        {
           _fixture = new ApiTestFixture<Program>();
        }

        [Fact(DisplayName ="Get StatusCode OK")]
        public async Task ConsultaTemperatura()
        {
            // act
            var httpResponse = await _fixture.httpClient.GetAsync("WeatherForecast");
            var bodyresponse =  httpResponse.Content.ReadAsStringAsync().Result;

            // assert
            Assert.Equal(HttpStatusCode.OK, httpResponse.StatusCode);
            Assert.NotEmpty(bodyresponse);
        }
    }
}