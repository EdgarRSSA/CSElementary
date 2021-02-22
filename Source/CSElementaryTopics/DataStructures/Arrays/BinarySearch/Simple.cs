namespace Elementary.DataStructures.Arrays.BinarySearch
{
	public static partial class Topic
	{
		[Test(Active = false)]
		public static void SimpleElement()
		{
			byte[] bytes = new byte[100];
			bytes[25] = 55;

			// ORDENAR
			System.Array.Sort<byte>(bytes);

			byte target = 55;
			var location = System.Array.BinarySearch(bytes, target);

			System.Console.WriteLine($"Busqueda Binaria de '55' encontrado en {location}");
			System.Console.WriteLine($"55 = {bytes[location]}");
		}

	}
}
