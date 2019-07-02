using amadeus;
using amadeus.exceptions;
using NUnit.Framework;
using System;
namespace amadeustest
{
    [TestFixture()]
    public class ExceptionsTest
    {
        [Test()]
        public void TestNilResponse()
        {
            ResponseException error = new ResponseException(null);
            Assert.IsTrue(error.ToString() == "amadeus.exceptions.ResponseException: [---]");
        }

        [Test()]
        public void TestNoStatusCode()
        {
            Response response = new Response(null);
            ResponseException error = new ResponseException(response);
            Assert.IsTrue(error.ToString() == "amadeus.exceptions.ResponseException: [---]");
        }

    }

}
