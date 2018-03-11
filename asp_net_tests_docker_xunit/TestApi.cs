using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using asp_net_tests_docker;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using NUnit.Framework;

namespace asp_net_tests_docker_xunit 
{

    [TestFixture]
    public class TestApi {
        private readonly TestServer _server;
        private readonly HttpClient _client;
        private const string ApiUrl = "api/values";

        public TestApi () 
        {
            _server = new TestServer (new WebHostBuilder ()
                .UseStartup<Startup> ());
            _client = _server.CreateClient ();
        }

        [Test]
        public async Task Should_return_4_users_from_db() 
        {            
            HttpResponseMessage response = await _client.GetAsync (ApiUrl);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            IList<TestUser> users =
                JsonConvert.DeserializeObject<IList<TestUser>> (await response.Content.ReadAsStringAsync());
            
            Assert.NotNull(users);
            Assert.True(users.Count == 4);
        }
    }
}