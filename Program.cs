using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
	class Program
	{

		static bool processing = true;

		static void Main(string[] args)
		{
			GuessManager gs = new GuessManager();

			Console.Write("I thought of an integer, guess it: ");

			gs.GivenString = Console.ReadLine();

			while (processing)
			{
				if (!gs.IsNumber)
				{
					Console.WriteLine();
					Console.Write("You entered something wrong. Try again.");
					gs.GivenString = Console.ReadLine();
				}
				else if ((gs.IsNumber) && (gs.GivenNumber == gs.Number))
				{
					Console.WriteLine();
					Console.ForegroundColor = ConsoleColor.DarkRed;
					Console.WriteLine("Congratulations, you guessed it! We must repeat!");
					processing = false;
					Console.ReadLine();
				}
				else if ((gs.IsNumber) && (gs.GivenNumber < gs.Number))
				{
					Console.WriteLine();
					Console.Write("My number is greater. Enter another:");
					gs.GivenString = Console.ReadLine();
				}
				else if ((gs.IsNumber) && (gs.GivenNumber > gs.Number))
				{
					Console.WriteLine();
					Console.WriteLine("My number is less. Enter another:");
					gs.GivenString = Console.ReadLine();
				}
			}
		}
	}
}
