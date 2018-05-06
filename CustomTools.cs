using System;

namespace Custom
{
	public class CustomTools
	{
		#region Else
		/// <summary>
		/// Fibonacci Sequence.
		/// </summary>
		/// <param name="n"></param>
		public static void FibonacciSequence(int n)
		{
			int f = 0;
			int g = 1;
			Console.WriteLine("Fibonacci Sequenct(" + n + "): ");
			for (int i = 0; i <= n; i++)
			{
				if (i == n)
				{
					Console.WriteLine(f);
					break;
				}
				Console.Write(f + " ");
				f = f + g;
				g = f - g;
			}
		}
		/// <summary>
		/// Get first n terms of Fibonacci Sequence.
		/// </summary>
		/// <param name="n"></param>
		/// <returns></returns>
		public static int[] GetFibonacciSequenceElements(int n)
		{
			int[] arr = new int[n + 1];
			int f = 0;
			int g = 1;
			Console.WriteLine("Get Fibonacci Sequenct Elements(" + n + "): ");
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
		/// <summary>
		/// Calculate an int number's binary string.
		/// </summary>
		/// <param name="n"></param>
		public static void ToBinaryString(int n)
		{
			string str = "";
			Console.WriteLine("ToBinaryString(" + n + "): ");
			for (int t = n; t > 0; t /= 2)
			{
				// Remainder first-in last-out
				str = (t % 2) + str;
				Console.WriteLine(str);
			}
			Console.WriteLine("Result: " + str);
		}
		/// <summary>
		/// Return a number less than or equal to Log_{2}N.
		/// </summary>
		/// <param name="n"></param>
		/// <returns></returns>
		public static int Lg(int n)
		{
			int index = 0;
			Console.WriteLine("lg(" + n + "): ");
			while (n > 0)
			{
				n >>= 1;
				Console.Write(n + " ");
				index++;
			}
			Console.WriteLine();

			return index - 1;
		}
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

			Console.WriteLine("histogram: ");
			for (int i = 0; i < arr.Length; i++)
			{
				int tmp = arr[i];
				if (tmp >= m)
					continue;

				result[tmp] += 1;
			}

			return result;
		}
		/// <summary>
		/// Realization multiply by add.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public static int Multiply(int a, int b)
		{
			Console.WriteLine(a + " " + b);
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
			Console.WriteLine(a + " " + b);
			if (b == 0) return 1;
			if (b % 2 == 0) return Exponentiation(a * a, b / 2);
			return Exponentiation(a * a, b / 2) * a;
		}
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
		#endregion

		#region Array
		/// <summary>
		/// Get a max number from the array.
		/// </summary>
		/// <param name="arr">.</param>
		/// <returns></returns>
		public static double GetMax(double[] arr)
		{
			int N = arr.Length;
			double max = arr[0];
			if (N <= 1)
				return max;

			for (int i = 1; i < N; i++)
			{
				if (arr[i] > max)
					max = arr[i];
			}
			return max;
		}
		/// <summary>
		/// Calculate average for the arr.
		/// </summary>
		/// <param name="arr"></param>
		/// <returns></returns>
		public static double GetAverage(double[] arr)
		{
			int N = arr.Length;
			double sum = 0.0;
			for (int i = 0; i < N; i++)
			{
				sum += arr[i];
			}

			return sum / N;
		}

		/// <summary>
		/// Copy the target to arr.
		/// </summary>
		/// <param name="target"></param>
		/// <param name="arr"></param>
		public static void Copy(double[] target, ref double[] arr)
		{
			int N = target.Length;
			for (int i = 0; i < N; i++)
			{
				arr[i] = target[i];
			}
		}
		/// <summary>
		/// Reverse the arr's element.
		/// </summary>
		/// <param name="arr"></param>
		public static void Reverse(ref double[] arr)
		{
			int N = arr.Length;
			for (int i = 0; i < N / 2; i++)
			{
				double tmp = arr[i];
				arr[i] = arr[N - 1 - i];
				arr[N - 1 - i] = tmp;
			}
		}

		/// <summary>
		/// Check if string str is in alphabet order.
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		public static bool IsAlphabetOrder(string str)
		{
			int length = str.Length;
			for (int i = 1; i < length; i++)
			{
				if (str[i - 1].CompareTo(str[i]) > 0)
					return false;
			}

			return true;
		}
		#endregion

		#region Matrix
		/// <summary>
		/// Create a random matrix. type int one-dimensional
		/// </summary>
		/// <param name="length"></param>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns></returns>
		public static int[] GetRandomMatrix(int length, int min, int max)
		{
			int[] result = new int[length];
			Random random = new Random();
			for (int i = 0; i < length; i++)
			{
				result[i] = random.Next(min, max);
			}

			return result;
		}
		/// <summary>
		/// Create a random matrix. type double one-dimensional
		/// </summary>
		/// <param name="length"></param>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns></returns>
		public static double[] GetRandomMatrix(int length, double min, double max)
		{
			double[] result = new double[length];
			Random random = new Random();
			for (int i = 0; i < length; i++)
			{
				result[i] = random.NextDouble() * (max - min) + min;
			}

			return result;
		}
		/// <summary>
		/// Create a random matrix. type int two-dimensional
		/// </summary>
		/// <param name="rowCount"></param>
		/// <param name="colCount"></param>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns></returns>
		public static int[,] GetRandomMatrix2D(int rowCount, int colCount, int min, int max)
		{
			int[,] result = new int[rowCount, colCount];
			Random random = new Random();
			for (int i = 0; i < rowCount; i++)
			{
				for (int j = 0; j < colCount; j++)
				{
					result[i, j] = random.Next(min, max);
				}
			}

			return result;
		}
		/// <summary>
		/// Create a random matrix. type double two-dimensional
		/// </summary>
		/// <param name="rowCount"></param>
		/// <param name="colCount"></param>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns></returns>
		public static double[,] GetRandomMatrix2D(int rowCount, int colCount, double min, double max)
		{
			double[,] result = new double[rowCount, colCount];
			Random random = new Random();
			for (int i = 0; i < rowCount; i++)
			{
				for (int j = 0; j < colCount; j++)
				{
					result[i, j] = random.NextDouble() * (max - min) + min;
				}
			}

			return result;
		}
		
		/// <summary>
		/// Print out a matrix. type one-dimensional
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="matrix"></param>
		public static void Print<T> (T[] matrix)
			where T : struct
		{
			int length = matrix.Length;
			Console.WriteLine("Print: ");
			for (int i = 0; i < length; i++)
			{
				if (i == length - 1)
				{
					Console.WriteLine(matrix[i]);
					break;
				}
				Console.Write(matrix[i] + " ");
			}
		}
		/// <summary>
		/// Print out a matrix. type two-dimensional
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="matrix"></param>
		public static void Print<T> (T[,] matrix)
			where T : struct
		{
			int rowCount = matrix.GetLength(0);
			int colCount = matrix.GetLength(1);
			Console.WriteLine("Print: ");
			for (int i = 0; i < rowCount; i++)
			{
				for (int j = 0; j < colCount; j++)
				{
					if (j == colCount - 1)
					{
						Console.WriteLine(matrix[i, j]);
						break;
					}
					Console.Write(matrix[i, j] + " ");
				}
			}
		}

		
		/// <summary>
		/// Matrix dot product.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		public static double Dot(double[] x, double[] y)
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
		public static double[,] Multiply(double[,] a, double[,] b)
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
		public static double[,] Transpose(double[,] a)
		{
			int rowCount = a.GetLength(0);
			int colCount = a.GetLength(1);
			if (rowCount != colCount)
				return new double[,] { };

			int sameCount = rowCount;
			double[,] result = new double[rowCount, colCount];
			for (int i = 0; i < sameCount; i++)
			{
				for (int j = i + 1; j < sameCount; j++)
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
		public static double[] Multiply(double[,] a, double[] x)
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
		public static double[] Multiply(double[] y, double[,] b)
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
		#endregion

		#region Search Alogrithms
		/*
		 *	Recursion:
		 *		when use recursion, remember these rules:
		 *			- Don't forget the return sentence.
		 *			- Recursion always used to solve a sub problem.
		 *			- In recursion, the parent part and the sub part should not have intersection.
		 */
		/// <summary>
		/// Binary Search
		/// </summary>
		/// <param name="key"></param>
		/// <param name="arr"></param>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <returns></returns>
		public static int BinarySearch(int key, int[] arr, int left, int right)
		{
			if (left > right) return -1;
			int mid = left + (right - left) / 2;
			if (key < arr[mid]) return BinarySearch(key, arr, left, mid - 1);
			else if (key > arr[mid]) return BinarySearch(key, arr, mid + 1, right);
			else return mid;
		}
		#endregion

		#region Math
		/// <summary>
		/// Return the abs of x. int type
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public static int Abs(int x)
		{
			int result = x > 0 ? x : -x;
			return result;
		}
		/// <summary>
		/// Return the abs of x. double type
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public static double Abs(double x)
		{
			double result = x > 0.0 ? x : -x;
			return result;
		}
		/// <summary>
		/// Calculate sqrt, use Newton's Method.
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public static double Sqrt(double x)
		{
			if (x < 0) return Double.NaN;
			double error = 1e-15;
			double t = x;
			while (Abs(t - x / t) > error * t)
			{
				t = (x / t + t) / 2.0;
			}

			return t;
		}

		/// <summary>
		/// Pythagoras Theorem, calculate triangle's hypotenuse
		/// </summary>
		/// <param name="ras1"></param>
		/// <param name="ras2"></param>
		/// <returns></returns>
		public static double PythagorasTheorem(double ras1, double ras2)
		{
			double result = Sqrt(ras1 * ras1 + ras2 * ras2);
			return result;
		}
		/// <summary>
		/// Euchlidean Distance
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public static double EuclideanDistance(double[] a, double[] b)
		{
			int length = a.Length;
			double sum = 0.0;
			for (int i = 0; i < length; i++)
			{
				sum += (a[i] - b[i]) * (a[i] - b[i]);
			}

			return Sqrt(sum);
		}
		/// <summary>
		/// Calculate HarmonicSeries.
		///	Harmonic Series:
		///		sum = 1+1/2+1/3+1/4+...+1/n
		/// </summary>
		/// <param name="N"></param>
		/// <returns></returns>
		public static double HarmonicSeries(int N)
		{
			double sum = 0.0;
			for (int i = 1; i <= N; i++)
			{
				sum += 1.0 / i;
			}

			return sum;
		}

		/// <summary>
		/// Check if number x is prime number.
		/// Prime number: 
		///		In the natural number which greater than 1, and there are no more factors besides 1 and itself.
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public static bool IsPrime(int x)
		{
			if (x < 2) return false;
			for (int i = 2; i * i <= x; i++)
			{
				if (x % i == 0) return false;
			}

			return true;
		}
		#endregion

		#region String
		/// <summary>
		/// Check if string str is palindrome.
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		public static bool IsPalindrome(string str)
		{
			int length = str.Length;
			for (int i = 0; i < length / 2; i++)
			{
				if (str[i] != str[length - i - 1])
					return false;
			}

			return true;
		}
		#endregion

		#region Sorting Alogrithm
		#region  Help Function
		/// <summary>
		/// Check if a is less than b.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		private static bool Less<T> (T a, T b)
			where T : struct, IComparable
		{
			return a.CompareTo(b) < 0;
		}
		/// <summary>
		/// Exchange arr[i] and arr[j].
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="arr"></param>
		/// <param name="i"></param>
		/// <param name="j"></param>
		public static void Exchange<T> (ref T[] arr, int i, int j)
			where T : struct
		{
			T tmp = arr[i];
			arr[i] = arr[j];
			arr[j] = tmp;
		}
		/// <summary>
		/// Check if array is sorted. select order type by set variable: isReverse.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="arr"></param>
		/// <param name="isReverse"></param>
		/// <returns></returns>
		public static bool IsSorted<T> (T[] arr, bool isReverse = false)
			where T : struct, IComparable
		{
			for (int i = 1; i < arr.Length; i++)
			{
				if (isReverse == false)
				{
					if (Less(arr[i], arr[i - 1]))
						return false;
				}
				else
				{
					if (Less(arr[i - 1], arr[i]))
						return false;
				}
			}

			return true;
		}
		#endregion

		/// <summary>
		/// Selection Sort Alogrithm
		///		Steps:
		///			First, find the smallest element.
		///			Second, Exchange the smallest element with the first element(if the first one is the smallest, exchange with itself).
		///			Third, find the smallest element in the rest elements, exchange it with the second element.
		///			And then, continue First to Third until sort end.
		///		
		///		Characteristic:
		///			1. For a long n's array, it needs about (N-1)+(N-2)+...+2+1=N(N-1)/2~(N^2)/2 times compare operation and n times exchange.
		///			2. Date move times leastly, the relation of exchange times and array's size is linear. 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="arr"></param>
		public static void SelectionSort<T> (ref T[] arr)
			where T : struct, IComparable
		{
			int n = arr.Length;
			for (int i = 0; i < n; i++)
			{
				int min = i;
				for (int j = i+1; j < n; j++)
				{
					if (Less(arr[j], arr[min]))
						min = j;
				}
				Exchange(ref arr, i, min);
			}
		}

		/// <summary>
		/// InsertionSort Algorithm
		///		Steps:
		///			For each a[i]
		///				From arr[0] to arr[i-1] each one as element 
		///					if element smaller than a[i];
		///						exchange(element, a[i])
		///		Characteristic:
		///			1. In bad situation, it needs to compare (N^2)/2 times and exchange (N^2)/2 times.
		///			2. In average situation, it needs to compare (N^2)/4 times and exchange (N^2)/4 times.
		///			3. In best situation, it needs to compare N-1 times and exchange 0 time.
		///			4. the left side is always in order(a[i]'s left side).
		///			5. arr's inverse number decide Insertion Sort Alogrithm's performance.
		///				set exchange count = e, compare count = c, inverse number = n, arr's length = len.
		///				we have:
		///					i. e = n
		///					ii. n+len-1 >= c >= n
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="arr"></param>
		public static void InsertionSort<T> (ref T[] arr)
			where T:struct, IComparable
		{
			int n = arr.Length;
			for (int i = 1; i < n; i++)
			{
				for (int j = i; j > 0; j--)
				{
					if (Less(arr[j], arr[j - 1]))
						Exchange(ref arr, j, j - 1);
				}
			}
		}
		#endregion
	}
}