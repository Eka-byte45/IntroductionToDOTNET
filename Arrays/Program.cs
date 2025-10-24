//#define ARRAY1
//#define ARRAY_11
//#define ARRAY_2
#define JAGGED_ARRAYS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Arrays
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if ARRAY1
			int[] arr = { 3, 5, 8, 13, 21 };
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i]+"\t");
			}
			Console.WriteLine();

			foreach(int i in arr)
			{
                Console.Write(i+"\t");
			}
			Console.WriteLine();
#endif
			Random rand = new Random(0);
#if ARRAY_11
			Console.Write("Введите размер массива: ");
			int n = Convert.ToInt32(Console.ReadLine());
			int[] arr = new int[n];

			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rand.Next(100);
			}

			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write($"{arr[i]}\t");
			}
			Console.WriteLine();

			//int summa = 0;
			//for(int i = 0;i<arr.Length; i++)
			//{
			//	summa += arr[i];
			//}
			//double average = (double)summa/n;

			//int max = arr[0];
			//for (int i = 1;i<arr.Length ; i++)
			//{
			//	if (arr[i] > max)
			//	{
			//		max= arr[i];
			//	}
			//}

			//int min = arr[0];
			//for (int i = 1; i < arr.Length; i++)
			//{
			//	if (arr[i] < min)
			//	{
			//		 min = arr[i];
			//	}
			//}
			//Console.WriteLine($"Сумма: {summa}, среднее арифметическое: {average}, максимальное значение:{max}, минимальное значение: {min}");
			Console.WriteLine($"Сумма элементов массива: {arr.Sum()}");
			Console.WriteLine($"Среднее арифметическое: {arr.Average()}");
			Console.WriteLine($"Минимальное значение: {arr.Min()}");
			Console.WriteLine($"Максимальное значение: {arr.Max()}");
			/*foreach(ref int i  in arr)
			{
				i=rand.Next(100);
			}

			foreach(int i in arr)
			{
				Console.Write($"{i}\t");
			}
			Console.WriteLine();*/

#endif

#if ARRAY_2
			Console.Write("Введите количество строк: ");
			int rows = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите количество элементов строки: ");
			int cols = Convert.ToInt32(Console.ReadLine());

			int[,] arr = new int[rows, cols];
			Console.WriteLine($"Количество измерений: {arr.Rank}");
			Console.WriteLine($"Количество элементов: {arr.Length}");
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					arr[i, j] = rand.Next(10);
				}

			}

			foreach (int i in arr)
			{
				Console.Write(i + "\t");
			}
			Console.WriteLine();
			Console.WriteLine();
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					Console.Write($"{arr[i, j]}\t");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
			Console.WriteLine($"Сумма элементов массива: {arr.Cast<int>().Sum()}");
			Console.WriteLine($"Среднее арифметическое элементов массива: {arr.Cast<int>().Average()}");
			Console.WriteLine($"Минимальноне: {arr.Cast<int>().Min()}");
			Console.WriteLine($"Максимальное: {arr.Cast<int>().Max()}"); 
#endif
			int[][] arr =
			{
				new int[] { 0,1,1,2 },
				new int[] { 3,5,8,13,21},
				new int[] { 34,55,89 },
				//new int[] { 144,233,377,610,987}
			};

			for(int i=0; i<arr.Length; i++)
			{
				for(int j=0; j<arr[i].Length; j++)
				{
					Console.Write(arr[i][j]+"\t");
				}
				Console.WriteLine();
			}
            Console.WriteLine("\n-----------------------------------------\n");
			foreach(int[] i in arr)
			{
                //Console.Write(i+"\t");
				foreach(int j in i)
				{
                    Console.Write(j+"\t");
				}
				Console.WriteLine();
			}
            Console.WriteLine();
			int sum = 0;
			int count = 0;
			foreach(int[] i in arr)
			{
				sum += i.Sum();
				count += i.Length;
			}
			Console.WriteLine($"Сумма элементов массива: {sum}");
			Console.WriteLine($"Количество элементов массива: {count}");
			Console.WriteLine($"Среднее арифметическое: {(double)sum/count}");
			int min, max;
			min = max = arr[0][0];
			foreach(int[] i in arr)
			{
				if(i.Min() < min) min = i.Min();
				if(i.Max() > max) max = i.Max();
				
			}
			Console.WriteLine($"Минимальное значение:{min}");
			Console.WriteLine($"Максимальное значение:{max}");

		}
	}
}
