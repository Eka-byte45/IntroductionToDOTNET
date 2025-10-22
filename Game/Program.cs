using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	internal class Program
	{
		static void Main(string[] args)
		{
			char symbol = '@';
			int x = 0, y = 0;
			Console.CursorVisible = false;

			while (true)
			{
				int oldx = x, oldy = y;

				ConsoleKeyInfo key = Console.ReadKey(true);
				switch (key.Key)
				{
					case ConsoleKey.UpArrow:
						y--;
						break;
					case ConsoleKey.DownArrow:
						y++;
						break;
					case ConsoleKey.LeftArrow:
						x--;
						break;
					case ConsoleKey.RightArrow:
						x++;
						break;
					case ConsoleKey.Escape:
						return;

				}
				if (x < 0) x = 0;
				if (y < 0) y = 0;
				if (x >= Console.BufferWidth) x = Console.BufferWidth - 1;
				if (y >= Console.BufferHeight) y = Console.BufferHeight - 1;

				Console.SetCursorPosition(oldx, oldy);
				Console.Write(' ');
				Console.SetCursorPosition(x, y);
				Console.Write(symbol);

			}
		}
	}
}


			
		


