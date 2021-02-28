using System;
using System.Collections.Generic;

namespace Elementary.DataStructures.Lists
{
	public static partial class Lists
	{

		[Test(Active = false)]
		public static void Use()
		{
			Console.WriteLine("Listas Genericas");

			List<string> list = new List<string>()
			{
				"qwqe","bgfd","ftw","htr","awe"
			};
			Print(list);

			/**
			 * Capacidad y numero en elementos.
			 */
			Console.WriteLine($"\nCapacidad :{list.Capacity}");
			Console.WriteLine($"Elementos :{list.Count}");


			/**
			 * Ordenar.
			 */
			list.Sort();
			Console.WriteLine("\nOrdenar listas:");
			Print(list);

			/**
			 * Ordenar inversamente,
			 */
			list.Reverse();
			Console.WriteLine("\nOrdenar listas inversamente:");
			Print(list);

			/**
			 * Busqueda.
			 */
			list.Sort();
			int location =list.BinarySearch("qwqe");
			Console.WriteLine("\nBuscar 'qwqe' : {0}", location);


			/**
			 * Conversiones.
			 */
			Console.WriteLine("\nConversion");
			Converter<string,char[]> converter = (val1)=>
			{
				return val1.ToCharArray();
			};
			var charlist =list.ConvertAll<char[]>(converter);
			foreach ( var item in charlist )
			{
				Console.Write("\t");
				foreach ( var item2 in item )
				{
					Console.Write($"{item2,-5}");
				}
				Console.WriteLine();
			}

		}

		private static void Print<T>(List<T> list)
		{
			Console.Write("\t");
			list.ForEach((val) =>
			{
				Console.Write($"{val,-6}");
			});
			Console.WriteLine();
		}
	}
}
