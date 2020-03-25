using System;
using System.IO;
using System.Linq;

namespace ValueTypesTraining
{
	class Program
	{
		static void Main(string[] args)
		{
			#region WSTĘP

			/// Typy wartościowe inaczej bezpośrednie to typy, które:
			///		Są przechowywane na stosie,
			///		Są kopiowane przez wartość
			///	Stos to miejsce w pamięci przeznaczone do przechowywania typów bezpośrednich
			///	Każda nowa zmienna o typie bezpośrednim dostaje miejsce w pamięci właśnie na stosie
			///	Kopiowanie przez wartość oznacza, że utworzona kopia typu bezpośredniego ma autonomiczną wartość od oryginału
			///	Modyfikacja wartości oryginału nie wpływa na wartość kopii
			///	Wyróżnia się następujące typy bezpośrednie:
			///		Typy całkowitoliczbowe:
			///			byte, sbyte, short, int, long - oraz wariacje tych typów z "u" i "?"
			///		Typy zmiennoprzecinkowe:
			///			double, float, decimal - oraz wariacje tych typów z "?"
			///		Typ logiczny bool
			///		Typ daty i czasu DateTime
			///		Typ znakowy char
			///		Wszystkie struktury
			///		
			///	WAŻNE: Typ string NIE JEST typem wartościowym, a referencyjnym.
			///			



			#endregion

			#region Integers

			/// Na typy całkowitoliczbowe z rodziny Integer składają się
			///		short - Int16 od -32768 do 32768
			///		int - Int32 od -2147483648 do 2147483647
			///		long - Int64 od -9223372036854775808 do 9223372036854775808
			///		Różnica między nimi polega na tym ile pamięci każda zmienna o danym typie zajmuje na stosie
			///		Biorąc pod uwagę ilość pamięci każdy ten typ ma ograniczony zakres danych (może przyjmować wartości tylko z danego zakresu)
			///		W sytuacji kiedy wartość wykroczy poza zakres typu, nowa wartość otrzymuje najniższą wartość z zakresu
			///		Np. jeśli zmienna typu short równa jest 32768 to po dodaniu +1 do wartości, nowa wartość nie będzie 32769, a -32768 (najniższa wartość z zakresu)

			short myFirstShort = 3434;
			System.Int16 mySecShort = myFirstShort;

			int myFirstInt = 24141;
			System.Int32 mySecInt = myFirstInt;

			long myFirstLong = 1342352344235;
			System.Int64 mySecLong = myFirstLong;

			#endregion

			#region Typy z przyrostkiem u

			/// Typy całkowitoliczbowe Integer można tworzyć również z przyrostkiem u
			/// Orzymujemy wtedy:
			///		ushort, uint, ulong
			/// Przyrostek ten oznacza, że typ posiada tylko liczby nieujemne (0 i dodatnie)
			/// Szerokość zakresu pozostaje taka sama 
			/// Czyli jeśli short miał zakres od -32768 do 32768 to szerokość zakresu to 65535
			/// Typ ushort będzie miał zatem zakres od 0 do 65535
			/// Typy z przyrostkiem u również podlegają regułom wykroczenia wartości poza zakres
			/// Domyślnie jednak typy z przyrostkiem u nie są tworzone przez kompilator i słówko "var" 
			/// Typy te należy zadeklarować jawnie

			var short1 = 15;
			ushort ushort1 = 15;

			/// Jestem short1 i mój typ to short
			Console.WriteLine($"Jestem short1 i mój typ to {short1.GetType().ToString()}");

			/// Jestem ushort1 i mój typ to ushort
			Console.WriteLine($"Jestem ushort1 i mój typ to {ushort1.GetType().ToString()}");

			#endregion

			#region Double, Float, decimal

			/// Typy zmiennoprzecinkowe umożliwiają przechowywać wartości ułamkowe:
			/// Wyróżniamy 3 typy zmiennoprzecinkowe:
			///		double,
			///		float,
			///		decimal
			///		
			/// Dwa pierwsze typy niosą ze sobą ryzyko zaokrąglania wartości
			/// Dlatego też jeśli ważne jest trzymanie jak najdokładniejszego zaokrąglenia należy stosować decimal
			/// Domyślnym typem dla wprowadzonych wartości zmiennoprzecinkowych jest double
			/// Aby utworzyć typ decimal należy wartość oznaczyć przyrostkiem m
			/// 

			var myFirstDecimal = 1.10m;
			var myFirstDouble = 1.10;
			var myFirstFloat = 1.10f;

			/// Moim typem jest System.Decimal
			Console.WriteLine($"Moim typem jest {(myFirstDecimal).GetType().ToString()}");

			/// Moim typem jest System.Double
			Console.WriteLine($"Moim typem jest {(myFirstDouble).GetType().ToString()}");

			/// Moim typem jest System.Float
			Console.WriteLine($"Moim typem jest {(myFirstFloat).GetType().ToString()}");

			#endregion

			#region Bool

			/// Typ logiczny bool przyjmuje tylko 2 wartości:
			///		true
			///		false
			///	Podczas inicjalizacji zmiennej typu bool można posłużyć się każdym wyrażeniem jakie zwraca wartość logiczną
			///	Oznacza to, że każde wyrażenie, o którym można powiedzieć że jest PRAWDĄ lub FAŁSZEM zwraca wartość logiczną
			///	

			bool myFirstBool = true;
			int integer1 = 10;
			var mySecBool = integer1 > 15;

			/// Jestem myFirstBool i mój typ to System.Boolean, a wartość to true
			Console.WriteLine($"Jestem myFirstBool i mój typ to {myFirstBool.GetType().ToString()}, a wartość to {myFirstBool}");

			/// Jestem mySecBool i mój typ to System.Boolean, a wartość to false
			Console.WriteLine($"Jestem mySecBool i mój typ to {mySecBool.GetType().ToString()}, a wartość to {mySecBool}");

			#endregion

			#region char

			/// Typ char jest typem reprezentującym pojedyńczy znak (może być to litera, liczba lub, znaki specjalne)
			/// 

			#endregion

			DateTime dateTime = new DateTime(2020, 3, 24, 5, 24, 13);
			DateTime dateTime2 = DateTime.Now;
			DateTime today = DateTime.Parse("24-03-2020");

			int a = 10;
			int b = a;
			String text2 = "";
			Car myCar = new Car();
			myCar.name = "Opel";

			Car mySecCar = myCar;
			myCar.name = "Audi";

			bool boolCar = myCar.name == mySecCar.name;

			a = a + 2;

			string[] countries = new string[2];
			Console.WriteLine($"Tablica ma długość {countries.Length}");
			countries[0] = "Polska";

			Console.WriteLine($"Tablica ma długość {countries.Length}");
			Console.WriteLine($"Element 1 to: {countries[1]}");

			int[] numbers = new int[10];
			var countriesList = countries.ToList();
			foreach(int num in numbers)
			{
				Console.WriteLine(num);
			}

			Car[] cars = new Car[5];

			
			Console.ReadLine();

		}

	}
}
