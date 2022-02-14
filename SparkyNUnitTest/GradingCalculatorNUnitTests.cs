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
                calc.Score = 95;
                calc.AttendancePercentage = 90;
                Assert.AreEqual("A", calc.GetGrade());
            }

            [Test]
            [TestCase(85, 90)]
            [TestCase(95, 65)]
            public void GradingCalculator_Score85Or95AndAttendance90Or65_GradeB(int a, int b)
            {
                calc.Score = a;
                calc.AttendancePercentage = b;
                Assert.AreEqual("B", calc.GetGrade());
            }

            [Test]
            public void GradingCalculator_Score65AndAttendance90_GradeC()
            {
                calc.Score = 65;
                calc.AttendancePercentage = 90;
                Assert.AreEqual("C", calc.GetGrade());
            }

            [Test]
            [TestCase(95, 55)]
            [TestCase(65, 55)]
            [TestCase(50, 90)]
            public void GradingCalculator_ScoreForFOrAttendanceForF(int a, int b)
            {
                calc.Score = a;
                calc.AttendancePercentage = b;
                Assert.AreEqual("F", calc.GetGrade());
            }
        }
    }
}

