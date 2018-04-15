using System;

public class Exercise18
{
	/// <summary>
	/// Realization multiply by add.
	/// </summary>
	/// <param name="a"></param>
	/// <param name="b"></param>
	/// <returns></returns>
	public static int Multiply(int a, int b)
	{
		if (b == 0) return 0;
		if (b % 2 == 0) return Multiply(a + a, b / 2);
		return Multiply(a + a, b / 2) + a;
	}
	
	/// <summary>
	/// Realization exponentiation by multiply. a is base, b is index.
	/// </summary>
	/// <param name="a"></param>
	/// <param name="b"></param>
	/// <returns></returns>
	public static int Exponentiation(int a, int b)
	{
		if (b == 0) return 1;
		if (b % 2 == 0) return Exponentiation(a * a, b / 2);
		return Exponentiation(a * a, b / 2) * a;
	}
}