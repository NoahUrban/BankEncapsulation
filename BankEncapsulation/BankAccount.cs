using System;
public class BankAccount
{
	private double _balance = 0;

	public BankAccount()
	{
		
	}

	public void Deposit(double amount)
	{
		_balance += amount;
	}

	public void GetBalance()
	{
		Console.WriteLine($"Balance: {_balance}");
	}
}


