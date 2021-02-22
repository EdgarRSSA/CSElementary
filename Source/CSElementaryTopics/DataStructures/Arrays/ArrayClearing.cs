namespace Elementary.DataStructures.Arrays
{
	public static partial class Topics
	{

		[Test(Active = false)]
		public static void Clearing()
		{
			int[] ints = { 1, 2, 3, 4, 5, 8, 6, 5, 3, 76 };

			System.Console.WriteLine("Limpiando Arrays:");
			for ( int i = 0; i < ints.Length; i++ )
			{
				System.Console.WriteLine($"\t{i}-{ints[i]}");
			}

			// LOS ARRAYS SE COMPARTEN POR REFERENCIA ENTRE METODOS
			System.Array.Clear(ints, 0, ints.Length);

			System.Console.WriteLine("Array limpiado:");
			for ( int i = 0; i < ints.Length; i++ )
			{
				System.Console.WriteLine($"\t{i}-{ints[i]}");
			}
		}

	}
}
