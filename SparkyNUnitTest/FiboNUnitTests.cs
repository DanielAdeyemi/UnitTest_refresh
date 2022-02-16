using System;
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
            fibo.Range = 1;
            Assert.IsNotNull(fibo.GetFiboSeries);
        }

    }
}
