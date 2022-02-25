using System;
using System.Collections.Generic;

namespace Sparky
{
	public class BankAccount
	{
		public int balance { get; set; }
		private readonly ILogBook _logBook;
		public BankAccount(ILogBook logBook)  
		{
			_logBook = logBook;
			balance = 0;
		}
		public bool Deposit(int amount)
		{
			_logBook.Message("Deposit invoked");
			balance += amount;
			return true;
		}

		public bool Withdraw(int amount)
		{
			if (amount <= balance)
			{
				balance -= amount;
				return true;
			}
			return false;
		}

		public int GetBalance()
        {
			return balance;
        }
    }
}


