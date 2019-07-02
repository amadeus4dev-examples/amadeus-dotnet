using amadeus;
using NUnit.Framework;
using System;
namespace amadeustest
{
    [TestFixture()]
    public class ParamsTest
    {
        [Test()]
        public void TestNullKeyValueWith()
        {
            try
            {
                Params.with(null, "123");
            } catch (Exception e)
            {
                Assert.IsInstanceOf(typeof(ArgumentNullException), e);
            }
        }

        [Test()]
        public void TestNullKeyValueAnd()
        {
            try
            {
                Params.with("foo", "123").and(null, "234");
            }
            catch (Exception e)
            {
                Assert.IsInstanceOf(typeof(ArgumentNullException), e);
            }
        }

        [Test()]
        public void TestToQueryString()
        {
            Params _params = Params.with("foo", "123").and("bar", "234");
            Assert.IsTrue(_params.toQueryString() == "foo=123&bar=234");
        }

    }
}
