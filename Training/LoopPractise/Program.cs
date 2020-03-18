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
        }
    }
}
