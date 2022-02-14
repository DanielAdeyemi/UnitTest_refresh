﻿using System;
namespace Sparky
{
	public class CustomerType { }
	public class BasicCustomer : CustomerType { }
	public class PlatinumCustomer : CustomerType { }
	public class Customer
	{
		public int Discount = 15;
        public int OrderTotal { get; set; }
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
        public CustomerType GetCustomerDetails()
		{
			if(OrderTotal < 100)
			{
				return new BasicCustomer();
			}
			return new PlatinumCustomer();
		}
    }
	
}

