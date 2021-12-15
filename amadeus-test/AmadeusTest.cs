using amadeus;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace amadeustest
{
    [TestFixture()]
    public class AmadeusTest
    {
        [Test()]
        public void TestBuilder()
        {
            Assert.IsInstanceOf(typeof(Configuration), Amadeus.builder("id", "secret"), "should return a Configuration");
        }

        [Test()]
        public void TestBuilderWithNullClientId()
        {
            Assert.IsNotNull(Amadeus.builder(null, "secret").build(), "should return null");
        }

        [Test()]
        public void TestBuilderWithNullClientSecret()
        {
            Assert.IsNotNull(Amadeus.builder("client", null).build(), "should return null");
        }

        [Test()]
        public void TestBuilderWithEnvironment()
        {
            System.Environment.SetEnvironmentVariable("AMADEUS_CLIENT_ID", "123");
            System.Environment.SetEnvironmentVariable("AMADEUS_CLIENT_SECRET", "234");
            System.Environment.SetEnvironmentVariable("AMADEUS_LOG_LEVEL", "debug");
            System.Environment.SetEnvironmentVariable("AMADEUS_PORT", "123");
            System.Environment.SetEnvironmentVariable("AMADEUS_HOST", "my.custom.host.com");
            Assert.IsInstanceOf(typeof(Configuration), Amadeus.builder(), "should return a Configuration");
            Amadeus amadeus = Amadeus.builder().build();
            Assert.IsTrue(amadeus.configuration.logLevel == "debug");
            Assert.IsTrue(amadeus.configuration.port == 123);
            Assert.IsTrue(amadeus.configuration.host == "my.custom.host.com");
            System.Environment.SetEnvironmentVariable("AMADEUS_CLIENT_ID", null);
            System.Environment.SetEnvironmentVariable("AMADEUS_CLIENT_SECRET", null);
            System.Environment.SetEnvironmentVariable("AMADEUS_LOG_LEVEL", null);
            System.Environment.SetEnvironmentVariable("AMADEUS_PORT", null);
            System.Environment.SetEnvironmentVariable("AMADEUS_HOST", null);
        }

        [Test()]
        public void TestVersion()
        {
            Assert.IsTrue(Amadeus.VERSION == "1.0.0", "should have a version number");
        }
    }
}
