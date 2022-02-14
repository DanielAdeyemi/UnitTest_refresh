using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sparky;


namespace SparkyMSTest
{
	[TestClass]
	public class CalculatorTests
	{
		[TestMethod]
		public void AddNums_InputTwoInt_GetCorrectAddition()
		{
			Calculator calc = new();
			int result = calc.AddNums(10, 20);
			Assert.AreEqual(30, result);
		}
	}
}

