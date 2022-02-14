using System;
using NUnit.Framework;
using Sparky;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class CustomerNUnitTests
    {
        [Test]
        public void CombineName_InputNames_ReturnGreeting()
        {
            var customer = new Customer();
            string fullName = customer.GreetAndCombineNames("Ben", "Spark");
            Assert.That(fullName, Is.EqualTo("Hello, Ben Spark"));
        }
    }
}

