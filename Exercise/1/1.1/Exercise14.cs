using System;

public class Exercise14
{
	/// <summary>
	/// Return a number less than or equal to Log_2{N}.
	/// </summary>
	/// <param name="n"></param>
	/// <returns></returns>
	public static int Lg(int n)
	{
		int index = 0;
		while(n > 0)
		{
			n >>= 1;
			index++;
		}
		
		return index-1;
	}
}