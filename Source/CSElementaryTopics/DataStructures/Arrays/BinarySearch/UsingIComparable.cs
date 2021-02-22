using System;

namespace Elementary.DataStructures.Arrays.BinarySearch
{
	namespace Examples
	{
		interface IPerson
		{
			string Name { get; }
		}


		class Person : IComparable, IPerson
		{
			public string Name { get; }
			public Person(string name)
			{
				Name = name;
			}
			public int CompareTo(Object other)
			{
				if ( other.GetType().GetInterface("IPerson") != null )
				{
					string nameOther = ((IPerson)other).Name;
					string nameThis = Name;
					return nameThis.CompareTo(nameOther);
				}
				else
				{
					throw new ArgumentNullException("other", "No contiene la propiedad Name.");
				}
			}
		}


	}



	public static partial class Topic
	{
		[Test(Active = false)]
		public static void UsingIComparable()
		{

			Console.WriteLine("Busqueda Binaria Usando IComparable en objetos");

			// ARRAY
			Examples.Person[] personArray = {
				new Examples.Person("Anna"),
				new Examples.Person("Annaa"),
				new Examples.Person("AAnna"),
				new Examples.Person("Anna"),
				new Examples.Person("AAxna"),
				new Examples.Person("AAnnz"),
				new Examples.Person("Juan"),
			};

			// ORDENAR
			Array.Sort(personArray);
			for ( int i = 0; i < personArray.Length; i++ )
			{
				Console.WriteLine($"\t{i}-{personArray[i].Name}");
			}

			// BUSQUEDA
			Examples.Person target = new Examples.Person("Anna");
			int location = Array.BinarySearch(personArray, target);
			Console.WriteLine($"{target.Name} in {location}");

		}


	}

}
