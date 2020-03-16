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
		#region WSTĘP

		/// Tworząc klasę należy zachować konwencję, która została wypracowana przez programistów
		/// Należy zachować porządek w rzeczach, które są deklarowane wewnątrz klasy
		/// Czytając klasę od góry:
		/// Jako pierwsze powinny być zadeklarowane pola
		/// Jako drugie powinny być zadeklarowane właściwości
		/// Jako trzecie powinny być zadeklarowane konstruktory, od najbardziej ogólnego po najbardziej szczegółowy
		/// Jako czwarte powinny być zadeklarowane metody publiczne
		/// Jako piąte powinny być zadeklarowane metody niepubliczne
		///
		/// MODYFIKATORY DOSTĘPU
		/// public - klasa publiczna, dostępna w każdym projekcie, który wykorzystuje obecny projekt
		/// internal - klasa wewnętrzna, dostępna tylko w projekcie w którym została założona
		
		#endregion

		#region POLA

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

		#endregion

		#region WŁAŚCIWOŚCI

		/// Właściwości zarządzają dostępem do pól klasy
		/// Za pomocą właściwości można rozbudować logikę pobierania danych z pola jak i wpisywania wartości do pola
		/// Getter (get) odpowiada za logikę pobierania. Domyślnie logika udostępnia pełny dostęp do pola bez żadnych zmian
		/// Setter (set) odpowiada za logikę wpisywania. Domyślnie logika wpisuje wartość do pola bez żadnych zmian
		/// Do getter'ów i setter'ów również można dodać modyfikator dostępu
		/// Taki modyfikator decyduje z jakiego poziomu można pobrać (get) wartość lub wpisać (set) wartość
		/// Modyfikatory dostępu dla getter'ów i setter'ów są takie same jak dla pól czy właściwości
		/// Domyślnym modyfikatorem dostępu dla get i set jest public
		/// Utworzenie właściwości odbywa się poprzez określenie modyfikatora dostępu, typu, nazwy właściwości oraz można też określić wartość domyślną
		/// Nazwę właściwości tworzymy w konwencji PascalCase (Każda pierwsza litera każdego słowa jest duża)
		/// Modyfikatory dostępu są te same co dla pól i oznaczają to samo
		/// 
		/// BEST PRACTICIES
		/// Obecnie najczęściej wykorzystuje się właściwości do przechowywania publicznych lub wewnętrznych danych o klasie z domyślnym getter'em i setter'em
		/// Rzadko stosuje się własne getter'y i setter'y ponieważ tworzy to problem utrzymywania logiki aplikacji w kolejnym miejscu w kodzie
		/// Własne getter'y i setter'y powinny być proste, szybkie i nie wykorzystywać skomplikowanej logiki

		/// <summary>
		/// Publiczna właściwość typu string i nazwie Name
		/// Getter i setter nie mają modyfikatorów dostępu co oznacza, że są one publiczne (public)
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Publiczna właściwość typu int i nazwie Number
		/// Getter jest publiczny, ale setter jest wewnętrzny
		/// Oznacza to że pobrać wartość można z każdego projektu ale wpisać wartość można tylko z projektu, w którym ta klasa została utworzona
		/// </summary>
		public int Number { get; internal set; }

		/// <summary>
		/// Publiczna właściwość typu string i nazwie Description
		/// Getter i setter są publiczne
		/// Getter i setter są zdefiniowane - tak też wyglądają domyślne getter'y i setter'y dla programu kompilującego
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		#endregion  

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
