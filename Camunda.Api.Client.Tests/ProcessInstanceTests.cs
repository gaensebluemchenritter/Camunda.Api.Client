using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Camunda.Api.Client.ServiceEndpoints.ProcessInstance;
using RichardSzalay.MockHttp;
using Xunit;

namespace Camunda.Api.Client.Tests
{
    public class ProcessInstanceTests
    {
        [Fact]
        public async Task GetList()
        {
            var mockHttp = new MockHttpMessageHandler();

            var request = mockHttp.Expect(HttpMethod.Post, "http://localhost:8080/engine-rest/process-instance");
            request.Respond(HttpStatusCode.OK, Infrastructure.Iana.MediaTypes.Application.Json, "[]");
            ////mockHttp.Expect(HttpMethod.Post, "http://localhost:8080/engine-rest/process-instance")
            ////    .Respond(HttpStatusCode.OK, Infrastructure.MediaTypes.Application.Json, "[]");


            var client = CamundaClient.Create("http://localhost:8080/engine-rest", mockHttp);
            var process = await client.ProcessInstances.Query().List();

            Assert.NotNull(process);
        }
    }
}
