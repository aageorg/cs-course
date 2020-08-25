using System;
using System.Threading;

class Program
{
	static void Main()
	{
		Console.WriteLine("Enter your name:");
		string name = Console.ReadLine();
		if (name != "")
		{
			Thread.Sleep(5000);
			Console.WriteLine($"Hello, {name}!");
			Thread.Sleep(5000);
			Console.WriteLine($"Goodbye, {name}!");

		}
		else
		{

		}
		Console.ReadKey();
	}
}
