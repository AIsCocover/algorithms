using System;

public class Exercise13
{
	/// <summary>
	/// Transpose the matrix
	/// </summary>
	/// <param name="matrix"></param>
	/// <returns></returns>
	public static double[,] Transpose(double[,] matrix)
	{
		int n = matrix.GetLength(0);
		for (int i = 0; i < n; i++)
		{
			for (int j = i; j < n; j++)
			{
				double tmp = matrix[i, j];
				matrix[i, j] = matrix[j, i];
				matrix[j, i] = tmp;
			}
		}
		return matrix;
	}
}