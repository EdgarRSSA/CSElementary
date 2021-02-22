using System;

namespace Elementary.DataStructures.Arrays.BinarySearch
{
	namespace Examples
	{
		public static class Search<T>
		{
			public static void Location(ref T[] array, T target)
			{
				Console.WriteLine("Ordenando:");
				Array.Sort<T>(array);
				for ( int i = 0; i < array.Length; i++ )
				{
					Console.WriteLine($"\t{i}-{array[i]}");
				}
				int loc = Array.BinarySearch<T>(array, target);
				Console.WriteLine($"Item {target} in: {( loc < 0 ? "Not Found" : loc.ToString() )}");

			}
		}

	}


	public static partial class Topic
	{
		[Test(Active = false)]
		public static void Generic()
		{
			// Arrays
			int[] ints = { -1, -20, 1, 2, 3, 4 };
			byte[] bytes = { 0, 255, 127, 30 };
			char[] chars = "abcdfgdfg".ToCharArray();


			// Busqueda Generica
			Examples.Search<int>.Location(ref ints, 3);
			Examples.Search<byte>.Location(ref bytes, 127);
			Examples.Search<char>.Location(ref chars, 'f');
		}

	}
}
