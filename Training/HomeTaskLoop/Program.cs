using System;
using System.Collections.Generic;

namespace HomeTaskLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>();
            int[] arrayNum = new int[20];
            var random = new Random();
            for (int i = 0; i < 20; i++)
            {
                var resultRandom = random.Next(0, 1000);
                Console.WriteLine($"Your lucky numbers are: {resultRandom}");


            }



        }
}
}
