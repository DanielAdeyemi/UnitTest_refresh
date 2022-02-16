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

        [Test]
        public void CheckValidity_Range6_ReturnFibo()
        {
            Assert.Multiple(() =>
            {
                fibo.Range = 6;
                List<int> result = new List<int> { 0, 1, 1, 2, 3, 5 };
                Assert.That(fibo.GetFiboSeries, Does.Contain(3));
                Assert.That(fibo.GetFiboSeries, Does.Not.Contain(4));
                Assert.That(fibo.GetFiboSeries, Has.Count.EqualTo(6));
                CollectionAssert.AreEqual(result, fibo.GetFiboSeries());
            });
        }
    }
}
