using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Klasa Random umożliwia losowanie liczb z zadanego zakresu
            /// Aby wykonać losowanie należy najpierw zainicjalizować zmienną o typie Random
            
            var r = new Random();

            /// Klasa Random posiada 2 konstruktory
            /// Pierwszy nie posiada żadnego parametru
            /// Drugi posiada parametr "seed" o typie "int"
            /// Dla naszych potrzeb wystarczy znać pierwszy konstruktor

            /// Do losowania liczby całkowitej należy wykorzystać metodę Next()
            /// Metoda ta posiada 3 różne postacie:
            /// Pierwsza nie przyjmuje żadnego parametru
            /// Liczba całkowita zostanie wylosowana z całego zakresu dostępnych wartości dla typu Int32
            var randomInt = r.Next();
            /// Druga przyjmuje jeden parametr "maxValue" o typie "int"
            /// Oznacza to że wylosowana wartość nie będzie większa niż wskazana liczba
            /// W poniższym liczba będzie mniejsza bądź równa 100
            var randomInt2 = r.Next(100);
            /// Trzecia postać przyjmuje dwa parametry
            /// "minValue" o typie "int" oraz "maxValue" o typie "int"
            /// Wylosowana wartość będzie z zakresu wskazanych liczb
            /// W poniższym przypadku wartość będzie większa bądź równa 100 i mniejsza bądź równa 500
            var randomInt3 = r.Next(100, 500);
        }
    }
}
