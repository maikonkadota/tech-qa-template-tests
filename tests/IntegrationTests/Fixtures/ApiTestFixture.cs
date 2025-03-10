using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace tech_qa_integrationTests.Fixtures
{
    [CollectionDefinition(nameof(ApiTestFixtureCollection))]
    public class ApiTestFixtureCollection : ICollectionFixture<ApiTestFixture<Program>> { }
        public class ApiTestFixture<Program> : IDisposable where Program : class
        {
            public readonly AppFactory<Program> customWebApplicationFactory;
            public readonly HttpClient httpClient;

            public ApiTestFixture()
            {
                customWebApplicationFactory = new AppFactory<Program>();
                httpClient = customWebApplicationFactory.CreateClient();
            }

            public void Dispose()
            {
                customWebApplicationFactory.Dispose();
                httpClient.Dispose();
            }
        }

    }

