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
            Assert.That(fullName, Does.Contain("ben Spark").IgnoreCase);
            Assert.That(fullName, Does.StartWith("Hello,"));
            Assert.That(fullName, Does.EndWith("Spark"));
            Assert.That(fullName, Does.Match("Hello, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]"));
        }
    }
}

