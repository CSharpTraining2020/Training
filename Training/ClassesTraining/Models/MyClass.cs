using MyInternalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTraining.Models
{
	/// <summary>
	/// Dziedziczę po klasie System.Object. Jestem typu MyClass
	/// </summary>
	public class MyClass
	{
        /// Pola przechowują dane opisujące klasę
        /// Utworzenie pola odbywa się poprzez określenie modyfikator dostępu, typu, nazwy pola oraz można też określić wartość pola
        /// Nazwę pola tworzymy w konwecji camelCase (pierwsza litera pierwszego słowa jest mała, pierwsze litery kolejnych słów duże)
        /// Wartość pola musi być zgodna z typem pola
        /// Na koniec stawiamy ;
        /// 
        /// {modyfikator_dostępu} {typ} {nazwaWKonwencjiCamel} = {wartość_pola};
        ///
        /// MODYFIKATORY DOSTĘPU
        /// public - oznacza, że pole jest dostępne (widoczne i możliwe do użycia) w każdym projekcie jaki wykorzystuje klasę
        /// internal - oznacza, że pole jest dostępne (widoczne i możliwe do użycia) tylko w projekcie w jakim stworzona została klasa
        /// private - oznacza, że pole jest dostępne (widoczne i możliwe do użycia) tylko wewnątrz danej klasy
        /// protected - zostanie wyjaśnione w szkoleniu o dziedziczeniu
        /// internal protected - zostanie wyjaśnione w szkoleniu o dziedziczeniu
        ///
        /// BEST PRACTICES
        /// Obecnie wykorzystuje się najczęsciej pola private w celu ograniczenia dostępu do danych opisujących klasę
        /// Rolę pól internal i public przejęły właściwości


        /// <summary>
        /// Publiczne pole typu string i nazwie "name"
        /// Domyślnie pole przyjmuje wartość "Anita"
        /// </summary>
		public string name = "Anita";
        /// <summary>
        /// Wewnętrzne pole typu int i nazwie "number"
        /// Domyślna wartość nie jest ustawiona co oznacza, że jest to wartość domyślna dla typu pola.
        /// Ponieważ typ pola to int to wartością domyślną jest 0.
        /// </summary>
		internal int number;
        /// <summary>
        /// Wewnętrzne pole typu string i nazwie "description"
        /// Domyślna wartość nie jest ustawiona co oznacza, że jest to wartość domyślna dla typu pola.
        /// Ponieważ typ pola to string to wartością domyślną jest "" (pusty ciąg znaków)
        /// </summary>
		private string description;
        /// <summary>
        /// Publiczne pole typu MyPublicClass i nazwie publicField.
        /// Domyślna wartość nie jest ustawiona co oznacza, że jest to wartość domyślna dla typu pola.
        /// Ponieważ typ pola to klasa to wartością domyślną jest null.
        /// </summary>
        public MyPublicClass publicField;


        /// Właściwości zarządzają dostępem do pól klasy
        /// Za pomocą właściwości można rozbudować logikę pobierania danych z pola jak i wpisywania wartości do pola
        /// Getter (get) odpowiada za logikę pobierania. Domyślnie logika udostępnia pełny dostęp do pola bez żadnych zmian
        /// Setter (set) odpowiada za logikę wpisywania. Domyślnie logika wpisuje wartość do pola bez żadnych zmian
        /// Utworzenie właściwości odbywa się poprzez określenie modyfikatora dostępu, typu, nazwy właściwości oraz można też określić wartość domyślną
        /// 

        /// <summary>
        /// 
        /// </summary>
		public string Name { get; set; }

		public int Number { get; set; }

		public string Description
		{
			get { return description;  }
			set { description = value; }
		}


		public MyClass()
		{
			this.description = this.name + " Lewandowska";
		}

		public MyClass(string nameParam)
		{
			this.name = nameParam;
		}


		/// <summary>
		/// To jest metoda publiczna dostępna w całym projekcie i poza nim
		/// </summary>
		public void DoSomething()
		{
			Console.WriteLine("Coś robię na rozkaz");
			DoSomethingPrivate();
		}

		/// <summary>
		/// Metoda publiczna zwracająca string
		/// </summary>
		/// <returns></returns>
		public string GiveMeYourName()
		{
			return "Moje imię to " + this.name;
		}

		/// <summary>
		/// Metoda publiczna zwracająca MyPublicClass
		/// </summary>
		/// <returns></returns>
		public MyPublicClass GiveMePublicClass()
		{
			var result = new MyPublicClass();
			return new MyPublicClass();
		}

		public static void MyStaticMethod()
		{
			Console.WriteLine("Wywołanie metody statycznej");
		}

		/// <summary>
		/// To jest metoda wewnętrzna dostępna w całym projekcie i tylko w nim
		/// </summary>
		internal void DoSomethingInternal()
		{
			Console.WriteLine("Coś robię wewnętrznie");
		}

		/// <summary>
		/// To jest metoda prywatna dostępna tylko w tej klasie
		/// </summary>
		private void DoSomethingPrivate()
		{
			Console.WriteLine("Dodatkowo robię coś prywatnie");
		}
	}
}
