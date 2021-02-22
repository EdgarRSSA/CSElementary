using System;

namespace Elementary.DataStructures.Arrays.BinarySearch
{
	public static partial class Topic
	{
		[Test(Active = false)]
		public static void InRangeUsingIComparable()
		{
			Console.WriteLine("Busqueda binaria en un Rango, usando IComparable.");

			// ARRAY
			Examples.Person[] personArray =
			{
				new Examples.Person("Mari1"),
				new Examples.Person("Mari2"),
				new Examples.Person("Mari3"),
				new Examples.Person("Mari4"),
				new Examples.Person("Maria"),
				new Examples.Person("maria"),
				new Examples.Person("Mxria"),
				new Examples.Person("Mariat"),
				new Examples.Person("Maria"),
				new Examples.Person("Marib"),
				new Examples.Person("Mariaa"),
				new Examples.Person("Maria"),
				new Examples.Person("mMaria"),
				new Examples.Person("MMaria"),
			};

			// ORDENAR            
			Array.Sort(personArray);
			for ( int i = 0; i < personArray.Length; i++ )
			{
				Console.WriteLine($"\t{i}-{ personArray[i].Name}");
			}

			// BUSCAR EN RANGO
			Examples.Person target = new Examples.Person("Maria");
			int location = Array.BinarySearch(personArray, 0, 5, target);
			Console.WriteLine($"Existe {target.Name} en el rango 0-5 : {( location < 0 ? "No" : ( "Si en " + location ) )}");
		}


	}
}
