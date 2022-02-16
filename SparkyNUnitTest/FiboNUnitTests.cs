using System;
using System.Collections.Generic;
using NUnit.Framework;
using Sparky;

namespace SparkyNUnitTest
{
	[TestFixture]
	public class FiboNUnitTests
	{
        private Fibo fibo;
        [SetUp]
        public void Setup()
        {
            fibo = new Fibo();
        }

        [Test]
        public void IsListEmpty_InputRange_ReturnNonEmpty()
        {
            Assert.Multiple(() =>
            {
                fibo.Range = 1;
                List<int> result = new List<int>{ 0 };
                Assert.IsNotNull(fibo.GetFiboSeries);
                Assert.That(fibo.GetFiboSeries, Is.Ordered);
                CollectionAssert.AreEqual(result, fibo.GetFiboSeries());
            });
            }

    }
}
