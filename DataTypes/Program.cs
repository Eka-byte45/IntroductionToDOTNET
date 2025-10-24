//#define DATA_TYPES
//#define CONSTANT
#define TYPE_CONVERTIONS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	internal class Program
	{
		const string delimetr = "\n--------------------------\n";
		static void Main(string[] args)
		{
#if DATA_TYPES
			Console.WriteLine($"bool занимает {sizeof(bool)} Байт памяти,класс обертка-{typeof(bool)} ");
			Console.WriteLine(bool.FalseString);
			Console.WriteLine(bool.TrueString);
			Console.WriteLine(typeof(bool));

			Console.WriteLine(delimetr);
			///////////////////////////////////////////
			Console.WriteLine(
$@"Тип данных char занимает {sizeof(char)} Байт памяти, и принимает значения в диапазоне
от{(int)char.MinValue} до {(int)char.MaxValue}. Класс-обвертка - {typeof(char)}"
				);
			Console.WriteLine(delimetr);

			Console.WriteLine
				(
@"Raw-строка - игнорирует все специальные символы и Escape-последовательности\t\n,
то есть воспринимается как есть as-is)"
				);
			Console.WriteLine (delimetr);
			///////////////////////////////////////////
			Console.WriteLine
				(
$@"Байт занимает {sizeof(byte)} Байт памяти 
принимает значения в диапазоне от {byte.MinValue} до {byte.MaxValue},
класс-обвертка {typeof(byte)}"
				);
			Console.WriteLine(delimetr);

			Console.WriteLine
				(
$@"sbyte занимает {sizeof(sbyte)} Байт памяти 
принимает значения в диапазоне от {sbyte.MinValue} до {sbyte.MaxValue},
класс-обвертка {typeof(sbyte)}"
				);
			Console.WriteLine(delimetr);

			Console.WriteLine
				(
$@"short занимает {sizeof(short)} Байт памяти 
принимает значения в диапазоне от {short.MinValue} до {short.MaxValue},
класс-обвертка {typeof(short)}"
				);

			Console.WriteLine(delimetr);
			Console.WriteLine
				(
$@"ushort занимает {sizeof(ushort)} Байт памяти 
принимает значения в диапазоне от {ushort.MinValue} до {ushort.MaxValue},
класс-обвертка {typeof(ushort)}"
				);
			Console.WriteLine(delimetr);
			Console.WriteLine
				(
$@"int занимает {sizeof(int)} Байт памяти 
принимает значения в диапазоне от {int.MinValue} до {int.MaxValue},
класс-обвертка {typeof(int)}"
				);
			Console.WriteLine(delimetr);
			Console.WriteLine
				(
$@"uint занимает {sizeof(uint)} Байт памяти 
принимает значения в диапазоне от {uint.MinValue} до {uint.MaxValue},
класс-обвертка {typeof(uint)}"
				);
			Console.WriteLine(delimetr);
			Console.WriteLine
				(
$@"uint занимает {sizeof(uint)} Байт памяти 
принимает значения в диапазоне от {uint.MinValue} до {uint.MaxValue},
класс-обвертка {typeof(uint)}"
				);
			Console.WriteLine(delimetr);
			Console.WriteLine
				(
$@"long занимает {sizeof(long)} Байт памяти 
принимает значения в диапазоне от {long.MinValue} до {long.MaxValue},
класс-обвертка {typeof(long)}"
				);
			Console.WriteLine(delimetr);
			Console.WriteLine
				(
$@"ulong занимает {sizeof(ulong)} Байт памяти 
принимает значения в диапазоне от {ulong.MinValue} до {ulong.MaxValue},
класс-обвертка {typeof(ulong)}"
				);
			Console.WriteLine(delimetr);
			Console.WriteLine
				(
$@"float занимает {sizeof(float)} Байт памяти
принимает значения в диапазоне от {float.MinValue} до {float.MaxValue},
класс-обвертка {typeof(float)}"
				);

			Console.WriteLine(delimetr);
			Console.WriteLine
				(
$@"double занимает {sizeof(double)} Байт памяти
принимает значения в диапазоне от {double.MinValue} до {double.MaxValue},
класс-обвертка {typeof(double)}"
				);
			Console.WriteLine(delimetr);

			Console.WriteLine
				(
$@"decimal занимает {sizeof(decimal)} Байт памяти
принимает значения в диапазоне от {decimal.MinValue} до {decimal.MaxValue},
класс-обвертка {typeof(decimal)}"
				);
			Console.WriteLine(delimetr);
			
#endif
#if CONSTANT


			decimal a = 1;
			a /= 3;
			Console.WriteLine(a);
			a*= 3;
			Console.WriteLine(a);
			//////////////////////////////////////////////
			Console.WriteLine(delimetr);
			Console.WriteLine("Hello".GetType());
			//Console.WriteLine(typeof("Hello"));
			Console.WriteLine(5.0.GetType());
#endif

#if TYPE_CONVERTIONS
			int n = 5;
			while (n-- > 0)
			{
				Console.WriteLine(n);
			}
			//while (n > 0) { Console.WriteLine(n); n--; }

			Console.WriteLine(delimetr);
			//ushort b = (ushort)-2;
			//Console.WriteLine(b);
			double a = 2.2;
			short b = (short)a;
			Console.WriteLine(b);
			//bool rain = Convert.ToBoolean("True");
			bool rain = bool.Parse("False");
			Console.WriteLine(rain);
#endif
		}
	}
}
