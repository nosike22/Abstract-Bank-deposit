
// C# program to show the
// working of abstract class
using System;

namespace Frank_s_ { }


public abstract class Bank
{

	public abstract void getBalance();

}


public class BankA : Bank
{

	
	public override void getBalance()
	{
		Console.WriteLine("$100 Was deposited into BankA");
	}
}


public class BankB : Bank
{


	public override void getBalance()
	{
		Console.WriteLine("$150 was deposited into bankB");
	}
}

public class BankC : Bank
{

	
	public override void getBalance()
	{
		Console.WriteLine("$200 was deposited into bankC");
	}
}



public class main_method
{

	
	public static void Main()
	{

		
		Bank g;

		
		g = new BankA();

		
		g.getBalance();

		
		g = new BankB();

	
		g.getBalance();

		
		g = new BankC();
		
		g . getBalance();

	}
}



