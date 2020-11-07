using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
	class Program
	{

		private static bool processing = true;

		static void Main(string[] args)
		{
			ProcessingGuess();
		}

		private static void ProcessingGuess()
		{
			GuessManager gs = new GuessManager();

			Console.Write("I thought of an integer, guess it: ");

			gs.GivenString = Console.ReadLine();

			Console.WriteLine();

			while (processing)
			{
				if (!gs.IsNumber)
				{
					Console.Write("You entered something wrong. Try again: ");
					gs.GivenString = Console.ReadLine();
					Console.WriteLine();
				}
				else if ((gs.IsNumber) && (gs.GivenNumber == gs.Number))
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
					Console.WriteLine("Congratulations, You guessed !");
					Console.WriteLine();
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write("We offer to play more! If You want, please enter: 'yes' (Everything else is a way out): ");

					string wish = Console.ReadLine().ToUpper();

					Console.WriteLine();

					if (wish == "YES")
					{
						ProcessingGuess();
					}
					else
					{
						processing = false;
						Console.ReadLine();
					}
				}
				else if ((gs.IsNumber) && (gs.GivenNumber < gs.Number))
				{
					Console.Write("My number is greater. Enter another: ");
					gs.GivenString = Console.ReadLine();
					Console.WriteLine();
				}
				else if ((gs.IsNumber) && (gs.GivenNumber > gs.Number))
				{
					Console.Write("My number is less. Enter another: ");
					gs.GivenString = Console.ReadLine();
					Console.WriteLine();
				}
			}
		}

	}
}
