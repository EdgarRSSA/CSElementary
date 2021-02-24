using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementary.DataStructures.Arrays
{
	public static partial class Topics
	{
		[Test(Active = false)]
		public static void FindItems()
		{
			FindAnElement();
			FindAll();
			FindIndex();
			FindLast();
			
		}

		private static void FindLast()
		{
			Console.WriteLine("\n4 -Searches for an element that matches the conditions defined by the specified " +
				"predicate, and returns the zero-based index of the last occurrence within the range of elements " +
				"in the Array that contains the specified number of elements and ends at the specified index.");

			string[] array =
			{
				"abcd",
				"alfa",
				"bghnt",
				"gred",
				"ljkho",
				"otedp",
				"beta"
			};

			// Busqueda en el rango 0-3
			string[] targets = {"alfa","beta" };

			//	BUSCA DE ARRIBA PARA ABAJO -(1<-2<-3)- = COUNT 3
			// Devuelve el primero que encuentra.
			int find = Array.FindLastIndex(array,3,3, (match) =>
			{
				Console.WriteLine("---"+match);
				return match.Equals(targets[0]);
			});

			string isFind = find==-1?"Not":"Yes";

			Console.WriteLine($"{targets.GetType().Name}: Find :{isFind}");
		}

		private static void FindIndex()
		{
			Console.WriteLine("\n3-Searches for an element that matches the conditions defined by the specified predicate, " +
				"and returns the zero-based index of the first occurrence within the range of elements in the Array that starts " +
				"at the specified index and contains the specified number of elements.");
			
			string[] array =
			{
				"abcd","bghnt","gred","ljkho","otedp","alfa","beta"
			};

			// Busqueda en el rango 0-3
			string[] targets = {"alfa","gred" };
			int find = Array.FindIndex<string>(array,0,3, (match) =>
			{
				return match.Equals(targets[0])|match.Equals(targets[1]);
			});

			string isFind = find==-1?"Not":"Yes";
			Console.WriteLine($"{targets.GetType().Name}: Find :{isFind}");
		}

		private static void FindAll()
		{
			Console.WriteLine("\n2-Retrieves all the elements " +
				"that match the conditions defined by the specified predicate.");
			string[] alfa =
			{
				"abcd","bghnt","gred","ljkho","otedp"
			};

			// Busqueda
			string[] targets = {"alfa","gred" };
			string[] find = Array.FindAll<string>(alfa, (match) =>
			{
				return match.Equals(targets[0])|match.Equals(targets[1]);
			});
			string isFind = find==null?"Not":"Yes";
			Console.WriteLine($"{targets.GetType().Name}: Find :{isFind}");
		}

		private static void FindAnElement()
		{
			Console.WriteLine("1-Searches for an element that matches the conditions defined by the specified predicate, " +
				"and returns the first occurrence within the entire Array.");
			string[] alfa =
			{
				"abcd","bghnt","gred","ljkho","otedp"
			};

			// Busqueda
			string target = "alfa";
			string find = Array.Find<string>(alfa, (match) =>
			{
				return match.Equals(target);
			});
			string isFind = find==null?"Not":"Yes";
			Console.WriteLine($"{target}: Find :{isFind}");

		}


	}
}
