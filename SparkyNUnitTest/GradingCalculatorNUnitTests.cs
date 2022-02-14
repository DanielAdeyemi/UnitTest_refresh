using System;
using NUnit.Framework;
using Sparky;

namespace SparkyNUnitTest
{
	public class GradingCalculatorNUnitTests
	{
        [TestFixture]
        public class CustomerNUnitTests
        {
            private GradingCalculator calc;
            [SetUp]
            public void Setup()
            {
                calc = new GradingCalculator();
            }

            [Test]
            public void GradingCalculator_Attendance90AndScore95_GradeA()
            {
                calc.AttendancePercentage = 90;
                calc.Score = 95;
                Assert.AreEqual("A", calc.GetGrade());
            }
        }
    }
}

