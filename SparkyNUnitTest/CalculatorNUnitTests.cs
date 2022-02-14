using System;
using NUnit.Framework;
namespace Sparky
{
	[TestFixture]
	public class CalculatorNUnitTests
	{
		[Test]
		public void AddNums_InputTwoInt_GetCorrectAddition()
		{
			Calculator calc = new();
			int result = calc.AddNums(10, 20);
			Assert.AreEqual(30, result);
		}
		[Test]
		public void IsOddNums_InputEven_GetFalse()
        {
			Calculator calc = new();
			bool result = calc.isOddNum(2);
            Assert.IsFalse(result);
        }
		[Test]
		[TestCase(11)]
		[TestCase(13)]
		public void IsOddNums_InputOdd_GetTrue(int a)
        {
			Calculator calc = new();
            bool result = calc.isOddNum(a);
            Assert.IsTrue(result);
        }

		[Test]
		[TestCase(10, ExpectedResult = false)]
		[TestCase(11, ExpectedResult = true)]

		public bool IsOddNums_InputNum_GetBoolResult(int a)
        {
			Calculator calc = new();
			return calc.isOddNum(a);
        }
	}
}

