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
			var myClass = new MyClass();
			myClass.DoSomething();

			myClass.DoSomethingInternal();
			MyClass.MyStaticMethod();


			var myPublicClass = new MyPublicClass();


			Console.ReadLine();
		}
	}
}
