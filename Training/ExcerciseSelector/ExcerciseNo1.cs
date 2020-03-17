using System;

namespace ExcerciseSelector
{
    internal class ExcerciseNo1
    {
        public ExcerciseNo1()
        {
            // konstruktory klasy 

        }

        internal void Execute()
        {
            Console.WriteLine("Choose a number from the range of (-1000) to 1000:");
            int userNumbersRangeMin, userNumbersRangeMax;
            userNumbersRangeMin = int.Parse(Console.ReadLine());
            userNumbersRangeMax = int.Parse(Console.ReadLine());
            Console.WriteLine(" Enter a counter for random from the range of 3 to 15");
            int counter = int.Parse(Console.ReadLine());

            // zabezpieczenie wprowadzanego zakresu liczb przez uzytkownika
            bool isItCorrectRangeMin = true;
            while (isItCorrectRangeMin)
            { 
                if (userNumbersRangeMin>(-1000) && userNumbersRangeMin<1000 )
                {
                    Console.WriteLine("Valid Min range");
                    isItCorrectRangeMin = false; // przeciazenie warunku petli 
                } 
                else 
                {
                    Console.WriteLine("There is a mistake!Enter valid range.");
                    Console.WriteLine("Enter valid range:"); // moge poprawic wartosc 
                    userNumbersRangeMin = int.Parse(Console.ReadLine());
                }
                
            }
            bool isItCorrectRangeMax = true;
            while (isItCorrectRangeMax) 
            {
            if(userNumbersRangeMax>(-1000)&& userNumbersRangeMax<1000  && userNumbersRangeMin<= userNumbersRangeMax) 
                {
                    Console.WriteLine("Valid Max range");
                    isItCorrectRangeMax = false; // przeciazenie warunek petli
                }
                else 
                {

                    Console.WriteLine("There is a mistake!Enter valid range");
                    Console.WriteLine("Enter valid range:"); // moge poprawic wartosc 
                    userNumbersRangeMax = int.Parse(Console.ReadLine());
                }
            }
            bool isItCorredctCounter = true;
            while (isItCorredctCounter)
            {
                if (counter > 3 && counter < 15)
                {
                    Console.WriteLine("Correct counter");
                    isItCorredctCounter = false; // przeciazenie warunek petli
                }
                else
                {
                    Console.WriteLine("There is a mistake!Enter valid counter");
                    Console.WriteLine("Enter valid counter:"); // moge poprawic wartosc 
                    counter = int.Parse(Console.ReadLine());
                }

            }

            var rangeOfNumbers = new Random();
            Console.WriteLine(rangeOfNumbers.Next(userNumbersRangeMin, userNumbersRangeMax));




        }
    }
}