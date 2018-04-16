using System;

public class Exercise33
{
		/// <summary>
		/// Matrix dot product.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		public static double dot(double[] x, double[] y)
		{
			int lenX = x.Length;
			int lenY = y.Length;
			int len = lenX;
			if (lenX != lenY)
				return double.MinValue;

			double sum = 0.0;
			for (int i = 0; i < len; i++)
			{
				sum += x[i] * y[i];
			}

			return sum;
		}
		
		/// <summary>
		/// Matrix multiply between two matrix.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public static double[,] mult(double[,] a, double[,] b)
		{
			int aColCount = a.GetLength(1);
			int bRowCount = b.GetLength(0);
			if (aColCount != bRowCount)
				return new double[,] { };

			int sameCount = aColCount;
			int rowCount = a.GetLength(0);
			int colCount = b.GetLength(1);
			double[,] result = new double[rowCount, colCount];
			for (int i = 0; i < rowCount; i++)
			{
				for (int j = 0; j < colCount; j++)
				{
					double tmp = 0.0;
					for (int k = 0; k < sameCount; k++)
					{
						tmp += a[i, k] * b[k, j];
					}

					result[i, j] = tmp;
				}
			}

			return result;
		}
		
		/// <summary>
		/// Matrix transpose for square matrix.
		/// </summary>
		/// <param name="a"></param>
		/// <returns></returns>
		public static double[,] transpose(double[,] a)
		{
			int rowCount = a.GetLength(0);
			int colCount = a.GetLength(1);
			if (rowCount != colCount)
				return new double[,] { };

			int sameCount = rowCount;
			double[,] result = new double[rowCount, colCount];
			for (int i = 0; i < sameCount; i++)
			{
				for (int j = i+1; j < sameCount; j++)
				{
					double tmp = a[i, j];
					a[i, j] = a[j, i];
					a[j, i] = tmp;
				}
			}

			return a;
		}
		
		/// <summary>
		/// Matrix multiply between matrix and vector.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="x"></param>
		/// <returns></returns>
		public static double[] mult(double[,] a, double[] x)
		{
			int aColCount = a.GetLength(1);
			int xCount = x.Length;
			if (aColCount != xCount)
				return new double[] { };

			int sameCount = aColCount;
			int rowCount = a.GetLength(0);
			double[] result = new double[rowCount];
			for (int i = 0; i < sameCount; i++)
			{
				for (int j = 0; j < rowCount; j++)
				{
					result[j] += a[j, i] * x[i];
				}
			}

			return result;
		}
		
		/// <summary>
		/// Matrix multiply between vector and matrix.
		/// </summary>
		/// <param name="y"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public static double[] mult(double[] y, double[,] b)
		{
			int yCount = y.Length;
			int bRowCount = b.GetLength(0);
			if (yCount != bRowCount)
				return new double[] { };

			int sameCount = yCount;
			int colCount = b.GetLength(1);
			double[] result = new double[colCount];
			for (int i = 0; i < colCount; i++)
			{
				for (int j = 0; j < sameCount; j++)
				{
					result[i] += y[j] * b[j, i];
				}
			}

			return result;
		}
}