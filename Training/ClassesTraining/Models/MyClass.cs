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
		public string name = "Anita";
		internal int number;
		private string description;
		public MyPublicClass publicMyNewSuperExtraClass;

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
