using Microsoft.AspNetCore.Mvc.Testing;

namespace tech_qa_integrationTests
{
    public class AppFactory<Program> :
        WebApplicationFactory<Program> where Program : class { }
}
