namespace Elementary.DataStructures.Arrays.BinarySearch
{

	public static partial class Topic
	{
		[Test(Active = false)]
		public static void InSimpleRange()
		{
			// ARRAYS DE BYTES
			byte[] byteArray = new byte[100];

			// AGREGAR VALORES RANDOM            
			var num = new System.Random();
			num.NextBytes(byteArray);

			// ORDENAR ARRAY
			System.Array.Sort<byte>(byteArray);

			// BUSCAR
			byte target = 3;
			int inn = System.Array.BinarySearch(byteArray, 0, 10, target);
			string existe = ( inn>= 0) ? $"Existe" : "No existe";

			System.Console.WriteLine($"Busqueda de '{target}' en el rango 0-49:\t{existe}");

		}


	}
}
