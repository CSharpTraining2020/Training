using System;
using System.Collections.Generic;

namespace LoopTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            #region WSTĘP
            /// Pętle umożliwiają wykonywać ten sam fragment kodu n razy. Nazywane jest to inaczej ITERACJĄ.
            /// Tak więc pętle umożliwiają iterowanie fragmentu kodu.
            /// Mówi się także, że pętle umożliwiają iterować po listach/tabelach.
            /// Każde kolejne przejście pętli po liście jest zwane ITEROWANIEM PO LIŚCIE.
            /// Wyróżnia się 4 rodzaje pętli w C#:
            /// For
            /// Foreach
            /// While
            /// DoWhile
            #endregion

            #region FOR

            /// Pętla for służy głównie do iterowania po liście/tabelach ale może też być wykonywana bez żadnego związku z listami.
            /// Składnia pętli for składa się z następujących części:
            /// Słówko kluczowe "for"
            /// deklaracji zmiennej pomocniczej/liczącej
            /// warunku zakończenia pętli - dopóki warunek zwraca prawdę to pętla działa
            /// inkrementator zmiennej liczącej - inkrementator będzie wyzwalany zawsze na koniec pętli

            /// for - Słowko kluczowe for
            /// int i = 0 - deklaracja zmiennej pomcniczej - zmienna ta jest widoczna jedynie wewnątrz pętli.
            ///     Musi mieć określony typ jawnie lub niejawnie
            ///     Musi mieć określoną wartość początkową
            /// i < 10 - warunek zakończenia pętli - warunek musi zwracać wartość boolean
            /// i++ - inkrementator zmiennej liczącej - zwiększa wartość zmiennej liczącej na końcu każdego wykonania się pętli
            ///

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                /// Wynikiem pętli będzie lista liczba od 0 do 9
            }

            /// Najczęściej wykonuje się pętle mające zmienną pomocniczą typ int oraz inkrementator, zwiększającą ją o 1.
            /// Ale nic nie stoi na przeszkodzie aby stworzyć pętlę o typie zmiennej liczącej np. string
            /// Pętla posiada zmienną pomocniczą "s" o typie string
            /// Pętla będzie wykonywać się aż, długość zmiennej "s" będzie 100 lub większa
            /// Co każde wykonanie pętli do zmiennej "s" zostanie dopisana kolejna litera "a"
            for (string s = "a"; s.Length < 100; s = s + "a")
            {
                Console.WriteLine(s);
                /// Wynikiem pętli będzie lista tekstów, gdzie pierwszy będzie posiadał 1 literę "a"
                /// Każdy kolejny będzie posiadał o 1 literę "a" więcej od poprzedniego
                /// Ostatni będzie posiadał 99 liter "a" 
            }

            /// Jeśli warunek pętli przestaje być spełniany to:
            ///     Obecne wykonanie pętli nie zostanie przerwane i przejdzie do końca
            ///     Kolejne wykonanie pętli nie zostanie wywołane i wykonanie kodu przejdzie do kolejnych linii kodu poza pętlą

            List<string> countries = new List<string>
                { "Polska", "Niemcy", "Czechy", "Słowacja", "Rosja", "Białoruś", "Ukraina", "Litwa"};

            /// Kolejną najczęstszą praktyką wykorzystania pętli for jest iterowanie po liście
            /// Elementy listy zawsze numerowane są liczbami całkowitymi zaczynając od 0
            for (int i = 0; i < countries.Count; i++)
            {
                Console.WriteLine(countries[i]);
            }

            #endregion
        }
    }
}
