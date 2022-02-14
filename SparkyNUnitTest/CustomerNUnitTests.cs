﻿using System;
using NUnit.Framework;
using Sparky;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class CustomerNUnitTests
    {
        private Customer customer;
        [SetUp]
        public void Setup()
        {
            customer = new Customer();
        }

        [Test]
        public void CombineName_InputNames_ReturnGreeting()
        {
            customer.GreetAndCombineNames("Ben", "Spark");
            Assert.That(customer.GreetMessage, Is.EqualTo("Hello, Ben Spark"));
            Assert.That(customer.GreetMessage, Does.Contain("ben Spark").IgnoreCase);
            Assert.That(customer.GreetMessage, Does.StartWith("Hello,"));
            Assert.That(customer.GreetMessage, Does.EndWith("Spark"));
            Assert.That(customer.GreetMessage, Does.Match("Hello, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]"));
        }
    }
}

