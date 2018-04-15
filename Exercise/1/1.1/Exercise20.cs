using System;

public class Exercise20
{
	/// <summary>
	/// Calculate the natural logarithm of factorial of n.
	/// </summary>
	/// <param name="n"></param>
	public static double NaturalLogarithmOfFactorial(int n)
	{
		if (n == 1)
			return 0;
		else
		{
			return Math.Log(n) + NaturalLogarithmOfFactorial(n - 1);
		}
	}
}