using System;

public class Exercise19
{
	/// <summary>
	/// Get first n terms of Fibonacci Sequence.
	/// </summary>
	/// <param name="n"></param>
	/// <returns></returns>
	public static int[] GetFibonacciSequenceElements(int n)
	{
		int[] arr = new int[n+1];
		int f = 0;
		int g = 1;
		for (int i = 0; i <= n; i++)
		{
			if (i == n)
			{
				arr[i] = f;
				break;
			}

			arr[i] = f;
			f = f + g;
			g = f - g;
		}
		return arr;
	}
}