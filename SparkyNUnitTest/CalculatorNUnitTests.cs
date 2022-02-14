using System;
using NUnit.Framework;
using System.Collections.Generic;
namespace Sparky
{
	[TestFixture]
	public class CalculatorNUnitTests
    {
		private Calculator calc;
		[SetUp]
		public void Setup()
		{
			calc = new Calculator();
		}

		[Test]
		public void AddNums_InputTwoInt_GetCorrectAddition()
		{
			int result = calc.AddNums(10, 20);
			Assert.AreEqual(30, result);
		}

		[Test]
		public void IsOddNums_InputEven_GetFalse()
        {
			bool result = calc.isOddNum(2);
            Assert.IsFalse(result);
        }

		[Test]
		[TestCase(11)]
		[TestCase(13)]
		public void IsOddNums_InputOdd_GetTrue(int a)
        {
            bool result = calc.isOddNum(a);
            Assert.IsTrue(result);
        }

		[Test]
		[TestCase(10, ExpectedResult = false)]
		[TestCase(11, ExpectedResult = true)]

		public bool IsOddNums_InputNum_GetBoolResult(int a)
        {
			return calc.isOddNum(a);
        }

		[Test]
		[TestCase(5.4, 10.5)]
		[TestCase(5.43, 10.53)]
		[TestCase(5.49, 10.59)]
		public void AddNumsDouble_InputTwoDoubles_GetCorrectAddition(double a, double b)
        {
			double result = calc.AddDoubles(a, b);
            Assert.AreEqual(15.9, result, 1);
        }

        [Test]
        public void OddRange_InputMinAndMaxRange_ReturnValidNumsRange()
        {
			List<int> expectedOddRange = new() { 5, 7, 9 };
			List<int> result = calc.GetOddRange(3, 10);
			Assert.That(result, Is.EquivalentTo(expectedOddRange));
        }
    }
}

