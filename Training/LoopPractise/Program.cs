using LoopPractise.Models;
using System;
using System.Collections.Generic;

namespace LoopPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loop Practise");


            var integerList = new List<int>
                {16, 14, 65, 233, 67, 34, 65, 43, 67, 85, 124, 64, 256, 45};
            var namesList = new List<string>
                {"Łukasz", "Anita", "Jan", "Piotr", "Tomasz", "Krystian", "Sebastian", "Robert"};
            var countriesList = new List<string>
                {"Polska", "USA", "Niemcy", "Ukraina", "Włochy", "Chiny", "Hiszpania", "Australia"};
            var peopleList = new List<Person>
            {
                new Person {Age = 15, FirstName = "Ania", LastName = "Kowalska"},
                new Person {Age = 24, FirstName = "Marek", LastName = "Nowak"},
                new Person {Age = 65, FirstName = "Janusz", LastName = "Złotówka"},
                new Person {Age = 9, FirstName = "Brajanek", LastName = "Złotopolski"},
                new Person {Age = 43, FirstName = "Mariusz", LastName = "Piotrowski"},
                new Person {Age = 21, FirstName = "Renata", LastName = "Śmiała"},
                new Person {Age = 35, FirstName = "Dobrawa", LastName = "Przemyślidka"},
                new Person {Age = 17, FirstName = "Alicja", LastName = "Porawska"},
                new Person {Age = 29, FirstName = "Andrzej", LastName = "Jerzykowski"},
                new Person {Age = 76, FirstName = "Benedykt", LastName = "Papieski"}
            };

            /// zadanie 1. 
			/// wyswietlić wszystkie imiona z list namesList z listy / 2 sposoby for i foreach 
            for (int i = 0; i < namesList.Count; i++) //wchodze do listy names. .COunt jest dla List<>
            {
                Console.WriteLine(namesList[i]);
            }

			foreach (string names in namesList)
			{
				Console.WriteLine(names);
			}

			/// zadanie 2.
			/// Wyświetlić wszystkie nazwy krajów z listy countriesList oraz długość ich nazw
			/// Obliczyć średnią długość nazw krajó
			double result=0;
            int sum=0;
            for(int i = 0; i < countriesList.Count; i++) 
            {
                Console.WriteLine(countriesList[i]); // nazwa kaju
                Console.WriteLine(countriesList[i].Length); // dlugosc nazwy kraju 
                sum = sum + countriesList[i].Length;
                
            }
            result = sum / countriesList.Count;
            Console.WriteLine(result); // srednia długosc krajów w nazwach 

			/// zadanie 3.
			/// Wyświetl w pętli liczby od 1 do 15
            for (int i = 1; i <= 15; i++) // wyswietlenie od 1 do 15
            {
                Console.WriteLine(i);

            }

			/// zadanie 4.
			/// Wyświetlić osobno każdą literkę z podanego zdania
			/// Wyświetlić dodatkowo tylko literki 'a'
            string text = "Ala ma kota"; // wysweitlic kaza literke a pozycja = dlugosc znakow
            for (int a = 0; a < text.Length; a++)
            {
                Console.WriteLine(text[a]);
                if (text[a] == 'a') //pozycja elementu,indeks
                {
                    Console.WriteLine(a);
                }
            }

			/// zadanie 5.
			/// Wyświetlić tylko imiona zawierające literę 'a'
            foreach (string word in namesList) // idziemy po slowach z listy 
            {
                for (int i = 0; i < word.Length; i++) // idziemy po literach w danym słowie
                {
                    if (word[i] == 'a')
                    {
                        Console.WriteLine(word);
                        break;//przerywa petle w momencie kiedy znajdzie w slowie litere a. Konczy oetle w ktorej sie znajduje
                    }
                }
            }

            foreach (var item in namesList)
            {
                //item.Contains('a'); metoda ktora sprawdza konkretna litere w danych slowie. Zwraca  typ bool 

                if (item.Contains('a')) // jesli if, else  ma jedna linie kodu klamry sa zbedne 
                    Console.WriteLine(item);

            }

            /// zadanie 6.
			/// Losowanie liczb od 0 do 100 ktore sa podzielne przez 8 
			/// Należy losować liczby tak długo aż natrafimy na pierwszą liczbę podzielną przez 8
            var r = new Random();
            bool checkRange = true;
            while (checkRange)
            {

                int number = r.Next(0, 100);
                if (number % 8 == 0) //podzilena 
                {
                    Console.WriteLine(number);
                    checkRange = false; // przeciązanie 
                }
                else
                {
                    Console.WriteLine("Niepodzilena przez 8");

                }

            }

			/// Zadanie 7.
			/// Załóż pustą listę i w pętli wylosuj i wpisz do tej list 20 liczb z zakresu od 0 do 1000
			/// Wypisz wylosowane liczby w konsoli w 1 linii
			


			/// Zadanie 8.
			/// Na podstawie listy z zadania 7 wyżej wyszukaj w tej liście liczby większe od 250
			/// Wypisz te liczby w konsoli w 1 linii
			/// Nie używaj wyrażeń labmda
			


			/// Zadanie 9.******
			/// Wykonaj poprzednie zadanie z wykorzystaniem wyrażenia lambda
			


			/// Zadanie 10.
			/// Na podstawie listy z zadania powyżej wyszukaj pierwszą liczbę większą od 100
			/// Wypisz w konsoli indeks tej liczby i jaka to liczba
			/// Nie używaj wyrażeń lambda
			


			/// Zadanie 11.******
			/// Wykonaj poprzednie zadanie z wykorzystaniem wyrażenia lambda
			


			/// Zadanie 12.
			/// Znaleźć i wypisać w konsoli wszystkie lata przestępne jakie były w XX wieku
			/// Zaczynając od 1900 do 1999
			


			/// Zadanie 13.***
			/// Stworzyć pustą listę integerów.
			/// Do tej listy należy wpisać sumę liczb, z których składają się lata, które minęły lub trwają z XXI wieku
			/// Np. rok 2000 ma 4 liczby - 2, 0, 0, 0 - suma tych liczb wynosi 2 - wpisujemy 2 do listy
			/// rok 2001 ma 4 liczby - 2, 0, 0, 1 - suma tych liczb wynosi 3 - wpisujemy 3 do listy
			/// itd
			/// Wyliczone wartości wypisać w jednej linii
			/// TIP: 
			///		Pamiętaj że każdą liczbę np. 2000 można przerobić na tekst metodą ToString() - 2000.ToString() = "2000"
			///		Pamiętaj że pętlami można przechodzić po tekście jak po listach i tablicach
			///		Pamiętaj że tekst możesz parsować na liczby
			///		Pamiętaj że aby spradzić bieżącą datę można posłużyć się DateTime.Today
			///		Pamiętaj że każda zmienna DateTime posiada właściwość Year, która zwraca wartość roku z daty
			///		Parsowanie i wszystkie typy wartościowe opisałem w ValueTypesTraining

			/// Zadanie 14.
			/// Na podstawie lsty z zadania 13 obliczyć średnią wartość wartości w liście
			/// Obliczoną wartość wypisać w konsoli


            Console.ReadLine();
        }
    }
}
