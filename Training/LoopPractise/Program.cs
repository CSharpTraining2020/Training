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

            // zadanie 1. wyswietlie elemnety z listy / 2 sposoby for i foreach 
            for (int i = 0; i < namesList.Count; i++) //wchodze do listy names. .COunt jest dla List<>
            {
                Console.WriteLine(namesList[i]);
            }
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

            foreach (string names in namesList)
            {
                Console.WriteLine(names);
            }

            for (int i = 1; i <= 15; i++) // wyswietlenie od 1 do 15
            {
                Console.WriteLine(i);

            }

            string text = "Ala ma kota"; // wysweitlic kaza literke a pozycja = dlugosc znakow

            for (int a = 0; a < text.Length; a++)
            {
                Console.WriteLine(text[a]);
                if (text[a] == 'a') //pozycja elementu,indeks
                {
                    Console.WriteLine(a);
                }


            }

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

           


            //Losowanie liczb od 0 do 100 ktore sa podzielne przez 8 
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

            Console.ReadLine();
        }
    }
}
