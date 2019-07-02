using amadeus;
using NUnit.Framework;
using System;
using System.Diagnostics;

namespace amadeustest
{
    [TestFixture()]
    public class ConfigurationTest
    {
        [Test()]
        public void TestInitialize()
        {
            Assert.IsInstanceOf(typeof(Configuration), Amadeus.builder("id", "secret"), "should return a Configuration object");
        }

        [Test()]
        public void TestBuild()
        {
            Configuration configuration = new Configuration("123", "234");

            Assert.IsInstanceOf(typeof(Amadeus), configuration.build(), "should return a Amadeus object");
            Assert.IsTrue(configuration.clientId == "123", "should set the com.amadeus.client ID");
            Assert.IsTrue(configuration.clientSecret == "234", "should set the com.amadeus.client secret");
        }

        [Test()]
        public void TestBuildDefaults()
        {
            Configuration configuration = new Configuration("id", "secret");

            Assert.IsInstanceOf(typeof(TraceSource), configuration.Logger);
            Assert.IsTrue(configuration.logLevel == "silent");
            Assert.IsTrue(configuration.hostname == "test");
            Assert.IsTrue(configuration.host == "test.api.amadeus.com");
            Assert.IsTrue(configuration.ssl);
            Assert.IsTrue(configuration.port == 443);
            Assert.IsNull(configuration.customAppId);
            Assert.IsNull(configuration.customAppVersion);
        }

        [Test()]
        public void TestBuildCustomLogger()
        {
            TraceSource logger = new TraceSource("Test");
            Configuration configuration = new Configuration("id", "secret");
            configuration.Logger = logger;
            configuration.logLevel = "debug";

            Assert.IsTrue(configuration.Logger == logger);
            Assert.IsTrue(configuration.logLevel == "debug");
        }

        [Test()]
        public void TestBuildCustomHostname()
        {
            TraceSource logger = new TraceSource("Test");
            Configuration configuration = new Configuration("id", "secret");
            configuration.setHostname("production");

            Assert.IsTrue(configuration.hostname == "production");
            Assert.IsTrue(configuration.host == "api.amadeus.com");
        }

        [Test()]
        public void TestBuildInvalidHostname()
        {
            try
            {
                Configuration configuration = new Configuration("id", "secret");
                configuration.setHostname("foo");
            }
            catch (Exception e)
            {
                Assert.IsInstanceOf(typeof(ArgumentException), e);
            }
        }

        [Test()]
        public void TestBuildCustomHost()
        {
            Configuration configuration = new Configuration("id", "secret");
            configuration.host = "foo.bar.com";

            Assert.IsTrue(configuration.host == "foo.bar.com");
        }

        [Test()]
        public void TestBuildCustomSsl()
        {
            Configuration configuration = new Configuration("id", "secret");
            configuration.setSsl(true);

            Assert.IsTrue(configuration.ssl);
            Assert.IsTrue(configuration.port == 443);
        }

        [Test()]
        public void TestBuildCustomSslWithCustomPort()
        {
            Configuration configuration = new Configuration("id", "secret");
            configuration.port = 8080;
            configuration.setSsl(true);

            Assert.IsTrue(configuration.ssl);
            Assert.IsTrue(configuration.port == 8080);
        }

        [Test()]
        public void TestBuildCustomNonSsl()
        {
            Configuration configuration = new Configuration("id", "secret");
            configuration.setSsl(false);

            Assert.IsFalse(configuration.ssl);
            Assert.IsTrue(configuration.port == 80);
        }

        [Test()]
        public void TestBuildCustomNonSslWithCustomPort()
        {
            Configuration configuration = new Configuration("id", "secret");
            configuration.port = 8080;
            configuration.setSsl(false);

            Assert.IsFalse(configuration.ssl);
            Assert.IsTrue(configuration.port == 8080);
        }

    }

}
