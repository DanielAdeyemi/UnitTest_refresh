﻿using System;
namespace Sparky
{
	public class Customer
	{
		public int Discount = 15;
		public string GreetMessage { get; set; }
		public string GreetAndCombineNames(string firstName, string lastName)
		{
            if (string.IsNullOrWhiteSpace(firstName))
            {
				throw new ArgumentException("Empty First name");
            }
			GreetMessage = $"Hello, {firstName} {lastName}";
            Discount = 20;
            return GreetMessage;
		}
    }
}

