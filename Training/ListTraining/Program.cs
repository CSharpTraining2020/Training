using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            #region WSTĘP

            #region LISTY

            /// Listy są tzw. typami generycznymi
            /// Oznacza to, że typ listy jest ustalany na podstawie typu generycznego wprowadzonego w nawiasach < >
            /// Typ listy ustala się podczas inicjalizacji zmiennej listowej.
            /// Listy umożliwiają przechowywanie wielu obiektów o typie generycznym podanym w nawiasach < >
            /// W przeciwieństwie do tabel lista nie musi mieć zdefiniowanej max ilości elementów możliwych do wpisania 
            /// To jest przykład najprostszej inicjalizacji listy, która będzie przyjmować elementy o typie string
            /// Tak utworzona lista jest pusta i nie posiada żadnych elementów.
            var stringList = new List<string>();

            #endregion

            #region TABLICE

            /// Tablice są również typami generycznymi
            /// Są jednak rzadziej stosowane z uwagi na wiele korzyści jakie posiadają list, a nie posiadają tablice
            /// Występują jednak w kodzie na tyle często, że należy wiedzieć jak obchodzić się z tablicami
            /// Tak jak listy typ tablicy jest ustalany na podstawie typu generycznego
            /// Tablice deklarujemy za pomocą typu elementów oraz nawiasów kwadratowych [ ]
            /// Podczas deklaracji tabeli należy określić ile elementów tablica będzie przechowywać
            /// Ilości elementów w liście nie można zmienić po deklaracji ani przekroczyć
            var arrayString = new string[10];

            #endregion

            #endregion

            #region WŁAŚCIWOŚCI

            #region COUNT / COUNT() / LENGTH 

            /// Każda lista lub też tablica udostępnia sposób sprawdzenia ile elementów znajduje się obecnie w liście
            ///     lub jaka jest długość tablicy
            /// Informacja ta jest pomocna przy tworzeniu np. pętl iterujących po listach/tablicach
            ///
            /// LENGTH:
            /// Każda tablica posiada właściwość Length, która mówi jak "długa" jest tablica
            /// Length mówi jak "długa" jest tablica, a nie ile ma elementów - jest to ważna różnica
            /// Tablica "intArray" nie posiada żadnego elementu, a jej długość jest równa 10
            /// Dlatego też zmienna "intArrayLen" będzie także równa 10
            /// Długość nie zmieni się również wtedy gdy wpiszemy pierwszy lub kolejne elementy do tablicy

            var intArray = new int[10];
            var intArrayLen = intArray.Length;

            /// COUNT i COUNT()
            /// Wszystkie listy posiadają albo właściwość Count albo metodę Count()
            /// Która, lista posiada, którą "rzecz" jest zależne od typu listy
            /// Listy List<T> zawsze posiadają właściwość Count
            /// I metoda i właściwość zawsze zwracają dokładną ilość elementów w liście

            List<string> countries = new List<string>
                { "Polska", "Niemcy", "Czechy", "Słowacja", "Rosja", "Białoruś", "Ukraina", "Litwa"};

            /// zmienna countriesCount jest równa 8
            int countriesCount = countries.Count;

            #endregion

            #endregion

            #region METODA ADD

            /// Dodawanie elementów do listy odbywa się poprzez metodę Add()
            /// Metoda Add() posiada 1 parametr, który zawsze jest typu generycznego - w tym przypadku string
            /// Różne przykłady dodawania elementów
            stringList.Add("Łukasz");
            string name = "Jan";
            stringList.Add($"Mam na imię {name}");
            string surname = "Kowalski";
            stringList.Add(surname);

            var integerList = new List<int>();
            var a = 11;
            var b = 5;
            integerList.Add(a);
            integerList.Add(a + b);
            integerList.Add(Sum(a, b));
            /// Błąd - zmienna name jest typu string i nie może zostać dodana do listy o typie generycznym int
            //integerList.Add(name);

            /// Możliwa jest również inicjalizacja listy i wprowadzenie od razu wartości do listy
            var decimalList = new List<decimal>
            {
                10.5m,
                5.5m,
                1.0m,
                6m
            };

            #endregion

            #region INDEKSY I PĘTLE

            /// Wszystkie dodane elementy są indeksowane
            /// Oznacza to że są numerowane od 0 w górę
            /// Pierwszy element ma indeks 0, drugi 1, trzeci 2 itd.
            /// Aby używać indeksów należy wykorzystać nawiasy [ ]

            /// Naturalnym użyciem list jest wykorzystanie ich w pętlach for i foreach
            /// Właściwość Count mówi ile jest elementów wewnątrz listy. Tablice dla przykładu mają taką samą Właściwość o nazwie Length
            /// Nie wszystkie typy list mają właściwość Count
            /// Część z nich posiada metodę Count(), która zwraca informację ile jest elementów w liście
            
            Console.WriteLine("INDEKSY I PĘTLE");
            
            for (int i = 0; i < integerList.Count; i++)
            {
                /// Za pomocą pętli for i zmiennej pomocniczej "i" można pobrać do osobnej zmiennej każdy element listy.
                var sampleInt = integerList[i];
                Console.WriteLine(sampleInt.ToString());
                /// Wynikiem tej pętli będzie wypisanie w konsoli
                /// 11
                /// 16
                /// 16

            }

            /// Elementy można też pobierać za pomocą na sztywno wprowadzonej wartości indeksu
            /// Należy z tym uważać ponieważ jeśli w liście nie istnieje element o zadanym indeksie, program zgłosi wyjątek
            var secondElement = integerList[1];

            foreach (var stringItem in stringList)
            {
                Console.WriteLine(stringItem);
                /// Wynikiem tej pętli będzie wypisanie w konsoli:
                /// Łukasz
                /// Mam na imię Jan
                /// Kowalski
            }

            #endregion

            #region METODA INSERT

            Console.WriteLine("METODA INSERT");

            /// Metoda Insert() umożliwia wprowadzenie nowego elementu dokładnie na wskazaną pozycję w liście
            /// Pozycję wskazuje się poprzez indeks
            /// Indeks musi istnieć już w liście lub być pierwszym nieistniejącym jeszcze indeksem w liście
            /// Element listy znajdujący się obecnie na wskazanym indeksie zostanie przesunięty o 1 pozycję w dół
            /// Elementy listy znajduące się poniżej wskazanego indeksu zostaną przesunięte w dół o 1 pozycję
            /// Metoda Insert() przyjmuje 2 parametry
            /// Pierwszy to "index" o typie "int" - parametr ten wskazuje na jaką pozycję ma zostać wprowadzona wartość
            /// Drugi to "value" o typie generycznym list - wartość która ma zostać wprowadzona do listy na wskazaną pozycję (index)

            var newIntegerList = new List<int>
            {
                /*[0]*/10,
                /*[1]*/16,
                /*[2]*/22,
                /*[3]*/56
            };

            /// Wartość 78 zostanie wprowadzona na pozycję 0. Wszystkie poniższe elementy zostaną przesunięte o 1 pozycję w dół
            newIntegerList.Insert(0, 78);
            /// Wartość 115 zostanie wprowadzona na pozycję 2.
            /// Wartość 16 będzie miała teraz indeks 3, a wartość 22 indeks 4, a wartość 56 indeks 5
            /// Pamiętaj że Insert(0, 78) już wprowadził nową wartość i indeksy w liście się przesunęły - są inne niż w przykładzie
            newIntegerList.Insert(2, 115);
            /// Wartość 66 zostanie wprowadzona na pozycję 6 (koniec listy).
            /// Jest to pierwszy nieistniejący do tej pory indeks i dlatego możliwe jest jego wykorzystanie
            /// Pamiętaj że Insert(0,78) i Insert(2, 115) już wprowadziły nowe wartości
            newIntegerList.Insert(6, 66);
            /// Wartość 2000 nie zostanie wprowadzona na pozycję 15 ponieważ jest indeks ten jest zbyt odległy
            /// Pierwszym dopuszczalnym indeksem teraz jest 7
            /// Wykonanie tej metody zakończy się błędem
            /// Wykonanie jest zakomentowane dla prawidłowego działania programu
            //newIntegerList.Insert(15, 2000);

            foreach (var newInt in newIntegerList)
            {
                Console.WriteLine(newInt.ToString());
                /// Wynikiem tej pętli będzie wypisanie w konsoli:
                /// 78
                /// 10
                /// 115
                /// 16
                /// 22
                /// 56
                /// 66
            }

            Console.ReadLine();
        }

        #endregion

        static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
