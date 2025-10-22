//#define CONSOLE
#define CHECK
//#define HOME_CHECK
using System;//#include
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IntroductionToDOTNET
{
	internal class Program
	{
		static void DrawFilledCell(int size)
		{
			for (int j = 0; j < size; ++j)
			{
				Console.Write("* ");
			}
			Console.Write(" "); 
		}

		static void DrawEmptyCell(int size)
		{
			for (int j = 0; j < size; j++)
			{
				Console.Write("  ");
			}
			Console.Write(" "); 
		}

		static void Main(string[] args)
		{
#if CONSOLE
            Console.WriteLine("Hello World!" );
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            //Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.Write("Hello .NET\t");
            Console.WriteLine();
            Console.Title = "Introduction to .NET";
            //Console.Beep(200,2000);
            Console.CursorLeft = 25;
            Console.CursorTop = 5;
            Console.WriteLine("SetCursorPosition");
            Console.SetCursorPosition(22, 8);
            Console.WriteLine("Another pothition");
            Console.ResetColor();


#endif

#if CHECK
			Console.Write("Введите ваше имя: ");
			string firstName = Console.ReadLine();

			Console.Write("Введите вашу фамилию: ");
			string lastName = Console.ReadLine();

			Console.Write("Введите ваш возраст: ");
			int age = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine(lastName + " " + firstName + " " + age);//конкатенация строк
			Console.WriteLine(String.Format("{0} {1} {2}", lastName, firstName, age));//форматирование строк
			Console.WriteLine($"{lastName} {firstName} {age}");//итерполяция строк



#endif

#if HOME_CHECK
			//Console.Write("Введите размер: ");
			//int size = Convert.ToInt32(Console.ReadLine());
			//1. Квадрат
			//*****
			//*****
			//*****

			//Console.WriteLine();
			//for (int i = 0; i < size; ++i)
			//{
			//	for (int j = 0; j < size; ++j)
			//	{
			//		Console.Write("* ");
			//	}
			//	Console.WriteLine();
			//}

			//2. Треугольник 
			//*
			//**
			//***
			//****
			//*****

			//Вариант I

			//for (int i = 0; i < size; ++i)
			//{
			//	for (int j = 0; j < size; ++j)
			//	{
			//		if (i > j)
			//		{
			//			Console.Write("* ");
			//		}
			//		else
			//		{
			//			Console.Write("  ");
			//		}

			//	}
			//	Console.WriteLine();
			//}

			//ВариантII

			//for (int i = 0; i < size; ++i)
			//{
			//	for (int j = 0; j <= i; ++j)
			//	{
			//		Console.Write("* ");
			//	}
			//	Console.WriteLine();
			//}

			//3. Треугольник 
			//*****
			//****
			//***
			//**
			//*

			//I.Вариант

			//for (int i = 0; i < size; ++i)
			//{
			//	for (int j = 0; j < size; ++j)
			//	{
			//		if (i + j < size)
			//		{
			//			Console.Write("* ");
			//		}
			//		else
			//		{
			//			Console.Write("  ");
			//		}
			//	}
			//	Console.WriteLine();
			//}

			//II.Вариант

			//for (int i = 0; i < size; ++i)
			//{
			//	for(int j = size;j>i; --j)
			//	{
			//		Console.Write("* ");
			//	}
			//	Console.WriteLine();
			//}

			//4. Треугольник
			//    *
			//   **
			//  ***
			// ****
			//*****

			//I.Вариант
			//for (int i = 0; i < size; ++i)
			//{
			//	for (int j = 0; j < size; ++j)
			//	{
			//		if (i + j >= size-1)
			//		{
			//			Console.Write("* ");
			//		}
			//		else
			//		{
			//			Console.Write("  ");
			//		}
			//	}
			//	Console.WriteLine();
			//}

			//II.Вариант
			//for (int i = 0; i < size; ++i)
			//{
			//	for (int j = size; j > i; --j)
			//	{
			//		Console.Write("  ");
			//	}
			//	for (int j = 0; j <= i; ++j)
			//	{
			//		Console.Write("* ");
			//	}
			//	Console.WriteLine();
			//}

			//III.Вариант
			//for(int i=0; i<size; i++)
			//{
			//	Console.SetCursorPosition(size - i, i + 1);
			//	for(int j=0; j<=i; j++)
			//	{
			//		Console.Write("*");
			//	}
			//}

			//5. Треугольник
			//*****
			// ****
			//  ***
			//   **
			//    *
			//I.Вариант

			//for (int i = 0; i < size; ++i)
			//{
			//	for (int j = 0; j < size; ++j)
			//	{
			//		if (i <= j)
			//		{
			//			Console.Write("* ");
			//		}
			//		else
			//		{
			//			Console.Write("  ");
			//		}
			//	}
			//	Console.WriteLine();
			//}

			//II.Вариант
			//for (int i = 0; i < size; ++i)
			//{
			//	for (int j = 0; j <= i; ++j)
			//	{
			//		Console.Write(" ");
			//	}
			//	for (int j = size; j > i; --j)
			//	{
			//		Console.Write("*");
			//	}
			//	Console.WriteLine();
			//}
			//III.Вариант
			//for (int i = 0; i < size; ++i)
			//{
			//	Console.SetCursorPosition(i, i + 1);
			//	for (int j = size; j > i; --j)
			//	{

			//		Console.Write("*");
			//	}
			//	Console.WriteLine();
			//}

			//6. 
			//+ - + - +
			//- + - + -
			//+ - + - +
			//- + - + -

			//for (int i = 0; i < size; ++i)
			//{
			//	for (int j = 0; j < size; ++j)
			//	{
			//		Console.Write(i % 2 == j % 2 ? "+ " : "- ");
			//	}
			//	Console.WriteLine();
			//}

			//7. Ромб
			//     /\
			//    /  \
			//   /    \
			//   \    /
			//    \  /
			//     \/

			//for (int i = 0; i < size; ++i)//общее количество строк
			//{
			//	for (int j = i; j < size; ++j)//пробелы слева
			//	Console.Write(" ");
			//	Console.Write("/");
			//	for (int j = 0; j < i; ++j)//пробелы внутри
			//	Console.Write("  ");
			//	Console.Write("\\");
			//	Console.WriteLine();

			//}
			//for (int i = 0; i < size; ++i)
			//{
			//	for (int j = 0 - 1; j < i; ++j)
			//	Console.Write(" ");
			//	Console.Write("\\");
			//	for (int j = i + 1; j < size; ++j)
			//	Console.Write("  ");
			//	Console.Write("/");
			//	Console.WriteLine();
			//}

			//8. Шахматная доска
			//****    ****    ****
			//****    ****    **** 
			//****    ****    ****
			//    ****    ****
			//    ****    ****
			//    ****    ****
			//****    ****    ****
			//****    ****    ****
			//****    ****    ****

			//int boardSize = 8; 
			//int cellSize = 5;  

			//// Внешний цикл для строк доски
			//for (int row = 0; row < boardSize; row++)
			//{
			//	for (int cellRow = 0; cellRow < cellSize; cellRow++)
			//	{
			//		// Внутренний цикл для столбцов доски
			//		for (int col = 0; col < boardSize; col++)
			//		{
			//			if ((row + col) % 2 == 0)
			//			{ 
			//				DrawFilledCell(cellSize);
			//			}
			//			else
			//			{
			//				DrawEmptyCell(cellSize);
			//			}
			//		}

			//		Console.WriteLine();
			//	}
			//}

			int boardSize = 8; 
			int cellSize = 5;  

			// Внешний цикл для строк шахматной доски
			for (int row = 0; row < boardSize * cellSize; row++)
			{
				// Внутренний цикл для столбцов шахматной доски
				for (int col = 0; col < boardSize * cellSize; col++)
				{
					
					if (((row / cellSize) + (col / cellSize)) % 2 == 0)
					{
						
						Console.Write("* ");
					}
					else
					{
						
						Console.Write("  ");
					}
				}
				
				Console.WriteLine();
			}
			Thread.Sleep(3000);
#endif
		}
	}
}
