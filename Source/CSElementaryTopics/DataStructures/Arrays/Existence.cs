using System;

namespace Elementary.DataStructures.Arrays
{
	public static partial class Topics
	{

		[Test(Active = false)]
		public static void ElementExistece()
		{
			Console.WriteLine("Existencia de un elemento en un array:");

			int[] elements =
			{
				1,2,3,4,5,6,7
			};

			int target = 8;

			bool exist = Array.Exists<int>(elements, (match) =>
			{
				return match == target;
			});

			Console.WriteLine($"Existencia de {target} en {elements.GetType().Name} -> {exist}");


		}

	}

}
