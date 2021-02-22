using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementary.Class
{
	namespace Examples
	{
		class MyClass<T, K, L>
		{
			public void Print(T value, K values, L val)
			{
				Console.WriteLine("The value T <" + value.ToString() + "> Type:" + value.GetType().Name);
				Console.WriteLine("The value V <" + values.ToString() + "> Type:" + values.GetType().Name);
				Console.WriteLine("The value L <" + val.ToString() + "> Type:" + val.GetType().Name);
			}
		}

	}

	public static partial class Topic
	{
		[Test(Active = false)]
		public static void GenericClass()
		{
			// Clase con 3 argumentos genericos.
			Examples.MyClass<string,int,bool> myclass = new Examples.MyClass<string,int,bool>();

			Console.WriteLine($"Clase con 3 argumentos genericos: {myclass.GetType().Name}\n");

			myclass.Print("sdsd", 10, false);


		}


	}


}
