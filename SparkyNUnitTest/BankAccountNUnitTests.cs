using System;
using NUnit.Framework;
using Sparky;

namespace SparkyNUnitTest
{
	[TestFixture]
	public class BankAccountNUnitTests
	{
		private BankAccount bankAccount;
		[SetUp]
		public void Setup ()
        {
			bankAccount = new(new LogBook());
        }
		[Test]
		public void BankDeposit_Add100_ReturnTrue()
        {
			var result = bankAccount.Deposit(100);
			Assert.IsTrue(result);
			Assert.That(bankAccount.GetBalance, Is.EqualTo(100));
        }
	}
}

