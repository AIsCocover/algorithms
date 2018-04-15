using System;

public class Exercise
{
	/// <summary>
	/// Fibonacci Sequence.
	/// </summary>
	/// <param name="n"></param>
	public static void FibonacciSequence(int n)
	{
		int f = 0;
		int g = 1;
		Console.WriteLine("Fibonacci Sequenct(" + n + "): ");
		for (int i = 0; i <=n; i++)
		{
			if(i==n)
			{
				Console.WriteLine(f);
				break;
			}
			Console.Write(f + " ");
			f = f + g;
			g = f - g;
		}
	}
}