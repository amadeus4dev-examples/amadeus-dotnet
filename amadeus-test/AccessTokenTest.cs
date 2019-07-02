using amadeus;
using NUnit.Framework;
using System;
namespace amadeustest
{
    [TestFixture()]
    public class AccessTokenTest
    {
        [Test()]
        public void AccessTokenGenerationTest()
        {
            try
            {
                Configuration amadeusconfig = Amadeus.builder("MRDG9GUuYOBmPLWGo1RC6mWw1Yj0chQA", "vE1cCThQDtyX8Gzb");
                Amadeus amadeus = amadeusconfig.build();
            }
            catch
            {
                throw new AssertionException("");
            }
        }
    }
}
