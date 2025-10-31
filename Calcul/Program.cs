//#define CALC_IF
//#define CALC_SWITCH
//#define HOME_CHECK
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CalcMy
{
	internal class Program
	{
		static string expression = "";
		static readonly char[] operators = new char[] { '+', '-', '*', '/' };
		static string[] operands;
		static double[] values;
		static readonly char[] digits = "0123456789.,".ToCharArray();
		static string[] operations;
		static void Main(string[] args)
		{
			Console.Write("Введите арифметическое выражение: ");
			expression = "((((5+3)*2)-4)+((2+3)*2))";
			//string expression = Console.ReadLine();
			expression = expression.Replace(".", ",");
			expression = expression.Replace(" ", "");
			Console.Write(expression);

			double Result = Calculate(expression);
			Console.Write($" = {Result}");
			Console.WriteLine();

		}
#if HOME_CHECK
		while (operations.Contains("*") || operations.Contains("/"))
			{
				for (int i = 0; i < operations.Length; i++)
				{
					if (operations[i] == "*")
					{
						values[i] = values[i] * values[i + 1];
						for (int j = i + 1; j < operations.Length; j++)
						{
							operations[j - 1] = operations[j];
							values[j] = values[j + 1];
						}
						if (operations[operations.Length - 1] != " ")
						{
							operations[operations.Length - 1] = " ";
							values[values.Length - 1] = 0;
						}
						for (int k = 0; k < values.Length; k++)
						{
							Console.Write(values[k] + "\t");
						}
						Console.WriteLine();
						for (int m = 0; m < operations.Length; m++)
						{
							Console.Write(operations[m] + "\t");
						}
						Console.WriteLine();
					}
					else if (operations[i] == "/")
					{
						values[i] = values[i] / values[i + 1];
						for (int j = i + 1; j < operations.Length; j++)
						{
							operations[j - 1] = operations[j];
							values[j] = values[j + 1];
						}
						if (operations[operations.Length - 1] != " ")
						{
							operations[operations.Length - 1] = " ";
							values[values.Length - 1] = 0;
						}
						for (int k = 0; k < values.Length; k++)
						{
							Console.Write(values[k] + "\t");
						}
						Console.WriteLine();
						for (int m = 0; m < operations.Length; m++)
						{
							Console.Write(operations[m] + "\t");
						}
						Console.WriteLine();
					}

				}

			}

			while (operations.Contains("+") || operations.Contains("-"))
			{
				for (int i = 0; i < operations.Length; i++)
				{
					if (operations[i] == "+")
					{
						values[0] = values[0] + values[i + 1];
						for (int j = i + 1; j < operations.Length; j++)
						{
							operations[j - 1] = operations[j];
							values[j] = values[j + 1];
						}
						if (operations[operations.Length - 1] != " ")
						{
							operations[operations.Length - 1] = " ";
							values[values.Length - 1] = 0;
						}
						for (int k = 0; k < values.Length; k++)
						{
							Console.Write(values[k] + "\t");
						}
						Console.WriteLine();
						for (int m = 0; m < operations.Length; m++)
						{
							Console.Write(operations[m] + "\t");
						}
						Console.WriteLine();
						break;
					}
					else if (operations[i] == "-")
					{
						values[0] = values[0] - values[i + 1];
						for (int j = i + 1; j < operations.Length; j++)
						{
							operations[j - 1] = operations[j];
							values[j] = values[j + 1];
						}
						if (operations[operations.Length - 1] != " ")
						{
							operations[operations.Length - 1] = " ";
							values[values.Length - 1] = 0;
						}
						for (int k = 0; k < values.Length; k++)
						{
							Console.Write(values[k] + "\t");
						}
						Console.WriteLine();
						for (int m = 0; m < operations.Length; m++)
						{
							Console.Write(operations[m] + "\t");
						}
						Console.WriteLine();
						break;
					}

				}

			}
			Console.WriteLine("Результат: " + values[0]);
		} 
#endif

#if CALC_IF
			if (expression.Contains('+'))
				Console.WriteLine($"{values[0]} + {values[1]} = {values[0] + values[1]}");
			else if (expression.Contains("-"))
				Console.WriteLine($"{values[0]} - {values[1]} = {values[0] - values[1]}");
			else if (expression.Contains("*"))
				Console.WriteLine($"{values[0]} * {values[1]} = {values[0] * values[1]}");
			else if (expression.Contains("/"))
				Console.WriteLine($"{values[0]} / {values[1]} = {values[0] / values[1]}");
			else Console.WriteLine("Error: No operation");
#endif

#if CALC_SWITCH
			switch (expression[expression.IndexOfAny(operators)])
			{
				case '+': Console.WriteLine($"{values[0]} + {values[1]} = {values[0] + values[1]}");break;
				case '-': Console.WriteLine($"{values[0]} - {values[1]} = {values[0] - values[1]}"); break;
				case '*': Console.WriteLine($"{values[0]} * {values[1]} = {values[0] * values[1]}"); break;
				case '/': Console.WriteLine($"{values[0]} / {values[1]} = {values[0] / values[1]}"); break;
			}
#endif
		static double Calculate(string expression)
		{
			while (expression.Contains('('))
			{
				int startIndex = expression.IndexOf('(');
				int endIndex = FindClosingBraket(expression, startIndex);
				string innerExpression = expression.Substring(startIndex + 1, endIndex - startIndex - 1);
				double result = Calculate(innerExpression);
				expression = expression.Remove(startIndex, endIndex - startIndex + 1).Insert(startIndex, result.ToString());
			}
			operands = expression.Split(operators);
			values = Array.ConvertAll(operands, s => Convert.ToDouble(s));
			operations = expression.Split(digits).Where(o => !string.IsNullOrWhiteSpace(o)).ToArray();

			for (int i = 0; i < operations.Length; i++)
			{
				if (operations[i] == "*" || operations[i] == "/")
				{
					if (operations[i] == "*") values[i] *= values[i + 1];
					else if (operations[i] == "/") values[i] /= values[i + 1];
					Shift(i);
					i--;
				}
			}

			for (int i = 0; i < operations.Length; i++)
			{
				if (operations[i] == "+" || operations[i] == "-")
				{
					if (operations[i] == "+") values[i] += values[i + 1];
					else if (operations[i] == "-") values[i] -= values[i + 1];
					Shift(i);
					i--;
				}
			}
			return values[0];
		}

		static void Shift(int index)
		{
			for (int i = index; i < operations.Length - 1; i++)
			{
				operations[i] = operations[i + 1];
			}
			for (int i = index + 1; i < values.Length - 1; i++)
			{
				values[i] = values[i + 1];
			}
			operations[operations.Length - 1] = "";
			values[values.Length - 1] = 0;
		}
		static int FindClosingBraket(string str, int StartIndex)
		{
			int count = 1;
			for (int i = StartIndex + 1; i < str.Length; i++)
			{
				if (str[i] == '(') count++;
				else if (str[i] == ')') count--;
				if (count == 0) return i;
			}
			return -1;
		}

	}

}

