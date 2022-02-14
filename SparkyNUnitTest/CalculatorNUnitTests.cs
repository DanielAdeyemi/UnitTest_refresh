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
			Assert.AreEqual(10, result);
		}
	}
}

