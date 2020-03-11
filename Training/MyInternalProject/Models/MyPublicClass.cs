using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInternalProject.Models
{
	/// <summary>
	/// To jest klasa publiczna dostępna poza tym projektem
	/// </summary>
	public class MyPublicClass
	{
		MyPrivateClass MyPrivate { get; }



		private class MyPrivateClass
		{

		}
	}
}
