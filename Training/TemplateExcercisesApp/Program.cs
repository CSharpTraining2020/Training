using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateExcercisesApp.Excercises;

namespace TemplateExcercisesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowExcercisesList();
            bool runApp = true;

            while (runApp)
            {
                var userInput = Console.ReadLine();

                if (userInput.ToLower() == "q")
                {
                    runApp = false;
                    continue;
                }

                Console.Clear();

                switch (userInput)
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
                ShowExcercisesList();
            }

            Console.WriteLine("KONIEC");
            Console.ReadLine();
        }

        static void ShowExcercisesList()
        {
            List<string> excercisesList = new List<string>
            {
                "1. Zadanie nr 1",
                "2. Zadanie nr 2",
                "3. Zadanie nr 3"
            };

            foreach (var exercise in excercisesList)
            {
                Console.WriteLine(exercise);
            }
        }
    }
}
