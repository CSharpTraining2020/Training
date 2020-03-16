using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugTutorial
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("To jest debug tutorial");
			Console.WriteLine("Aplikacja ta oblicza czy podana liczba jest liczbą pierwszą czy nie");

			bool endLoop = true;
			
			while(endLoop)
			{
				Console.WriteLine("Podaj liczbę: ");
				var readedText = Console.ReadLine();

				if (readedText.ToLower() == "q")
				{
					endLoop = false;
					continue;
				}

				int parsedInteger;
				var parseResult = int.TryParse(readedText, out parsedInteger);

				if (parseResult)
				{
					var isPrime = CheckIfNumberIsPrime(parsedInteger);

					if (isPrime)
					{
						Console.WriteLine($"Podana liczba {parsedInteger} jest liczbą pierwszą");
					}
					else
					{
						Console.WriteLine($"Podana liczba {parsedInteger} nie jest liczbą pierwszą");
					}
				}
			}

			Console.WriteLine("Koniec");
			Console.ReadLine();
		}

		static bool CheckIfNumberIsPrime(int number)
		{
			if (number == 2 || number == 3 || number == 5)
			{
				return true;
			}
			else if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0)
			{
				return false;
			}

			return true;
		}
	}
}
