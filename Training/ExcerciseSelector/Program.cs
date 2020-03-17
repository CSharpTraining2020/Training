using System;
using System.Collections.Generic;

namespace ExcerciseSelector
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcerciseList();

            bool startApp=true;

            while (startApp) 
            {
                var UserImpact = Console.ReadLine();

               if (UserImpact.ToLower() =="q") // zakonczenie programu na przycisk q
                {
                     startApp = false;
                    continue;
                }

                Console.Clear();

                switch (UserImpact) 
                {
                    case "1":
                        {
                            var excercise1 = new ExcerciseNo1();
                            excercise1.Execute();
                            break;
                        }
                    case "2":
                        {
                            var excercise2 = new ExcerciseNo2();
                            excercise2.Execute();
                            break;
                        }
                    case "3":
                        {
                            var excercise3 = new ExcerciseNo3();
                            excercise3.Execute();
                            break;
                        }
                 

                }
                Console.ReadLine();

                Console.Clear();

                ExerciseList(); // ponowny wybór zadań 

            }
            Console.WriteLine("KONIEC ZADAŃ");
            Console.ReadLine();

        }

        private static void ExerciseList()
        {
            throw new NotImplementedException();
        }

        public static void ExcerciseList() 
        {
            List<string> excercisesList = new List<string>
           {
           "1. Excercise no 1",
            "2. Excercise no 2",
            "3. Excercise no 3"

        };
            foreach(string excercise in excercisesList) 
            {
                Console.WriteLine(excercise);
            }

        }
    }
}
