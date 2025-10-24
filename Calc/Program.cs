using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
	internal class Program
	{

		static void Main(string[] args)
		{
			while (true)
			{
				try
				{
					Console.WriteLine("Введите первое число: ");
					double number1 = double.Parse(Console.ReadLine());

					Console.WriteLine("Выберите тип операции: + - * /");
					char choice = Convert.ToChar(Console.ReadLine());

					if (choice != '+' && choice != '-' && choice != '*' && choice != '/')
					{
						throw new ArgumentException("Неправильная операция. Допустимы только знаки: +, -, *, /");
					}

					Console.WriteLine("Введите второе число:");
					double number2 = double.Parse(Console.ReadLine());

					double result = 0.0;

					switch (choice)
					{
						case ('+'):

							result = number1 + number2;
							Console.WriteLine($"{number1} + {number2} = {result} ");
							break;
						case ('-'):
							result = number1 - number2;
							Console.WriteLine($"{number1} - {number2} = {result} ");
							break;
						case ('*'):
							result = number1 * number2;
							Console.WriteLine($"{number1} * {number2} = {result} ");
							break;
						case ('/'):
							if (number2 == 0)
							{
								throw new DivideByZeroException("На ноль делить нельзя!");
							}
							else
							{
								result = number1 / number2;
								Console.WriteLine($"{number1} / {number2} = {result} ");
								break;
							}
						default:
							Console.WriteLine("Неверная операция. Попробуйте снова.");
							continue;

					}
					Console.WriteLine("Хотите продолжить расчеты? (Y/N)");
					string answer = Console.ReadLine();
					if (answer.Trim().ToUpper() != "Y")
					{
						break;
					}

				}
				catch(DivideByZeroException ex)
				{
                    Console.WriteLine(ex.Message);
				}
				catch(ArgumentException ex)
				{
                    Console.WriteLine(ex.Message);
				}
				catch(FormatException)
				{
					Console.WriteLine("Ошибка: введено некорректное число.");
				}
				
			}

		}
	}
}


	

