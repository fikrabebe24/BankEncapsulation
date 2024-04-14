﻿using System;
namespace BankEncapsulation
{
	public class BankAccount
	{
		private double balance = 0;

		public BankAccount()
		{
		}

        //Define a method named Deposit that will accept a double and store that value in the balance field

        public void Deposit(double amount)
		{
			balance = amount;
		}

        //Define a method named GetBalance that will return the amount stored in the balance field
        public double GetBalance()
		{
			return balance;
		}
	}
}

