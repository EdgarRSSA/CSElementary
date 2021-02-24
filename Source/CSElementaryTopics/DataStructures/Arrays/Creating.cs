using System;

namespace Elementary.DataStructures.Arrays
{
	public static partial class Topics
	{
		[Test(Active = false)]
		public static void Creating()
		{

			Console.WriteLine("CreatingInstance Methods:\n");

			// 1 DIMENSION
			Console.WriteLine("\t1.Creates a one-dimensional Array of the specified Type and length, with zero-based indexing.");
			var arr = Array.CreateInstance(typeof(int), 10);
			Console.WriteLine($"\t\tType: {arr.GetType().Name} Length: {arr.Length} Dimension: {arr.Rank}");
			int val = 1;
			for ( int j = 0; j <= arr.GetUpperBound(0); j++ )
			{
				arr.SetValue(val++, j);
				Console.WriteLine($"\t\t{j}:{( (int[]) arr )[j]}");
			}


			// 2 DIMENSION
			Console.WriteLine("\t2.Creates a two-dimensional Array of the specified Type and dimension lengths, with zero-based indexing.");
			arr = Array.CreateInstance(typeof(int), 2, 3);
			CreatingDescriptor(arr);
			val = 1;

			for ( int i = 0; i <= arr.GetUpperBound(0); i++ )
			{
				for ( int j = 0; j <= arr.GetUpperBound(1); j++ )
				{
					arr.SetValue(val++, i, j);
					Console.WriteLine($"\t\t{i},{j}:{( (int[,]) arr )[i, j]}");
				}
			}

			// 3 DIMENSION
			Console.WriteLine("\t3.Creates a three-dimensional Array of the specified Type and dimension lengths, with zero-based indexing.");
			arr = Array.CreateInstance(typeof(int), 2, 3, 4);
			CreatingDescriptor(arr);
			val = 1;

			for ( int i = 0; i <= arr.GetUpperBound(0); i++ )
			{
				for ( int j = 0; j <= arr.GetUpperBound(1); j++ )
				{
					for ( int k = 0; k <= arr.GetUpperBound(2); k++ )
					{
						arr.SetValue(val++, i, j, k);
						Console.WriteLine($"\t\t{i},{j},{k} :{arr.GetValue(i, j, k)}");

					}
				}
			}


			// N DIMENSION
			Console.WriteLine(
				"\t4.Creates a multidimensional Array of the specified" +
				"Type and dimension lengths, with zero-based indexing." +
				"\n\tThe dimension lengths are specified in an array of 32-bit integers."
			);
			arr = Array.CreateInstance(typeof(int), new int[] { 3, 5, 2, 4 });
			CreatingDescriptor(arr);

			#region Rangos del array
			int[] range = new int[arr.Rank]; // rangos
			for ( int i = 0; i < arr.Rank; i++ )
			{
				range[i] = arr.GetLength(i);
				Console.WriteLine($"\tRango{i}:{range[i]}");
			}
			#endregion

			int[] pos = new int[arr.Rank];

			for ( int i = 0; i < range[0]; i++ )
			{
				pos[0] = i;
				for ( int j = 0; j < range[1]; j++ )
				{
					pos[1] = j;
					for ( int k = 0; k < range[2]; k++ )
					{
						pos[2] = k;
						for ( int l = 0; l < range[3]; l++ )
						{
							pos[3] = l;
							Console.WriteLine($"\t\t{pos[0]},{pos[1]},{pos[2]},{pos[3]} : {arr.GetValue(pos)}");
						}
					}
				}
			}



		}
		
		private static void CreatingDescriptor(Array arr)
		{
			Console.WriteLine($"\t\tType: {arr.GetType().Name} Length: {arr.Length} Dimension: {arr.Rank}");
		}




	}
}
