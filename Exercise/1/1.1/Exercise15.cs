using System;

public class Exercise15
{
	/// <summary>
	/// Count the appearance amount of a number which store in arr and less than m(not include m).
	/// </summary>
	/// <param name="arr"></param>
	/// <param name="m"></param>
	/// <returns></returns>
	public static int[] Histogram(int[] arr, int m)
	{
		int[] result = new int[m];
		for (int i = 0; i < m; i++)
		{
			result[i] = 0;
		}

		for (int i = 0; i < arr.Length; i++)
		{
			int tmp = arr[i];
			if (tmp >= m)
				continue;

			result[tmp] += 1;
		}

		return result;
	}
}