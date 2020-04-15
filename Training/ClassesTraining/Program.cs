using ClassesTraining.Models;
using MyInternalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Inicjalizacja - utworzenie nowej instancji(jednostki) obiektu(encji) za pomocą słówka "new"
            /// Do inicjalizacji wykorzystywane są konstruktory zdefiniowane w klasie inicjalizowanego obiektu
            /// klasa=typ referencyjny(sterta= duza ilosc pamięci)=obiekt=encja
            var myClass = new MyClass();

            /// Metoda instancyjna - metoda wywoływana na instancji(jednostce) obiektu(encji).
            /// Aby wykonać metodę instancyjną wcześniej należy zainicjalizować obiekt(encje) za pomocą słówka "new"
            /// Metody instancyjne zdefiniowane są w klasie obiektu
			myClass.DoSomething();
            myClass.DoSomethingInternal();

            /// Metoda statyczna - metoda wywoływana na typie(klasie) obiektu(encji)
            /// Aby wykonać metodę statyczną należy wykorzystać typ(klasę) obiektu.
            /// Metod statycznych nie można wywoływać za pomocą instancji(jednostki) obiektu(encji)
            /// Metody statyczne zdefiniowane są w klasie obiektu
            MyClass.MyStaticMethod();

            Console.ReadLine();
        }
    }
}
