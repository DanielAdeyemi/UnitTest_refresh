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
                List<int> result = fibo.GetFiboSeries();
                List<int> expected = new() { 0 };
                Assert.IsNotNull(result);
                Assert.That(result, Is.Ordered);
                CollectionAssert.AreEqual(expected, result);
            });
        }

        [Test]
        public void CheckValidity_Range6_ReturnFibo()
        {
            Assert.Multiple(() =>
            {
                fibo.Range = 6;
                List<int> expected = new () { 0, 1, 1, 2, 3, 5 };
                List<int> result = fibo.GetFiboSeries();
                Assert.That(result, Does.Contain(3));
                Assert.That(result, Does.Not.Contain(4));
                Assert.That(result, Has.Count.EqualTo(6));
                CollectionAssert.AreEqual(expected, result);
            });
        }
    }
}
