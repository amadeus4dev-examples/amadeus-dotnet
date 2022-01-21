using amadeus;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace amadeustest
{
    [TestFixture()]
    public class RequestTest
    {
        [Test()]
        public void TestInitializer()
        {
            Amadeus amadeus = Amadeus.builder("123", "234").build();
            Params _params = Params.with("foo", "bar");
            Request request = new Request("GET", "/foo/bar", _params, "token", amadeus);

            Assert.IsTrue(request.verb == "GET");
            Assert.IsTrue(request.host == "test.api.amadeus.com");
            Assert.IsTrue(request.path == "/foo/bar");
            Assert.IsTrue(request._params == _params);
            Assert.IsTrue(request.bearerToken == "token");
            Assert.IsTrue(request.languageVersion == typeof(string).Assembly.ImageRuntimeVersion);
            Assert.IsTrue(request.clientVersion == Amadeus.VERSION);
            Assert.IsTrue(request.appId == null);
            Assert.IsTrue(request.appVersion == null);
            Assert.IsTrue(request.port == 443);
            Assert.IsTrue(request.ssl);
            Assert.IsTrue(request.scheme == "https");
            Assert.IsTrue(request.headers.Count == 3);
            Assert.IsTrue(request.headers["Accept"] == "application/json, application/vnd.amadeus+json");
            Assert.IsTrue(request.headers["Authorization"] == "token");
            Assert.IsTrue(Regex.Matches(request.headers["User-Agent"], "amadeus-csharp/.* csharp/.*").Count>0);
        }

        [Test()]
        public void TestInitializerWithoutBearerToken()
        {
            try
            {
                Amadeus amadeus = Amadeus.builder("123", "234").build();
                Params _params = Params.with("foo", "bar");
                Request request = new Request("GET", "/foo/bar", _params, null, amadeus);

                Assert.IsTrue(request.headers.Count == 2);
            } catch (Exception e)
            {
                Assert.IsInstanceOf(typeof(KeyNotFoundException), e);
            }
        }

        [Test()]
        public void TestInitializerWithCustomAppInfo()
        {
            Configuration configution = Amadeus.builder("123", "234");
            configution.customAppId = "amadeus-cli";
            configution.customAppVersion = "123";
            Amadeus amadeus = configution.build();
            Params _params = Params.with("foo", "bar");
            Request request = new Request("GET", "/foo/bar", _params, "token", amadeus);

            Assert.IsTrue(Regex.Matches(request.headers["User-Agent"], "amadeus-csharp/.* csharp/.* amadeus-cli/.*").Count > 0);
        }

        [Test()]
        public void TestInitializerWithHTTP()
        {
            Configuration configution = Amadeus.builder("123", "234");
            configution.ssl = false;
            Amadeus amadeus = configution.build();
            Params _params = Params.with("foo", "bar");
            Request request = new Request("GET", "/foo/bar", _params, "token", amadeus);

            Assert.IsTrue(request.scheme == "http");
        }

        [Test()]
        public void TestBuildUriForGetRequest()
        {
            Configuration configution = Amadeus.builder("123", "234");
            Amadeus amadeus = configution.build();
            Params _params = Params.with("foo", "bar");
            Request request = new Request("GET", "/foo/bar", _params, null, amadeus);

            Assert.IsTrue(request.uri == "https://test.api.amadeus.com:443/foo/bar?foo=bar");
        }

        [Test()]
        public void TestBuildUriForGetRequestWithoutParams()
        {
            Configuration configution = Amadeus.builder("123", "234");
            Amadeus amadeus = configution.build();
            Request request = new Request("GET", "/foo/bar", new Params(), null, amadeus);

            Assert.IsTrue(request.uri == "https://test.api.amadeus.com:443/foo/bar?");
        }

        [Test()]
        public void TestBuildUriForPostRequest()
        {
            Configuration configution = Amadeus.builder("123", "234");
            Amadeus amadeus = configution.build();
            Params _params = Params.with("foo", "bar");
            Request request = new Request("POST", "/foo/bar", _params, null, amadeus);

            Assert.IsTrue(request.uri == "https://test.api.amadeus.com:443/foo/bar?");
        }

        [Test()]
        public void TestEstablishConnection()
        {
            Configuration configution = Amadeus.builder("123", "234");
            Amadeus amadeus = configution.build();
            Params _params = Params.with("foo", "bar");
            Request request = new Request("POST", "/v1/security/oauth2/token", new Params(), null, amadeus);
            request.establishConnection();
            Assert.IsNotNull(request.connection);
        }
    }
}
