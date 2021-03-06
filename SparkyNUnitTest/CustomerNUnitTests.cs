using System;
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
            Assert.Multiple(() =>
            {

                customer.GreetAndCombineNames("Ben", "Spark");
                Assert.That(customer.GreetMessage, Is.EqualTo("Hello, Ben Spark"));
                Assert.That(customer.GreetMessage, Does.Contain("ben Spark").IgnoreCase);
                Assert.That(customer.GreetMessage, Does.StartWith("Hello,"));
                Assert.That(customer.GreetMessage, Does.EndWith("Spark"));
                Assert.That(customer.GreetMessage, Does.Match("Hello, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]"));
            });
        }

        [Test]
        public void DiscountCheck_DefaultCustomer_ReturnsDiscountInRange()
        {
            int result = customer.Discount;
            Assert.That(result, Is.InRange(10, 25));
        }

        [Test]
        public void GreetMessage_GreetedWithoutLastName_ReturnsNotNull()
        {
            customer.GreetAndCombineNames("Ben", "");
            Assert.IsNotNull(customer.GreetMessage);
        }

        [Test]
        public void GreetChecker_EmptyFirstName_ThrowsException()
        {
            Assert.Multiple(() =>
            {
                var exceptionDetails = Assert.Throws<ArgumentException>(() =>
            {
                customer.GreetAndCombineNames("", "Spark");
            });
                Assert.AreEqual("Empty First name", exceptionDetails.Message);

                Assert.Throws<ArgumentException>(() => customer.GreetAndCombineNames("", "Spark")
                );
                Assert.That(() => customer.GreetAndCombineNames("", "Spark"),
                    Throws.ArgumentException);
            });
        }

        [Test]
        public void CustomerType_CreateCustomerWithLessThanHundredOrder_ReturnBasicCustomer()
        {
            customer.OrderTotal = 10;
            var result = customer.GetCustomerDetails();
            Assert.That(result, Is.TypeOf<BasicCustomer>());
        }

        [Test]
        public void CustomerType_CreateCustomerWithMoreThanHundredOrder_ReturnPlatinumCustomer()
        {
            customer.OrderTotal = 102;
            var result = customer.GetCustomerDetails();
            Assert.That(result, Is.TypeOf<PlatinumCustomer>());
        }
    }
}

