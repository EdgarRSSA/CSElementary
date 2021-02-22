using System;

namespace Elementary.Class
{
	namespace Examples
	{
		public class Book
		{
			/// <summary>
			/// Campo Autores.
			/// </summary>
			private readonly string[] Authors;

			/// <summary>
			/// Nombre del libro.
			/// </summary>
			public string Name { get; set; }

			/// <summary>
			/// Constructor principal.
			/// </summary>
			/// <param name="AuthorsCapacity">Numero de autores del libro.</param>
			/// <remarks>AuthorsCapacity default 10.</remarks>
			public Book(int AuthorsCapacity = 10)
			{
				Authors = new string[AuthorsCapacity];
			}


			/// <summary>
			/// Indice de autores.
			/// </summary>
			/// <param name="i">Base 0.</param>
			/// <returns></returns>
			public string this[int i]
			{
				get
				{
					if ( i >= 0 && i < ( Authors.Length ) )
					{
						return Authors[i];
					}
					else
					{
						throw new ArgumentOutOfRangeException("i", "No existe el elemento seleccionado.");
					}
				}
				set
				{
					if ( value is null )
					{
						throw new ArgumentNullException(value, "El argumento no puede ser Nulo.");
					}
					else
					{
						if ( i >= 0 && i < ( Authors.Length ) )
						{
							Authors[i] = value;
						}
						else
						{
							throw new ArgumentOutOfRangeException("i", "Fuera de capacidad");
						}

					}
				}
			}

		}

	}


	public static partial class Topic
	{
		[Test(Active = false)]
		public static void IndexArray()
		{
			Console.WriteLine("Indice tipo Array[n]:");

			Examples.Book book = new Examples.Book(6);

			book[0] = "Mickey";
			book[1] = "Sam";
			book[2] = "Victor";
			book[3] = "Aurelio";
			book[4] = "Marco";
			book[5] = "Sarah";

			Console.WriteLine($"Autor 2 :{book[2]}");

		}


	}
}
