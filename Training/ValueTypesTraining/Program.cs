using System;
using System.Globalization;
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

			#region Typy całkowitoliczbowe

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

			#region Statyczne pola i metody typów całkowitoliczbowych

			/// Wszystkie typy całkowitoliczbowe posiadają pola i metody statyczne
			/// Są one dostępne z poziomu typu całkowitoliczbowym, a nie z poziomu zmiennej o typie całkowitoliczbowym
			/// 
			/// Pola statyczne
			///		MinValue - minimalna wartość zakresu
			///		MaxValue - maksymalna wartość zakresu
			///	Metody statyczne
			///		Equals
			///		ReferenceEquals
			///		Parse
			///		TryParse


			#region MinValue i MaxValue

			/// Każdy typ całkowitoliczbowy posiada statyczne pola dostępne z poziomu typu:
			///		MinValue - minimalna wartość zakresu
			///		MaxValue - maksymalna wartość zakresu

			short minVal = short.MinValue;
			short maxVal = short.MaxValue;

			/// Minimalną wartością zakresu typu short jest -32768, a maksymalną jest 32767
			Console.WriteLine($"Minimalną wartością zakresu typu short jest {minVal}, a maksymalną jest {maxVal}");

			/// Oczywiście deklaracja osobnych zmiennych nie była konieczna
			/// Wewnątrz nawiasów { } można bezpośrednio odwołać się do pola statycznego
			/// Minimalną wartością zakresu typu int jest -2147483648, a maksymalną jest 2147483647
			Console.WriteLine($"Minimalną wartością zakresu typu int jest {int.MinValue}, a maksymalną jest {int.MaxValue}");

			/// Minimalną wartością zakresu dla typu ulong jest 0, a maksymalną jest 18446744073709551615
			Console.WriteLine($"Minimalną wartością zakresu dla typu ulong jest {ulong.MinValue}, a maksymalną jest {ulong.MaxValue}");

			#endregion

			#region Parse() i TryParse()

			/// Parsowanie to proces przekształcania tekstu na wybrany typ danych
			/// Wszystkie typy wartościowe posiadają posiadają obie metody, które pozwalają przekształcić tekst na wartość o danym typie

			string text1 = "15";
			int parsedText1 = int.Parse(text1);
			short parsedText2 = short.Parse("13");
			ulong parsedText3 = ulong.Parse("4343243234");

			/// Poniższa linia nie zostanie wykonana ponieważ nie jest możliwe przekonwertowanie tekstu abcd na liczbę całkowitą
			//int parsedText4 = int.Parse("abcd");

			/// Po parsowaniu parsedText1 wartość tej zmiennej wynosi 15
			Console.WriteLine($"Po parsowaniu parsedText1 wartość tej zmiennej wynosi {parsedText1}");

			/// Po parsowaniu parsedText2 wartość tej zmiennej wynosi 13
			Console.WriteLine($"Po parsowaniu parsedText2 wartość tej zmiennej wynosi {parsedText2}");

			/// Po parsowaniu parsedText3 wartość tej zmiennej wynosi 4343243234
			Console.WriteLine($"Po parsowaniu parsedText3 wartość tej zmiennej wynosi {parsedText3}");

			/// Nie jest możliwe wykonanie parsowania tekstu 'abcd' na typ całkowitoliczbowy
			Console.WriteLine($"Nie jest możliwe wykonanie parsowania tekstu 'abcd' na typ całkowitoliczbowy");

			/// Aby zabezpieczyć się przed możliwym nieudanym parsowaniem należy stosować metodę TryParse()
			/// TryParse() zwraca wartość typu bool, która odpowiada na pytanie "Czy parsowanie zakończyło się sukcesem?"
			/// Jeśli tak zwracana jest wartość true, a sparsowana wartość jest przekazywana za pomocą parametru "out"
			/// Jeśli nie zwracana jest wartość false

			string text2 = "17";
			int parsedText5 = 0;
			bool parseResult = int.TryParse(text2, out parsedText5);

			/// Ponieważ "text2" ma wartość "17" to możliwe będzie wykonanie parsowania
			/// Zmienna parseResult będzie miała wartość true
			/// Za pomocą parametru "out" w metodzie TryParse() wartość po parsowaniu zostanie przypisana do zmiennej parsedText5
			/// Słówko "out" odgrywa tutaj kluczową rolę i musi ono znajdować się przed parametrem!

			string text3 = "17a";
			short parsedText6 = 0;
			bool parseResult2 = short.TryParse(text3, out parsedText6);

			/// Ponieważ "text3" ma wartość "17a" to nie jest możliwe wykonanie parsowania
			/// Zmienna parseResult będzie miała wartość false
			/// Zmienna parsedText6 pozostaje bez zmian czyli jej wartość to 0

			/// Zmienna parseResult ma wartość true co oznacza, że parsowanie zakończyło się sukcesem. 
			///		Sparsowana wartość to 17 i jest przypisana do zmiennej parsedText5
			Console.WriteLine($"Zmienna parseResult ma wartość {parseResult} co oznacza, że parsowanie zakończyło się sukcesem. " +
				$"Sparsowana wartość to {parsedText5} i jest przypisana do zmiennej parsedText5");


			/// Zmienna parseResult2 ma wartość false co oznacza, że parsowanie nie powiodło się.
			///		Zmienna parsedText6 pozostaje bez zmian i wynosi 0
			Console.WriteLine($"Zmienna parseResult2 ma wartość {parseResult2} co oznacza, ze parsowanie nie powiodło się." +
				$"Zmienna parsedText6 pozostaje bez zmian i wynosi {parsedText6}");

			/// Wynik parsowania można wykorzystać np w ifie
			
			if (parseResult)
			{
				Console.WriteLine("Parsowanie zakończone sukcesem");
			}
			else
			{
				Console.WriteLine("Parsowanie nie powiodło się");
			}

			/// Można też oczywiście wykorzystać całą metodę TryParse() wewnątrz warunku if

			long parsedText7;
			if (long.TryParse("18",out parsedText7))
			{
				Console.WriteLine("Parsowanie zakończone sukcesem");
			}
			else
			{
				Console.WriteLine("Parsowanie nie powiodło się");
			}

			/// Metoda TryParse() może być bardzo użyteczna w sytuacji gdy chcemy się zabezpieczyć przed wprowadzeniem przez użytkowników wartości, której nie chcemy
			/// Do wprowadzania tekstu z konsoli słuzy Console.ReadLine(). Metoda ta zwraca typ string

			Console.WriteLine("Wprowadź liczbę całkowitą");
			string text4 = Console.ReadLine();
			Console.WriteLine($"Wprowadziłeś wartość {text4}");

			int parsedText8;
			if (int.TryParse(text4, out parsedText8))
			{
				Console.WriteLine("Wprowadziłeś liczbę. Gratulacje");
			}
			else
			{
				Console.WriteLine("To nie jest liczba. Nie umiesz czytać poleceń");
			}

			/// Cały powyższy kod można delikatnie skrócić. Inicjalizacja zmiennej text4 nie jest konieczna

			Console.WriteLine("Wprowadź liczbę całkowitą ponownie");

			int parsedText9;
			if (int.TryParse(Console.ReadLine(), out parsedText9))
			{ 
				Console.WriteLine($"Wprowadziłeś liczbę {parsedText9}. Gratulacje");
			}
			else
			{
				Console.WriteLine("To nie jest liczba. Nie umiesz czytać poleceń");
			}

			#endregion

			#endregion

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

			/// Typy zmiennoprzecinkowe również posiadają pola statyczne, które są dostępne z poziomu typu

			#region Pola styczne i metody typów zmiennoprzecinkowych

			#region MinValue MaxValue Parse() TryParse()

			/// Pola MinValue, MaxValue oraz metody Parse() i TryParse() zostały opisane dla typów całkowitoliczbowych
			/// Ponieważ ich działanie jest takie samo nie będę tutaj opisywał ich ponownie

			#endregion

			#region decimal

			/// Decimal posiada dodatkowe pola statyczne
			///		MinusOne - zwraca -1
			///		One - zwraca 1
			///		Zero - zwraca 0
			///	Działają one dokładnie tak samo jako MinValue i MaxValue

			/// Ciekwszymi składowymi statycznymi typu decimal są metody konwertujące
			///		ToByte() - konwertuje wartość decimal do typu Byte
			///		ToDouble() - konwertuje wartość decimal do typu Double 
			///		ToInt16() - konwertuje wartość decimal do typu Int16 (short)
			///		ToInt32() - konwertuje wartość decimal do typu Int32 (int)
			///		ToInt64() - konwertuje wartość decimal do typu Int64 (long)
			///		ToSByte() - konwertuje wartość decimal do typu SByte
			///		ToSingle() - konwertuje wartość decimal do typu Float
			///		ToUInt16() - konwertuje wartość decimal do typu UInt16 (ushort)
			///		ToUInt32() - konwertuje wartość decimal do typu UInt32 (uint)
			///		ToUInt64() - konweruje wartość decimal do typu UInt64 (ulong)

			/// Należy pamiętać, że decimal ma największy zakres spośród wszystkich typów liczbowych
			/// Konwertowanie wartości decimal na inny typ może się nie udać jeśli wartość będzie wykraczać poza zakres docelowego typu
			///		Należy o tym pamiętać ponieważ podczas pisania kodu, VS nie zazanczy potencjalnego ryzyka błędu
			///		Błąd pojawi się dopiero w momencie wywoływania kodu
			/// Konwertowanie wartości decimal do typu całkowitoliczbowego powoduje obcięcie wartości ułamkowych 
			///		Nie następuje zaokroąglenie w górę lub w dół! Wartość po przecinku jest zwyczajnie ucinana

			decimal decimal1 = 15.0m;
			int convertedDec1 = decimal.ToInt32(decimal1);
			ushort convertedDec2 = decimal.ToUInt16(17.23m);

			/// Konwersja zakończy się błędem ponieważ wartość decimal jest z poza zakresu ulong
			//ulong convertedDec = decimal.ToUInt64(-15.23m);

			/// Wartość decimal 15.0 została skonwertowana do typu System.Int32 i wynosi 15
			Console.WriteLine($"Wartość decimal {decimal1} została skonwertowana do typu {convertedDec1.GetType().ToString()} i wynosi {convertedDec1}");

			/// Wartość decimal 17.23 została skonwertowana do typu System.UInt64 i wynosi 17
			Console.WriteLine($"Wartość decimal {17.23m} została skonwertowana do typu {convertedDec2.GetType().ToString()} i wynosi {convertedDec2}");

			Console.WriteLine("Konwersja -15.23 do typu ulong nie powiedzie się ponieważ wartość jest z poza zakresu ulong");

			/// Inne ciekawe metody statyczne decimal
			///		Ceiling() - zaokrąglanie w górę - to samo można osiągnąć wykorzystując Math.Ceiling()
			///		Floor() - zaokrąglanie w dół - to samo można osiągnąć wykorzystując Math.Floor()
			///		Round() - zaokrąglenie w dół lub w górę - zależy co jest bliżej - Math.Round()
			
			#endregion

			#endregion

			#endregion

			#region Bool

			/// Typ logiczny bool przyjmuje tylko 2 wartości:
			///		true
			///		false
			///	Podczas inicjalizacji zmiennej typu bool można posłużyć się każdym wyrażeniem jakie zwraca wartość logiczną
			///	Oznacza to, że każde wyrażenie, o którym można powiedzieć że jest PRAWDĄ lub FAŁSZEM zwraca wartość logiczną
			///	Co za tym idzie wyrażenia, które zwracają bool można używać wszędzie tam gdzie bool jest wymagany (ify, warunki pętli)
			///		zamiennie ze zmiennymi o typie bool. To czy wykorzystana zmienna typu bool w if'ie lub warunek zwracający bool zależy od programisty i sytuacji

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

			#region DateTime

			/// Typ DateTime umożliwia pzrechowywanie wartości na temat daty i czasu
			/// Inicjalizacja zmiennej o typie DateTime odbywa się zawsze za pomocą słówka "new"
			/// DateTime posiada wiele konstruktorów. Te najbardziej pomocne są 2:
			///		new DateTime(int year, int month, int day) - tworzenie DateTime z możliwością podania roku, miesiąca i dnia
			///		new DateTime(int year, int month, int day, int hour, int minute, int second) - taki sam jak wyżej z możliwością wprowadzenia wartości dla czasu
			/// Użycie pustego konstruktora new DateTime() spowoduje utworzenie 01-01-0001 00:00:00.000

			DateTime defaultDateTime = new DateTime();

			/// Wartością domyślną typu DateTime to 01-01-0001 00:00:00.000
			Console.WriteLine($"Wartością domyślną typu DateTime to {defaultDateTime}");

			DateTime date = new DateTime(2020, 4, 3);
			DateTime dateTime1 = new DateTime(2020, 4, 3, 10, 49, 00);

			/// Jestem zmienną date i mam wartość 03-04-2020 00:00:00.000
			Console.WriteLine($"Jestem zmienną date i mam wartość {date}");

			/// Jestem zmienną dateTime i mam wartość03-04-2020 10:49:00.000
			Console.WriteLine($"Jestem zmienną dateTime i mam wartość {dateTime1}");

			#region Statyczne pola i metody DateTime

			/// MaxValue i MinValue działają tak samo jak w każdym innym typie wartościowym 

			/// Minimalna wartość dla typu DateTime to 01-01-0001 00:00:00.000, a maksymalna to 31-12-9999 23:59:59.999
			Console.WriteLine($"Minimalna wartość dla typu DateTime to {DateTime.MinValue}, a maksymalna to {DateTime.MaxValue}");

			#region Today i Now

			/// Bardzo ważnymi statystycznymi właściwosciami DateTime są Today i Now
			/// Obie wartości dostarczają na temat bieżącej daty i bieżącego czasu 
			/// Obie wartości pobierają datę i czas na podstawie ustawień twojego komutera
			/// Więc jeśli masz złą datę ustawioną w komputerze, właściwości te również zwrócą Ci błędną datę

			DateTime todayDate = DateTime.Today;
			DateTime nowDateTime = DateTime.Now;

			Console.WriteLine($"Dziś mamy dzień {todayDate}");
			Console.WriteLine($"Dziś mamy dzień i jest godzina {nowDateTime}");

			#endregion

			#region Parse() i TryParse()

			/// Metody Parse() i TryParse() działają dokładnie tak samo jak dla pozostałych typów wartościowych
			/// Jest jednak pewna różnica
			/// Otóż przede wszystkim datę w zależności od kultury przedstawia się różnie np:
			///		03-04-2020 - polski format daty
			///		04/03/2020 - amerykański format daty
			///		itd
			///	Należy brać format daty pod uwagę
			///	Domyślne formatowanie w jakim zostanie wykonane parsowanie to formatowanie ustawione w Twoim PC
			///	Jeśli chcemy wykonać parsowanie w innym formatowaniu należy posłużyć się nolejnym parametrem metod Parse() i TryParse()
			///		provider - parametr, w którym można dostarczyć informację o formacie, w którym ma zostać wykonane parsowanie
			///		Do tego parametru najczęściej przekazuje się zmienną typu CultureInfo

			DateTime parsedDateTime1 = DateTime.Parse("03-04-2020");
			DateTime parsedDateTime2 = DateTime.Parse("04/03/2020 11:14:00.000", new CultureInfo("en-US"));

			#endregion

			#endregion

			#region Instancyjne pola i metody DateTime

			/// W przeciwieństwie do pozostałych typów wartościowych typ DateTime ma bardzo bogatą pulę metod i właściwości instancyjnych

			#region Instancyjne właściwości DateTime

			/// Właściwości
			///		Date - zwraca wartosć typu DateTime tylko z informacją o dacie
			///		Day - zwraca wartość typu int z informacją dnia miesiąca ze zmiennej DateTime (1-31)
			///		DayOfWeek - zwraca wartość int z informacją numeru dnia tygodnia ze zmiennej DateTime (1-7)
			///		DayOfYear - zwraca wartość int z informacją dnia roku ze zmiennej DateTime (1-366)
			///		Hour - zwraca wartość int z informacją godziny ze zmiennej DateTime
			///		Miliseconds - zwraca wartość int z informacją milisekund ze zmiennej DateTime
			///		Month - zwraca wartość int z informacją numeru miesiąca ze zmiennej DateTime
			///		Second - zwraca wartość int z informacją sekundy ze zmiennej DateTime
			///		Year - zwraca wartość int z informacją o roku ze zmiennej DateTime
			
			DateTime dateTime2 = new DateTime();
			/// Rok domyślnej daty to 1
			Console.WriteLine($"Rok domyślnej daty to {dateTime2.Year}");

			DateTime dateTime3 = new DateTime(1998, 12, 13);
			/// Miesiąc zmiennej dateTime3 to 12
			Console.WriteLine($"Miesiąc zmiennej dateTime3 to {dateTime3.Month}");

			DateTime dateTime4 = new DateTime(1939, 9, 1, 5, 25, 43);
			/// Sekunda zmiennej dateTime4 to 43
			Console.WriteLine($"Sekunda zmiennej dateTime4 to {dateTime4.Second}");

			#endregion

			#region Instancyjne metody DateTime

			/// Największą grupę metod stanowią metody Add, które umożliwiają dodawanie lub odejmowanie od zmiennej typu DateTime określonego przedziału czasu
			///		AddDays()
			///		AddHours()
			///		AddMiliseconds()
			///		AddMinutes()
			///		AddSeconds()
			///		AddYears()
			///		Wszystkie te metody przyjmują parametr typu int reprezentujący wartość o jaką ma zostać zwiększona bądź zmniejszona data

			DateTime todayDate2 = DateTime.Today;
			DateTime tomorrow = todayDate2.AddDays(1);
			DateTime yesterday = todayDate2.AddDays(-1);

			/// Kolejną grupą przydantych metod jest formatowanie daty do tekstu w różnych stylach
			/// Datę można zapisywać w sposób skrócony np. "03-04-2020" ale można również zapisać "03 kwietnia 2020" lub "Piątek 3 kwietnia 2020"
			///		lub jeszcze inaczej w zależności od kultury ustawionej na PC 
			///	ToLongDateString()
			///	ToLongTimeString()
			///	ToShortDateString()
			///	ToShortTimeString()

			
			#endregion

			#endregion

			#endregion

			Console.ReadLine();

		}

	}
}
