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
		public void IsOddNums_InputOdd_GetTrue()
        {
			Calculator calc = new();
            bool result = calc.isOddNum(3);
            Assert.IsTrue(result);
        }
	}
}

